using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Clientes
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public TiposDocumentos tipoDoc { get; set; }
        public int nroDoc { get; set; }
        public string email { get; set; }
        public int nroTelefono { get; set; }
        public Clientes(int id, string nom, string ape, TiposDocumentos tipo, int nro, string mail, int nroTele)
        {
            this.idCliente = id;
            this.nombre = nom;
            this.apellido = ape;
            this.nroDoc = nro;
            this.email = mail;
            this.nroTelefono = nroTele;
            tipo = new TiposDocumentos();
        }
        public Clientes()
        {
            idCliente = 0;
            nombre = "";
            apellido = "";
            tipoDoc = new TiposDocumentos();
            nroDoc = 0;
            email = "";
            nroTelefono = 0;
        }
    }
}
