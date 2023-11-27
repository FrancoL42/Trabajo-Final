using CinesBackend.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCine.Http;

namespace TPCine.Abm
{
    public partial class FrmModificarCliente : Form
    {
        Clientes c;
        public FrmModificarCliente()
        {
            InitializeComponent();
        }
        private async Task cargarDGV()
        {
            string url = string.Format("https://localhost:7229/traerClientes");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Clientes> lstClientes = JsonConvert.DeserializeObject<List<Clientes>>(data);
            foreach (Clientes c in lstClientes)
            {
                dgvCliente.Rows.Add(c.idCliente, c.nombre, c.apellido, c.nroDoc, "Activo");
            }
        }
        private async Task cargarCombo()
        {
            string url = string.Format("https://localhost:7229/traerClientes");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Clientes> lstClientes = JsonConvert.DeserializeObject<List<Clientes>>(data);
            cboCliente.DataSource = lstClientes;
            cboCliente.ValueMember = "idCliente";
            cboCliente.DisplayMember = "apellido";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            await cargarCombo();
            await cargarDGV();
            c = new Clientes();
           
        }
        public async Task modificarCliente(Clientes c)
        {
            string url = "https://localhost:7229/modificarCliente";
            string json = JsonConvert.SerializeObject(c);
            var data = await ClienteSingleton.GetInstance().PutAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCliente.Rows.Clear();
            await cargarDGV();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo))
                this.Close();
        }
        private bool validar()
        {
            if(cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtNombre.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtApellido.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtDoc.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtTelefono.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtMail.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if(validar() == true)
            {
                Clientes cl = (Clientes)cboCliente.SelectedItem;
                c.idCliente = cl.idCliente;
                c.nombre = txtNombre.Text;
                c.apellido = txtApellido.Text;
                c.nroDoc = Convert.ToInt32(txtDoc.Text);
                c.nroTelefono = Convert.ToInt32(txtTelefono.Text);
                c.email = txtMail.Text;
                await modificarCliente(c);

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("No puede ingresar numeros");
            e.Handled = true;
            txtNombre.Text = String.Empty;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("No puede ingresar numeros");
            e.Handled = true;
            txtApellido.Text = String.Empty;
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar letras");
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar letras");
                e.Handled = true;
            }
        }
    }
}
