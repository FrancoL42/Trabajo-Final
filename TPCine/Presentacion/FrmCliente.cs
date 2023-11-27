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

namespace TPCine.Presentacion
{
    public partial class FrmCliente : Form
    {
        List<Peliculas> lstPeliculas;
        public FrmCliente()
        {
            InitializeComponent();
            lstPeliculas = new List<Peliculas>();
        }

        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            //listaPeliculas = fact.crearDao().PeliculasConDetalles();
            await cargarPeliculas();
            pbPelicula1.Click += pictureBox_Click;
            pbPelicula2.Click += pictureBox_Click;
            pbPelicula3.Click += pictureBox_Click;
            pbPelicula4.Click += pictureBox_Click;

            pbPeliculaElegida.Click += pictureBox_Click;
            EstablecerId();
        }
        private async Task cargarPeliculas()
        {
            string url = string.Format("https://localhost:7229/TraerPeliculasCliente");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            lstPeliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
        }
        private void EstablecerId()
        {
            for (int i = 0; i < 7; i++)
            {
                PictureBox pictureBox = Controls.Find($"pictureBox{i + 1}", true).FirstOrDefault() as PictureBox;
                if (pictureBox != null)
                {
                    pictureBox.Tag = i; // Asigna el índice como Tag
                }


            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {

            if (lstPeliculas != null && lstPeliculas.Count > 0)
            {
                PictureBox pictureBox = sender as PictureBox;
                int index = Convert.ToInt32(pictureBox.Tag);
                if (index >= 0 && index < lstPeliculas.Count)
                {
                    Peliculas p = lstPeliculas[index];

                    pbPeliculaElegida.Image = pictureBox.Image;

                    lblNombrePelicula.Text = p.nombrePelicula;
                    label.Text = p.genero.nombreGenero;
                    lblClasificacion.Text = p.clasificación.descripcion;
                    lblIdioma.Text = p.idioma.nombreIdioma;
                    lblFechaEstreno.Text = p.fecEstreno.ToString("dd/mm/yyyy");
                }
            }
        }
        private void btnComprarEntrada_Click(object sender, EventArgs e)
        {
            FrmIniciarSesion frm = new FrmIniciarSesion();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void pbPelicula1_Click(object sender, EventArgs e)
        {

        }

        private void pbPeliculaElegida_Click(object sender, EventArgs e)
        {

        }
    }
}
