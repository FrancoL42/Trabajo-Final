using Cines.Clases.Ubicacion;

namespace Cines.Clases.Personas
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public Persona persona { get; set; }
        public string Mail { get; set; }
        public Barrios barrio { get; set; }

        public Cargos cargo { get; set; }

        public Empleados()
        {
            IdEmpleado = 0;
            persona = new Persona();
            Mail = string.Empty;
            barrio = new Barrios();
            cargo = new Cargos();
        }
        public Empleados(int id, Persona pers,string mail, Barrios bar, Cargos carg)
        {
            IdEmpleado = id;
            persona = pers;
            Mail = mail;
            barrio = bar;
            cargo = carg;
            
        }
    }
}