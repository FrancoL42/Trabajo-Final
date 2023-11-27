using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class ButacasxSalas
    {
        public Salas sala { get; set; }
        public int idButaca { get; set; }
        public string estadoButaca { get; set; }
        public ButacasxSalas()
        {
            sala = new Salas();
            idButaca = 0;
            estadoButaca = "";
        }
        public ButacasxSalas(Salas sala, int id, string estado)
        {
            this.sala = new Salas();
            this.idButaca = id;
            this.estadoButaca = estado;
        }
    }
}
