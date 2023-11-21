using Cines.Clases.Cine;
using Cines.Clases.Cines;
using Cines.Clases.Cines.Cine;
using Cines.Clases.Cines.Cines;
using Cines.Clases.Personas;
using Cines.Clases.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCineBack.Acceso_a_Datos.Dao
{
   public  interface IDao
    {
        bool borrar(string id);
        int proximoID();
        List<DetalleComprobante> TraerDetalle();
        List<Comprobantes> TraerComprobantes();
        DataTable obtenerInformeVentasPorMes(int Mes, int Anio);
        List<Peliculas> TraerPeliculas();
        bool crear(Comprobantes comprobantes, Clientes c);
        List<Butacas> TraerButacas(string fechaSeleccionada, string? peliculaSelccionada);
        List<Funciones> TraerFunciones(string pelicula, string fechita);
        public Peliculas TraerPeliculaPorId(int idPelicula);
        public List<Comprobantes> obtenerComprobantesParametros(int nroDoc, string apellido);
        public bool IniciarSesion(string usuario, string contrasenia, out int idEmpleado, out int idCargo);
        public List<Peliculas> PeliculasConDetalles();
    }
}
