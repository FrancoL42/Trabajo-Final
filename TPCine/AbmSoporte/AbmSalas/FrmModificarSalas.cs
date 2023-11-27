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
using CinesBackend.Clases;

namespace TPCine.AbmSoporte.AbmSalas
{
    public partial class FrmModificarSalas : Form
    {
        Salas s;
        public FrmModificarSalas()
        {
            InitializeComponent();
        }

        private async void FrmBajaSalas_Load(object sender, EventArgs e)
        {
            await cargarGrilla();
            await cargarCombo();
            s = new Salas();
        }
        private bool validar()
        {
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cboNroSala.SelectedIndex == -1)
            {
                MessageBox.Show("Elija una sala para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private async Task cargarGrilla()
        {
            string url = string.Format("https://localhost:7229/TraerSalas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Salas> Salas = JsonConvert.DeserializeObject<List<Salas>>(data);
            foreach (Salas s in Salas)
            {
                Salas sala = new Salas();
                sala.idSala = s.idSala;
                sala.cantidadButacas = s.cantidadButacas;
                sala.estadoSala = s.estadoSala;
                dgvSalas.Rows.Add(new object[] { sala.idSala, sala.cantidadButacas, sala.estadoSala });
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Dispose();
        }
        private void limpiar()
        {
            cboNroSala.SelectedIndex = -1;
            nudCantidad.Value = 0;

        }
        private async Task cargarCombo()
        {
            string url = string.Format("https://localhost:7229/TraerSalas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Salas> Salas = JsonConvert.DeserializeObject<List<Salas>>(data);
            cboNroSala.DataSource = Salas;
            cboNroSala.ValueMember = "idSala";
            cboNroSala.DisplayMember = "idSala";
            cboNroSala.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private async Task modificarSala(Salas s)
        {
            string url = string.Format("https://localhost:7229/ModificarSala");
            string json = JsonConvert.SerializeObject(s);
            var data = await ClienteSingleton.GetInstance().PutAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSalas.Rows.Clear();
            await cargarGrilla();
            limpiar();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Salas sala = (Salas)cboNroSala.SelectedItem;
            if(validar()== true)
            {             
                s.cantidadButacas = Convert.ToInt32(nudCantidad.Value);
                s.idSala = sala.idSala;
                await modificarSala(s);
                limpiar();
            }
        }
    }
}
