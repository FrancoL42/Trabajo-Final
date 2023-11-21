namespace Cines.Clases.Ventas
{
    public class FormaPago
    {
        public int IdFormaPago { get; set; }
        public string Forma { get; set; }

        public FormaPago()
        {
            IdFormaPago = 0;
            Forma = string.Empty;
        }
        public FormaPago(int id, string form)
        {
            IdFormaPago = id;
            Forma = form;
        }
    }
}