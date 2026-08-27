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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnIlkSayfa = new Button();
            btnOnceki = new Button();
            lblSayfa = new Label();
            btnSonraki = new Button();
            btnSonSayfa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExcel).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnDosyaSec
            // 
            btnDosyaSec.BackColor = Color.FromArgb(16, 124, 65);
            btnDosyaSec.Cursor = Cursors.Hand;
            btnDosyaSec.FlatAppearance.BorderSize = 0;
            btnDosyaSec.FlatStyle = FlatStyle.Flat;
            btnDosyaSec.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDosyaSec.ForeColor = Color.White;
            btnDosyaSec.Location = new Point(870, 30);
            btnDosyaSec.Name = "btnDosyaSec";
            btnDosyaSec.Size = new Size(150, 35);
            btnDosyaSec.TabIndex = 0;
            btnDosyaSec.Text = "Dosya Seç";
            btnDosyaSec.UseVisualStyleBackColor = false;
            btnDosyaSec.Click += btnDosyaSec_Click;
            // 
            // txtDosyaYolu
            // 
            txtDosyaYolu.Font = new Font("Segoe UI", 12.5F);
            txtDosyaYolu.Location = new Point(350, 30);
            txtDosyaYolu.Name = "txtDosyaYolu";
            txtDosyaYolu.Size = new Size(500, 35);
            txtDosyaYolu.TabIndex = 1;
            // 
            // dgvExcel
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExcel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExcel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcel.Location = new Point(40, 195);
            dgvExcel.Name = "dgvExcel";
            dgvExcel.ReadOnly = true;
            dgvExcel.RowHeadersWidth = 51;
            dgvExcel.Size = new Size(1342, 335);
            dgvExcel.TabIndex = 2;
            // 
            // btnIceAktar
            // 
            btnIceAktar.Anchor = AnchorStyles.Bottom;
            btnIceAktar.BackColor = Color.FromArgb(16, 124, 65);
            btnIceAktar.Cursor = Cursors.Hand;
            btnIceAktar.FlatAppearance.BorderSize = 0;
            btnIceAktar.FlatStyle = FlatStyle.Flat;
            btnIceAktar.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            btnIceAktar.ForeColor = Color.White;
            btnIceAktar.Location = new Point(571, 608);
            btnIceAktar.Name = "btnIceAktar";
            btnIceAktar.Size = new Size(280, 48);
            btnIceAktar.TabIndex = 3;
            btnIceAktar.Text = "İçe Aktar";
            btnIceAktar.UseVisualStyleBackColor = false;
            btnIceAktar.Click += btnIceAktar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 124, 65);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 70);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(16, 124, 65);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1422, 70);
            label1.TabIndex = 0;
            label1.Text = "Stok Takip Sistemi | Excel'den Ürün Ekleme";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtDosyaYolu);
            groupBox1.Controls.Add(btnDosyaSec);
            groupBox1.Location = new Point(40, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1342, 95);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom;
            groupBox3.Controls.Add(btnIlkSayfa);
            groupBox3.Controls.Add(btnOnceki);
            groupBox3.Controls.Add(lblSayfa);
            groupBox3.Controls.Add(btnSonraki);
            groupBox3.Controls.Add(btnSonSayfa);
            groupBox3.Location = new Point(316, 536);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 58);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // btnIlkSayfa
            // 
            btnIlkSayfa.BackColor = Color.White;
            btnIlkSayfa.Cursor = Cursors.Hand;
            btnIlkSayfa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnIlkSayfa.FlatStyle = FlatStyle.Flat;
            btnIlkSayfa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIlkSayfa.ForeColor = Color.FromArgb(30, 41, 59);
            btnIlkSayfa.Location = new Point(30, 16);
            btnIlkSayfa.Name = "btnIlkSayfa";
            btnIlkSayfa.Size = new Size(110, 32);
            btnIlkSayfa.TabIndex = 10;
            btnIlkSayfa.Text = "İlk Sayfa";
            btnIlkSayfa.UseVisualStyleBackColor = false;
            btnIlkSayfa.Click += btnIlkSayfa_Click;
            // 
            // btnOnceki
            // 
            btnOnceki.BackColor = Color.White;
            btnOnceki.Cursor = Cursors.Hand;
            btnOnceki.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnOnceki.FlatStyle = FlatStyle.Flat;
            btnOnceki.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOnceki.ForeColor = Color.FromArgb(30, 41, 59);
            btnOnceki.Location = new Point(155, 16);
            btnOnceki.Name = "btnOnceki";
            btnOnceki.Size = new Size(110, 32);
            btnOnceki.TabIndex = 7;
            btnOnceki.Text = "<Önceki<";
            btnOnceki.UseVisualStyleBackColor = false;
            btnOnceki.Click += btnOnceki_Click;
            // 
            // lblSayfa
            // 
            lblSayfa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSayfa.ForeColor = Color.FromArgb(71, 85, 105);
            lblSayfa.Location = new Point(280, 18);
            lblSayfa.Name = "lblSayfa";
            lblSayfa.Size = new Size(240, 26);
            lblSayfa.TabIndex = 11;
            lblSayfa.Text = "Sayfa 1 / 2 (Toplam Kayıt: 13)";
            lblSayfa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.White;
            btnSonraki.Cursor = Cursors.Hand;
            btnSonraki.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSonraki.ForeColor = Color.FromArgb(30, 41, 59);
            btnSonraki.Location = new Point(535, 16);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(110, 32);
            btnSonraki.TabIndex = 8;
            btnSonraki.Text = ">Sonraki>";
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // btnSonSayfa
            // 
            btnSonSayfa.BackColor = Color.White;
            btnSonSayfa.Cursor = Cursors.Hand;
            btnSonSayfa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSonSayfa.FlatStyle = FlatStyle.Flat;
            btnSonSayfa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSonSayfa.ForeColor = Color.FromArgb(30, 41, 59);
            btnSonSayfa.Location = new Point(660, 16);
            btnSonSayfa.Name = "btnSonSayfa";
            btnSonSayfa.Size = new Size(110, 32);
            btnSonSayfa.TabIndex = 9;
            btnSonSayfa.Text = "Son Sayfa";
            btnSonSayfa.UseVisualStyleBackColor = false;
            btnSonSayfa.Click += btnSonSayfa_Click;
            // 
            // FormExcelUrunEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1422, 676);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnIceAktar);
            Controls.Add(dgvExcel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormExcelUrunEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Excelden İçeri Aktar";
            Load += FormExcelUrunEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExcel).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDosyaSec;
        private TextBox txtDosyaYolu;
        private DataGridView dgvExcel;
        private Button btnIceAktar;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnIlkSayfa;
        private Button btnOnceki;
        private Label lblSayfa;
        private Button btnSonraki;
        private Button btnSonSayfa;
    }
}
