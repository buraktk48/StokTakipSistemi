namespace StokTakipSistemi
{
    partial class FormUrunPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunPanel));
            dgvUrunler = new DataGridView();
            label1 = new Label();
            txtAra = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnUrunEkle = new Button();
            btnExcelEkle = new Button();
            btnUrunGuncelle = new Button();
            btnUrunSil = new Button();
            btnUrunYenile = new Button();
            groupBox2 = new GroupBox();
            btnOnceki = new Button();
            btnSonraki = new Button();
            btnSonSayfa = new Button();
            btnIlkSayfa = new Button();
            lblSayfa = new Label();
            groupBox3 = new GroupBox();
            lblFooter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(40, 190);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(1342, 353);
            dgvUrunler.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(611, 16);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 1;
            label1.Text = "Ürün Ara:";
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top;
            txtAra.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAra.Location = new Point(491, 48);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(360, 35);
            txtAra.TabIndex = 2;
            txtAra.TextAlign = HorizontalAlignment.Center;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 70);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 16);
            label2.Name = "label2";
            label2.Size = new Size(500, 38);
            label2.TabIndex = 4;
            label2.Text = "Stok Takip Sistemi | Ürün Yönetimi";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnUrunEkle);
            groupBox1.Controls.Add(btnExcelEkle);
            groupBox1.Controls.Add(btnUrunGuncelle);
            groupBox1.Controls.Add(btnUrunSil);
            groupBox1.Controls.Add(btnUrunYenile);
            groupBox1.Location = new Point(40, 613);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1342, 75);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.FromArgb(30, 41, 59);
            btnUrunEkle.Cursor = Cursors.Hand;
            btnUrunEkle.FlatAppearance.BorderSize = 0;
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunEkle.ForeColor = Color.White;
            btnUrunEkle.Image = (Image)resources.GetObject("btnUrunEkle.Image");
            btnUrunEkle.Location = new Point(39, 18);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(210, 48);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = "  Ekle";
            btnUrunEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnExcelEkle
            // 
            btnExcelEkle.BackColor = Color.FromArgb(30, 41, 59);
            btnExcelEkle.Cursor = Cursors.Hand;
            btnExcelEkle.FlatAppearance.BorderSize = 0;
            btnExcelEkle.FlatStyle = FlatStyle.Flat;
            btnExcelEkle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExcelEkle.ForeColor = Color.White;
            btnExcelEkle.Image = (Image)resources.GetObject("btnExcelEkle.Image");
            btnExcelEkle.Location = new Point(287, 18);
            btnExcelEkle.Name = "btnExcelEkle";
            btnExcelEkle.Size = new Size(286, 48);
            btnExcelEkle.TabIndex = 4;
            btnExcelEkle.Text = " Excel Üzerinden Ekle";
            btnExcelEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcelEkle.UseVisualStyleBackColor = false;
            btnExcelEkle.Click += btnExcelEkle_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.BackColor = Color.White;
            btnUrunGuncelle.Cursor = Cursors.Hand;
            btnUrunGuncelle.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnUrunGuncelle.FlatStyle = FlatStyle.Flat;
            btnUrunGuncelle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunGuncelle.ForeColor = Color.FromArgb(30, 41, 59);
            btnUrunGuncelle.Image = (Image)resources.GetObject("btnUrunGuncelle.Image");
            btnUrunGuncelle.Location = new Point(594, 18);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(210, 48);
            btnUrunGuncelle.TabIndex = 1;
            btnUrunGuncelle.Text = "  Güncelle";
            btnUrunGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunGuncelle.UseVisualStyleBackColor = false;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.BackColor = Color.White;
            btnUrunSil.Cursor = Cursors.Hand;
            btnUrunSil.FlatAppearance.BorderColor = Color.FromArgb(225, 29, 72);
            btnUrunSil.FlatStyle = FlatStyle.Flat;
            btnUrunSil.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunSil.ForeColor = Color.FromArgb(225, 29, 72);
            btnUrunSil.Image = (Image)resources.GetObject("btnUrunSil.Image");
            btnUrunSil.Location = new Point(831, 18);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(210, 48);
            btnUrunSil.TabIndex = 2;
            btnUrunSil.Text = "  Sil";
            btnUrunSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunSil.UseVisualStyleBackColor = false;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunYenile
            // 
            btnUrunYenile.BackColor = Color.White;
            btnUrunYenile.Cursor = Cursors.Hand;
            btnUrunYenile.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnUrunYenile.FlatStyle = FlatStyle.Flat;
            btnUrunYenile.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunYenile.ForeColor = Color.FromArgb(30, 41, 59);
            btnUrunYenile.Image = (Image)resources.GetObject("btnUrunYenile.Image");
            btnUrunYenile.Location = new Point(1066, 18);
            btnUrunYenile.Name = "btnUrunYenile";
            btnUrunYenile.Size = new Size(210, 48);
            btnUrunYenile.TabIndex = 3;
            btnUrunYenile.Text = "  Yenile";
            btnUrunYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunYenile.UseVisualStyleBackColor = false;
            btnUrunYenile.Click += btnYenile_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtAra);
            groupBox2.Location = new Point(40, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1342, 95);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
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
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom;
            groupBox3.Controls.Add(btnIlkSayfa);
            groupBox3.Controls.Add(btnOnceki);
            groupBox3.Controls.Add(lblSayfa);
            groupBox3.Controls.Add(btnSonraki);
            groupBox3.Controls.Add(btnSonSayfa);
            groupBox3.Location = new Point(311, 551);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 58);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // lblFooter
            // 
            lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFooter.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.Location = new Point(1122, 668);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(270, 22);
            lblFooter.TabIndex = 13;
            lblFooter.Text = "© 2026 Dalaman Belediyesi";
            lblFooter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormUrunPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1422, 693);
            Controls.Add(lblFooter);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvUrunler);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUrunPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Ürün Yönetimi";
            Load += FormUrunListe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUrunler;
        private Label label1;
        private TextBox txtAra;
        private Panel panel1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnUrunSil;
        private Button btnUrunGuncelle;
        private Button btnUrunEkle;
        private Button btnUrunYenile;
        private GroupBox groupBox2;
        private Button btnExcelEkle;
        private Button btnOnceki;
        private Button btnSonraki;
        private Button btnSonSayfa;
        private Button btnIlkSayfa;
        private Label lblSayfa;
        private GroupBox groupBox3;
        private Label lblFooter;
    }
}


