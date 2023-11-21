using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCineBack.Acceso_a_Datos.Dao;
namespace CineApp.Forms
{
    public partial class frmIniciarSesion : Form
    {
        IDao dao;
        public frmIniciarSesion()
        {
            InitializeComponent();

            dao = new DaoCine();
        }

        private void btnIniciarSesionAceptar_Click(object sender, EventArgs e)
        {


        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesionCancelar_Click(object sender, EventArgs e)
        {

        }

        private void gbIniciarSesion_Enter(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void gbIniciarSesion_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesionAceptar_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contrasenia = textBox2.Text;
            if (dao.IniciarSesion(usuario, contrasenia, out int idEmpleado, out int idCargo))
            {
                if (idCargo == 1)
                {
                    frmAdministrador admin = new frmAdministrador();
                    admin.ShowDialog();
                    this.Close();
                }
                else if (idCargo == 2)
                {
                    frmComprarEntrada cajero = new frmComprarEntrada();
                    cajero.ShowDialog();
                    this.Close();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("CONTRASEÑA O USUARIO INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
