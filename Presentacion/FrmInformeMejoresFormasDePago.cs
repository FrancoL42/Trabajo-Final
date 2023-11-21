using CIneLabo.Data.DBHelper.Ventas;
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
    public partial class FrmInformeMejoresFormasDePago : Form
    {
        IDaoInformeVentas dao;
        public FrmInformeMejoresFormasDePago()
        {
            InitializeComponent();
            dao = new DaoInformeVentas();
        }

        private void FrmInformeMejoresFormasDePago_Load(object sender, EventArgs e)
        {
            btnGenerarInforme.Enabled = false;
            btnLimpiar.Enabled = false;
            DateTime fechita = DateTime.Now.Date;
            if (dtpDesde.Value != fechita || dtpHasta.Value != fechita)
            {
                btnGenerarInforme.Enabled = true;

            }
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpDesde.Value;
            DateTime fechaFin = dtpHasta.Value;

            DataTable dt = dao.ObtenerMejoresFormasDePago(fechaInicio, fechaFin);
            if (dt != null)
            {
                dgvFormasDePago.DataSource = dt;
            }
            btnLimpiar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvFormasDePago.DataSource = null;
            btnLimpiar.Enabled = false;
        }
    }
}
