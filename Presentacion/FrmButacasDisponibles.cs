
using CIneLabo.Data;
using CIneLabo.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinesFront.Presentacion
{
    public partial class FrmButacasDisponibles : Form
    {
        DaoPeliculas daopel;
        DaoSalas daosal;
        DaoFuncion daofun;
        DaoButacas daobut;
        private Dictionary<int, PictureBox> diccionarioPictureBox = new Dictionary<int, PictureBox>();
        public FrmButacasDisponibles()
        {
            InitializeComponent();
            daopel = new DaoPeliculas();
            daosal = new DaoSalas();
            daofun = new DaoFuncion();
            daobut = new DaoButacas();
            EnlazarButacasConNumeritos();
            //  MostrarButacasDisponibles();
        }

        public void EnlazarButacasConNumeritos()
        {
            diccionarioPictureBox.Add(1, pbButaca1);// nRO BUTACA
            diccionarioPictureBox.Add(2, pbButaca2);
            diccionarioPictureBox.Add(3, pbButaca3);
            diccionarioPictureBox.Add(4, pbButaca4);
            diccionarioPictureBox.Add(5, pbButaca5);
            diccionarioPictureBox.Add(6, pbButaca6);
            diccionarioPictureBox.Add(7, pbButaca7);
            diccionarioPictureBox.Add(8, pbButaca8);
            diccionarioPictureBox.Add(9, pbButaca9);
            diccionarioPictureBox.Add(10, pbButaca10);
            diccionarioPictureBox.Add(11, pbButaca11);
            diccionarioPictureBox.Add(12, pbButaca12);
            diccionarioPictureBox.Add(13, pbButaca13);
            diccionarioPictureBox.Add(14, pbButaca14);
            diccionarioPictureBox.Add(15, pbButaca15);
            diccionarioPictureBox.Add(16, pbButaca16);
            diccionarioPictureBox.Add(17, pbButaca17);
            diccionarioPictureBox.Add(18, pbButaca18);

        }
        private void FrmButacasDisponiblies_Load(object sender, EventArgs e)
        {
            cboPelicula.DataSource = daopel.ObtenerPeliculas();
            cboPelicula.ValueMember = "IdPelicula";
            cboPelicula.DisplayMember = "Titulo";


            //    cboFunciones.DataSource = daofun.TraerFunciones();
            cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFunciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //  MostrarButacasDisponibles();
            //          CambiarColorFondoPictureBox(pbButaca1, 1,18);
            //        CambiarColorFondoPictureBox(pbButaca2, 1, 18);
            //      CambiarColorFondoPictureBox(pbButaca3, 1, 18);
            foreach (var kvp in diccionarioPictureBox)
            {
                int numero = kvp.Key;
                PictureBox pictureBox = kvp.Value;

                CambiarColorFondoPictureBox(numero, pictureBox);
            }


        }

        /*        private void CambiarColorFondoPictureBox(PictureBox pictureBox, int rangoInicio, int rangoFin)
                {
                    Random random = new Random();
                    int numeroAleatorio = random.Next(rangoInicio, rangoFin + 1);

                    foreach (var kvp in diccionarioPictureBox)
                    { //relacionar los picture box y que si el id del picture box figura con el de butacas pintarlo de equis color 
                        int numeroButaca = kvp.Key;
                        PictureBox pbButaca = kvp.Value;

                        //buscar butacas con el numero correspondiente en la lista
                        //                   Butacas but = butacas.FirstOrDefault(but => but.NroButaca == numeroButaca);
                        //                    Butacas but 
                        if (numeroButaca == numeroAleatorio)
                        {
                            pbButaca.BackColor = Color.Green;
                        }
                        else
                        {
                            pbButaca.BackColor = Color.Red; //no existe
                        }


                    }


                    // Puedes ajustar esta parte para que se adapte a tus necesidades


                }*/
        private void CambiarColorFondoPictureBox(int numero, PictureBox pictureBox)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 19);

            // Puedes ajustar el umbral según la probabilidad deseada
            if (numeroAleatorio <= 10)
            {
                // Cambia el color de fondo si el número aleatorio está dentro de un rango específico

                pictureBox.BackColor = Color.DarkGreen;
            }
            else
            {
                pictureBox.BackColor = Color.Maroon;
            }
            // De lo contrario, no cambia el color de fondo
        }

        private void buttonCambiarColores_Click(object sender, EventArgs e)
        {
            // Llama al método para cambiar el color de fondo de algunos PictureBox
            foreach (var kvp in diccionarioPictureBox)
            {
                int numero = kvp.Key;
                PictureBox pictureBox = kvp.Value;

                CambiarColorFondoPictureBox(numero, pictureBox);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboSala.Enabled = true;
            cboSala.DataSource = daosal.ObtenerSalas(cboPelicula.Text, dtpDesde.Value.ToShortDateString());
            cboSala.ValueMember = "IdSala";
            cboSala.DisplayMember = "IdSala";
        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboFunciones.Enabled = true;
            cboFunciones.DataSource = daofun.ObtenerFuncion(cboPelicula.Text, dtpDesde.Value.ToShortDateString(), int.Parse(cboSala.Text));
            cboFunciones.ValueMember = "IdFuncion";
            cboFunciones.DisplayMember = "Hora";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que desea volver al menú?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /*        public void MostrarButacasDisponibles()
      {
//          string peliculaSeleccionada = cboPelicula.DisplayMember;
//           string fechaSeleccionada = dtpDesde.Value.ToShortDateString();
//           int salaSeleccionada = cboSala.DisplayMember;
          // No puedo parsear
//           int funcionSeleccionada = int.Parse(cboFunciones.ValueMember);

//            if (cboPelicula.SelectedIndex != 0)
//          {
 //             List<Butacas> butacas = new List<Butacas>();
//               butacas = daobut.ObtenerButacas(cboPelicula.Text, dtpDesde.Value.ToShortDateString(), int.Parse(cboSala.Text), int.Parse(cboFunciones.Text));


              foreach (var kvp in diccionarioPictureBox)
              { //relacionar los picture box y que si el id del picture box figura con el de butacas pintarlo de equis color 
                  int numeroButaca = kvp.Key;
                  PictureBox pictureBox = kvp.Value;

                  //buscar butacas con el numero correspondiente en la lista
//                   Butacas but = butacas.FirstOrDefault(but => but.NroButaca == numeroButaca);
 //                    Butacas but 
                  if (but != null)
                  {
                      if (but.NroButaca != 0)
                      {
                          pictureBox.BackColor = Color.Green; //Butaca disponible

                      }
                      else
                      {
                          pictureBox.BackColor = Color.Red; //butaca no disponible
                      }
                  }
                  else
                  {
                      pictureBox.BackColor = Color.Transparent; //no existe
                  }


              }
/*           }
          else
          {
              MessageBox.Show("Debe seleccionar una pelicula");
              cboPelicula.Focus();
          }
      }*/
    }
}
