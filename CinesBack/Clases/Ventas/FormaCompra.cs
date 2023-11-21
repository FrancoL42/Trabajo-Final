namespace Cines.Clases.Ventas
{
    public class FormaCompra
    {
        public int IdFormaCompra { get; set; }
        public string Forma { get; set; }

        public FormaCompra()
        {
            IdFormaCompra = 0;
            Forma = string.Empty;
        }
        public FormaCompra(int id, string form)
        {
            IdFormaCompra = id;
            Forma = form;
            
        }
    }
}