using Cines.Clases.Cine;
using Cines.Clases.Cines.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases.Cine
{
    internal class ButacasSalas
    {
        public int Id_butacas_sala { get; set; }
        public Salas sala { get; set; }
        public Butacas butaca { get; set; }
    }
}
