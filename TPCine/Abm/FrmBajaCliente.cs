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
    public partial class FrmBajaCliente : Form
    {
        public FrmBajaCliente()
        {
            InitializeComponent();
        }
        private async Task bajaCliente(Clientes c)
        {
            string url = "https://localhost:7229/bajaCliente";
            string json = JsonConvert.SerializeObject(c);
            var data = await ClienteSingleton.GetInstance().PutAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCliente.Rows.Clear();
            await cargarDGV();
        }
        private async void btnBaja_Click(object sender, EventArgs e)
        {
            if(cboCliente.SelectedIndex != -1)
            {
                Clientes c = (Clientes)cboCliente.SelectedItem;
                await bajaCliente(c);
            }
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
        private async void FrmBajaCliente_Load(object sender, EventArgs e)
        {
            await cargarCombo();
            await cargarDGV();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo))
                this.Close();
        }
    }
}
