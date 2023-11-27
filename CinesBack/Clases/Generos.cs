using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Generos
    {
        public int idGenero { get; set; }
        public string nombreGenero { get; set; }
        public Generos(int id, string nombre)
        {
            this.idGenero = id;
            this.nombreGenero = nombre;
        }
        public Generos()
        {
            idGenero = 0;
            nombreGenero = "";
        }
    }
}
