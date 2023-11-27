using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Clases
{
    public class Funciones
    {
        public int idFuncion { get; set; }
        public Peliculas pelicula { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }
        public Salas  sala { get; set; }
        public decimal precioFuncion { get; set; }
        public Funciones(int id, Peliculas p, DateTime Fec, TimeSpan hora, Salas salas, decimal precio)
        {
            this.idFuncion = id;
            this.pelicula = new Peliculas();
            this.fecha = Fec;
            this.hora = hora;
            this.sala = new Salas();
            this.precioFuncion = precio;
        }
        public Funciones()
        {
            this.idFuncion = 0;
            this.hora = TimeSpan.Zero;
            this.pelicula = new Peliculas();
            this.fecha = DateTime.Now;
            this.sala = new Salas();
            this.precioFuncion = 0;
        }
    }
}
