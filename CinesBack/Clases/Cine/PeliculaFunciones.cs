using Cines.Clases.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases.Cine
{
    public class PeliculaFunciones
    {
        public int id_peli_funcion { get; set; }
        public Peliculas Peli { get; set; }
        public Funciones Funcion { get; set; }
        public PeliculaFunciones()
        {
            id_peli_funcion = 0;
            Peli = new Peliculas();
            Funcion = new Funciones();

        }
        public PeliculaFunciones(int id,Peliculas peli, Funciones func)
        {
            id_peli_funcion = id;
            Peli = peli;
            Funcion = func;
        }
    }
}
