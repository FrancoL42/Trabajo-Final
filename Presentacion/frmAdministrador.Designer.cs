namespace CineApp.Forms
{
    partial class frmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            pbFondoMenu = new PictureBox();
            iconoMenu = new PictureBox();
            lblMenu = new Label();
            iconoSoporte = new PictureBox();
            iconoTransaccion = new PictureBox();
            iconoReporte = new PictureBox();
            iconoNosotros = new PictureBox();
            lblSoporte = new Label();
            lblTransaccion = new Label();
            lblReporte = new Label();
            lblNosotros = new Label();
            btnSalir = new Button();
            iconoSalir = new PictureBox();
            btnVentas = new Button();
            btnButacas = new Button();
            btnClientes = new Button();
            btnMejoresClientes = new Button();
            btnButacasDisponibles = new Button();
            btnVentasPorMes = new Button();
            btnFormasPago = new Button();
            btnActualizarPrecio = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFondoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoSoporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoTransaccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoNosotros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoSalir).BeginInit();
            SuspendLayout();
            // 
            // pbFondoMenu
            // 
            pbFondoMenu.BackColor = Color.IndianRed;
            pbFondoMenu.Location = new Point(-1, 0);
            pbFondoMenu.Name = "pbFondoMenu";
            pbFondoMenu.Size = new Size(400, 1060);
            pbFondoMenu.TabIndex = 0;
            pbFondoMenu.TabStop = false;
            // 
            // iconoMenu
            // 
            iconoMenu.BackColor = Color.IndianRed;
            iconoMenu.BackgroundImage = (Image)resources.GetObject("iconoMenu.BackgroundImage");
            iconoMenu.BackgroundImageLayout = ImageLayout.Center;
            iconoMenu.Image = CinesFront.Properties.Resources.boton_menu;
            iconoMenu.Location = new Point(36, 74);
            iconoMenu.Name = "iconoMenu";
            iconoMenu.Size = new Size(57, 54);
            iconoMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoMenu.TabIndex = 1;
            iconoMenu.TabStop = false;
            iconoMenu.Click += iconoMenu_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.IndianRed;
            lblMenu.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.Black;
            lblMenu.Location = new Point(180, 85);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(100, 32);
            lblMenu.TabIndex = 73;
            lblMenu.Text = "MENU";
            // 
            // iconoSoporte
            // 
            iconoSoporte.BackColor = Color.IndianRed;
            iconoSoporte.BackgroundImageLayout = ImageLayout.Center;
            iconoSoporte.Image = CinesFront.Properties.Resources.boton_soporte;
            iconoSoporte.Location = new Point(36, 248);
            iconoSoporte.Name = "iconoSoporte";
            iconoSoporte.Size = new Size(57, 54);
            iconoSoporte.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoSoporte.TabIndex = 74;
            iconoSoporte.TabStop = false;
            // 
            // iconoTransaccion
            // 
            iconoTransaccion.BackColor = Color.IndianRed;
            iconoTransaccion.BackgroundImageLayout = ImageLayout.Center;
            iconoTransaccion.Image = CinesFront.Properties.Resources.boton_transaccion;
            iconoTransaccion.Location = new Point(36, 405);
            iconoTransaccion.Name = "iconoTransaccion";
            iconoTransaccion.Size = new Size(57, 54);
            iconoTransaccion.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoTransaccion.TabIndex = 75;
            iconoTransaccion.TabStop = false;
            // 
            // iconoReporte
            // 
            iconoReporte.BackColor = Color.IndianRed;
            iconoReporte.BackgroundImageLayout = ImageLayout.Center;
            iconoReporte.Image = CinesFront.Properties.Resources.boton_reporte;
            iconoReporte.Location = new Point(36, 582);
            iconoReporte.Name = "iconoReporte";
            iconoReporte.Size = new Size(57, 54);
            iconoReporte.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoReporte.TabIndex = 76;
            iconoReporte.TabStop = false;
            iconoReporte.Click += iconoReporte_Click;
            // 
            // iconoNosotros
            // 
            iconoNosotros.BackColor = Color.IndianRed;
            iconoNosotros.BackgroundImageLayout = ImageLayout.Center;
            iconoNosotros.Image = CinesFront.Properties.Resources.boton_nosotros;
            iconoNosotros.Location = new Point(36, 752);
            iconoNosotros.Name = "iconoNosotros";
            iconoNosotros.Size = new Size(57, 54);
            iconoNosotros.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoNosotros.TabIndex = 77;
            iconoNosotros.TabStop = false;
            iconoNosotros.Click += iconoNosotros_Click;
            // 
            // lblSoporte
            // 
            lblSoporte.AutoSize = true;
            lblSoporte.BackColor = Color.IndianRed;
            lblSoporte.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoporte.ForeColor = Color.Black;
            lblSoporte.Location = new Point(147, 260);
            lblSoporte.Name = "lblSoporte";
            lblSoporte.Size = new Size(159, 32);
            lblSoporte.TabIndex = 78;
            lblSoporte.Text = "SOPORTE";
            lblSoporte.Click += lblSoporte_Click;
            // 
            // lblTransaccion
            // 
            lblTransaccion.AutoSize = true;
            lblTransaccion.BackColor = Color.IndianRed;
            lblTransaccion.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransaccion.ForeColor = Color.Black;
            lblTransaccion.Location = new Point(119, 418);
            lblTransaccion.Name = "lblTransaccion";
            lblTransaccion.Size = new Size(268, 32);
            lblTransaccion.TabIndex = 79;
            lblTransaccion.Text = "TRANSACCIONES";
            // 
            // lblReporte
            // 
            lblReporte.AutoSize = true;
            lblReporte.BackColor = Color.IndianRed;
            lblReporte.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblReporte.ForeColor = Color.Black;
            lblReporte.Location = new Point(149, 591);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(195, 32);
            lblReporte.TabIndex = 80;
            lblReporte.Text = "CONSULTAS";
            lblReporte.Click += lblReporte_Click;
            // 
            // lblNosotros
            // 
            lblNosotros.AutoSize = true;
            lblNosotros.BackColor = Color.IndianRed;
            lblNosotros.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNosotros.ForeColor = Color.Black;
            lblNosotros.Location = new Point(147, 764);
            lblNosotros.Name = "lblNosotros";
            lblNosotros.Size = new Size(183, 32);
            lblNosotros.TabIndex = 81;
            lblNosotros.Text = "NOSOTROS";
            lblNosotros.Click += lblNosotros_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnSalir.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(119, 923);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(228, 58);
            btnSalir.TabIndex = 82;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // iconoSalir
            // 
            iconoSalir.BackColor = Color.IndianRed;
            iconoSalir.BackgroundImageLayout = ImageLayout.Center;
            iconoSalir.Image = CinesFront.Properties.Resources.boton_salir;
            iconoSalir.Location = new Point(36, 923);
            iconoSalir.Name = "iconoSalir";
            iconoSalir.Size = new Size(57, 54);
            iconoSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoSalir.TabIndex = 83;
            iconoSalir.TabStop = false;
            iconoSalir.Click += iconoSalir_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.Desktop;
            btnVentas.Enabled = false;
            btnVentas.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentas.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.IndianRed;
            btnVentas.Location = new Point(483, 685);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(228, 58);
            btnVentas.TabIndex = 84;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Visible = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnButacas
            // 
            btnButacas.BackColor = SystemColors.Desktop;
            btnButacas.Enabled = false;
            btnButacas.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnButacas.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnButacas.ForeColor = Color.IndianRed;
            btnButacas.Location = new Point(483, 578);
            btnButacas.Margin = new Padding(3, 4, 3, 4);
            btnButacas.Name = "btnButacas";
            btnButacas.Size = new Size(228, 58);
            btnButacas.TabIndex = 85;
            btnButacas.Text = "BUTACAS";
            btnButacas.UseVisualStyleBackColor = false;
            btnButacas.Visible = false;
            btnButacas.Click += btnButacas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.Desktop;
            btnClientes.Enabled = false;
            btnClientes.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnClientes.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.IndianRed;
            btnClientes.Location = new Point(483, 480);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(228, 58);
            btnClientes.TabIndex = 87;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Visible = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnMejoresClientes
            // 
            btnMejoresClientes.BackColor = SystemColors.Desktop;
            btnMejoresClientes.Enabled = false;
            btnMejoresClientes.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnMejoresClientes.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMejoresClientes.ForeColor = Color.IndianRed;
            btnMejoresClientes.Location = new Point(785, 465);
            btnMejoresClientes.Margin = new Padding(3, 4, 3, 4);
            btnMejoresClientes.Name = "btnMejoresClientes";
            btnMejoresClientes.Size = new Size(228, 73);
            btnMejoresClientes.TabIndex = 88;
            btnMejoresClientes.Text = "MEJORES CLIENTES";
            btnMejoresClientes.UseVisualStyleBackColor = false;
            btnMejoresClientes.Visible = false;
            btnMejoresClientes.Click += button3_Click;
            // 
            // btnButacasDisponibles
            // 
            btnButacasDisponibles.BackColor = SystemColors.Desktop;
            btnButacasDisponibles.Enabled = false;
            btnButacasDisponibles.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnButacasDisponibles.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnButacasDisponibles.ForeColor = Color.IndianRed;
            btnButacasDisponibles.Location = new Point(785, 572);
            btnButacasDisponibles.Margin = new Padding(3, 4, 3, 4);
            btnButacasDisponibles.Name = "btnButacasDisponibles";
            btnButacasDisponibles.Size = new Size(228, 73);
            btnButacasDisponibles.TabIndex = 89;
            btnButacasDisponibles.Text = "BUTACAS DISPONIBLES";
            btnButacasDisponibles.UseVisualStyleBackColor = false;
            btnButacasDisponibles.Visible = false;
            btnButacasDisponibles.Click += btnButacasDisponibles_Click;
            // 
            // btnVentasPorMes
            // 
            btnVentasPorMes.BackColor = SystemColors.Desktop;
            btnVentasPorMes.Enabled = false;
            btnVentasPorMes.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentasPorMes.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentasPorMes.ForeColor = Color.IndianRed;
            btnVentasPorMes.Location = new Point(785, 685);
            btnVentasPorMes.Margin = new Padding(3, 4, 3, 4);
            btnVentasPorMes.Name = "btnVentasPorMes";
            btnVentasPorMes.Size = new Size(228, 71);
            btnVentasPorMes.TabIndex = 90;
            btnVentasPorMes.Text = "VENTAS POR MES";
            btnVentasPorMes.UseVisualStyleBackColor = false;
            btnVentasPorMes.Visible = false;
            btnVentasPorMes.Click += btnVentasPorMes_Click;
            // 
            // btnFormasPago
            // 
            btnFormasPago.BackColor = SystemColors.Desktop;
            btnFormasPago.Enabled = false;
            btnFormasPago.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnFormasPago.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormasPago.ForeColor = Color.IndianRed;
            btnFormasPago.Location = new Point(785, 784);
            btnFormasPago.Margin = new Padding(3, 4, 3, 4);
            btnFormasPago.Name = "btnFormasPago";
            btnFormasPago.Size = new Size(228, 71);
            btnFormasPago.TabIndex = 91;
            btnFormasPago.Text = "FORMAS DE PAGO";
            btnFormasPago.UseVisualStyleBackColor = false;
            btnFormasPago.Visible = false;
            btnFormasPago.Click += btnFormasPago_Click;
            // 
            // btnActualizarPrecio
            // 
            btnActualizarPrecio.BackColor = SystemColors.Desktop;
            btnActualizarPrecio.Enabled = false;
            btnActualizarPrecio.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnActualizarPrecio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarPrecio.ForeColor = Color.IndianRed;
            btnActualizarPrecio.Location = new Point(785, 897);
            btnActualizarPrecio.Margin = new Padding(3, 4, 3, 4);
            btnActualizarPrecio.Name = "btnActualizarPrecio";
            btnActualizarPrecio.Size = new Size(228, 71);
            btnActualizarPrecio.TabIndex = 92;
            btnActualizarPrecio.Text = "ACTUALIZAR PRECIO";
            btnActualizarPrecio.UseVisualStyleBackColor = false;
            btnActualizarPrecio.Visible = false;
            btnActualizarPrecio.Click += btnActualizarPrecio_Click;
            // 
            // frmAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnActualizarPrecio);
            Controls.Add(btnFormasPago);
            Controls.Add(btnVentasPorMes);
            Controls.Add(btnButacasDisponibles);
            Controls.Add(btnMejoresClientes);
            Controls.Add(btnClientes);
            Controls.Add(btnButacas);
            Controls.Add(btnVentas);
            Controls.Add(iconoSalir);
            Controls.Add(btnSalir);
            Controls.Add(lblNosotros);
            Controls.Add(lblReporte);
            Controls.Add(lblTransaccion);
            Controls.Add(lblSoporte);
            Controls.Add(iconoNosotros);
            Controls.Add(iconoReporte);
            Controls.Add(iconoTransaccion);
            Controls.Add(iconoSoporte);
            Controls.Add(lblMenu);
            Controls.Add(iconoMenu);
            Controls.Add(pbFondoMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdministrador";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbFondoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoSoporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoTransaccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoNosotros).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFondoMenu;
        private PictureBox iconoMenu;
        private Label lblMenu;
        private PictureBox iconoSoporte;
        private PictureBox iconoTransaccion;
        private PictureBox iconoReporte;
        private PictureBox iconoNosotros;
        private Label lblSoporte;
        private Label lblTransaccion;
        private Label lblReporte;
        private Label lblNosotros;
        public Button btnSalir;
        private PictureBox iconoSalir;
        public Button btnVentas;
        public Button btnButacas;
        public Button btnClientes;
        public Button btnMejoresClientes;
        public Button btnButacasDisponibles;
        public Button btnVentasPorMes;
        public Button btnFormasPago;
        public Button btnActualizarPrecio;
    }
}