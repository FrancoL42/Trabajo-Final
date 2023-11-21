namespace Cines.Clases.Cine
{
    public class TipoSala
    {
        public int IdTipoSala { get; set; }
        public string tipo { get; set; }

        public TipoSala()
        {
            IdTipoSala = 0;
            tipo = string.Empty;
        }
        public TipoSala(int id, string tip)
        {
            IdTipoSala = id;
            tipo = tip;
             
        }
    }
}