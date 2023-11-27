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

namespace TPCine.AbmSoporte.AbmFunciones
{
    public partial class FrmAltaFunciones : Form
    {
        Funciones f;
        public FrmAltaFunciones()
        {
            InitializeComponent();
        }

        private async void FrmAltaFunciones_Load(object sender, EventArgs e)
        {
            limpiar();
            await cargarDGV();
            await cargarCombos();
            f = new Funciones();
        }
        private async Task cargarDGV()
        {
            string url = string.Format("https://localhost:7229/TraerFunciones");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Funciones> lstFuncioens = JsonConvert.DeserializeObject<List<Funciones>>(data);
            foreach (Funciones f in lstFuncioens)
            {
                dgvFunciones.Rows.Add(f.idFuncion, f.pelicula.nombrePelicula, f.hora, f.fecha, f.precioFuncion, f.sala.idSala);
            }
            //foreach (Funciones f in lstFuncioens)
            //{
            //    dgvFunciones.Rows.Add(f.idFuncion, f.pelicula.nombrePelicula, f.hora, f.fecha, f.precioFuncion, f.sala.idSala);
            //}
        }
        private async Task cargarCombos()
        {
            string url = string.Format("https://localhost:7229/TraerPeliculas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            cboPelicula.DataSource = peliculas;
            cboPelicula.ValueMember = "idPelicula";
            cboPelicula.DisplayMember = "nombrePelicula";
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.SelectedItem = 1;
            string urlSala = string.Format("https://localhost:7229/TraerSalas");
            var dataSala = await ClienteSingleton.GetInstance().GetAsync(urlSala);
            List<Salas> lstSalas = JsonConvert.DeserializeObject<List<Salas>>(dataSala);
            cboSala.DataSource = lstSalas;
            cboSala.ValueMember = "idSala";
            cboSala.DisplayMember = "idSala";
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.SelectedItem = 1;
        }
        private async Task altaFuncion(Funciones f)
        {
            string url = string.Format("https://localhost:7229/AltaFunciones");
            string json = JsonConvert.SerializeObject(f);
            var data = await ClienteSingleton.GetInstance().PostAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            dgvFunciones.Rows.Clear();
            await cargarDGV();
        }
        private void limpiar()
        {
            dtpHora.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            cboPelicula.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
        }
        private bool validar()
        {
            if(dtpHora.Value <= DateTime.MinValue)
            {
                MessageBox.Show("Ingrese una hora valida", "Error", MessageBoxButtons.OK);
                return false;
            }
            if(dateTimePicker1.Value == DateTime.Today)
            {
                MessageBox.Show("Ingrese una fecha valida", "Error", MessageBoxButtons.OK );
                return false;
            }
            if(cboPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una pelicula", "Error",MessageBoxButtons.OK);
                return false;
            }
            if(cboSala.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una sala", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
           
        }
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Peliculas p = (Peliculas)cboPelicula.SelectedItem;
            Salas s = (Salas)cboSala.SelectedItem;
            if (validar())
            {
                f.fecha = dateTimePicker1.Value.Date;
                int hora = dtpHora.Value.Hour;
                if (hora > 24)
                    return;
                int minutos = dtpHora.Value.Minute;
                int sec = dtpHora.Value.Second;
                f.hora = new TimeSpan(hora, minutos, sec);
                f.sala.idSala = s.idSala;
                f.pelicula.idPelicula = p.idPelicula;
                f.precioFuncion = 12;
                foreach(DataGridViewRow row in dgvFunciones.Rows)
                {
                    if(row.Cells["colHora"].Value.ToString().Equals(f.hora) && row.Cells["colPelicula"].Value.ToString().Equals(f.pelicula.nombrePelicula))
                    {
                        MessageBox.Show("Ya existe una funcion a esa hora", "Error", MessageBoxButtons.OK);
                        return;
                    }
                        
                }
                await altaFuncion(f);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo))
                this.Close();
        }
    }
}
