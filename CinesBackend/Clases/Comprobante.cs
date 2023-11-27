using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Clases
{
    public class Comprobante
    {
        public int idComprobante { get; set; }
        public DateTime fechaCompra { get; set; }   
        public TimeSpan hora { get; set; }
        public Empleados empleado { get; set; }
        public Clientes clientes { get; set; }
        public Funciones funcion { get; set; }
        public decimal totalPagar { get; set; }
        public List<DetalleComprobante> detalles { get; set; }
        public Comprobante(int id, DateTime fecha, TimeSpan hora, Empleados e, Clientes c, Funciones f, decimal total)
        {
            this.totalPagar=total;
            this.idComprobante=id;
            this.fechaCompra=fecha;
            this.hora=hora;
            e = new Empleados();
            c = new Clientes();
            f = new Funciones();
            detalles = new List<DetalleComprobante>();
        }
        public Comprobante()
        {
            idComprobante = 0;
            fechaCompra = DateTime.Now;
            hora = TimeSpan.Zero;
            empleado = new Empleados();
            clientes = new Clientes();
            funcion = new Funciones();
            totalPagar = 0;
            detalles = new List<DetalleComprobante>();
        }
        public void agregarDetalle(DetalleComprobante d)
        {
            detalles.Add(d);
        }
        public void quitardetalle(DetalleComprobante d)
        {
            detalles.Remove(d);
        }
    }
}
