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
    public partial class FrmInformeDeVentasPorMes : Form
    {
        IDaoInformeVentas dao;
        public FrmInformeDeVentasPorMes()
        {
            InitializeComponent();
            dao = new DaoInformeVentas();

        }

        private void FrmInformeDeVentasPorMes_Load(object sender, EventArgs e)
        {
            //cboCine.DataSource = dao.traerCines();
            //cboCine.ValueMember = "ID_CINE"; 
            //cboCine.DisplayMember = "NOMBRE_CINE"; 
            btnGenerarInforme.Enabled = false;
            btnLimpiar.Enabled = false;
            DateTime fechita = DateTime.Now.Date;
            if (dateTimePicker1.Value != fechita || dateTimePicker2.Value != fechita)
            {
                btnGenerarInforme.Enabled = true;

            }



        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            DateTime fechaIncio = dateTimePicker1.Value;
            DateTime fechaFin = dateTimePicker2.Value;
            //string NombreCine = cboCine.SelectedItem.ToString();
            DataTable datosInforme = dao.ObtenerDatosInformeVentasPorMes(fechaIncio, fechaFin/*,NombreCine*/);

            // Asignar al DataGridView
            if (datosInforme != null)
            {
                dataGridView1.DataSource = datosInforme;
            }
            btnLimpiar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            btnLimpiar.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
