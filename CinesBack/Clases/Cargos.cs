using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Cargos
    {
        public int idCargo { get; set; }
        public string Descripcion { get; set; }
        public Cargos(int id, string descripcion)
        {
            this.idCargo = id;
            this.Descripcion = descripcion;
        }
        public Cargos()
        {
            idCargo = 0;
            Descripcion = "";
        }
    }
}
