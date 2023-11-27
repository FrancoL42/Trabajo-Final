using CinesBackend.AccesoDatosFranco.Dao;
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
using TPCine.Presentacion;

namespace TPCine
{
    public partial class FrmIniciarSesion : Form
    {
        IDaoFranco dao;
        public FrmIniciarSesion()
        {
            InitializeComponent();
            dao = new DaoFranco();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string contrasenia = txtContraseñaUsuarios.Text;
            if (dao.IniciarSesion(usuario, contrasenia, out int idEmpleado, out int idCargo))
            {
                if (idCargo == 1)
                {
                    FrmAdministrador admin = new FrmAdministrador();
                    admin.ShowDialog();
                    this.Close();
                }
                else if (idCargo == 2)
                {
                    FrmComprarEntrada cajero = new FrmComprarEntrada(6);
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
