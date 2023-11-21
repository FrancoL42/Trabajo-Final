using CineApp.Forms;
using Cines.Acceso_a_Datos.Factory;
using Cines.Clases.Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineApp
{
    public partial class frmCliente : Form
    {
        aFactoria fact;
        List<Peliculas> listaPeliculas;
        public frmCliente()
        {
            InitializeComponent();
            fact = new Factoria();

        }

        private void btnComprarEntradas_Click(object sender, EventArgs e)
        {
            frmComprarEntrada compra = new frmComprarEntrada();
            compra.ShowDialog();

        }

        private void btnNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

            listaPeliculas = fact.crearDao().PeliculasConDetalles();
            //listaPeliculas = await cargarPeliculas();
            pictureBox1.Click += pictureBox_Click;
            pictureBox11.Click += pictureBox_Click;
            pictureBox2.Click += pictureBox_Click;
            pictureBox3.Click += pictureBox_Click;
            pictureBox4.Click += pictureBox_Click;
            pictureBox5.Click += pictureBox_Click;
            pictureBox6.Click += pictureBox_Click;
            EstablecerId();
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

            if (listaPeliculas != null && listaPeliculas.Count > 0)
            {
                PictureBox pictureBox = sender as PictureBox;
                int index = Convert.ToInt32(pictureBox.Tag);
                if (index >= 0 && index < listaPeliculas.Count)
                {
                    Peliculas p = listaPeliculas[index];

                    pictureBox1.Image = pictureBox.Image;

                    lblNombrePelicula.Text = p.Titulo;
                    lblGenero.Text = p.Genero.genero;
                    lblClasificacion.Text = p.clasificacion.Descripcion;
                    lblIdioma.Text = p.Idioma.Lenguaje;
                    lblFecha.Text = p.Fec_Estreno.ToString("dd/mm/yyyy");
                }
            }
        }

        private void btnComprarEntradas_Click_1(object sender, EventArgs e)
        {
            frmComprarEntrada frm = new frmComprarEntrada();
            frm.ShowDialog();
        }

        private void btnNombreUsuario_Click_1(object sender, EventArgs e)
        {
            frmIniciarSesion iniciarSesion = new frmIniciarSesion();
            iniciarSesion.ShowDialog();
            if (btnSalir.Enabled == false)
            {
                btnSalir.Enabled = true;
                btnSalir.Visible = true;
            }
            else
            {
                btnSalir.Enabled = false;
                btnSalir.Visible = false;
            }


        }

        private void frmCliente_Load_1(object sender, EventArgs e)
        {
            listaPeliculas = fact.crearDao().PeliculasConDetalles();
            //listaPeliculas = await cargarPeliculas();
            pictureBox1.Click += pictureBox_Click;
            pictureBox11.Click += pictureBox_Click;
            pictureBox2.Click += pictureBox_Click;
            pictureBox3.Click += pictureBox_Click;
            pictureBox4.Click += pictureBox_Click;
            pictureBox5.Click += pictureBox_Click;
            pictureBox6.Click += pictureBox_Click;
            EstablecerId();
        }

        private void btnComprarEntradas_Click_2(object sender, EventArgs e)
        {
            frmIniciarSesion frm = new frmIniciarSesion();
            frm.ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo))
            this.Dispose();
        }
    }
}