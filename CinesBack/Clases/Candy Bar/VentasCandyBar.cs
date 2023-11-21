using Cines.Clases.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases.Candy_Bar
{
    public class VentasCandyBar
    {
        private int IdVentasCandy { get; set; }
        private Comprobantes comprobante { get; set; }
        private ProductoCandy productoCandy { get; set; }
        private int Cantidad { get; set; }
        private double Precio {get; set; }

        public VentasCandyBar(int id, Comprobantes cmp, ProductoCandy candy, int cant, double pre)
        {
              IdVentasCandy  = id;
            comprobante = cmp;
            productoCandy = candy;
            Cantidad = cant;
            Precio = pre;
        }

    }
}
