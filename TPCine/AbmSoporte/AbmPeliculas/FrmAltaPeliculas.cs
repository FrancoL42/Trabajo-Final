using CinesBackend.AccesoDatosFranco.Dao;
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
    public partial class FrmAltaPeliculas : Form
    {
        ClienteSingleton cliente;
        IDaoFranco dao;
        Peliculas peliculas1;
        public FrmAltaPeliculas()
        {
            InitializeComponent();
        }

        private void txtNombrePelicula_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task cargarCombos()
        {
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
        private async void FrmAltaPeliculas_Load(object sender, EventArgs e)
        {
            await cargarDgvPeliculas();
            await cargarCombos();
            dao = new DaoFranco();
            peliculas1 = new Peliculas();
            limpiar();
            dtpDuracion.CustomFormat = "HH";
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
        private async Task insertarPelicula(Peliculas p)
        {
            string json = JsonConvert.SerializeObject(p);
            string url = "https://localhost:7229/insertarPelicula";
            var data = await ClienteSingleton.GetInstance().PostAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            await cargarDgvPeliculas();
        }
        private bool validar()
        {
            if(txtDirector.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtNombrePelicula.Text == String.Empty)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false ;
            }
            if(cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(dtpFechaEstreno.Value == DateTime.Today)
            {
                MessageBox.Show("ERROR CAMPOS FALTANTES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private void limpiar()
        {
            txtNombrePelicula.Text = string.Empty;
            txtDirector.Text = string.Empty;
            cboIdioma.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboClasificacion.SelectedIndex = -1;
            dtpFechaEstreno.Value = DateTime.Today;
        }
        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            Clasificacion c = (Clasificacion)cboClasificacion.SelectedItem;
            Idiomas i = (Idiomas)cboIdioma.SelectedItem;
            Generos g = (Generos)cboGenero.SelectedItem;
            if(validar()== true)
            {
                peliculas1.nombrePelicula = txtNombrePelicula.Text;
                peliculas1.clasificación.idClasificacion = c.idClasificacion;
                peliculas1.idioma.idIdioma = i.idIdioma;
                peliculas1.fecEstreno = dtpFechaEstreno.Value;
                peliculas1.genero.idGenero = g.idGenero;
                peliculas1.director = txtDirector.Text;
                int Hora = dtpDuracion.Value.Hour;
                int minutos = dtpDuracion.Value.Minute;
                int segundos = dtpDuracion.Value.Second;
                peliculas1.duracion = new TimeSpan(Hora, minutos, segundos);
                await insertarPelicula(peliculas1);
            }       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Dispose();

        }

        private void dtpDuracion_MouseDown(object sender, MouseEventArgs e)
        {
            dtpDuracion.CustomFormat = "HH:mm";
        }

        private void dtpDuracion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePelicula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar numeros");
                e.Handled = true;
            }
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
