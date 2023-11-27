using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Actores
    {
        public int idActor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Peliculas pelicula { get; set; }
        public Actores(int id, string nom, string ape, Peliculas p)
        {
            this.idActor = id;
            this.nombre = nom;
            this.apellido = ape;
            p = new Peliculas();
        }
        public Actores()
        {
            idActor = 0;
            nombre = "";
            apellido = "";
            pelicula = new Peliculas();
        }
    }
}
