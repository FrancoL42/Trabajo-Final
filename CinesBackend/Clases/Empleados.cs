using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBackend.Clases
{
    public class Empleados
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public TiposDocumentos tipoDoc { get; set; }
        public int nroDoc { get; set; }
        public Cargos cargo { get; set; }
        public Empleados(int id, string nom, string ape, TiposDocumentos tipo, int nro, Cargos c)
        {
            this.idEmpleado = id;
            this.nombre = nom;
            this.apellido = ape;
            tipo = new TiposDocumentos();
            this.nroDoc = nro;
            c = new Cargos();
        }
        public Empleados()
        {
            idEmpleado=0;
            nombre = "";
            apellido = "";
            tipoDoc = new TiposDocumentos();
            nroDoc = 0;
            cargo = new Cargos();
        }
    }
}
