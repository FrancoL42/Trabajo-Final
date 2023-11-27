using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Clases
{
    public class DetalleComprobante
    {
        public Comprobante comprobante { get; set; }
        public Salas sala { get; set; }
        public ButacasxSalas butacasxSalas { get; set; }
        public List<ButacasxSalas> lstButacasxSalas { get; set; }
        public DetalleComprobante()
        {
            this.comprobante = new Comprobante();
            this.sala = new Salas();
            this.butacasxSalas = new ButacasxSalas();
            lstButacasxSalas = new List<ButacasxSalas>();
        }
        public void quitarButaca(ButacasxSalas b)
        {
            List<ButacasxSalas> itemsToRemove = new List<ButacasxSalas>();

            foreach (ButacasxSalas bu in lstButacasxSalas)
            {
                if (b.idButaca.Equals(bu.idButaca))
                {
                    itemsToRemove.Add(bu);
                }
            }

            foreach (ButacasxSalas buToRemove in itemsToRemove)
            {
                lstButacasxSalas.Remove(buToRemove);
            }
        }
 
    }
}
