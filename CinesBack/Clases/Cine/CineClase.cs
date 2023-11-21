using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Ubicacion;

namespace Cines.Clases.Cine
{
    public class CineClase
    {
        public int IdCines { get; set; }
        public Barrios Barrios { get; set; }

        public string Cine { get; set; }

        public CineClase()
        {
            IdCines = 0;
            Barrios = new Barrios();
            Cine = string.Empty;
        }
        public CineClase(int id, Barrios bar, string nombre)
        {
            IdCines = id;
            Barrios = bar;
            Cine = nombre;
            
        }
    }
}
