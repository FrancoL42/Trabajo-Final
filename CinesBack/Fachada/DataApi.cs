using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Personas;
using Cines.Clases.Ventas;
using SistemaCineBack.Acceso_a_Datos.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Fachada
{
    public class DataApi : IDataApi
    {
        IDao dao;
        public DataApi()
        {
            dao = new DaoCine();
        }

        public bool borrarComprobante(string id)
        {
            return dao.borrar(id);
        }

        public bool insertarComprobante(Comprobantes comprobantes, Clientes c)
        {
            return dao.crear(comprobantes, c);
        }

        public List<Comprobantes> obtenerComprobantes()
        {
            return dao.TraerComprobantes();
        }

        public List<DetalleComprobante> obtenerDetalleComprobantes()
        {
            return dao.TraerDetalle();
        }

        public DataTable obtenerInformeVentasPorMes(int mes, int anio)
        {
            return dao.obtenerInformeVentasPorMes(mes, anio);
        }

        public List<Butacas> TraerButacas(string Fecha, string pelicula)
        {
            return dao.TraerButacas(Fecha, pelicula);
        }
    

        public List<Funciones> TraerFunciones(string pelicula, string fechita)
        {
            return dao.TraerFunciones(pelicula, fechita);
        }

        public List<Peliculas> TraerPeliculas()
        {
            return dao.TraerPeliculas(); 
        }

        public Peliculas traerPeliculasId(int id)
        {
            return dao.TraerPeliculaPorId(id);
        }
    }
}
