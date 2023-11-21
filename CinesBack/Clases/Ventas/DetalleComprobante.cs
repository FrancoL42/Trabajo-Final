using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Cine;
using Cines.Clases.Cines;
using Cines.Clases.Cines.Cine;

namespace Cines.Clases.Ventas
{
    public class DetalleComprobante
    {
        public int IdDetalleComprobante { get; set; }
        public Comprobantes comprobante { get; set; }
        public Funciones funcione { get; set; }
        public ButacasFunciones butacaXfuncion { get; set; }

        public FormaPago formaPago { get; set; }
        public double precio { get; set; }

        public DetalleComprobante()
        {
            IdDetalleComprobante = 0;
            comprobante = new Comprobantes();
            funcione = new Funciones();
            butacaXfuncion = new ButacasFunciones();
            formaPago = new FormaPago();
            precio = 0;
        }
        public DetalleComprobante(int id, Comprobantes comp, Funciones fun, ButacasFunciones bxf, FormaPago forma, double pre)
        {
            IdDetalleComprobante = id;
            comprobante = comp;
            funcione = fun;
            butacaXfuncion = bxf;
            formaPago = forma; 
            precio = pre;
        }
    }
}
