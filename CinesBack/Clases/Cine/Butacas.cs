using Cines.Clases.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cines.Clases.Cines.Cine
{
    public class Butacas
    {
        public int IdButaca { get; set; }
        public int NroButaca { get; set; }
        public int Fila { get; set; }
        public bool Disponible { get; set; }
        public Salas sala { get; set; }


        
        public Butacas(int Id, int Nro,int fila, bool disp,Salas sal)
        {
            IdButaca = Id;
            NroButaca = Nro;
            Fila = fila;
            sala = sal;
            Disponible = disp;
             
        }
        public Butacas(int Id, int Nro, int fila)
        {
            IdButaca = Id;
            NroButaca = Nro;
            Fila = fila;
        }

        public Butacas()
        {
        }
    }
}
