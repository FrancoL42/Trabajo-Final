namespace Cines.Clases.Ubicacion
{
    public class PaisOrigen
    {
        public int IdPais { get; set; }
        public string Pais { get; set; }

        public PaisOrigen()
        {
            IdPais = 0;
            Pais = string.Empty;
        }
        public PaisOrigen(int id, string nom)
        {
            IdPais = id;
            Pais = nom;
        }
    }
}