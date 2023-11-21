using CIneLabo.Data;
using CIneLabo.Data.Clientes;
using CIneLabo.Entidades.Cine;
using CIneLabo.Entidades.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIneLabo.Data.DBHelper;


namespace CIneLabo.Presentacion
{
    public partial class FrmPodio : Form
    {
        DaoPeliculas daopel;
        DaoGeneros daogen;
        ClientesDao daocli;

        public FrmPodio()
        {
            InitializeComponent();
            daopel = new DaoPeliculas();
            daogen = new DaoGeneros();
            daocli = new ClientesDao();

        }
        private void FrmPodio_Load(object sender, EventArgs e)
        {
            //CargarPeliculas();
            CargarGeneros();

        }



        private void Mostrartop3Clientes(Genero generoSeleccionado)
        {
            generoSeleccionado = (Genero)cboGenero.SelectedItem;
            string sp = "SP_CONSULTAR_TOP3_CLIENTES_POR_GENERO_PUNTAJE";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@GeneroPelicula", generoSeleccionado.genero));
            DataTable table = DbHelper.GetInstancia().Consultar(sp, lst);

            if (table.Rows.Count >= 3)
            {
                // Mostrar el primer cliente en el TextBox1
                MostrarClienteEnTextBox(table.Rows[0], txtPrimero);

                // Mostrar el segundo cliente en el TextBox2
                MostrarClienteEnTextBox(table.Rows[1], txtSegundo);

                // Mostrar el tercer cliente en el TextBox3
                MostrarClienteEnTextBox(table.Rows[2], txtTercero);
            }
            else
            {
                MessageBox.Show("No se encontraron suficientes clientes para el género seleccionado.");
                txtPrimero.Text = string.Empty;
                txtSegundo.Text = string.Empty;
                txtTercero.Text = string.Empty;
            }
        }
        private void MostrarClienteEnTextBox(DataRow cliente, TextBox textBox)
        {
            textBox.Text = $"{cliente["NOMBRE_CLIENTE"]} {cliente["APELLIDO_CLIENTE"]} \n Total Gastado: {cliente["TotalGastado"]}";
        }


        private void CargarGeneros()
        {
            cboGenero.DataSource = daogen.ObtenerGeneros();
            cboGenero.ValueMember = "IdGenero";
            cboGenero.DisplayMember = "genero";
        }

        private void CargarPeliculas()
        {
            cboGenero.DataSource = daopel.ObtenerPeliculas();
            cboGenero.ValueMember = "IdPelicula";
            cboGenero.DisplayMember = "Titulo";
        }

        private void dgvPodio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Genero generoSeleccionado = (Genero)cboGenero.SelectedItem;


            string sp = "SP_CONSULTAR_CLIENTES_POR_GENERO_PUNTAJE";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@GeneroPelicula", generoSeleccionado.genero));
            DataTable table = DbHelper.GetInstancia().Consultar(sp, lst);
            dgvPodio.Rows.Clear();
            foreach (DataRow fila in table.Rows)
            {
                dgvPodio.Rows.Add(new object[] { fila["ID_CLIENTE"].ToString(),
                                                   fila["NOMBRE_APELLIDO"],
                                                   fila["TotalGastado"].ToString()});
            }
            Mostrartop3Clientes(generoSeleccionado);
        }

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea volver al menú principal?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }
=======

>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
    }
}
