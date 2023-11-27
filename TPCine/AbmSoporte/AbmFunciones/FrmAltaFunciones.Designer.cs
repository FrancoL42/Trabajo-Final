namespace TPCine.AbmSoporte.AbmFunciones
{
    partial class FrmAltaFunciones
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 26, 0, 0, 0, 0);
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(398, 25);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(184, 21);
            this.cboSala.TabIndex = 2;
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(215, 25);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(177, 21);
            this.cboPelicula.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de la Funcion";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 52);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(97, 13);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora de la Funcion";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(215, 9);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(44, 13);
            this.lblPelicula.TabIndex = 6;
            this.lblPelicula.Text = "Pelicula";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(398, 9);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(28, 13);
            this.lblSala.TabIndex = 7;
            this.lblSala.Text = "Sala";
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPelicula,
            this.colHora,
            this.colFecha,
            this.colPrecio,
            this.colNroSala});
            this.dgvFunciones.Location = new System.Drawing.Point(10, 94);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.Size = new System.Drawing.Size(775, 189);
            this.dgvFunciones.TabIndex = 8;
            // 
            // colID
            // 
            this.colID.HeaderText = "Nro° de Funcion";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colPelicula
            // 
            this.colPelicula.HeaderText = "Pelicula";
            this.colPelicula.Name = "colPelicula";
            this.colPelicula.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            this.colHora.Width = 150;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 150;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 130;
            // 
            // colNroSala
            // 
            this.colNroSala.HeaderText = "Nro° de Sala";
            this.colNroSala.Name = "colNroSala";
            this.colNroSala.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(710, 293);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(15, 68);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(197, 20);
            this.dtpHora.TabIndex = 33;
            this.dtpHora.Value = new System.DateTime(2023, 11, 25, 0, 0, 0, 0);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 293);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAltaFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(795, 328);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmAltaFunciones";
            this.Text = "Alta de Funciones";
            this.Load += new System.EventHandler(this.FrmAltaFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboSala;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroSala;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnSalir;
    }
}