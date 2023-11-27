using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class DetalleComprobante
    {
        public Comprobante comprobante { get; set; }
        public Salas sala { get; set; } 
        public ButacasxSalas butacasxSalas { get; set; }
        public DetalleComprobante()
        {
            this.comprobante = new Comprobante();
            this.sala = new Salas();
            this.butacasxSalas = new ButacasxSalas();
        }
 
    }
}
