using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Comprobante
    {
        public int idComprobante { get; set; }
        public DateTime fechaCompra { get; set; }   
        public int hora { get; set; }
        Empleados empleado { get; set; }
        Clientes clientes { get; set; }
        Funciones funcion { get; set; }
        public double totalPagar { get; set; }
        public Comprobante(int id, DateTime fecha, int hora, Empleados e, Clientes c, Funciones f, double total)
        {
            this.totalPagar=total;
            this.idComprobante=id;
            this.fechaCompra=fecha;
            this.hora=hora;
            e = new Empleados();
            c = new Clientes();
            f = new Funciones();
        }
        public Comprobante()
        {
            idComprobante = 0;
            fechaCompra = DateTime.Now;
            hora = DateTime.Now.Hour;
            empleado = new Empleados();
            clientes = new Clientes();
            funcion = new Funciones();
            totalPagar = 0;
        }
    }
}
