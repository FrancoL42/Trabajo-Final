using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCine.Reportes
{
    public partial class FrmReportePeliculas : Form
    {
        public FrmReportePeliculas()
        {
            InitializeComponent();
        }

        private void FrmReportePeliculas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
