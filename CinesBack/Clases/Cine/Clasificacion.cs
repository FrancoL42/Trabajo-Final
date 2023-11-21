namespace Cines.Clases.Cine
{
    public class Clasificacion
    {
        public int Id_clasificacion { get; set; }
        public string Descripcion { get; set; }

        public Clasificacion()
        {
            Id_clasificacion = 0;
            Descripcion = string.Empty;
        }
        public Clasificacion(int id, string desc)
        {
            Id_clasificacion = id;
            Descripcion = desc;
            
        }
    }
}