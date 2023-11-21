using CIneLabo.Data;
using CIneLabo.Data.DBHelper;
using CIneLabo.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIneLabo.Presentacion
{
    public partial class FrmActualizacionPrecio : Form
    {
        public FrmActualizacionPrecio()
        {
            InitializeComponent();
        }

        private void FrmActualizacionPrecio_Load(object sender, EventArgs e)
        {
            cargarvalordolar();
            llenarDGV();
        }
        private void llenarDGV()
        {
            string sp = "ObtenerPeliculasConPrecios";

            DataTable table = DbHelper.GetInstancia().Consultar(sp);
            dgvPeliPrecio.Rows.Clear();
            foreach (DataRow fila in table.Rows)
            {
<<<<<<< HEAD
                dgvPeliPrecio.Rows.Add(new object[] { fila["NombrePelicula"],
                                                   fila["Precio"].ToString()});
            }

=======
                dgvPeliPrecio.Rows.Add(new object[] { fila["NombrePelicula"],                                                   
                                                   fila["Precio"].ToString()});
            }
            
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
        }
        private void cargarvalordolar()
        {

            string sp = "ObtenerUltimoValorDolar";
            string resultado = DbHelper.GetInstancia().ConsultarValorSP(sp);
            txtDolarAntes.Text = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //@PorcentajeCambio = ((@ValorDolarActual - @ValorDolarAntes) / @ValorDolarAntes) * 100;

            double dolarAntes = double.Parse(txtDolarAntes.Text);
            double valorDolarActual = double.Parse(txtValorDolarActual.Text);

            // Realizar la resta y asignar el resultado a txtPorcentaje.Text
            txtPorcentaje.Text = (((valorDolarActual - dolarAntes) / dolarAntes) * 100).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sp = "AjustarPreciosPorDolar";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@ValorDolarAntes", double.Parse(txtDolarAntes.Text)));
            lst.Add(new Parametro("@ValorDolarActual", double.Parse(txtValorDolarActual.Text)));
            DataTable table = DbHelper.GetInstancia().Consultar(sp, lst);
            dgvPeliPrecio.DataSource = null;
            llenarDGV();
<<<<<<< HEAD
        }

        private void lblValDolAnt_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
=======
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e

        }



    }
}

