using Cines.Clases.Cine;

namespace CinesBack.Clases.Candy_Bar
{
    public class ProductoCandy
    {
        private int IdProductoCandy {get; set;}
        private string Nombre { get; set;}
        private string Descripcion { get; set;}
        private double Precio { get; set;}
        private CineClase cine {get; set;}

        public ProductoCandy(int id, string nom, string desc, double pre, CineClase cin)
        {
            IdProductoCandy = id;
            Nombre = nom;
            Descripcion = desc;
            Precio = pre;
            cine = cin;
                
        }

    }
}