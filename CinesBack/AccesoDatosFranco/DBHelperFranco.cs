using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CinesBack.Clases;

namespace CinesBack.AccesoDatosFranco
{
    public class DBHelperFranco
    {        
        public SqlConnection cnn = new SqlConnection("");
        private static DBHelperFranco instancia;
        public static DBHelperFranco obtenerInstancia()
        {
            if (instancia == null)
                instancia = new DBHelperFranco();
            return instancia;
        }
        public DataTable consultarSinParametros(string sp)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }



        public bool AltaPeliculas(Peliculas p) //ABM PELICULAS
        {
            cnn.Open();
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_PELICULA", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titulo", p.nombrePelicula);
                cmd.Parameters.AddWithValue("@duracion", p.duracion);
                cmd.Parameters.AddWithValue("@idIdioma", p.idioma.idIdioma);
                cmd.Parameters.AddWithValue("@idClasificion", p.clasificación.idClasificacion);
                cmd.Parameters.AddWithValue("@idGenero", p.genero.idGenero);
                cmd.Parameters.AddWithValue("@fecEstreno", p.fecEstreno);
                cmd.Parameters.AddWithValue("@director", p.director);
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
        public bool BorrarPelicula(Peliculas p)
        {
            cnn.Open();
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                t = cnn.BeginTransaction();
                aux = true;
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                throw;
                
            }
            return aux;
        }
        public bool AltaSalas(Salas s) //ABM SALAS
        {
            cnn.Open();
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_SALAS", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cantAsientos", s.cantidadButacas);
                SqlParameter param = new SqlParameter();
                cmd.ExecuteNonQuery();
                int cantAsientos = s.cantidadButacas;
                for (int i = 1; i <= cantAsientos; i++)
                {
                    SqlCommand cmdButaca = new SqlCommand();
                    cmdButaca.CommandType = CommandType.StoredProcedure;
                    cmdButaca.Parameters.AddWithValue("@idSala", s.idSala);
                    cmdButaca.Parameters.AddWithValue("@nroButaca", i);
                }
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
        public bool AltaOperadores(Empleados e) //ABM EMPLEADOS
        {
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
            cnn.Open();
            bool aux = false;
            try
            {
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_ALTA_FUNCIONES", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecfuncion", f.fecha);
                cmd.Parameters.AddWithValue("@horaFuncion", f.hora);
                cmd.Parameters.AddWithValue("@idPelicula", f.pelicula.idPelicula);
                cmd.Parameters.AddWithValue("@idSala", f.sala.idSala);
                cmd.ExecuteNonQuery();
                t.Commit();
                aux = true;
            }
            catch (Exception)
            {

                throw;
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
