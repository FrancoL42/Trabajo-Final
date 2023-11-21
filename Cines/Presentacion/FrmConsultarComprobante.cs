using Cines.Clases.Personas;
using Cines.Clases.Ventas;
using CinesFront.Http;
using Newtonsoft.Json;
using SistemaCineBack.Acceso_a_Datos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinesFront.Presentacion
{
    public partial class FrmConsultarComprobante : Form
    {
        IDao dao;
        Clientes cliente;
        Comprobantes c;     
        private async Task eliminarComprobante(string id)
        {
            string Json = JsonConvert.SerializeObject(id);
            string url = "https://localhost:7011/borrarComprobante?id=" + id;
            var data = await ClienteSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvComprobantes.Rows.Clear();
            await CargarDGV();        
        }
        private void obtenerComprobantes()
        {
            if(txtCliente.Text == "")
            {
                MessageBox.Show("INGRESE UN CLIENTE", "ERROR");
                return;
            }
            if(txtDoc.Text == string.Empty)
            {
                MessageBox.Show("INGRESE UN CLIENTE", "ERROR");
                return;
            }
            int nroDoc = Convert.ToInt32(txtDoc.Text);
            List<Comprobantes> lista = dao.obtenerComprobantesParametros(nroDoc, txtCliente.Text);
        }
        private async Task<List<Comprobantes>> CargarDGV()
        {
            //Cargar DGV
            //string url = "https://localhost:7028/getComprobantes";
            //var data = await ClienteSingleton.GetInstance().GetAsync(url);
            //List<Comprobantes> lstComprobantes = JsonConvert.DeserializeObject<List<Comprobantes>>(data);
            int nroDoc = Convert.ToInt32(txtDoc.Text);
            List<Comprobantes> lista = dao.obtenerComprobantesParametros(nroDoc, txtCliente.Text);

            foreach (Comprobantes c in lista)
            {
                
                dgvComprobantes.Rows.Add(new object[] { c.IdComprobante, cliente.persona.Apellido, c.fecha, "Eliminar Comprobante" });
            }
            return lista;
           
        }
        public FrmConsultarComprobante()
        {
            InitializeComponent();
            dao = new DaoCine();
            c = new Comprobantes();
        }

        private void FrmConsultarComprobante_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnElminar.Enabled = false;
        }
        private async Task editarComprobante(Comprobantes comprobantes)
        {
            string Json = JsonConvert.SerializeObject(comprobantes);
            string url = "https://localhost:7028/editarComprobante";
            var data = await ClienteSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            dgvComprobantes.Rows.Clear();
            cliente = new Clientes();
            cliente.NroDocumento = Convert.ToInt32(txtDoc.Text);
            cliente.persona.Apellido = txtCliente.Text;
            btnElminar.Enabled = true;
            btnModificar.Enabled = true;
            await CargarDGV();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Dispose();
           
        }

        private async void btnElminar_Click(object sender, EventArgs e)
        {
            
            string nro = txtNroComprobante.Text;
            await eliminarComprobante(nro);
            btnModificar.Enabled = false;
            btnElminar.Enabled = false;

        }

        private void dgvComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnElminar.Enabled = false;
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
