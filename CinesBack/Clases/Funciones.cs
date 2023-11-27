using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Funciones
    {
        public int idFuncion { get; set; }
        public Peliculas pelicula { get; set; }
        public DateTime fecha { get; set; }
        public int hora { get; set; }
        public Salas  sala { get; set; }
        public Funciones(int id, Peliculas p, DateTime Fec, int hora, Salas salas)
        {
            this.idFuncion = id;
            this.pelicula = new Peliculas();
            this.fecha = Fec;
            this.hora = hora;
            this.sala = new Salas();
        }
        public Funciones()
        {
            this.idFuncion = 0;
            this.hora = DateTime.Now.Hour;
            this.pelicula = new Peliculas();
            this.fecha = DateTime.Now;
            this.sala = new Salas();
        }
    }
}
