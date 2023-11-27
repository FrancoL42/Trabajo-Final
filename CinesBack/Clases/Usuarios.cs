using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinesBack.Clases
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public Empleados empleado { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }

        public Usuarios(int id, Empleados e, string nombre, string contra)
        {
            this.idUsuario = id;
            e = new Empleados();
            this.nombreUsuario = nombre;
            this.contraseña = contra;
        }
        public Usuarios()
        {
            idUsuario=0;
            empleado=new Empleados();
            nombreUsuario = "";
            contraseña = "";
        }
    }
}
