using Cines.Clases.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases.Cine
{
    public class FuncionSala
    {
        public int id_funcion_sala { get; set; }
        public Funciones Funcion { get; set; }
        public Salas Sala { get; set; }
    }
}
