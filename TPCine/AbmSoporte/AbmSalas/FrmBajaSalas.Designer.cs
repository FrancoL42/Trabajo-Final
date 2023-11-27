namespace TPCine.AbmSoporte.AbmSalas
{
    partial class FrmBajaSala
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
            this.lblNroSala = new System.Windows.Forms.Label();
            this.cboNroSala = new System.Windows.Forms.ComboBox();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.colIDSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroSala
            // 
            this.lblNroSala.AutoSize = true;
            this.lblNroSala.Location = new System.Drawing.Point(12, 9);
            this.lblNroSala.Name = "lblNroSala";
            this.lblNroSala.Size = new System.Drawing.Size(70, 13);
            this.lblNroSala.TabIndex = 19;
            this.lblNroSala.Text = "Nro° de Sala:";
            // 
            // cboNroSala
            // 
            this.cboNroSala.FormattingEnabled = true;
            this.cboNroSala.Location = new System.Drawing.Point(12, 26);
            this.cboNroSala.Name = "cboNroSala";
            this.cboNroSala.Size = new System.Drawing.Size(152, 21);
            this.cboNroSala.TabIndex = 18;
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
            this.dgvSalas.Location = new System.Drawing.Point(12, 52);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.ReadOnly = true;
            this.dgvSalas.Size = new System.Drawing.Size(483, 150);
            this.dgvSalas.TabIndex = 15;
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
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(408, 208);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(87, 23);
            this.btnBaja.TabIndex = 14;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseMnemonic = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBajaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(509, 242);
            this.Controls.Add(this.lblNroSala);
            this.Controls.Add(this.cboNroSala);
            this.Controls.Add(this.dgvSalas);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmBajaSala";
            this.Text = "Baja Salas";
            this.Load += new System.EventHandler(this.FrmBajaSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroSala;
        private System.Windows.Forms.ComboBox cboNroSala;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSalir;
    }
}