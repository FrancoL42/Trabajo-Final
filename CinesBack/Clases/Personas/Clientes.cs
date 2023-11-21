namespace Cines.Clases.Personas
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public Persona persona { get; set; }
       
        public int NroDocumento { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }

        public Clientes()
        {
            IdCliente = 0;
            persona = new Persona();
          
            NroDocumento = 0;
            Telefono = 0;
            Mail = string.Empty;
        }
        public Clientes(int id, Persona pers, int nroD,int tel, string email)
        {
            IdCliente = id;
            persona = pers;
           
            NroDocumento = nroD;
            Telefono = tel;
            Mail = email;
            
        }
    }
}