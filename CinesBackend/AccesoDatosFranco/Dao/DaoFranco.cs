using CinesBackend.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.AccesoDatosFranco.Dao
{
    public class DaoFranco : IDaoFranco
    {
        public bool insertarPeliculas(Peliculas p)
        {
            return HelperDB.obtenerInstancia().AltaPeliculas(p);
        }

        public bool crearComprobante(Comprobante c)
        {
            return HelperDB.obtenerInstancia().InsertarAbmMaestro(c);
        }

        public List<ButacasxSalas> traerButacasxSalas(int id)
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarButacasxSalas("SP_TRAER_BUTACASXSALAS", id);
            List<ButacasxSalas> lstButacas = new List<ButacasxSalas>();
            foreach(DataRow row in tabla.Rows)
            {
                ButacasxSalas butacasxSalas = new ButacasxSalas();
                butacasxSalas.idButaca = Convert.ToInt32(row["butaca_nro"]);
                butacasxSalas.estadoButaca = (row["estado"]).ToString();
                lstButacas.Add(butacasxSalas);
            }
            return lstButacas;
        }

        public List<Funciones> traerFunciones(string pelicula, string fecha)
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarFunciones("SP_CONSULTAR_FUNCIONES", pelicula, fecha);
           List<Funciones> funciones = new List<Funciones>();
            foreach(DataRow row in tabla.Rows)
            {
                Funciones funcion = new Funciones();
                funcion.idFuncion = Convert.ToInt32(row["ID_FUNCION"]);
                funcion.fecha = Convert.ToDateTime(row["FECHA"]);
                if (TimeSpan.TryParse(row["HORA"].ToString(), out TimeSpan hora))
                    funcion.hora = hora;
                funcion.pelicula.idPelicula = Convert.ToInt32(row["ID_PELICULA"]);
                funcion.pelicula.nombrePelicula = (row["TITULO"]).ToString();
                funcion.precioFuncion =(Decimal)row["PRECIO_ACTUAL"];
                funcion.sala.idSala = Convert.ToInt32(row["id_sala"]);
                funciones.Add(funcion);
            }
           return funciones;
        }

        public List<Peliculas> traerPeliculas()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_CONSULTAR_PELICULAS");
            List<Peliculas> lstPeliculas = new List<Peliculas>();
            foreach(DataRow row in tabla.Rows)
            {
                Peliculas p = new Peliculas();
                p.idPelicula = Convert.ToInt32(row["ID_PELICULA"]);
                p.nombrePelicula = (row["TITULO"]).ToString();
                p.duracion = (TimeSpan)row["duracion"];
                p.clasificación.idClasificacion = Convert.ToInt32(row["id_clasificacion"]);
                p.idioma.idIdioma= Convert.ToInt32(row["id_idioma"]);
                p.fecEstreno = Convert.ToDateTime(row["FEC_ESTRENO"]);
                lstPeliculas.Add(p);
            }
            return lstPeliculas;
        }

        public List<Salas> traerSalas()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_CONSULTAR_SALAS");
            List<Salas> lstSalas = new List<Salas>();
            foreach(DataRow row in tabla.Rows) 
            {
                Salas s = new Salas();
                s.idSala = Convert.ToInt32(row["ID_SALA"]);
                s.cantidadButacas = Convert.ToInt32(row["cantidad_asientos"]);
                s.estadoSala = (row["estado"]).ToString();               
                lstSalas.Add(s);
            }
            return lstSalas;
        }

        public List<Generos> traerGeneros()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_CONSULTAR_GENERO");
            List<Generos> lstGeneros = new List<Generos>();
            foreach(DataRow row in tabla.Rows)
            {
                Generos g = new Generos();
                g.idGenero = Convert.ToInt32(row["ID_GENERO"]);
                g.nombreGenero = (row["DESCRIPCION"]).ToString();
                lstGeneros.Add(g);
            }
            return lstGeneros;
        }

        public List<Clasificacion> traerClasificaciones()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_CONSULTAR_CLASIFICACION");
            List<Clasificacion> lstClasificaciones = new List<Clasificacion>();
            foreach(DataRow row in tabla.Rows)
            {
                Clasificacion c = new Clasificacion();
                c.idClasificacion = Convert.ToInt32(row["ID_CLASIFICACION"]);
                c.descripcion = (row["DESCRIPCION"]).ToString();
                lstClasificaciones.Add(c);
            }
            return lstClasificaciones;
        }

        public List<Idiomas> traerIdiomas()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_CONSULTAR_IDIOMA");
            List<Idiomas> lstIdiomas = new List<Idiomas>();
            foreach(DataRow row in tabla.Rows)
            {
                Idiomas i = new Idiomas();
                i.idIdioma = Convert.ToInt32(row["ID_IDIOMA"]);
                i.nombreIdioma = (row["nombreIdioma"]).ToString();
                lstIdiomas.Add(i);
            }
            return lstIdiomas;
        }

        public bool IniciarSesion(string usuario, string contrasenia, out int idEmpleado, out int idCargo)
        {
            return HelperDB.obtenerInstancia().IniciarSesion(usuario, contrasenia, out idEmpleado, out idCargo);
        }

        public bool modificarPeliculas(Peliculas p)
        {
            return HelperDB.obtenerInstancia().modificarPeliculas(p);
        }

        public bool bajaPelicula(Peliculas p)
        {
            return HelperDB.obtenerInstancia().BorrarPelicula(p);
        }

        public bool AltaSalas(Salas s)
        {
            return HelperDB.obtenerInstancia().AltaSalas(s);
        }

        public List<Funciones> traerFuncionesSinParam()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_CONSULTAR_FUNCIONES_SINPARAM");
            List<Funciones> lista = new List<Funciones>();
            foreach(DataRow row in tabla.Rows)
            {
                Funciones f = new Funciones();
                f.idFuncion = Convert.ToInt32(row["ID_FUNCION"]);
                f.hora = (TimeSpan)row["HORA"];
                f.fecha = Convert.ToDateTime(row["FECHA"]);
                f.precioFuncion = (decimal)row["PRECIO_ACTUAL"];
                f.sala.idSala = Convert.ToInt32(row["id_sala"]);
                f.pelicula.nombrePelicula = (row["TITULO"]).ToString();
                lista.Add(f);
            }
            return lista;
        }

        public bool AltaFunciones(Funciones f)
        {
            return HelperDB.obtenerInstancia().AltaFunciones(f);
        }

        public List<Peliculas> traerPeliculasCliente()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_PELICULAS_CLIENTE");
            List<Peliculas> lstPeliculas = new List<Peliculas>();
            foreach(DataRow row in tabla.Rows)
            {
                Peliculas p = new Peliculas();
                p.nombrePelicula = (row["TITULO"]).ToString();
                p.genero.nombreGenero = (row["nombreGenero"]).ToString();
                p.idioma.nombreIdioma = (row["IDIOMA"]).ToString();
                p.fecEstreno = Convert.ToDateTime(row["FEC_ESTRENO"]);
                lstPeliculas.Add(p);
            }
            return lstPeliculas;
        }

        public bool modificarSala(Salas s)
        {
            return HelperDB.obtenerInstancia().modificarSala(s);
        }

        public bool bajaSala(Salas s)
        {
            return HelperDB.obtenerInstancia().bajaSala(s);
        }

        public bool bajaCliente(Clientes c)
        {
            return HelperDB.obtenerInstancia().BajaCliente(c);
        }

        public List<Clientes> obtenerClientes()
        {
            DataTable tabla = HelperDB.obtenerInstancia().consultarSinParametros("SP_CONSULTAR_CLIENTES");
            List<Clientes> lista = new List<Clientes>();
            foreach(DataRow row in tabla.Rows)
            {
                Clientes c = new Clientes();
                c.idCliente = Convert.ToInt32(row["ID_CLIENTE"]);
                c.nombre = (row["NOMBRE_CLIENTE"]).ToString();
                c.apellido = (row["APELLIDO_CLIENTE"]).ToString();
                c.nroDoc = Convert.ToInt32(row["DOCUMENTO"]);
                lista.Add(c);
            }
            return lista;
        }

        public bool modificarCliente(Clientes c)
        {
            return HelperDB.obtenerInstancia().modificarCliente(c);
        }
    }
}
