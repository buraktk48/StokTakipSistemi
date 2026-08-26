namespace StokTakipSistemi
{
    partial class FormDepoPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepoPanel));
            dgvDepolar = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            btnDepoEkle = new Button();
            btnDepoYenile = new Button();
            groupBox1 = new GroupBox();
            btnDepoSil = new Button();
            btnDepoGuncelle = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtDepoAra = new TextBox();
            groupBox3 = new GroupBox();
            btnIlkSayfa = new Button();
            btnOnceki = new Button();
            lblSayfa = new Label();
            btnSonraki = new Button();
            btnSonSayfa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDepolar
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvDepolar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepolar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepolar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepolar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepolar.Location = new Point(40, 190);
            dgvDepolar.Name = "dgvDepolar";
            dgvDepolar.ReadOnly = true;
            dgvDepolar.RowHeadersWidth = 51;
            dgvDepolar.Size = new Size(1342, 353);
            dgvDepolar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 70);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 16);
            label2.Name = "label2";
            label2.Size = new Size(500, 38);
            label2.TabIndex = 5;
            label2.Text = "Stok Takip Sistemi | Depo Yönetimi";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDepoEkle
            // 
            btnDepoEkle.BackColor = Color.FromArgb(30, 41, 59);
            btnDepoEkle.Cursor = Cursors.Hand;
            btnDepoEkle.FlatAppearance.BorderSize = 0;
            btnDepoEkle.FlatStyle = FlatStyle.Flat;
            btnDepoEkle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepoEkle.ForeColor = Color.White;
            btnDepoEkle.Image = (Image)resources.GetObject("btnDepoEkle.Image");
            btnDepoEkle.Location = new Point(133, 21);
            btnDepoEkle.Name = "btnDepoEkle";
            btnDepoEkle.Size = new Size(210, 48);
            btnDepoEkle.TabIndex = 2;
            btnDepoEkle.Text = "  Ekle";
            btnDepoEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoEkle.UseVisualStyleBackColor = false;
            btnDepoEkle.Click += btnDepoEkle_Click;
            // 
            // btnDepoYenile
            // 
            btnDepoYenile.BackColor = Color.White;
            btnDepoYenile.Cursor = Cursors.Hand;
            btnDepoYenile.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDepoYenile.FlatStyle = FlatStyle.Flat;
            btnDepoYenile.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepoYenile.ForeColor = Color.FromArgb(30, 41, 59);
            btnDepoYenile.Image = (Image)resources.GetObject("btnDepoYenile.Image");
            btnDepoYenile.Location = new Point(969, 18);
            btnDepoYenile.Name = "btnDepoYenile";
            btnDepoYenile.Size = new Size(210, 48);
            btnDepoYenile.TabIndex = 3;
            btnDepoYenile.Text = "  Yenile";
            btnDepoYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoYenile.UseVisualStyleBackColor = false;
            btnDepoYenile.Click += btnDepoYenile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDepoSil);
            groupBox1.Controls.Add(btnDepoGuncelle);
            groupBox1.Controls.Add(btnDepoYenile);
            groupBox1.Controls.Add(btnDepoEkle);
            groupBox1.Location = new Point(40, 613);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1342, 75);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnDepoSil
            // 
            btnDepoSil.BackColor = Color.White;
            btnDepoSil.Cursor = Cursors.Hand;
            btnDepoSil.FlatAppearance.BorderColor = Color.FromArgb(225, 29, 72);
            btnDepoSil.FlatStyle = FlatStyle.Flat;
            btnDepoSil.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepoSil.ForeColor = Color.FromArgb(225, 29, 72);
            btnDepoSil.Image = (Image)resources.GetObject("btnDepoSil.Image");
            btnDepoSil.Location = new Point(706, 20);
            btnDepoSil.Name = "btnDepoSil";
            btnDepoSil.Size = new Size(210, 48);
            btnDepoSil.TabIndex = 5;
            btnDepoSil.Text = "  Sil";
            btnDepoSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoSil.UseVisualStyleBackColor = false;
            btnDepoSil.Click += btnDepoSil_Click;
            // 
            // btnDepoGuncelle
            // 
            btnDepoGuncelle.BackColor = Color.White;
            btnDepoGuncelle.Cursor = Cursors.Hand;
            btnDepoGuncelle.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDepoGuncelle.FlatStyle = FlatStyle.Flat;
            btnDepoGuncelle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepoGuncelle.ForeColor = Color.FromArgb(30, 41, 59);
            btnDepoGuncelle.Image = (Image)resources.GetObject("btnDepoGuncelle.Image");
            btnDepoGuncelle.Location = new Point(417, 21);
            btnDepoGuncelle.Name = "btnDepoGuncelle";
            btnDepoGuncelle.Size = new Size(210, 48);
            btnDepoGuncelle.TabIndex = 4;
            btnDepoGuncelle.Text = "  Güncelle";
            btnDepoGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoGuncelle.UseVisualStyleBackColor = false;
            btnDepoGuncelle.Click += btnDepoGuncelle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtDepoAra);
            groupBox2.Location = new Point(40, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1342, 95);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(611, 16);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 1;
            label1.Text = "Depo Ara:";
            // 
            // txtDepoAra
            // 
            txtDepoAra.Anchor = AnchorStyles.Top;
            txtDepoAra.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDepoAra.Location = new Point(491, 48);
            txtDepoAra.Name = "txtDepoAra";
            txtDepoAra.Size = new Size(360, 35);
            txtDepoAra.TabIndex = 2;
            txtDepoAra.TextAlign = HorizontalAlignment.Center;
            txtDepoAra.TextChanged += txtDepoAra_TextChanged;
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
            btnIlkSayfa.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnOnceki.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            lblSayfa.Text = "Sayfa 0/10";
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
            btnSonraki.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnSonSayfa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSonSayfa.UseVisualStyleBackColor = false;
            btnSonSayfa.Click += btnSonSayfa_Click;
            // 
            // FormDepoPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1422, 693);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgvDepolar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDepoPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Depo Paneli";
            Load += FormDepoPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDepolar;
        private Panel panel1;
        private Button btnDepoEkle;
        private Button btnDepoYenile;
        private GroupBox groupBox1;
        private Button btnDepoSil;
        private Button btnDepoGuncelle;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtDepoAra;
        private GroupBox groupBox3;
        private Button btnIlkSayfa;
        private Label lblSayfa;
        private Button btnOnceki;
        private Button btnSonraki;
        private Button btnSonSayfa;
    }
}

