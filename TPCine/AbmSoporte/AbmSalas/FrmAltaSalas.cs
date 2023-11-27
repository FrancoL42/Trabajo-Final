using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinesBackend.Clases;
using Newtonsoft.Json;
using TPCine.Http;

namespace TPCine.AbmSoporte.AbmSalas
{
    public partial class FrmAltaSalas : Form
    {
        Salas salas;
        ClienteSingleton c;
        public FrmAltaSalas()
        {
            InitializeComponent();
        }

        private async void FrmAltaSalas_Load(object sender, EventArgs e)
        {
            await cargarGrilla();
            salas = new Salas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(validar() == true)
            {

            }
            salas.cantidadButacas = (int)nudCantidad.Value;
            salas.estadoSala = "Disponible";
            dgvSalas.Rows.Add(new object[] { salas.idSala, salas.cantidadButacas, salas.estadoSala });
        }
        private bool validar()
        {
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }               
            return true;
        }
        private void limpiar()
        {
            nudCantidad.Value = 0;
        }
        private async Task altaSala(Salas s)
        {
            string url = string.Format("https://localhost:7229/AltaSala");
            string json = JsonConvert.SerializeObject(s);
            var data = await ClienteSingleton.GetInstance().PostAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSalas.Rows.Clear();
            await cargarGrilla();
            limpiar();
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

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                salas.cantidadButacas = (int)nudCantidad.Value;
                await altaSala(salas);
            }
          
        }
    }
}
