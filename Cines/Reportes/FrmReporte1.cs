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
    public partial class FrmReporte1 : Form
    {
        public FrmReporte1()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FrmReporte1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Cines.Reportes.Report1.rdlc";
            reportViewer1.Refresh();
        }
    }
}
