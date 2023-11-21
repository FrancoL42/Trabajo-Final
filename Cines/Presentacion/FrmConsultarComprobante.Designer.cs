namespace CinesFront.Presentacion
{
    partial class FrmConsultarComprobante
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
            this.dgvComprobantes = new System.Windows.Forms.DataGridView();
            this.colNroComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnElminar = new System.Windows.Forms.Button();
            this.lblEliminarNro = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprobantes
            // 
            this.dgvComprobantes.AllowUserToAddRows = false;
            this.dgvComprobantes.AllowUserToDeleteRows = false;
            this.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroComprobante,
            this.colCliente,
            this.colFecha});
            this.dgvComprobantes.Location = new System.Drawing.Point(12, 56);
            this.dgvComprobantes.Name = "dgvComprobantes";
            this.dgvComprobantes.ReadOnly = true;
            this.dgvComprobantes.RowTemplate.Height = 25;
            this.dgvComprobantes.Size = new System.Drawing.Size(776, 187);
            this.dgvComprobantes.TabIndex = 0;
            this.dgvComprobantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobantes_CellContentClick);
            // 
            // colNroComprobante
            // 
            this.colNroComprobante.HeaderText = "Nro Comprobante";
            this.colNroComprobante.Name = "colNroComprobante";
            this.colNroComprobante.ReadOnly = true;
            this.colNroComprobante.Width = 220;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 210;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 250;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(713, 257);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(632, 257);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(12, 9);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(98, 15);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Nro° Documento";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(218, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(198, 23);
            this.txtCliente.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(218, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(91, 15);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Apellido Cliente";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(12, 27);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(198, 23);
            this.txtDoc.TabIndex = 8;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnElminar
            // 
            this.btnElminar.Location = new System.Drawing.Point(551, 257);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.Size = new System.Drawing.Size(75, 23);
            this.btnElminar.TabIndex = 3;
            this.btnElminar.Text = "Elminar";
            this.btnElminar.UseVisualStyleBackColor = true;
            this.btnElminar.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // lblEliminarNro
            // 
            this.lblEliminarNro.AutoSize = true;
            this.lblEliminarNro.Location = new System.Drawing.Point(422, 9);
            this.lblEliminarNro.Name = "lblEliminarNro";
            this.lblEliminarNro.Size = new System.Drawing.Size(109, 15);
            this.lblEliminarNro.TabIndex = 10;
            this.lblEliminarNro.Text = "Nro° Comprobante";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Location = new System.Drawing.Point(422, 27);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(366, 23);
            this.txtNroComprobante.TabIndex = 11;
            // 
            // FrmConsultarComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(806, 292);
            this.Controls.Add(this.txtNroComprobante);
            this.Controls.Add(this.lblEliminarNro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.btnElminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvComprobantes);
            this.Name = "FrmConsultarComprobante";
            this.Text = "FrmConsultarComprobante";
            this.Load += new System.EventHandler(this.FrmConsultarComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvComprobantes;
        private Button btnCargar;
        private Button btnModificar;
        private Label lblDocumento;
        private TextBox txtCliente;
        private Label lblCliente;
        private TextBox txtDoc;
        private Button btnCancelar;
        private Button btnElminar;
        private Label lblEliminarNro;
        private TextBox txtNroComprobante;
        private DataGridViewTextBoxColumn colNroComprobante;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFecha;
    }
}