using System.CodeDom;

namespace Cines.Clases.Personas
{
    public class Cargos
    {
        public int IdCargos { get; set; }
        public string Cargo { get; set; }

        public Cargos()
        {
            IdCargos = 0;
            Cargo = string.Empty;
        }
        public Cargos(int id, string carg)
        {
            IdCargos = id;
            Cargo = carg;
            
        }
    }
}