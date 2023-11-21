namespace Cines.Clases.Personas
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
        public Persona(string nom, string ape)
        {
            Nombre = nom;
            Apellido = ape;
        }
    }
}