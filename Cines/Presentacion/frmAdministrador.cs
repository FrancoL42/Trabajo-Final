using CinesFront.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineApp.Forms
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void iconoMenu_Click(object sender, EventArgs e)
        {
            if (pbFondoMenu.Width == 400)
            {
                pbFondoMenu.Width = 150;
                lblMenu.Enabled = false;
                lblMenu.Visible = false;
                lblNosotros.Enabled = false;
                lblNosotros.Visible = false;
                lblReporte.Enabled = false;
                lblReporte.Visible = false;
                lblSoporte.Enabled = false;
                lblSoporte.Visible = false;
                lblTransaccion.Enabled = false;
                lblTransaccion.Visible = false;
                btnSalir.Enabled = false;
                btnSalir.Visible = false;
            }
            else
            {
                pbFondoMenu.Width = 400;
                lblMenu.Enabled = true;
                lblMenu.Visible = true;
                lblNosotros.Enabled = true;
                lblNosotros.Visible = true;
                lblReporte.Enabled = true;
                lblReporte.Visible = true;
                lblSoporte.Enabled = true;
                lblSoporte.Visible = true;
                lblTransaccion.Enabled = true;
                lblTransaccion.Visible = true;
                btnSalir.Enabled = true;
                btnSalir.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea abandonar la aplicación?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblReporte_Click(object sender, EventArgs e)
        {
            if (btnClientes.Enabled == true)
            {
                btnClientes.Enabled = false;
                btnClientes.Visible = false;
                btnButacas.Enabled = false;
                btnButacas.Visible = false;
                btnVentas.Enabled = false;
                btnVentas.Visible = false;
                btnActualizarPrecio.Enabled = false;
                btnActualizarPrecio.Visible = false;
                btnButacasDisponibles.Enabled = false;
                btnButacasDisponibles.Visible = false;
                btnMejoresClientes.Enabled = false;
                btnMejoresClientes.Visible = false;
                btnVentasPorMes.Enabled = false;
                btnVentasPorMes.Visible = false;
                btnFormasPago.Enabled = false;
                btnFormasPago.Visible = false;
            }
            else
            {
                btnClientes.Enabled = true;
                btnClientes.Visible = true;
                btnButacas.Enabled = true;
                btnButacas.Visible = true;
                btnVentas.Enabled = true;
                btnVentas.Visible = true;
            }

        }

        private void iconoReporte_Click(object sender, EventArgs e)
        {
            if (btnClientes.Enabled == true)
            {
                btnClientes.Enabled = false;
                btnClientes.Visible = false;
                btnButacas.Enabled = false;
                btnButacas.Visible = false;
                btnVentas.Enabled = false;
                btnVentas.Visible = false;
            }
            else
            {
                btnClientes.Enabled = true;
                btnClientes.Visible = true;
                btnButacas.Enabled = true;
                btnButacas.Visible = true;
                btnVentas.Enabled = true;
                btnVentas.Visible = true;
            }

        }

        private void iconoSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea abandonar la aplicación?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //        FrmPodio podio = new FrmPodio();
            //        podio.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (btnMejoresClientes.Enabled == false)
            {
                btnMejoresClientes.Enabled = true;
                btnMejoresClientes.Visible = true;
            }
            else { btnMejoresClientes.Enabled = false; btnMejoresClientes.Visible = false; }
        }

        private void btnButacas_Click(object sender, EventArgs e)
        {
            if (btnButacasDisponibles.Enabled == false) { btnButacasDisponibles.Enabled = true; btnButacasDisponibles.Visible = true; }
            else { btnButacasDisponibles.Enabled = false; btnButacasDisponibles.Visible = false; }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (btnVentasPorMes.Enabled == false)
            {
                btnVentasPorMes.Enabled = true;
                btnVentasPorMes.Visible = true;
                btnFormasPago.Enabled = true;
                btnFormasPago.Visible = true;
                btnActualizarPrecio.Enabled = true;
                btnActualizarPrecio.Visible = true;
            }
            else
            {
                btnVentasPorMes.Enabled = false;
                btnVentasPorMes.Visible = false;
                btnFormasPago.Enabled = false;
                btnFormasPago.Visible = false;
                btnActualizarPrecio.Enabled = false;
                btnActualizarPrecio.Visible = false;
            }
        }

        private void btnButacasDisponibles_Click(object sender, EventArgs e)
        {
            //   FrmButacasDisponibles butDisponible = new FrmButacasDisponibles();
            //   butDisponible.ShowDialog();
        }

        private void btnVentasPorMes_Click(object sender, EventArgs e)
        {
          
        }

        private void btnFormasPago_Click(object sender, EventArgs e)
        {
            //    FrmInformeMejoresFormasDePago formaPago = new FrmInformeMejoresFormasDePago();
            //    formaPago.ShowDialog();
        }

        private void btnActualizarPrecio_Click(object sender, EventArgs e)
        {
            //    FrmActualizacionPrecio actPrecio = new FrmActualizacionPrecio();
            //    actPrecio.ShowDialog();
        }

        private void lblSoporte_Click(object sender, EventArgs e)
        {

        }

        private void lblNosotros_Click(object sender, EventArgs e)
        {
            frmNosotros nosotros = new frmNosotros();
            nosotros.ShowDialog();
        }

        private void iconoNosotros_Click(object sender, EventArgs e)
        {
            frmNosotros nosotros = new frmNosotros();
            nosotros.ShowDialog();
        }

        private void lblTransaccion_Click(object sender, EventArgs e)
        {
            frmComprarEntrada frm = new frmComprarEntrada();
            frm.ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblSoporte_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNosotros_Click_1(object sender, EventArgs e)
        {
            frmNosotros nosotros = new frmNosotros();
            nosotros.ShowDialog();
        }

        private void lblReporte_Click_1(object sender, EventArgs e)
        {
            FrmConsultarComprobante frm = new FrmConsultarComprobante();
            frm.ShowDialog();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
