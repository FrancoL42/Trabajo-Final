using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class TiposDocumentos
    {
        public int idTipoDoc { get; set; }
        public string descripcionTipo { get; set; }
        public TiposDocumentos(int id, string desc )
        {
            this.idTipoDoc = id;
            this.descripcionTipo = desc;
        }
        public TiposDocumentos()
        {
            idTipoDoc=0;
            descripcionTipo = "";

        }
    }
}
