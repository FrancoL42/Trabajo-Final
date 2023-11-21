using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cine
{
    public class Funciones
    {
        public int IdFuncion { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public Salas sala { get; set; }
        public Peliculas pelicula { get; set; }
        public double Precio { get; set; }

        public TipoFormato formato { get; set; }

        public Funciones()
        {
            IdFuncion = 0;
            Hora = TimeSpan.Zero;
            Fecha = DateTime.Now;
            sala = new Salas();
            pelicula = new Peliculas();
            Precio = 0;
            formato = new TipoFormato();
        }
        public Funciones(int id, TimeSpan hor,DateTime fec, Salas sal, Peliculas pel, double pre)
        {
            IdFuncion = id;
            Hora = hor;
            Fecha = fec;
            sala = sal;
            pelicula = pel;
            Precio = pre;
            
        }

        

    }
}
