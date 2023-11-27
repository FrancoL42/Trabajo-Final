using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Clases
{
    public class Clasificacion
    {
        public int idClasificacion { get; set; }
        public string descripcion { get; set; }
        public Clasificacion(int id, string desc)
        {
            this.idClasificacion = id;
            this.descripcion = desc;
        }
        public Clasificacion()
        {
            idClasificacion=0;
            descripcion = "";
        }
    }
}
