namespace CIneLabo.Presentacion
{
    partial class FrmActualizacionPrecio
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
            button1 = new Button();
            button2 = new Button();
            txtDolarAntes = new TextBox();
            txtPorcentaje = new TextBox();
            txtValorDolarActual = new TextBox();
            lblValDolAnt = new Label();
            label1 = new Label();
            label2 = new Label();
            dgvPeliPrecio = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
<<<<<<< HEAD
            label3 = new Label();
            label4 = new Label();
=======
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
            ((System.ComponentModel.ISupportInitialize)dgvPeliPrecio).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(47, 431);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(216, 69);
            button1.TabIndex = 0;
            button1.Text = "Porcentaje Sugerido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(309, 431);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(216, 70);
            button2.TabIndex = 1;
            button2.Text = "Actualizar Precio";
<<<<<<< HEAD
            button2.UseVisualStyleBackColor = false;
=======
            button2.UseVisualStyleBackColor = true;
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
            button2.Click += button2_Click;
            // 
            // txtDolarAntes
            // 
            txtDolarAntes.Enabled = false;
<<<<<<< HEAD
            txtDolarAntes.Location = new Point(47, 201);
            txtDolarAntes.Margin = new Padding(4);
=======
            txtDolarAntes.Location = new Point(30, 55);
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
            txtDolarAntes.Name = "txtDolarAntes";
            txtDolarAntes.Size = new Size(168, 28);
            txtDolarAntes.TabIndex = 2;
            // 
            // txtPorcentaje
            // 
<<<<<<< HEAD
            txtPorcentaje.Location = new Point(47, 331);
            txtPorcentaje.Margin = new Padding(4);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(122, 28);
=======
            txtPorcentaje.Location = new Point(393, 138);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(90, 23);
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
            txtPorcentaje.TabIndex = 3;
            // 
            // txtValorDolarActual
            // 
            txtValorDolarActual.Location = new Point(330, 201);
            txtValorDolarActual.Margin = new Padding(4);
            txtValorDolarActual.Name = "txtValorDolarActual";
            txtValorDolarActual.Size = new Size(158, 28);
            txtValorDolarActual.TabIndex = 4;
            // 
            // lblValDolAnt
            // 
            lblValDolAnt.AutoSize = true;
            lblValDolAnt.BackColor = SystemColors.Desktop;
            lblValDolAnt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblValDolAnt.ForeColor = Color.Gold;
            lblValDolAnt.Location = new Point(47, 151);
            lblValDolAnt.Margin = new Padding(4, 0, 4, 0);
            lblValDolAnt.Name = "lblValDolAnt";
            lblValDolAnt.Size = new Size(186, 22);
            lblValDolAnt.TabIndex = 5;
            lblValDolAnt.Text = "Valor Dolar anterior";
            lblValDolAnt.Click += lblValDolAnt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(330, 151);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 22);
            label1.TabIndex = 6;
            label1.Text = "Nuevo Valor Dolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(47, 271);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 22);
=======
            label2.BackColor = Color.Silver;
            label2.Location = new Point(393, 107);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
            label2.TabIndex = 7;
            label2.Text = "Porcentaje Sugerido";
            // 
            // dgvPeliPrecio
            // 
            dgvPeliPrecio.AllowUserToAddRows = false;
            dgvPeliPrecio.AllowUserToDeleteRows = false;
<<<<<<< HEAD
            dgvPeliPrecio.BackgroundColor = SystemColors.Desktop;
            dgvPeliPrecio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliPrecio.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColPrecio });
            dgvPeliPrecio.Location = new Point(583, 121);
            dgvPeliPrecio.Margin = new Padding(4);
            dgvPeliPrecio.Name = "dgvPeliPrecio";
            dgvPeliPrecio.ReadOnly = true;
            dgvPeliPrecio.RowHeadersWidth = 51;
            dgvPeliPrecio.RowTemplate.Height = 25;
            dgvPeliPrecio.Size = new Size(379, 428);
=======
            dgvPeliPrecio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliPrecio.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColPrecio });
            dgvPeliPrecio.Location = new Point(30, 118);
            dgvPeliPrecio.Name = "dgvPeliPrecio";
            dgvPeliPrecio.ReadOnly = true;
            dgvPeliPrecio.RowTemplate.Height = 25;
            dgvPeliPrecio.Size = new Size(294, 254);
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
            dgvPeliPrecio.TabIndex = 8;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.MinimumWidth = 6;
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            ColPelicula.Width = 200;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 32);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 9;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(284, 42);
            label4.Name = "label4";
            label4.Size = new Size(469, 36);
            label4.TabIndex = 11;
            label4.Text = "ACTUALIZACIÓN DE PRECIOS";
            // 
            // FrmActualizacionPrecio
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1133, 628);
            Controls.Add(label4);
            Controls.Add(label3);
=======
            BackColor = Color.Black;
            ClientSize = new Size(546, 416);
>>>>>>> 476b5ae036dece9b065858a05448aa8e6d04e10e
            Controls.Add(dgvPeliPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblValDolAnt);
            Controls.Add(txtValorDolarActual);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtDolarAntes);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Gold;
            Margin = new Padding(4);
            Name = "FrmActualizacionPrecio";
            Text = "Actualizacion Precio Entradas";
            Load += FrmActualizacionPrecio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeliPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtDolarAntes;
        private TextBox txtPorcentaje;
        private TextBox txtValorDolarActual;
        private Label lblValDolAnt;
        private Label label1;
        private Label label2;
        private DataGridView dgvPeliPrecio;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColPrecio;
        private Label label3;
        private Label label4;
    }
}