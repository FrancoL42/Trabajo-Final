using Cines.Clases.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cines.Cine
{
    public class ButacasFunciones
    {
        public int IdButacasFuncion { get; set; }
        public Butacas butaca { get; set; }
        public Funciones funcion { get; set; }

        public Reservas reserva { get; set; }

        public ButacasFunciones()
        {
            IdButacasFuncion = 0;
            butaca = new Butacas();
            funcion = new Funciones();
            reserva = new Reservas();
        }

        public ButacasFunciones(int id, Butacas but, Funciones fun, Reservas res)
        {
            IdButacasFuncion = id;
            butaca = but;
            funcion = fun;
            reserva = res;
             
        }
    }
}
