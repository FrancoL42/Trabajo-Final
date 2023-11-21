using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cines.Clases.Ubicacion;

namespace Cines.Clases.Cine
{
    public class Peliculas
    {

        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public TimeSpan Duracion { get; set; } //DURACION EN BASE DE DATOS TIENE COMO TIPO DE DATO TIME (HORA)
        public Genero Genero { get; set; }
        public Clasificacion clasificacion { get; set; }

        public Idioma Idioma { get; set; }
        public DateTime Fec_Estreno { get; set; }
        public PaisOrigen Pais { get; set; }

        public Peliculas()
        {
            IdPelicula = 0;
            Titulo = string.Empty;
            Duracion = TimeSpan.Zero;
            Genero = new Genero();
            clasificacion = new Clasificacion();
            Idioma = new Idioma();
            Fec_Estreno = DateTime.Now;
            Pais = new PaisOrigen();
        }
        public Peliculas(int id, string title, TimeSpan dur, Genero gen, Clasificacion clasf, Idioma idiom, DateTime estreno, PaisOrigen pais)
        {
            IdPelicula = id;
            Titulo = title;
            Duracion = dur;
            Genero = gen;
            clasificacion = clasf;
            Idioma = idiom;
            Fec_Estreno = estreno;
            Pais = pais;
        }
        public Peliculas(string pelicula)
        {
            Titulo = pelicula;
        }

        
    }
}
