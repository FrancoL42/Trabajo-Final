using CinesBackend.AccesoDatosFranco.Dao;
using CinesBackend.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCine.Http;
using TPCine.Reportes;

namespace TPCine.Abm
{
    public partial class FrmComprarEntrada : Form
    {
        IDaoFranco dao;
        Comprobante c;
        DetalleComprobante detalle;
        ButacasxSalas butacas;
        Funciones f;
        decimal nroSubTotal = 0;
        int cantidadButacas = 0;
        int idempleado;
       
        public FrmComprarEntrada(int idEmpleado)
        {
            InitializeComponent();
            idempleado = idEmpleado;
            
        }
        private void calculatTotal(double subTotal, int cantidadButacas)
        {
            if(cantidadButacas > 2)
            {
                lblNroTotal.Text = (subTotal - subTotal * 0.1).ToString();
                lblNroDescuento.Text = "%10";
                
            }
            else
            {
                lblNroDescuento.Text = "0";
            }
        }
        private void desHabilitarButacas()
        {
            pb1.Enabled = false;
            pb1.BackColor = Color.Black;
            pb2.Enabled = false;
            pb2.BackColor = Color.Black;
            pb3.Enabled = false;
            pb3.BackColor = Color.Black;
            pb4.Enabled = false;
            pb4.BackColor = Color.Black;
            pb5.Enabled = false;
            pb5.BackColor = Color.Black;
            pb6.Enabled = false;
            pb6.BackColor = Color.Black;
            pb7.Enabled = false;
            pb7.BackColor = Color.Black;
            pb8.Enabled = false;
            pb8.BackColor = Color.Black;
            pb9.Enabled = false;
            pb9.BackColor = Color.Black;
            pb10.Enabled = false;
            pb10.BackColor = Color.Black;
            pb11.Enabled = false;
            pb11.BackColor = Color.Black;
            pb12.Enabled = false;
            pb12.BackColor = Color.Black;
            pb13.Enabled = false;
            pb13.BackColor = Color.Black;
            pb14.Enabled = false;
            pb14.BackColor = Color.Black;
            pb15.Enabled = false;
            pb15.BackColor = Color.Black;
            pb16.Enabled = false;
            pb16.BackColor = Color.Black;
            pb17.Enabled = false;
            pb17.BackColor = Color.Black;
            pb18.Enabled = false;
            pb18.BackColor = Color.Black;
        }

        private async void FrmComprarEntrada_Load(object sender, EventArgs e)
        {
            await traerPeliculas();
            dao = new DaoFranco();
            c = new Comprobante();
            butacas = new ButacasxSalas();
            detalle = new DetalleComprobante();
            f = new Funciones();
            desHabilitarButacas();
        }
        private async Task traerPeliculas()
        {
            string url = string.Format("https://localhost:7229/TraerPeliculas");
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Peliculas> peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(data);
            CboPelicula.DataSource = peliculas;
            CboPelicula.ValueMember = "idPelicula";
            CboPelicula.DisplayMember = "nombrePelicula";
            CboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPelicula.SelectedItem = 1;
        }
        private async Task traerFunciones(string pelicula, string fecha)
        {
            List<Funciones> lstFunciones = dao.traerFunciones(pelicula, fecha);
            cboFuncion.DataSource = lstFunciones;
            cboFuncion.ValueMember = "idFuncion";
            cboFuncion.DisplayMember = "hora";
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            if(lstFunciones.Count == 0)
            {
                dtpFecha.Focus();
                MessageBox.Show("No hay funciones para esta fecha", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                btnTraerButacas.Enabled = true;
            }

        }
        private void traerButacas(int idSala)
        {
            List<ButacasxSalas> lstButacas = dao.traerButacasxSalas(idSala);
            foreach(ButacasxSalas butacas in lstButacas)
            {
                ButacasxSalas b = new ButacasxSalas();
                b.idButaca = butacas.idButaca;
                b.estadoButaca = butacas.estadoButaca;
                if(b.idButaca == 1 && b.estadoButaca == "Ocupada")
                {
                    pb1.BackColor = Color.Red;
                    pb1.Enabled = false;
                }
                if(b.idButaca == 2 && b.estadoButaca == "Ocupada")
                {
                    pb2.BackColor = Color.Red;
                    pb2.Enabled = false;
                }
                if (b.idButaca == 3 && b.estadoButaca == "Ocupada")
                {
                    pb3.BackColor = Color.Red;
                    pb3.Enabled = false;
                }
                if (b.idButaca == 4 && b.estadoButaca == "Ocupada")
                {
                    pb4.BackColor = Color.Red;
                    pb4.Enabled = false;
                }
                if (b.idButaca == 5 && b.estadoButaca == "Ocupada")
                {
                    pb5.BackColor = Color.Red;
                    pb5.Enabled = false;
                }
                if (b.idButaca == 6 && b.estadoButaca == "Ocupada")
                {
                    pb6.BackColor = Color.Red;
                    pb6.Enabled = false;
                }
                if (b.idButaca == 7 && b.estadoButaca == "Ocupada")
                {
                    pb7.BackColor = Color.Red;
                    pb7.Enabled = false;
                }
                if (b.idButaca == 8 && b.estadoButaca == "Ocupada")
                {
                    pb8.BackColor = Color.Red;
                    pb8.Enabled = false;
                }
                if (b.idButaca == 9 && b.estadoButaca == "Ocupada")
                {
                    pb9.BackColor = Color.Red;
                    pb9.Enabled = false;
                }
                if (b.idButaca == 10 && b.estadoButaca == "Ocupada")
                {
                    pb10.BackColor = Color.Red;
                    pb10.Enabled = false;
                }
                if (b.idButaca == 11 && b.estadoButaca == "Ocupada")
                {
                    pb11.BackColor = Color.Red;
                    pb11.Enabled = false;
                }
                if (b.idButaca == 12 && b.estadoButaca == "Ocupada")
                {
                    pb12.BackColor = Color.Red;
                    pb12.Enabled = false;
                }
                if (b.idButaca == 12 && b.estadoButaca == "Ocupada")
                {
                    pb12.BackColor = Color.Red;
                    pb12.Enabled = false;
                }
                if (b.idButaca == 13 && b.estadoButaca == "Ocupada")
                {
                    pb13.BackColor = Color.Red;
                    pb13.Enabled = false;
                }
                if (b.idButaca == 14 && b.estadoButaca == "Ocupada")
                {
                    pb14.BackColor = Color.Red;
                    pb14.Enabled = false;
                }
                if (b.idButaca == 15 && b.estadoButaca == "Ocupada")
                {
                    pb15.BackColor = Color.Red;
                    pb15.Enabled = false;
                }
                if (b.idButaca == 16 && b.estadoButaca == "Ocupada")
                {
                    pb16.BackColor = Color.Red;
                    pb16.Enabled = false;
                }
                if (b.idButaca == 17 && b.estadoButaca == "Ocupada")
                {
                    pb17.BackColor = Color.Red;
                    pb17.Enabled = false;
                }
                if (b.idButaca == 18 && b.estadoButaca == "Ocupada")
                {
                    pb18.BackColor = Color.Red;
                    pb18.Enabled = false;
                }
                if (b.idButaca == 1 && b.estadoButaca == "Disponible")
                {
                    pb1.BackColor = Color.Green;
                    pb1.Enabled = true;
                }
                if (b.idButaca == 2 && b.estadoButaca == "Disponible")
                {
                    pb2.BackColor = Color.Green;
                    pb2.Enabled = true;
                }
                if (b.idButaca == 3 && b.estadoButaca == "Disponible")
                {
                    pb3.BackColor = Color.Green;
                    pb3.Enabled = true;
                }
                if (b.idButaca == 4 && b.estadoButaca == "Disponible")
                {
                    pb4.BackColor = Color.Green;
                    pb4.Enabled = true;
                }
                if (b.idButaca == 5 && b.estadoButaca == "Disponible")
                {
                    pb5.BackColor = Color.Green;
                    pb5.Enabled = true;
                }
                if (b.idButaca == 6 && b.estadoButaca == "Disponible")
                {
                    pb6.BackColor = Color.Green;
                    pb6.Enabled = true;
                }
                if (b.idButaca == 7 && b.estadoButaca == "Disponible")
                {
                    pb7.BackColor = Color.Green;
                    pb7.Enabled = true;
                }
                if (b.idButaca == 8 && b.estadoButaca == "Disponible")
                {
                    pb8.BackColor = Color.Green;
                    pb8.Enabled = true;
                }
                if (b.idButaca == 9 && b.estadoButaca == "Disponible")
                {
                    pb9.BackColor = Color.Green;
                    pb9.Enabled = true;
                }
                if (b.idButaca == 10 && b.estadoButaca == "Disponible")
                {
                    pb10.BackColor = Color.Green;
                    pb10.Enabled = true;
                }
                if (b.idButaca == 11 && b.estadoButaca == "Disponible")
                {
                    pb11.BackColor = Color.Green;
                    pb11.Enabled = true;
                }
                if (b.idButaca == 12 && b.estadoButaca == "Disponible")
                {
                    pb12.BackColor = Color.Green;
                    pb12.Enabled = true;
                }
                if (b.idButaca == 12 && b.estadoButaca == "Disponible")
                {
                    pb12.BackColor = Color.Green;
                    pb12.Enabled = true;
                }
                if (b.idButaca == 13 && b.estadoButaca == "Disponible")
                {
                    pb13.BackColor = Color.Green;
                    pb13.Enabled = true;
                }
                if (b.idButaca == 14 && b.estadoButaca == "Disponible")
                {
                    pb14.BackColor = Color.Green;
                    pb14.Enabled = true;
                }
                if (b.idButaca == 15 && b.estadoButaca == "Disponible")
                {
                    pb15.BackColor = Color.Green;
                    pb15.Enabled = true;
                }
                if (b.idButaca == 16 && b.estadoButaca == "Disponible")
                {
                    pb16.BackColor = Color.Green;
                    pb16.Enabled = true;
                }
                if (b.idButaca == 17 && b.estadoButaca == "Disponible")
                {
                    pb17.BackColor = Color.Green;
                    pb17.Enabled = true;
                }
                if (b.idButaca == 18 && b.estadoButaca == "Disponible")
                {
                    pb18.BackColor = Color.Green;
                    pb18.Enabled = true;
                }


            }
        }
        private async void btnTraerFunciones_Click(object sender, EventArgs e)
        {
            if (CboPelicula.SelectedIndex == -1)
            {

                CboPelicula.Focus();
                MessageBox.Show("Seleccione una funcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            
            Peliculas p = (Peliculas)CboPelicula.SelectedItem;
            await traerFunciones(p.nombrePelicula, dtpFecha.Value.ToShortDateString());
            lblNroSubTotal.Text = "0.00";
            btnTraerButacas.Enabled = true;
        }

        private void btnTraerButacas_Click(object sender, EventArgs e)
        {
            if(cboFuncion.SelectedIndex == -1)
            {
                cboFuncion.Focus();
                MessageBox.Show("Seleccione una funcion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            f = (Funciones)cboFuncion.SelectedItem;
            traerButacas(f.sala.idSala);
           
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            ButacasxSalas b = new ButacasxSalas();
            if(pb6.BackColor == Color.White)
            {
                pb6.BackColor = Color.Green;
                b.idButaca = 6;
                butacas.estadoButaca = "Ocupada";
                b.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(b);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
                
            }
            else
            {
                pb6.BackColor = Color.White;
                b.idButaca = 6;
                b.estadoButaca = "Ocupada";
                b.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(b);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca1 = new ButacasxSalas();
            if(pb1.BackColor == Color.White)
            {
                pb1.BackColor = Color.Green;
                butaca1.idButaca = 1;
                butaca1.estadoButaca = "Ocupada";
                butaca1.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca1);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb1.BackColor = Color.White;
                butaca1.idButaca = 1;
                butaca1.estadoButaca = "Ocupada";
                butaca1.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca1);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);

            }
           
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca2 = new ButacasxSalas();
            if (pb2.BackColor == Color.White)
            {
                pb2.BackColor = Color.Green;
                butaca2.idButaca = 2;
                butaca2.estadoButaca = "Ocupada";
                butaca2.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca2);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb2.BackColor = Color.White;
                butaca2.idButaca = 2;
                butaca2.estadoButaca = "Ocupada";
                butaca2.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca2);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca3 = new ButacasxSalas();
            if(pb3.BackColor == Color.White)
            {
                pb3.BackColor = Color.Green;
                butaca3.idButaca = 3;
                butaca3.estadoButaca = "Ocupada";
                butaca3.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca3);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb3.BackColor = Color.White;
                butaca3.idButaca = 3;
                butaca3.estadoButaca = "Ocupada";
                butaca3.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca3);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }

        }

        private void pb4_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca4 = new ButacasxSalas();
            if (pb4.BackColor == Color.White)
            {
                pb4.BackColor = Color.Green;
                butaca4.idButaca = 4;
                butaca4.estadoButaca = "Ocupada";
                butaca4.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca4);
                cantidadButacas++;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb4.BackColor = Color.White;
                butaca4.idButaca = 4;
                butaca4.estadoButaca = "Ocupada";
                butaca4.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca4);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca5 = new ButacasxSalas();
            if (pb5.BackColor == Color.White)
            {
                pb5.BackColor = Color.Green;
                butaca5.idButaca = 5;
                butaca5.estadoButaca = "Ocupada";
                butaca5.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca5);
                cantidadButacas++;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb5.BackColor = Color.White;
                butaca5.idButaca = 5;
                butaca5.estadoButaca = "Ocupada";
                butaca5.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca5);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca7 = new ButacasxSalas();
            if (pb7.BackColor == Color.White)
            {
                pb7.BackColor = Color.Green;
                butaca7.idButaca = 7;
                butaca7.estadoButaca = "Ocupada";
                butaca7.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca7);
                cantidadButacas++;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb7.BackColor = Color.White;
                butaca7.idButaca = 7;
                butaca7.estadoButaca = "Ocupada";
                butaca7.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca7);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca8 = new ButacasxSalas();
            if (pb8.BackColor == Color.White)
            {
                pb8.BackColor = Color.Green;
                butaca8.idButaca = 8;
                butaca8.estadoButaca = "Ocupada";
                butaca8.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca8);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb8.BackColor = Color.White;
                butaca8.idButaca = 8;
                butaca8.estadoButaca = "Ocupada";
                butaca8.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca8);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca9 = new ButacasxSalas();
            if (pb9.BackColor == Color.White)
            {
                pb9.BackColor = Color.Green;
                butaca9.idButaca = 9;
                butaca9.estadoButaca = "Ocupada";
                butaca9.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca9);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb9.BackColor = Color.White;
                butaca9.idButaca = 9;
                butaca9.estadoButaca = "Ocupada";
                butaca9.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca9);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
          
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca10 = new ButacasxSalas();
            if (pb10.BackColor == Color.White)
            {
                pb10.BackColor = Color.Green;
                butaca10.idButaca = 10;
                butaca10.estadoButaca = "Ocupada";
                butaca10.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca10);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb10.BackColor = Color.White;
                butaca10.idButaca = 10;
                butaca10.estadoButaca = "Ocupada";
                butaca10.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca10);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca11 = new ButacasxSalas();
            if(pb11.BackColor == Color.White)
            {
                pb11.BackColor = Color.Green;
                butaca11.idButaca = 11;
                butaca11.estadoButaca = "Ocupada";
                butaca11.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca11);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb11.BackColor = Color.White;
                butaca11.idButaca = 11;
                butaca11.estadoButaca = "Ocupada";
                butaca11.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca11) ;
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
         
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca12 = new ButacasxSalas();
            if( pb12.BackColor == Color.White)
            {
                pb12.BackColor = Color.Green;
                butaca12.idButaca = 12;
                butaca12.estadoButaca = "Ocupada";
                butaca12.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca12);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb12.BackColor = Color.White;
                butaca12.idButaca = 12;
                //bu.estadoButaca = "Ocupada";
                butaca12.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca12);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca13 = new ButacasxSalas();
            if (pb13.BackColor == Color.White)
            {
                pb13.BackColor = Color.Green;
                butaca13.idButaca = 13;
                butaca13.estadoButaca = "Ocupada";
                butaca13.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca13);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb13.BackColor = Color.White;
                butaca13.idButaca = 13;
                butaca13.estadoButaca = "Ocupada";
                butaca13.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca13);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca14 = new ButacasxSalas();
            if (pb14.BackColor == Color.White)
            {
                pb14.BackColor = Color.Green;
                butaca14.idButaca = 14;
                butaca14.estadoButaca = "Ocupada";
                butaca14.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca14);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb14.BackColor = Color.White;
                butaca14.idButaca = 14;
                butaca14.estadoButaca = "Ocupada";
                butaca14.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca14);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca15 = new ButacasxSalas();
            if (pb15.BackColor == Color.White)
            {
                pb15.BackColor = Color.Green;
                butaca15.idButaca = 15;
                butaca15.estadoButaca = "Ocupada";
                butaca15.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca15);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb15.BackColor = Color.White;
                butaca15.idButaca = 15;
                butaca15.estadoButaca = "Ocupada";
                butaca15.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca15);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
           
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca16 = new ButacasxSalas();
            if (pb16.BackColor == Color.White)
            {
                pb16.BackColor = Color.Green;
                butaca16.idButaca = 16;
                butaca16.estadoButaca = "Ocupada";
                butaca16.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca16);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb16.BackColor = Color.White;
                butaca16.idButaca = 16;
                butaca16.estadoButaca = "Ocupada";
                butaca16.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca16);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
        }

        private void pb17_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca17 = new ButacasxSalas();
            if (pb17.BackColor == Color.White)
            {
                pb17.BackColor = Color.Green;
                butaca17.idButaca = 17;
                butaca17.estadoButaca = "Ocupada";
                butaca17.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca17);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb17.BackColor = Color.White;
                butaca17.idButaca = 17;
                butaca17.estadoButaca = "Ocupada";
                butaca17.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca17);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
        }

        private void pb18_Click(object sender, EventArgs e)
        {
            ButacasxSalas butaca18 = new ButacasxSalas();
            if (pb18.BackColor == Color.White)
            {
                pb18.BackColor = Color.Green;
                butaca18.idButaca = 18;
                butaca18.estadoButaca = "Ocupada";
                butaca18.sala.idSala = f.sala.idSala;
                detalle.quitarButaca(butaca18);
                cantidadButacas--;
                nroSubTotal = nroSubTotal - f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
            else
            {
                pb18.BackColor = Color.White;
                butaca18.idButaca = 18;
                butaca18.estadoButaca = "Ocupada";
                butaca18.sala.idSala = f.sala.idSala;
                detalle.lstButacasxSalas.Add(butaca18);
                cantidadButacas++;
                nroSubTotal = nroSubTotal + f.precioFuncion;
                lblNroSubTotal.Text = nroSubTotal.ToString();
                calculatTotal(Convert.ToDouble(nroSubTotal), cantidadButacas);
            }
        }
        private async Task grabar(Comprobante c)
        {
            //return dao.crearComprobante(c);
            string json = JsonConvert.SerializeObject(c);
            string url = "https://localhost:7229/AltaComprobante";
            var data = await ClienteSingleton.GetInstance().PostAsync(url, json);
            MessageBox.Show(data, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }
        private void limpiar()
        {
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            CboPelicula.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtCorreo.Text = String.Empty;
            txtDNI.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            cboFuncion.SelectedIndex = -1;
            lblNroSubTotal.Text = "0.00";
            lblNroDescuento.Text = "-0.00";
            lblNroTotal.Text = "0.00";
        }
        private bool validar()
        {
            if(txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtNombre.Text.Length > 15)
            {
                MessageBox.Show("Nombre demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtApellido.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtApellido.Text.Length > 15)
            {
                MessageBox.Show("apellido demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(CboPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Elija una pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("Elija una funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtDNI.Text.Length > 8)
            {
                MessageBox.Show("Dni no valido, por favor ingrese 8 numeros o menos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return false;
            }
            if(txtDNI.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtTelefono.Text.Length > 15)
            {
                MessageBox.Show("Ingrese un telefono valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtTelefono.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtCorreo.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cboFuncion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una funcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cantidadButacas == 0)
            {
                MessageBox.Show("Elija al menos una butaca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private async void btnComprar_Click(object sender, EventArgs e)
        {
            if(validar() == true)
            {
                Funciones f = (Funciones)cboFuncion.SelectedItem;

                //SP CLIENTE
                c.clientes.nombre = txtNombre.Text;
                c.clientes.apellido = txtApellido.Text;
                c.clientes.nroDoc = Convert.ToInt32(txtDNI.Text);
                c.clientes.nroTelefono = Convert.ToInt64(txtTelefono.Text);
                c.clientes.email = txtCorreo.Text;
                //SP COMPROBANTE
                c.empleado.idEmpleado = idempleado;
                c.fechaCompra = DateTime.Today;
                c.hora = f.hora;
                c.totalPagar = nroSubTotal;
                c.funcion.idFuncion = f.idFuncion;
                c.detalles.Add(detalle);
                await grabar(c);
                desHabilitarButacas();
                FrmReporteTicket frm = new FrmReporteTicket();
                frm.ShowDialog();
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Dispose();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar numeros");
                e.Handled = true;
                txtNombre.Text = String.Empty;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar numeros");
                e.Handled = true;
                txtApellido.Text = String.Empty;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar letras");
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("No puede ingresar letras");
                e.Handled = true;
            }
        }
    }
}
