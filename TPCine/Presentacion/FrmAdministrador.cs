using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCine.Abm;
using TPCine.AbmSoporte.AbmFunciones;
using TPCine.AbmSoporte.AbmPeliculas;
using TPCine.AbmSoporte.AbmSalas;
using TPCine.Reportes;

namespace TPCine.Presentacion
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        private void lblConsultar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            this.Dispose();
        }

        private void lblComprar_Click(object sender, EventArgs e)
        {
            FrmComprarEntrada frm = new FrmComprarEntrada(1);
            frm.ShowDialog();
        }

        private void lblNosotros_Click(object sender, EventArgs e)
        {
            FrmNosotros frm = new FrmNosotros();
            frm.ShowDialog();
        }

        private void lblReporte_Click(object sender, EventArgs e)
        {
            //FrmReportePeliculasVendidas frm = new FrmReportePeliculasVendidas();
            //frm.ShowDialog();
            FrmReporteTicket from = new FrmReporteTicket();
            from.ShowDialog();
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void lblSoporte_Click(object sender, EventArgs e)
        {
            lblPeliculas.Visible = true;
            lblFunciones.Visible = true;
            lblSalas.Visible = true;
            lblClientes.Visible = true;
        }

        private void lblPeliculas_Click(object sender, EventArgs e)
        {
           lblAltaFunciones.Visible = false;
            //lblBAJAFunciones.Visible = false;
            //lblModificarFunciones.Visible = false;         
            lblAltaSalas.Visible = false;
            lblBajaCliente.Visible = false;
            lblModificarCliente.Visible = false;
            lblModificarSalas.Visible = false;
            lblBajaSalas.Visible=false;
            lblAltaPeliculas.Visible = true;
            lblBajaPeliculas.Visible = true;
            lblModificarPeliculas.Visible=true;
        }

        private void lblFunciones_Click(object sender, EventArgs e)
        {
            lblAltaFunciones.Visible = true;
            //lblBAJAFunciones.Visible = true;
            //lblModificarFunciones.Visible = true;
            lblAltaSalas.Visible = false;
            lblBajaCliente.Visible = false;
            lblModificarCliente.Visible = false;
            lblModificarSalas.Visible = false;
            lblBajaSalas.Visible = false;
            lblAltaPeliculas.Visible = false;
            lblBajaPeliculas.Visible = false;
            lblModificarPeliculas.Visible = false;
        }

        private void lblSalas_Click(object sender, EventArgs e)
        {
            lblAltaFunciones.Visible = false;
            //lblBAJAFunciones.Visible = false;
            //lblModificarFunciones.Visible = false;
            lblAltaSalas.Visible = true;
            lblBajaCliente.Visible = false;
            lblModificarCliente.Visible = false;
            lblModificarSalas.Visible = true;
            lblBajaSalas.Visible = true;
            lblAltaPeliculas.Visible = false;
            lblBajaPeliculas.Visible = false;
            lblModificarPeliculas.Visible = false;
        }

        private void lblAltaPeliculas_Click(object sender, EventArgs e)
        {
            FrmAltaPeliculas frm = new FrmAltaPeliculas();
            frm.ShowDialog();
        }

        private void lblBajaPeliculas_Click(object sender, EventArgs e)
        {
            FrmBajaPelicula frm = new FrmBajaPelicula();
            frm.ShowDialog();
        }

        private void lblModificarPeliculas_Click(object sender, EventArgs e)
        {
            FrmModificarPelicula frm = new FrmModificarPelicula();
            frm.ShowDialog();
        }

        private void lblAltaFunciones_Click(object sender, EventArgs e)
        {
            FrmAltaFunciones frm =new FrmAltaFunciones();
            frm.ShowDialog();
        }

        private void lblBAJAFunciones_Click(object sender, EventArgs e)
        {
            FrmBajaFunciones frm = new FrmBajaFunciones();
            frm.ShowDialog();
        }

        private void lblModificarFunciones_Click(object sender, EventArgs e)
        {
            FrmModificarFunciones frm = new FrmModificarFunciones();
            frm.ShowDialog();
        }

        private void lblAltaSalas_Click(object sender, EventArgs e)
        {
            FrmAltaSalas frm = new FrmAltaSalas();
            frm.ShowDialog();
        }

        private void lblBajaSalas_Click(object sender, EventArgs e)
        {
            FrmBajaSala frm = new FrmBajaSala();
            frm.ShowDialog();
        }

        private void lblModificarSalas_Click(object sender, EventArgs e)
        {
            FrmModificarSalas frm = new FrmModificarSalas();
            frm.ShowDialog();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            lblBajaCliente.Visible = true;
            lblModificarCliente.Visible = true;
            lblAltaPeliculas.Visible = false;
            lblBajaPeliculas.Visible = false;
            lblModificarPeliculas.Visible = false;
            lblModificarSalas.Visible = false;
            lblBajaSalas.Visible = false;
            lblAltaFunciones.Visible = false;
            //lblBAJAFunciones.Visible = false;
            //lblModificarFunciones.Visible = false;         
            lblAltaSalas.Visible = false;
        }

        private void lblBajaCliente_Click(object sender, EventArgs e)
        {
            FrmBajaCliente frm = new FrmBajaCliente();
            frm.ShowDialog();
        }

        private void lblModificarCliente_Click(object sender, EventArgs e)
        {
            FrmModificarCliente frm = new FrmModificarCliente();
            frm.ShowDialog();
        }
    }
}
