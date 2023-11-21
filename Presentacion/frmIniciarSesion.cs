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
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionAceptar_Click(object sender, EventArgs e)
        {
            frmAdministrador admin = new frmAdministrador();
            admin.ShowDialog();
            this.Close();
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesionCancelar_Click(object sender, EventArgs e)
        {

        }

        private void gbIniciarSesion_Enter(object sender, EventArgs e)
        {

        }
    }
}
