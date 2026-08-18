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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnDosyaSec.Location = new Point(688, 78);
            btnDosyaSec.Margin = new Padding(3, 2, 3, 2);
            btnDosyaSec.Name = "btnDosyaSec";
            btnDosyaSec.Size = new Size(242, 37);
            btnDosyaSec.TabIndex = 0;
            btnDosyaSec.Text = "Dosya Seç";
            btnDosyaSec.UseVisualStyleBackColor = true;
            btnDosyaSec.Click += btnDosyaSec_Click;
            // 
            // txtDosyaYolu
            // 
            txtDosyaYolu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDosyaYolu.Location = new Point(455, 82);
            txtDosyaYolu.Margin = new Padding(3, 2, 3, 2);
            txtDosyaYolu.Name = "txtDosyaYolu";
            txtDosyaYolu.Size = new Size(196, 33);
            txtDosyaYolu.TabIndex = 1;
            // 
            // dgvExcel
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dgvExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvExcel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Location = new Point(21, 128);
            dgvExcel.Margin = new Padding(3, 2, 3, 2);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.ReadOnly = true;
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(1377, 376);
            dgvExcel.TabIndex = 2;
            // 
            // btnIceAktar
            // 
            btnIceAktar.FlatStyle = FlatStyle.Flat;
            btnIceAktar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIceAktar.Location = new Point(589, 530);
            btnIceAktar.Margin = new Padding(3, 2, 3, 2);
            btnIceAktar.Name = "btnIceAktar";
            btnIceAktar.Size = new Size(244, 35);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 59);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.MediumSeaGreen;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1433, 59);
            label1.TabIndex = 0;
            label1.Text = "EXCELDEN ÜRÜN EKLEME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormExcelUrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 637);
            Controls.Add(panel1);
            Controls.Add(btnIceAktar);
            Controls.Add(dgvExcel);
            Controls.Add(txtDosyaYolu);
            Controls.Add(btnDosyaSec);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormExcelUrunEkle";
            Text = "Stok Takip Sistemi | Excelden İçeri Aktar";
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

