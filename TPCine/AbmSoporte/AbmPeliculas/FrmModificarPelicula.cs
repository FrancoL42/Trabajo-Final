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

namespace TPCine.AbmSoporte.AbmPeliculas
{
    public partial class FrmModificarPelicula : Form
    {
        Peliculas p;
        public FrmModificarPelicula()
        {
            InitializeComponent();
        }

        private async void FrmBajaPelicula_Load(object sender, EventArgs e)
        {
            p = new Peliculas();
            await cargarDgvPeliculas();
            await cargarCombos();
        }
        private async Task cargarDgvPeliculas()
        {
            string url = string.Format("https://localhost:7229/TraerPeliculas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            foreach (Peliculas p in peliculas)
            {
                Peliculas pelicula = new Peliculas();
                pelicula.idPelicula = p.idPelicula;
                pelicula.nombrePelicula = p.nombrePelicula;
                pelicula.duracion = p.duracion;
                pelicula.fecEstreno = p.fecEstreno;
                dgvPeliculas.Rows.Add(new object[] { pelicula.idPelicula, pelicula.nombrePelicula, pelicula.duracion, pelicula.fecEstreno });
            }
        }
        private async Task cargarCombos()
        {
            string url = string.Format("https://localhost:7229/TraerPeliculas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            CboPeliculas.DataSource = peliculas;
            CboPeliculas.ValueMember = "idPelicula";
            CboPeliculas.DisplayMember = "nombrePelicula";
            CboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPeliculas.SelectedItem = 1;
            string urlClasificaciones = string.Format("https://localhost:7229/TraerClasificaciones");
            var dataClasificacion = await ClienteSingleton.GetInstance().GetAsync(urlClasificaciones);
            List<Clasificacion> lstClasificacion = JsonConvert.DeserializeObject<List<Clasificacion>>(dataClasificacion);
            cboClasificacion.DataSource = lstClasificacion;
            cboClasificacion.ValueMember = "idClasificacion";
            cboClasificacion.DisplayMember = "descripcion";
            cboClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            string urlGeneros = string.Format("https://localhost:7229/TraerGeneros");
            var dataGeneros = await ClienteSingleton.GetInstance().GetAsync(urlGeneros);
            List<Generos> lstGeneros = JsonConvert.DeserializeObject<List<Generos>>(dataGeneros);
            cboGenero.DataSource = lstGeneros;
            cboGenero.ValueMember = "idGenero";
            cboGenero.DisplayMember = "nombreGenero";
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            string urlIdioma = string.Format("https://localhost:7229/TraerIdiomas");
            var dataIdioma = await ClienteSingleton.GetInstance().GetAsync(urlIdioma);
            List<Idiomas> lstIdiomas = JsonConvert.DeserializeObject<List<Idiomas>>(dataIdioma);
            cboIdioma.DataSource = lstIdiomas;
            cboIdioma.ValueMember = "idIdioma";
            cboIdioma.DisplayMember = "nombreIdioma";
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task modificarPelicula(Peliculas p)
        {
            string Json = JsonConvert.SerializeObject(p);
            string url = "https://localhost:7229/ModificarPelicula";
            var data = await ClienteSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPeliculas.Rows.Clear();
            await cargarDgvPeliculas();
        }
        private bool validar()
        {
            if (txtDirector.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CboPeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpFechaEstreno.Value == DateTime.Today)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void limpiar()
        {
            CboPeliculas.SelectedIndex = -1;
            txtDirector.Text = String.Empty;
            cboClasificacion.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            dtpFechaEstreno.Value = DateTime.Today;
            dtpDuracion.Value = DateTime.MinValue;
        }
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            Generos g = (Generos)cboGenero.SelectedItem;
            Clasificacion c = (Clasificacion)cboClasificacion.SelectedItem;
            Idiomas i = (Idiomas)cboIdioma.SelectedItem;
            Peliculas p = (Peliculas)CboPeliculas.SelectedItem;
            if (validar())
            {
                int hora = dtpDuracion.Value.Hour;
                int minutos = dtpDuracion.Value.Minute;
                int segundos = dtpDuracion.Value.Second;
                p.duracion = new TimeSpan(hora, minutos, segundos);
                p.genero.idGenero = g.idGenero;
                p.clasificación.idClasificacion = c.idClasificacion;
                p.idioma.idIdioma = i.idIdioma;
                p.director = txtDirector.Text;
                p.fecEstreno = dtpFechaEstreno.Value;
                p.idPelicula = p.idPelicula;
                await modificarPelicula(p);
            }         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Dispose();
        }

        private void txtDirector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar numeros");
                e.Handled = true;
            }
        }
    }
}
