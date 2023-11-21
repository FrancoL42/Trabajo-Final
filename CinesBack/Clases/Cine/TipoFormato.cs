namespace Cines.Clases.Cine
{
    public class TipoFormato
    {
        public int IdTipoFormato { get; set; }
        public string Tipo { get; set; }
        public TipoFormato()
        {
            IdTipoFormato = 0;
            Tipo = string.Empty;
        }
        public TipoFormato(int id, string tip)
        {
            IdTipoFormato = id;
            Tipo = tip;
            
        }
    }
}