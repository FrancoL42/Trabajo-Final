namespace CineApp
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox11 = new PictureBox();
            lblNombrePelicula = new Label();
            label12 = new Label();
            lblDuracion = new Label();
            lblGenero = new Label();
            lblClasificacion = new Label();
            lblFormato = new Label();
            lblIdioma = new Label();
            lblFecha = new Label();
            lblDirector = new Label();
            btnComprarEntradas = new Button();
            btnSalir = new Button();
            btnNombreUsuario = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(28, 709);
            label2.Name = "label2";
            label2.Size = new Size(1840, 32);
            label2.TabIndex = 2;
            label2.Text = "CARTELERA  ______________________________________________________________________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(289, 72);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 610);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = SystemColors.ControlLightLight;
            pictureBox11.Location = new Point(81, 745);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(200, 305);
            pictureBox11.TabIndex = 13;
            pictureBox11.TabStop = false;
            // 
            // lblNombrePelicula
            // 
            lblNombrePelicula.AutoSize = true;
            lblNombrePelicula.BackColor = SystemColors.Desktop;
            lblNombrePelicula.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombrePelicula.ForeColor = Color.Gold;
            lblNombrePelicula.Location = new Point(743, 124);
            lblNombrePelicula.Name = "lblNombrePelicula";
            lblNombrePelicula.Size = new Size(344, 32);
            lblNombrePelicula.TabIndex = 18;
            lblNombrePelicula.Text = "NOMBRE DE PELICULA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Desktop;
            label12.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Gold;
            label12.Location = new Point(1197, 124);
            label12.Name = "label12";
            label12.Size = new Size(798, 32);
            label12.TabIndex = 19;
            label12.Text = "_________________________________________________";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = SystemColors.Desktop;
            lblDuracion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuracion.ForeColor = Color.Gold;
            lblDuracion.Location = new Point(744, 215);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(132, 25);
            lblDuracion.TabIndex = 20;
            lblDuracion.Text = "DURACION:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = SystemColors.Desktop;
            lblGenero.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.Gold;
            lblGenero.Location = new Point(744, 291);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(109, 25);
            lblGenero.TabIndex = 21;
            lblGenero.Text = "GENERO:";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.BackColor = SystemColors.Desktop;
            lblClasificacion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClasificacion.ForeColor = Color.Gold;
            lblClasificacion.Location = new Point(744, 364);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(187, 25);
            lblClasificacion.TabIndex = 22;
            lblClasificacion.Text = "CLASIFICACION:";
            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.BackColor = SystemColors.Desktop;
            lblFormato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormato.ForeColor = Color.Gold;
            lblFormato.Location = new Point(744, 435);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(127, 25);
            lblFormato.TabIndex = 23;
            lblFormato.Text = "FORMATO:";
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.BackColor = SystemColors.Desktop;
            lblIdioma.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdioma.ForeColor = Color.Gold;
            lblIdioma.Location = new Point(744, 510);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(96, 25);
            lblIdioma.TabIndex = 24;
            lblIdioma.Text = "IDIOMA:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.Desktop;
            lblFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.Gold;
            lblFecha.Location = new Point(744, 651);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(236, 25);
            lblFecha.TabIndex = 25;
            lblFecha.Text = "FECHA DE ESTRENO:";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.BackColor = SystemColors.Desktop;
            lblDirector.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDirector.ForeColor = Color.Gold;
            lblDirector.Location = new Point(744, 582);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(129, 25);
            lblDirector.TabIndex = 26;
            lblDirector.Text = "DIRECTOR:";
            // 
            // btnComprarEntradas
            // 
            btnComprarEntradas.BackColor = SystemColors.Desktop;
            btnComprarEntradas.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprarEntradas.ForeColor = Color.Red;
            btnComprarEntradas.Location = new Point(1232, 618);
            btnComprarEntradas.Margin = new Padding(3, 4, 3, 4);
            btnComprarEntradas.Name = "btnComprarEntradas";
            btnComprarEntradas.Size = new Size(636, 58);
            btnComprarEntradas.TabIndex = 27;
            btnComprarEntradas.Text = "COMPRAR ENTRADAS";
            btnComprarEntradas.UseVisualStyleBackColor = false;
            btnComprarEntradas.Click += btnComprarEntradas_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.Enabled = false;
            btnSalir.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(1644, 82);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(268, 58);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Visible = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNombreUsuario
            // 
            btnNombreUsuario.BackColor = SystemColors.Desktop;
            btnNombreUsuario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNombreUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnNombreUsuario.Location = new Point(1367, 28);
            btnNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            btnNombreUsuario.Name = "btnNombreUsuario";
            btnNombreUsuario.Size = new Size(545, 58);
            btnNombreUsuario.TabIndex = 29;
            btnNombreUsuario.Text = "NOMBRE_USUARIO";
            btnNombreUsuario.UseVisualStyleBackColor = false;
            btnNombreUsuario.Click += btnNombreUsuario_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Location = new Point(396, 745);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 305);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlLightLight;
            pictureBox3.Location = new Point(712, 745);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 305);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlLightLight;
            pictureBox4.Location = new Point(1025, 745);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 305);
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ControlLightLight;
            pictureBox5.Location = new Point(1339, 745);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 305);
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ControlLightLight;
            pictureBox6.Location = new Point(1647, 745);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(200, 305);
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnNombreUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnComprarEntradas);
            Controls.Add(lblDirector);
            Controls.Add(lblFecha);
            Controls.Add(lblIdioma);
            Controls.Add(lblFormato);
            Controls.Add(lblClasificacion);
            Controls.Add(lblGenero);
            Controls.Add(lblDuracion);
            Controls.Add(label12);
            Controls.Add(lblNombrePelicula);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cine";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox11;
        private Label lblNombrePelicula;
        private Label label12;
        private Label lblDuracion;
        private Label lblGenero;
        private Label lblClasificacion;
        private Label lblFormato;
        private Label lblIdioma;
        private Label lblFecha;
        private Label lblDirector;
        private Button btnComprarEntradas;
        public Button btnSalir;
        public Button btnNombreUsuario;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}

