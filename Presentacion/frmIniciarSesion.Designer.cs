namespace CineApp.Forms
{
    partial class frmIniciarSesion
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
            gbIniciarSesion = new GroupBox();
            label1 = new Label();
            pictureBox13 = new PictureBox();
            btnIniciarSesionRegistrar = new Button();
            btnIniciarSesionAceptar = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            gbIniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // gbIniciarSesion
            // 
            gbIniciarSesion.Controls.Add(label1);
            gbIniciarSesion.Controls.Add(pictureBox13);
            gbIniciarSesion.Controls.Add(btnIniciarSesionRegistrar);
            gbIniciarSesion.Controls.Add(btnIniciarSesionAceptar);
            gbIniciarSesion.Controls.Add(label4);
            gbIniciarSesion.Controls.Add(label3);
            gbIniciarSesion.Controls.Add(textBox2);
            gbIniciarSesion.Controls.Add(textBox1);
            gbIniciarSesion.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbIniciarSesion.ForeColor = SystemColors.ButtonHighlight;
            gbIniciarSesion.Location = new Point(11, 15);
            gbIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            gbIniciarSesion.Name = "gbIniciarSesion";
            gbIniciarSesion.Padding = new Padding(3, 4, 3, 4);
            gbIniciarSesion.Size = new Size(530, 872);
            gbIniciarSesion.TabIndex = 17;
            gbIniciarSesion.TabStop = false;
            gbIniciarSesion.Text = "INICIAR SESION - BIENVENIDO DE VUELTA";
            gbIniciarSesion.Enter += gbIniciarSesion_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(57, 711);
            label1.Name = "label1";
            label1.Size = new Size(433, 16);
            label1.TabIndex = 7;
            label1.Text = "¿Aún no tienes cuenta? Crea una apretando el botón de abajo";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = SystemColors.Desktop;
            pictureBox13.BackgroundImage = CIneLabo.Properties.Resources.Icon_Login;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.InitialImage = null;
            pictureBox13.Location = new Point(143, 40);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(271, 281);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 6;
            pictureBox13.TabStop = false;
            // 
            // btnIniciarSesionRegistrar
            // 
            btnIniciarSesionRegistrar.BackColor = SystemColors.ControlText;
            btnIniciarSesionRegistrar.FlatAppearance.BorderColor = Color.Lime;
            btnIniciarSesionRegistrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesionRegistrar.ForeColor = Color.Yellow;
            btnIniciarSesionRegistrar.Location = new Point(81, 757);
            btnIniciarSesionRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesionRegistrar.Name = "btnIniciarSesionRegistrar";
            btnIniciarSesionRegistrar.Size = new Size(379, 60);
            btnIniciarSesionRegistrar.TabIndex = 5;
            btnIniciarSesionRegistrar.Text = "REGISTRARME";
            btnIniciarSesionRegistrar.UseVisualStyleBackColor = false;
            btnIniciarSesionRegistrar.Click += btnIniciarSesionCancelar_Click;
            // 
            // btnIniciarSesionAceptar
            // 
            btnIniciarSesionAceptar.BackColor = SystemColors.ControlText;
            btnIniciarSesionAceptar.FlatAppearance.BorderColor = Color.Lime;
            btnIniciarSesionAceptar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesionAceptar.ForeColor = Color.PaleGreen;
            btnIniciarSesionAceptar.Location = new Point(81, 601);
            btnIniciarSesionAceptar.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesionAceptar.Name = "btnIniciarSesionAceptar";
            btnIniciarSesionAceptar.Size = new Size(379, 60);
            btnIniciarSesionAceptar.TabIndex = 4;
            btnIniciarSesionAceptar.Text = "ACEPTAR";
            btnIniciarSesionAceptar.UseVisualStyleBackColor = false;
            btnIniciarSesionAceptar.Click += btnIniciarSesionAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(78, 475);
            label4.Name = "label4";
            label4.Size = new Size(309, 16);
            label4.TabIndex = 3;
            label4.Text = "INGRESE LA CONTRASEÑA DEL USUARIO";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(78, 348);
            label3.Name = "label3";
            label3.Size = new Size(265, 16);
            label3.TabIndex = 2;
            label3.Text = "INGRESE SU NOMBRE DE USUARIO";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 524);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 22);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 391);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 22);
            textBox1.TabIndex = 0;
            // 
            // frmIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(557, 842);
            ControlBox = false;
            Controls.Add(gbIniciarSesion);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmIniciarSesion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            Load += frmIniciarSesion_Load;
            gbIniciarSesion.ResumeLayout(false);
            gbIniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbIniciarSesion;
        private PictureBox pictureBox13;
        private Button btnIniciarSesionRegistrar;
        private Button btnIniciarSesionAceptar;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}