namespace TPCine.AbmSoporte.AbmSalas
{
    partial class FrmModificarSalas
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.colIDSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboNroSala = new System.Windows.Forms.ComboBox();
            this.lblNroSala = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad de Butacas";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(170, 23);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 9;
            // 
            // dgvSalas
            // 
            this.dgvSalas.AllowUserToAddRows = false;
            this.dgvSalas.AllowUserToDeleteRows = false;
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDSala,
            this.colCantidad,
            this.colEstado});
            this.dgvSalas.Location = new System.Drawing.Point(12, 49);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.ReadOnly = true;
            this.dgvSalas.Size = new System.Drawing.Size(483, 150);
            this.dgvSalas.TabIndex = 8;
            // 
            // colIDSala
            // 
            this.colIDSala.HeaderText = "Id Sala";
            this.colIDSala.Name = "colIDSala";
            this.colIDSala.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad Asientos";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 170;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 170;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(408, 205);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseMnemonic = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboNroSala
            // 
            this.cboNroSala.FormattingEnabled = true;
            this.cboNroSala.Location = new System.Drawing.Point(12, 23);
            this.cboNroSala.Name = "cboNroSala";
            this.cboNroSala.Size = new System.Drawing.Size(152, 21);
            this.cboNroSala.TabIndex = 11;
            // 
            // lblNroSala
            // 
            this.lblNroSala.AutoSize = true;
            this.lblNroSala.Location = new System.Drawing.Point(12, 6);
            this.lblNroSala.Name = "lblNroSala";
            this.lblNroSala.Size = new System.Drawing.Size(70, 13);
            this.lblNroSala.TabIndex = 12;
            this.lblNroSala.Text = "Nro° de Sala:";
            // 
            // FrmModificarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(507, 239);
            this.Controls.Add(this.lblNroSala);
            this.Controls.Add(this.cboNroSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.dgvSalas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmModificarSalas";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.FrmBajaSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboNroSala;
        private System.Windows.Forms.Label lblNroSala;
    }
}