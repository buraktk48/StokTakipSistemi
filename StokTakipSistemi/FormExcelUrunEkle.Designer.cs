namespace StokTakipSistemi
{
    partial class FormExcelUrunEkle
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcelUrunEkle));
            btnDosyaSec = new Button();
            txtDosyaYolu = new TextBox();
            dgvExcel = new DataGridView();
            btnIceAktar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExcel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDosyaSec
            // 
            btnDosyaSec.FlatStyle = FlatStyle.Flat;
            btnDosyaSec.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDosyaSec.Location = new Point(786, 104);
            btnDosyaSec.Name = "btnDosyaSec";
            btnDosyaSec.Size = new Size(277, 49);
            btnDosyaSec.TabIndex = 0;
            btnDosyaSec.Text = "Dosya Seç";
            btnDosyaSec.UseVisualStyleBackColor = true;
            btnDosyaSec.Click += btnDosyaSec_Click;
            // 
            // txtDosyaYolu
            // 
            txtDosyaYolu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDosyaYolu.Location = new Point(520, 109);
            txtDosyaYolu.Name = "txtDosyaYolu";
            txtDosyaYolu.Size = new Size(223, 39);
            txtDosyaYolu.TabIndex = 1;
            // 
            // dgvExcel
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExcel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Location = new Point(24, 171);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.ReadOnly = true;
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(1574, 501);
            dgvExcel.TabIndex = 2;
            // 
            // btnIceAktar
            // 
            btnIceAktar.FlatStyle = FlatStyle.Flat;
            btnIceAktar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIceAktar.Location = new Point(673, 707);
            btnIceAktar.Name = "btnIceAktar";
            btnIceAktar.Size = new Size(279, 47);
            btnIceAktar.TabIndex = 3;
            btnIceAktar.Text = "İçe Aktar";
            btnIceAktar.UseVisualStyleBackColor = true;
            btnIceAktar.Click += btnIceAktar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 79);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.MediumSeaGreen;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1638, 79);
            label1.TabIndex = 0;
            label1.Text = "EXCELDEN ÜRÜN EKLEME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormExcelUrunEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 849);
            Controls.Add(panel1);
            Controls.Add(btnIceAktar);
            Controls.Add(dgvExcel);
            Controls.Add(txtDosyaYolu);
            Controls.Add(btnDosyaSec);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormExcelUrunEkle";
            Text = "Stok Takip Sistemi | Excelden İçeri Aktar";
            Load += FormExcelUrunEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExcel).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDosyaSec;
        private TextBox txtDosyaYolu;
        private DataGridView dgvExcel;
        private Button btnIceAktar;
        private Panel panel1;
        private Label label1;
    }
}

