using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinesFront.Reportes
{
    public partial class frmReporteTicket : Form
    {
        public frmReporteTicket()
        {
            InitializeComponent();
        }

        private void frmReporteTicket_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Cines.Reportes.Report2.rdlc";
            reportViewer1.Refresh();
        }
    }
}
