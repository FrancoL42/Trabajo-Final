using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Salas
    {
        public int idSala { get; set; }
        public int cantidadButacas { get; set; }
        public string estadoSala { get; set; }
        public Salas(int id, int cantidad, string estado)
        {
            this.idSala = id;
            this.cantidadButacas = cantidad;
            this.estadoSala = estado;
        }
        public Salas()
        {
            idSala = 0;
            cantidadButacas = 0;
            estadoSala = "";
        }   
    }
}
