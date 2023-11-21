namespace CIneLabo.Presentacion
{
    partial class FrmInformeMejoresFormasDePago
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
            btnLimpiar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            btnGenerarInforme = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvFormasDePago = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFormasDePago).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(39, 388);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 51);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(39, 268);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(290, 27);
            dtpHasta.TabIndex = 26;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(39, 178);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(290, 27);
            dtpDesde.TabIndex = 25;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.IndianRed;
            btnGenerarInforme.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarInforme.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerarInforme.Location = new Point(219, 388);
            btnGenerarInforme.Margin = new Padding(3, 4, 3, 4);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(156, 51);
            btnGenerarInforme.TabIndex = 24;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Desktop;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(39, 89);
            label4.Name = "label4";
            label4.Size = new Size(260, 20);
            label4.TabIndex = 23;
            label4.Text = "Debes seleccionar una fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(39, 235);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 22;
            label3.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Desktop;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(39, 140);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 21;
            label2.Text = "Desde";
            // 
            // dgvFormasDePago
            // 
            dgvFormasDePago.BackgroundColor = SystemColors.Desktop;
            dgvFormasDePago.BorderStyle = BorderStyle.Fixed3D;
            dgvFormasDePago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormasDePago.Location = new Point(427, 89);
            dgvFormasDePago.Margin = new Padding(3, 4, 3, 4);
            dgvFormasDePago.Name = "dgvFormasDePago";
            dgvFormasDePago.RowHeadersWidth = 51;
            dgvFormasDePago.RowTemplate.Height = 25;
            dgvFormasDePago.Size = new Size(317, 350);
            dgvFormasDePago.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(148, 25);
            label1.Name = "label1";
            label1.Size = new Size(469, 36);
            label1.TabIndex = 19;
            label1.Text = "MEJORES FORMAS DE PAGO ";
            // 
            // FrmInformeMejoresFormasDePago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(816, 490);
            Controls.Add(btnLimpiar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(btnGenerarInforme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvFormasDePago);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmInformeMejoresFormasDePago";
            Text = "FrmInformeMejoresFormasDePago";
            Load += FrmInformeMejoresFormasDePago_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFormasDePago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnGenerarInforme;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvFormasDePago;
        private Label label1;
    }
}