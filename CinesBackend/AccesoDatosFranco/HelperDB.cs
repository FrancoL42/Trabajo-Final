using CinesBackend.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinesBackend.AccesoDatosFranco
{
    public class HelperDB
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-KND7ROK;Initial Catalog=cines_final;Integrated Security=True");
        private static HelperDB instancia;
        public static HelperDB obtenerInstancia()
        {
            if (instancia == null)
            { instancia = new HelperDB(); }
            return instancia;
        }
        public DataTable consultarSinParametros(string sp)
        {
            DataTable dt = new DataTable();
            if(cnn.State == ConnectionState.Closed)
                cnn.Open();

            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
        public DataTable consultarButacasxSalas(string sp, int idSala)
        {
            DataTable tabla = new DataTable();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idSala", idSala);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }


        public bool AltaPeliculas(Peliculas p) //ABM PELICULAS
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_PELICULAS", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titulo", p.nombrePelicula);
                cmd.Parameters.AddWithValue("@duracion", p.duracion);
                cmd.Parameters.AddWithValue("@idClasificacion", p.clasificación.idClasificacion);
                cmd.Parameters.AddWithValue("@id_idioma", p.idioma.idIdioma);
                cmd.Parameters.AddWithValue("@fecEstreno", p.fecEstreno);
                cmd.Parameters.AddWithValue("@idGenero", p.genero.idGenero);
                cmd.Parameters.AddWithValue("@director", p.director);
                cmd.ExecuteNonQuery();
                aux = true;
                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
           
            return aux;
        }
        public bool modificarPeliculas(Peliculas p)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_PELICULA", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPelicula", p.idPelicula);
                cmd.Parameters.AddWithValue("@duracion", p.duracion);
                cmd.Parameters.AddWithValue("@idClasificacion", p.clasificación.idClasificacion);
                cmd.Parameters.AddWithValue("@idIdioma", p.idioma.idIdioma);
                cmd.Parameters.AddWithValue("@fecEstreno", p.fecEstreno);
                cmd.Parameters.AddWithValue("@idGenero", p.genero.idGenero);
                cmd.Parameters.AddWithValue("@director", p.director);
                cmd.ExecuteNonQuery();
                aux = true;
                t.Commit();
            }
            catch (Exception)
            {

                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }
        public DataTable consultarFunciones(string sp, string pelicula, string fecha)
        {
            DataTable tabla = new DataTable();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pelicula", pelicula);
            cmd.Parameters.AddWithValue("@Fecha", fecha);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public bool BorrarPelicula(Peliculas p)
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                t = cnn.BeginTransaction();             
                SqlCommand cmd = new SqlCommand("SP_BAJA_PELICULAS", cnn, t);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", p.idPelicula);
                cmd.ExecuteNonQuery();
                aux = true;
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }
        public bool AltaSalas(Salas s) //ABM SALAS
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_ALTA_SALAS", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cantButacas", s.cantidadButacas);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@idSala";
                param.Direction = ParameterDirection.Output;
                param.DbType = DbType.Int32;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int idSala = (int)param.Value;
                int cantAsientos = s.cantidadButacas;
                //t.Commit();
                //t = cnn.BeginTransaction();
                for (int i = 1; i <= cantAsientos; i++)
                {
                    SqlCommand cmdButaca = new SqlCommand("SP_ALTA_BUTACAS", cnn, t);
                    cmdButaca.CommandType = CommandType.StoredProcedure;
                    cmdButaca.Parameters.AddWithValue("@idSala", idSala);
                    cmdButaca.Parameters.AddWithValue("@nroButaca", i);
                    cmdButaca.ExecuteNonQuery();
                }
                t.Commit();
                aux = true;
            }
            catch (Exception ex)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }      
            return aux;
        }
        public bool modificarSala(Salas s)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_SALA", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSala", s.idSala);
                cmd.Parameters.AddWithValue("@cantButacas", s.cantidadButacas);
                cmd.ExecuteNonQuery();
                aux = true;
                t.Commit();
            }
            catch (Exception)
            {

                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }
        public bool bajaSala(Salas s)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_BAJA_SALA", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSala", s.idSala);             
                cmd.ExecuteNonQuery();
                aux = true;
                t.Commit();
            }
            catch (Exception)
            {

                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }
        public bool AltaOperadores(Empleados e) //ABM EMPLEADOS
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_OPERADOR", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", e.nombre);
                cmd.Parameters.AddWithValue("@apellido", e.apellido);
                //cmd.Parameters.AddWithValue("@email", e.);
                //cmd.Parameters.AddWithValue("@idBarrio", e.barrio);
                cmd.Parameters.AddWithValue("@idCargo", e.cargo.idCargo);
                cmd.ExecuteNonQuery();
                aux = true;
            }
            catch (Exception ex)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            t.Commit();
            return aux;
        }
        public bool AltaFunciones(Funciones f) //ABM FUNCIONES
        {
            SqlTransaction t = null;
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            bool aux = false;
            try
            {
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_ALTA_FUNCIONES", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecfuncion", f.fecha);
                cmd.Parameters.AddWithValue("@horaFuncion", f.hora);
                cmd.Parameters.AddWithValue("@precio", f.precioFuncion);
                cmd.Parameters.AddWithValue("@idPelicula", f.pelicula.idPelicula);
                cmd.Parameters.AddWithValue("@idSala", f.sala.idSala);
                cmd.ExecuteNonQuery();
                t.Commit();
                aux = true;
            }
            catch (Exception)
            {

                t.Rollback();
            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }
        public bool InsertarAbmMaestro(Comprobante c) //ABMMAESTRO
        {
            bool aux = false;            
            SqlTransaction t = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdCliente = new SqlCommand("SP_INSERTAR_CLIENTE", cnn, t); //ALTA CLIENTE
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Parameters.AddWithValue("@nombre", c.clientes.nombre);
                cmdCliente.Parameters.AddWithValue("@apellido", c.clientes.apellido);
                cmdCliente.Parameters.AddWithValue("@documento", c.clientes.nroDoc);
                cmdCliente.Parameters.AddWithValue("@telefono", c.clientes.nroTelefono);
                cmdCliente.Parameters.AddWithValue("@email", c.clientes.email);
                SqlParameter pIdClienteOut = new SqlParameter();
                pIdClienteOut.ParameterName = "@idCliente";
                pIdClienteOut.DbType = DbType.Int64;
                pIdClienteOut.Direction = ParameterDirection.Output;
                cmdCliente.Parameters.Add(pIdClienteOut);
                cmdCliente.ExecuteNonQuery();
                long idCliente = Convert.ToInt64(pIdClienteOut.Value);


                SqlCommand cmdComprobante = new SqlCommand("SP_INSERTAR_COMPROBANTE", cnn, t); //ALTA COMPROBANTE
                cmdComprobante.CommandType = CommandType.StoredProcedure;
                cmdComprobante.Parameters.AddWithValue("@idCliente", idCliente);
                cmdComprobante.Parameters.AddWithValue("@idEmpleado",c.empleado.idEmpleado);
                cmdComprobante.Parameters.AddWithValue("@fecha",c.fechaCompra);
                cmdComprobante.Parameters.AddWithValue("@total", c.totalPagar);
                cmdComprobante.Parameters.AddWithValue("@idFuncion",c.funcion.idFuncion);
                SqlParameter pIdComprobanteOut = new SqlParameter();
                pIdComprobanteOut.ParameterName = "@idComprobante";
                pIdComprobanteOut.DbType= DbType.Int64;
                pIdComprobanteOut.Direction = ParameterDirection.Output ;
                cmdComprobante.Parameters.Add(pIdComprobanteOut);
                cmdComprobante.ExecuteNonQuery();
                long idComprobante = Convert.ToInt64(pIdComprobanteOut.Value);

                foreach(DetalleComprobante d in c.detalles) //ALTA DETALLE
                {
                    foreach(ButacasxSalas b in d.lstButacasxSalas)
                    {
                        SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE_COMPROBANTE", cnn, t);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;
                        cmdDetalle.Parameters.AddWithValue("@idComprobante", idComprobante);
                        cmdDetalle.Parameters.AddWithValue("@idSala", b.sala.idSala);
                        cmdDetalle.Parameters.AddWithValue("@idButaca", b.idButaca);
                        cmdDetalle.ExecuteNonQuery();
                    }
                   
                }
                t.Commit();
                aux = true;
            }
            catch (Exception ex)
            {

                t.Rollback();
            }
            finally
            {
                if (cnn.State == ConnectionState.Open && cnn != null)
                    cnn.Close();
            }

            return aux;
        }
        public bool IniciarSesion(string usuario, string contrasenia, out int idEmpleado, out int idCargo)
        {
            bool aux = false;
            idEmpleado = 0;
            idCargo = 0;           
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_IniciarSesionEmpleado", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                SqlParameter pIdEmpleado = new SqlParameter("@IdEmpleado", SqlDbType.Int);
                pIdEmpleado.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pIdEmpleado);

                SqlParameter pIdCargo = new SqlParameter("@IdCargo", SqlDbType.Int);
                pIdCargo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pIdCargo);

             
                cmd.ExecuteNonQuery();

                idEmpleado = Convert.ToInt32(pIdEmpleado.Value);
                idCargo = Convert.ToInt32(pIdCargo.Value);
                aux = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el inicio de sesión de empleado: {ex.Message}");
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return aux;
        }
        public bool BajaCliente(Clientes c)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_BAJA_CLIENTE", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(@"@idCliente", c.idCliente);

                cmd.ExecuteNonQuery();
                t.Commit();
                aux = true;
            }
            catch (Exception)
            {

                t.Rollback();
            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }
        public bool modificarCliente(Clientes c)
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_CLIENTE", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", c.idCliente);
                cmd.Parameters.AddWithValue("@nombre", c.nombre);
                cmd.Parameters.AddWithValue("@apellido", c.apellido);
                cmd.Parameters.AddWithValue("@documento", c.nroDoc);
                cmd.Parameters.AddWithValue("@telefono", c.nroTelefono);
                cmd.Parameters.AddWithValue("@email", c.email);
                cmd.ExecuteNonQuery();
                t.Commit();
                aux = true;
            }
            catch (Exception)
            {

                t.Rollback();
            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return aux;
        }
    }
}
