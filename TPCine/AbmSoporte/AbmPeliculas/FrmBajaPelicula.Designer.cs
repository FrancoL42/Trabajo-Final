namespace TPCine.AbmSoporte.AbmPeliculas
{
    partial class FrmBajaPelicula
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
            this.cboPeliculas = new System.Windows.Forms.ComboBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPeliculas
            // 
            this.cboPeliculas.FormattingEnabled = true;
            this.cboPeliculas.Location = new System.Drawing.Point(12, 25);
            this.cboPeliculas.Name = "cboPeliculas";
            this.cboPeliculas.Size = new System.Drawing.Size(225, 21);
            this.cboPeliculas.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(243, 25);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(94, 23);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Dar De Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elija la pelicula para dar de Baja";
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitulo,
            this.colDuracion,
            this.colFechaEstreno});
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 54);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.Size = new System.Drawing.Size(500, 220);
            this.dgvPeliculas.TabIndex = 28;
            // 
            // colID
            // 
            this.colID.HeaderText = "id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 150;
            // 
            // colDuracion
            // 
            this.colDuracion.HeaderText = "Duración";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.ReadOnly = true;
            this.colDuracion.Width = 150;
            // 
            // colFechaEstreno
            // 
            this.colFechaEstreno.HeaderText = "Fecha de Estreno";
            this.colFechaEstreno.Name = "colFechaEstreno";
            this.colFechaEstreno.ReadOnly = true;
            this.colFechaEstreno.Width = 155;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBajaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(533, 315);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.cboPeliculas);
            this.Name = "FrmBajaPelicula";
            this.Text = "FrmBajaPelicula";
            this.Load += new System.EventHandler(this.FrmBajaPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEstreno;
        private System.Windows.Forms.Button btnSalir;
    }
}