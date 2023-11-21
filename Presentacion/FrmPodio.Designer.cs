namespace CIneLabo.Presentacion
{
    partial class FrmPodio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPodio));
            dgvPodio = new DataGridView();
            txtSegundo = new TextBox();
            txtPrimero = new TextBox();
            txtTercero = new TextBox();
            gbSegundo = new GroupBox();
            gbPrimero = new GroupBox();
            gbTercero = new GroupBox();
            btnActualizar = new Button();
            cboGenero = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            Colposicion = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColPuntos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodio).BeginInit();
            SuspendLayout();
            // 
            // dgvPodio
            // 
            dgvPodio.AllowUserToAddRows = false;
            dgvPodio.AllowUserToDeleteRows = false;
            dgvPodio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodio.Columns.AddRange(new DataGridViewColumn[] { Colposicion, ColNombre, ColPuntos });
            dgvPodio.Location = new Point(12, 443);
            dgvPodio.Margin = new Padding(3, 4, 3, 4);
            dgvPodio.Name = "dgvPodio";
            dgvPodio.ReadOnly = true;
            dgvPodio.RowHeadersWidth = 51;
            dgvPodio.RowTemplate.Height = 25;
            dgvPodio.Size = new Size(758, 393);
            dgvPodio.TabIndex = 0;
            dgvPodio.CellContentClick += dgvPodio_CellContentClick;
            // 
            // txtSegundo
            // 
            txtSegundo.BackColor = SystemColors.Desktop;
            txtSegundo.BorderStyle = BorderStyle.FixedSingle;
            txtSegundo.Enabled = false;
            txtSegundo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundo.ForeColor = SystemColors.Control;
            txtSegundo.Location = new Point(39, 336);
            txtSegundo.Margin = new Padding(3, 4, 3, 4);
            txtSegundo.Multiline = true;
            txtSegundo.Name = "txtSegundo";
            txtSegundo.ReadOnly = true;
            txtSegundo.Size = new Size(212, 59);
            txtSegundo.TabIndex = 1;
            // 
            // txtPrimero
            // 
            txtPrimero.BackColor = SystemColors.Desktop;
            txtPrimero.BorderStyle = BorderStyle.FixedSingle;
            txtPrimero.Enabled = false;
            txtPrimero.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimero.ForeColor = SystemColors.Control;
            txtPrimero.Location = new Point(274, 336);
            txtPrimero.Margin = new Padding(3, 4, 3, 4);
            txtPrimero.Multiline = true;
            txtPrimero.Name = "txtPrimero";
            txtPrimero.ReadOnly = true;
            txtPrimero.Size = new Size(217, 59);
            txtPrimero.TabIndex = 2;
            // 
            // txtTercero
            // 
            txtTercero.BackColor = SystemColors.Desktop;
            txtTercero.BorderStyle = BorderStyle.FixedSingle;
            txtTercero.Enabled = false;
            txtTercero.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTercero.ForeColor = SystemColors.Control;
            txtTercero.Location = new Point(517, 336);
            txtTercero.Margin = new Padding(3, 4, 3, 4);
            txtTercero.Multiline = true;
            txtTercero.Name = "txtTercero";
            txtTercero.ReadOnly = true;
            txtTercero.Size = new Size(217, 59);
            txtTercero.TabIndex = 3;
            // 
            // gbSegundo
            // 
            gbSegundo.BackgroundImage = Properties.Resources.segundo_puesto;
            gbSegundo.BackgroundImageLayout = ImageLayout.Zoom;
            gbSegundo.Location = new Point(67, 190);
            gbSegundo.Margin = new Padding(3, 4, 3, 4);
            gbSegundo.Name = "gbSegundo";
            gbSegundo.Padding = new Padding(3, 4, 3, 4);
            gbSegundo.Size = new Size(146, 124);
            gbSegundo.TabIndex = 4;
            gbSegundo.TabStop = false;
            // 
            // gbPrimero
            // 
            gbPrimero.AccessibleRole = AccessibleRole.None;
            gbPrimero.BackgroundImage = Properties.Resources.primer_puesto;
            gbPrimero.BackgroundImageLayout = ImageLayout.Zoom;
            gbPrimero.Location = new Point(311, 190);
            gbPrimero.Margin = new Padding(3, 4, 3, 4);
            gbPrimero.Name = "gbPrimero";
            gbPrimero.Padding = new Padding(3, 4, 3, 4);
            gbPrimero.Size = new Size(146, 124);
            gbPrimero.TabIndex = 5;
            gbPrimero.TabStop = false;
            // 
            // gbTercero
            // 
            gbTercero.BackColor = SystemColors.Desktop;
            gbTercero.BackgroundImage = Properties.Resources.tercer_puesto;
            gbTercero.BackgroundImageLayout = ImageLayout.Zoom;
            gbTercero.ForeColor = SystemColors.Desktop;
            gbTercero.Location = new Point(562, 190);
            gbTercero.Margin = new Padding(3, 4, 3, 4);
            gbTercero.Name = "gbTercero";
            gbTercero.Padding = new Padding(3, 4, 3, 4);
            gbTercero.Size = new Size(146, 124);
            gbTercero.TabIndex = 5;
            gbTercero.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.IndianRed;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(536, 116);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(183, 52);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cboGenero
            // 
            cboGenero.BackColor = SystemColors.Desktop;
            cboGenero.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cboGenero.ForeColor = SystemColors.Control;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(44, 140);
            cboGenero.Margin = new Padding(3, 4, 3, 4);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(447, 27);
            cboGenero.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(536, 25);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(183, 52);
            button1.TabIndex = 7;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(82, 28);
            label3.Name = "label3";
            label3.Size = new Size(374, 36);
            label3.TabIndex = 98;
            label3.Text = "INFORME DE CLIENTES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(82, 81);
            label1.Name = "label1";
            label1.Size = new Size(375, 25);
            label1.TabIndex = 99;
            label1.Text = "MEJORES CLIENTES POR GENERO";
            // 
            // Colposicion
            // 
            Colposicion.HeaderText = "ID";
            Colposicion.MinimumWidth = 6;
            Colposicion.Name = "Colposicion";
            Colposicion.ReadOnly = true;
            Colposicion.Width = 200;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre y Apellido";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 350;
            // 
            // ColPuntos
            // 
            ColPuntos.HeaderText = "Puntos";
            ColPuntos.MinimumWidth = 6;
            ColPuntos.Name = "ColPuntos";
            ColPuntos.ReadOnly = true;
            ColPuntos.Width = 200;
            // 
            // FrmPodio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(782, 849);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(cboGenero);
            Controls.Add(btnActualizar);
            Controls.Add(gbTercero);
            Controls.Add(gbPrimero);
            Controls.Add(gbSegundo);
            Controls.Add(txtTercero);
            Controls.Add(txtPrimero);
            Controls.Add(txtSegundo);
            Controls.Add(dgvPodio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(800, 900);
            MinimumSize = new Size(533, 667);
            Name = "FrmPodio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podio";
            Load += FrmPodio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPodio;
        private TextBox txtSegundo;
        private TextBox txtPrimero;
        private TextBox txtTercero;
        private GroupBox gbSegundo;
        private GroupBox gbPrimero;
        private GroupBox gbTercero;
        private Button btnActualizar;
        private ComboBox cboGenero;
        private Button button1;
        private Label label3;
        private Label label1;
        private DataGridViewTextBoxColumn Colposicion;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColPuntos;
    }
}