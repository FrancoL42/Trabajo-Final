using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Personas;
using Cines.Clases.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Fachada
{
    public interface IDataApi
    {
        public List<Comprobantes> obtenerComprobantes(); //API
        public List<DetalleComprobante> obtenerDetalleComprobantes(); //API
        public Peliculas traerPeliculasId(int id); //API
        public List<Funciones> TraerFunciones(string pelicula, string fechita); //API
        public List<Peliculas> TraerPeliculas(); //API
        public DataTable obtenerInformeVentasPorMes(int mes, int anio); //API
        public List<Butacas> TraerButacas(string Fecha, string pelicula); //API
        public bool borrarComprobante(string id);
        public bool insertarComprobante(Comprobantes comprobantes, Clientes c);
    }
}
