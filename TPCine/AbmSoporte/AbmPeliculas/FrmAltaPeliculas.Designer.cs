namespace TPCine.AbmSoporte.AbmPeliculas
{
    partial class FrmAltaPeliculas
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
            this.txtNombrePelicula = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblNombrePelicula = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.dtpDuracion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(12, 25);
            this.txtNombrePelicula.MaxLength = 15;
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(200, 20);
            this.txtNombrePelicula.TabIndex = 0;
            this.txtNombrePelicula.TextChanged += new System.EventHandler(this.txtNombrePelicula_TextChanged);
            this.txtNombrePelicula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePelicula_KeyPress);
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(12, 105);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(200, 21);
            this.cboGenero.TabIndex = 1;
            // 
            // cboIdioma
            // 
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(12, 145);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(200, 21);
            this.cboIdioma.TabIndex = 2;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(12, 185);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(200, 21);
            this.cboClasificacion.TabIndex = 3;
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(12, 225);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEstreno.TabIndex = 4;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(12, 66);
            this.txtDirector.MaxLength = 15;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(200, 20);
            this.txtDirector.TabIndex = 5;
            this.txtDirector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirector_KeyPress);
            // 
            // lblNombrePelicula
            // 
            this.lblNombrePelicula.AutoSize = true;
            this.lblNombrePelicula.Location = new System.Drawing.Point(12, 9);
            this.lblNombrePelicula.Name = "lblNombrePelicula";
            this.lblNombrePelicula.Size = new System.Drawing.Size(110, 13);
            this.lblNombrePelicula.TabIndex = 6;
            this.lblNombrePelicula.Text = "Nombre de la Pelicula";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(12, 89);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Genero";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(12, 50);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(44, 13);
            this.lblDirector.TabIndex = 8;
            this.lblDirector.Text = "Director";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(12, 129);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(12, 169);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(66, 13);
            this.lblClasificacion.TabIndex = 10;
            this.lblClasificacion.Text = "Clasificación";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(12, 209);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(90, 13);
            this.lblFechaEstreno.TabIndex = 11;
            this.lblFechaEstreno.Text = "Fecha de estreno";
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
            this.dgvPeliculas.Location = new System.Drawing.Point(234, 25);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.Size = new System.Drawing.Size(499, 259);
            this.dgvPeliculas.TabIndex = 12;
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
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(613, 290);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(120, 23);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar Pelicula";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(12, 248);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 15;
            this.lblDuracion.Text = "Duración";
            // 
            // dtpDuracion
            // 
            this.dtpDuracion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDuracion.Location = new System.Drawing.Point(12, 264);
            this.dtpDuracion.Name = "dtpDuracion";
            this.dtpDuracion.ShowUpDown = true;
            this.dtpDuracion.Size = new System.Drawing.Size(200, 20);
            this.dtpDuracion.TabIndex = 16;
            this.dtpDuracion.Value = new System.DateTime(2023, 11, 25, 0, 0, 0, 0);
            this.dtpDuracion.ValueChanged += new System.EventHandler(this.dtpDuracion_ValueChanged);
            this.dtpDuracion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDuracion_MouseDown);
            // 
            // FrmAltaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(745, 322);
            this.Controls.Add(this.dtpDuracion);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNombrePelicula);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.dtpFechaEstreno);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.txtNombrePelicula);
            this.Name = "FrmAltaPeliculas";
            this.Text = "FrmAltaPeliculas";
            this.Load += new System.EventHandler(this.FrmAltaPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePelicula;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblNombrePelicula;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEstreno;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.DateTimePicker dtpDuracion;
    }
}