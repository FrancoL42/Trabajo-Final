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
    public partial class FrmBajaPelicula : Form
    {
        public FrmBajaPelicula()
        {
            InitializeComponent();
        }

        private async void FrmBajaPelicula_Load(object sender, EventArgs e)
        {
            await cargarCombo();
            await cargarDgv();
        }
        private async Task cargarDgv()
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
        private async Task cargarCombo()
        {
            string url = string.Format("https://localhost:7229/TraerPeliculas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            cboPeliculas.DataSource = peliculas;
            cboPeliculas.ValueMember = "idPelicula";
            cboPeliculas.DisplayMember = "nombrePelicula";
            cboPeliculas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeliculas.SelectedItem = 1;
        }
        private async Task bajaPelicula(Peliculas p)
        {
            string Json = JsonConvert.SerializeObject(p);
            string url = "https://localhost:7229/BajaPelicula";
            var data = await ClienteSingleton.GetInstance().PutAsync(url, Json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPeliculas.Rows.Clear();
            await cargarDgv();
        }
        private async void btnBaja_Click(object sender, EventArgs e)
        {
            Peliculas p = (Peliculas)cboPeliculas.SelectedItem;
            await bajaPelicula(p);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Dispose();
        }
    }
}
