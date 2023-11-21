using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cine
{
    public class Genero
    {
        public int IdGenero { get; set; }
        public string genero { get; set; }

        public Genero()
        {
            IdGenero = 0;
            genero = string.Empty;
        }

        public Genero(int id, string gen)
        {
            IdGenero = id;
            genero = gen;
             
        }
    }
}
