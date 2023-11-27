using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Clases
{
    public class Peliculas
    {
        public int idPelicula { get; set; }
        public string nombrePelicula { get; set; }
        public TimeSpan duracion { get; set; }
        public Clasificacion clasificación { get; set; }
        public Idiomas idioma { get; set; }
        public DateTime fecEstreno { get; set; }
        public Generos genero { get; set; }
        public string director { get; set; }
        public Peliculas(int id, string nombre, TimeSpan duracion, Clasificacion c, Idiomas i, DateTime fecha, Generos g, string director)
        {
            this.idPelicula = id;
            this.nombrePelicula = nombre;
            this.duracion = duracion;
            c = new Clasificacion();
            i = new Idiomas();
            this.fecEstreno = fecha;
            g = new Generos();
            this.director = director;
        }
        public Peliculas()
        {
            idPelicula = 0;
            nombrePelicula = "";
            duracion = TimeSpan.Zero;
            clasificación = new Clasificacion();
            idioma = new Idiomas();
            fecEstreno = DateTime.Today;
            genero = new Generos();
            director = "";
        }
    }
}
