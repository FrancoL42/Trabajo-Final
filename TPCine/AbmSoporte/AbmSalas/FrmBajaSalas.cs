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
    public partial class FrmBajaSala : Form
    {
        Salas s;
        public FrmBajaSala()
        {
            InitializeComponent();
        }

        private async void FrmBajaSalas_Load(object sender, EventArgs e)
        {
            await cargarCombo();
            await cargarGrilla();
            s = new Salas();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Dispose();
        }
        private async Task bajaSala(Salas s)
        {
            string url = string.Format("https://localhost:7229/BajaSala");
            string json = JsonConvert.SerializeObject(s);
            var data = await ClienteSingleton.GetInstance().PutAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSalas.Rows.Clear();
            await cargarGrilla();
            limpiar();
        }
        private void limpiar()
        {
            cboNroSala.SelectedIndex = -1;

        }
        private async void btnBaja_Click(object sender, EventArgs e)
        {
            if(cboNroSala.SelectedIndex != -1)
            {
                Salas sala = (Salas)cboNroSala.SelectedItem;
                s.idSala = sala.idSala;
                await bajaSala(s);
            }
        }
    }
}
