using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Clasificación
    {
        public int idClasificacion { get; set; }
        public string descripcion { get; set; }
        public Clasificación(int id, string desc)
        {
            this.idClasificacion = id;
            this.descripcion = desc;
        }
        public Clasificación()
        {
            idClasificacion=0;
            descripcion = "";
        }
    }
}
