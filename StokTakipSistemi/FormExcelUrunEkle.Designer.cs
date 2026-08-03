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
            btnDosyaSec.Location = new Point(502, 108);
            btnDosyaSec.Name = "btnDosyaSec";
            btnDosyaSec.Size = new Size(151, 36);
            btnDosyaSec.TabIndex = 0;
            btnDosyaSec.Text = "Dosya Seç";
            btnDosyaSec.UseVisualStyleBackColor = true;
            btnDosyaSec.Click += btnDosyaSec_Click;
            // 
            // txtDosyaYolu
            // 
            txtDosyaYolu.Location = new Point(284, 113);
            txtDosyaYolu.Name = "txtDosyaYolu";
            txtDosyaYolu.Size = new Size(185, 27);
            txtDosyaYolu.TabIndex = 1;
            // 
            // dgvExcel
            // 
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Location = new Point(37, 170);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(899, 285);
            dgvExcel.TabIndex = 2;
            // 
            // btnIceAktar
            // 
            btnIceAktar.FlatStyle = FlatStyle.Flat;
            btnIceAktar.Location = new Point(354, 485);
            btnIceAktar.Name = "btnIceAktar";
            btnIceAktar.Size = new Size(216, 45);
            btnIceAktar.TabIndex = 3;
            btnIceAktar.Text = "İçe Aktar";
            btnIceAktar.UseVisualStyleBackColor = true;
            btnIceAktar.Click += btnIceAktar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 79);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(284, 21);
            label1.Name = "label1";
            label1.Size = new Size(382, 41);
            label1.TabIndex = 0;
            label1.Text = "EXCELDEN ÜRÜN EKLEME";
            // 
            // FormExcelUrunEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 551);
            Controls.Add(panel1);
            Controls.Add(btnIceAktar);
            Controls.Add(dgvExcel);
            Controls.Add(txtDosyaYolu);
            Controls.Add(btnDosyaSec);
            Name = "FormExcelUrunEkle";
            Text = "Stok Takip Sistemi - Excelden İçeri Aktar";
            ((System.ComponentModel.ISupportInitialize)dgvExcel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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