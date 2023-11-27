using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Peliculas
    {
        public int idPelicula { get; set; }
        public string nombrePelicula { get; set; }
        public double duracion { get; set; }
        public Clasificación clasificación { get; set; }
        public Idiomas idioma { get; set; }
        public DateTime fecEstreno { get; set; }
        public Generos genero { get; set; }
        public string director { get; set; }
        public Peliculas(int id, string nombre, double duracion, Clasificación c, Idiomas i, DateTime fecha, Generos g, string director)
        {
            this.idPelicula = id;
            this.nombrePelicula = nombre;
            this.duracion = duracion;
            c = new Clasificación();
            i = new Idiomas();
            this.fecEstreno = fecha;
            g = new Generos();
            this.director = director;
        }
        public Peliculas()
        {
            idPelicula = 0;
            nombrePelicula = "";
            duracion = 0;
            clasificación = new Clasificación();
            idioma = new Idiomas();
            fecEstreno = DateTime.Today;
            genero = new Generos();
            director = "";
        }
    }
}
