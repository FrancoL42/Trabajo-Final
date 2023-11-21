using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Parametro
    {
        public string clave { get; set; }
        public object valor { get; set; }
        public Parametro(string Clave, object Valor)
        {
                this.clave = Clave;
                this.valor = Valor;
        }
    }
}
