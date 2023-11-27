using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Idiomas
    {
        public int idIdioma { get; set; }
        string nombreIdioma { get; set; }
        public Idiomas(int id, string nombre)
        {
            this.idIdioma = id;
            this.nombreIdioma = nombre;
        }
        public Idiomas()
        {
                idIdioma=0;
            nombreIdioma = "";
        }
    }
}
