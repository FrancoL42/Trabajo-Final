using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaCineBack.Acceso_a_Datos.Parametros;
using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Ventas;
using Cines.Clases.Personas;

namespace SistemaCineBack.Acceso_a_Datos
{
    class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-72P6KAS\SQLEXPRESS;Initial Catalog=cines_final;Integrated Security=True");
        public static HelperDB obtenerInstancia()
        {
            if (instancia == null)
            { instancia = new HelperDB(); }
            return instancia;
        }
        public SqlConnection GetConnection()
        {
            return cnn;
        }
        public DataTable consultar(string sp)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable consultarConParametros(string sp,string pelicula, string fecha)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pelicula", pelicula);
            cmd.Parameters.AddWithValue("@Fecha", fecha);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public bool ejecutarSql(string spComprobante, string spDetalle,string spCliente, Comprobantes comprobantes, Clientes c)
        {
            bool aux = true;
            
                    SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdCliente = new SqlCommand(spCliente, cnn,t);
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Parameters.AddWithValue("@nombre",c.persona.Nombre);
                cmdCliente.Parameters.AddWithValue("@apellido", c.persona.Apellido);
                //cmdCliente.Parameters.AddWithValue("@tipo_doc", 1);
                cmdCliente.Parameters.AddWithValue("@documento", c.NroDocumento);
                cmdCliente.Parameters.AddWithValue("@telefono", c.Telefono);
                cmdCliente.Parameters.AddWithValue("@email", c.Mail);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_cliente";
                param.DbType = DbType.Int32;
                param.Direction = ParameterDirection.Output;
                cmdCliente.Parameters.Add(param);                         
                cmdCliente.ExecuteNonQuery();
                int idCliente = (int)param.Value;

                SqlCommand cmdCompra = new SqlCommand(spComprobante, cnn, t);
                cmdCompra.CommandType = CommandType.StoredProcedure;
                cmdCompra.Parameters.AddWithValue("@Cliente",idCliente);
                cmdCompra.Parameters.AddWithValue("@fecha", comprobantes.fecha);
                SqlParameter pIdComprobanteOut = new SqlParameter();
                pIdComprobanteOut.ParameterName = "@idComprobante";
                pIdComprobanteOut.Direction = ParameterDirection.Output;
                pIdComprobanteOut.DbType = DbType.Int32;
                cmdCompra.Parameters.Add(pIdComprobanteOut);
                cmdCompra.ExecuteNonQuery();

                int idComprobante = (int)pIdComprobanteOut.Value;
               
                foreach(DetalleComprobante d in comprobantes.detalle)
                {
                    SqlCommand cmdDetalle = new SqlCommand(spDetalle, cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@idComprobante", idComprobante);
                    //cmdDetalle.Parameters.AddWithValue("@idCandy",0);
                    cmdDetalle.Parameters.AddWithValue("@idFuncion", d.funcione.IdFuncion);
                    cmdDetalle.Parameters.AddWithValue("@idSala", d.funcione.sala.IdSala);
                    cmdDetalle.Parameters.AddWithValue("@precio", d.funcione.Precio);
                    cmdDetalle.ExecuteNonQuery();
                    foreach(Butacas b in d.funcione.sala.butacas)
                    {
                        SqlCommand cmdSala = new SqlCommand("SP_INSERTAR_SALA", cnn, t);
                        cmdSala.CommandType = CommandType.StoredProcedure;
                        cmdSala.Parameters.AddWithValue("@idButaca", b.IdButaca);
                        cmdSala.ExecuteNonQuery();
                    }

                    aux = true;
                }

              
                t.Commit();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                aux = false;
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
           
            return aux;
        }
        public int obtenerProximoId()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_ID";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)pOut.Value;
        }
        //Metodo Traer Butacas
        public List<Butacas> TraerButacas(string fechaFuncion, string pelicula)
        {
            List<Butacas> lButacas = new List<Butacas>();

            try
            {
               
                
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand("ButacasDisponiblesXfuncion", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@FechaFuncion", fechaFuncion));
                        cmd.Parameters.Add(new SqlParameter("@Pelicula", pelicula));
                        //cmd.Parameters.Add(new SqlParameter("@HoraFuncion", Hora.Ticks));
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ID_BUTACA"] != DBNull.Value && reader["NRO_BUTACA"] != DBNull.Value && reader["FILA"] != DBNull.Value)
                                {
                                    int id = (int)reader["ID_BUTACA"];
                                    int nro = (int)reader["NRO_BUTACA"];
                                    int fila = (int)reader["FILA"];
                                    lButacas.Add(new Butacas(id, nro, fila));
                                }
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                // Manejar la excepción 
            }

            return lButacas;
           
        }
        public void Open()
        {
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
        }

        public void Close()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public bool borrarComprobantes(string id, string spBorrar)
        {
            bool aux = false;
            SqlTransaction t = null;
            int idComprobante = Convert.ToInt32(id);
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spBorrar, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idComprobante);
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
        public DataTable obtenerComprobantesParametros(int nroDoc, string apellido, string SP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(SP, cnn);
            DataTable tabla = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@documento", nroDoc);
            cmd.Parameters.AddWithValue("@cliente", apellido);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }

    }
}
