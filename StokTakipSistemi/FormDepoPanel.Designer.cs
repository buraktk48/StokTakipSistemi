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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            lblSayfa = new Label();
            btnOnceki = new Button();
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
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dgvDepolar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDepolar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepolar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDepolar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepolar.Location = new Point(54, 257);
            dgvDepolar.Name = "dgvDepolar";
            dgvDepolar.ReadOnly = true;
            dgvDepolar.RowHeadersWidth = 51;
            dgvDepolar.Size = new Size(1577, 456);
            dgvDepolar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1696, 77);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1696, 77);
            label2.TabIndex = 5;
            label2.Text = "DEPO YÖNETİMİ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDepoEkle
            // 
            btnDepoEkle.FlatStyle = FlatStyle.Flat;
            btnDepoEkle.Font = new Font("Segoe UI", 14.25F);
            btnDepoEkle.Image = (Image)resources.GetObject("btnDepoEkle.Image");
            btnDepoEkle.Location = new Point(206, 27);
            btnDepoEkle.Name = "btnDepoEkle";
            btnDepoEkle.Size = new Size(229, 51);
            btnDepoEkle.TabIndex = 2;
            btnDepoEkle.Text = "Ekle";
            btnDepoEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoEkle.UseVisualStyleBackColor = true;
            btnDepoEkle.Click += btnDepoEkle_Click;
            // 
            // btnDepoYenile
            // 
            btnDepoYenile.FlatStyle = FlatStyle.Flat;
            btnDepoYenile.Font = new Font("Segoe UI", 14.25F);
            btnDepoYenile.Image = (Image)resources.GetObject("btnDepoYenile.Image");
            btnDepoYenile.Location = new Point(1184, 27);
            btnDepoYenile.Name = "btnDepoYenile";
            btnDepoYenile.Size = new Size(229, 51);
            btnDepoYenile.TabIndex = 3;
            btnDepoYenile.Text = " Yenile";
            btnDepoYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoYenile.UseVisualStyleBackColor = true;
            btnDepoYenile.Click += btnDepoYenile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDepoSil);
            groupBox1.Controls.Add(btnDepoGuncelle);
            groupBox1.Controls.Add(btnDepoYenile);
            groupBox1.Controls.Add(btnDepoEkle);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(10, 794);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1672, 94);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnDepoSil
            // 
            btnDepoSil.FlatStyle = FlatStyle.Flat;
            btnDepoSil.Font = new Font("Segoe UI", 14.25F);
            btnDepoSil.Image = (Image)resources.GetObject("btnDepoSil.Image");
            btnDepoSil.Location = new Point(867, 27);
            btnDepoSil.Name = "btnDepoSil";
            btnDepoSil.Size = new Size(229, 51);
            btnDepoSil.TabIndex = 5;
            btnDepoSil.Text = "  Sil";
            btnDepoSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoSil.UseVisualStyleBackColor = true;
            btnDepoSil.Click += btnDepoSil_Click;
            // 
            // btnDepoGuncelle
            // 
            btnDepoGuncelle.FlatStyle = FlatStyle.Flat;
            btnDepoGuncelle.Font = new Font("Segoe UI", 14.25F);
            btnDepoGuncelle.Image = (Image)resources.GetObject("btnDepoGuncelle.Image");
            btnDepoGuncelle.Location = new Point(512, 27);
            btnDepoGuncelle.Name = "btnDepoGuncelle";
            btnDepoGuncelle.Size = new Size(229, 51);
            btnDepoGuncelle.TabIndex = 4;
            btnDepoGuncelle.Text = " Güncelle";
            btnDepoGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoGuncelle.UseVisualStyleBackColor = true;
            btnDepoGuncelle.Click += btnDepoGuncelle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtDepoAra);
            groupBox2.Location = new Point(54, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1577, 117);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(530, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 1;
            label1.Text = "Depo Ara:";
            // 
            // txtDepoAra
            // 
            txtDepoAra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDepoAra.Location = new Point(530, 61);
            txtDepoAra.Name = "txtDepoAra";
            txtDepoAra.Size = new Size(487, 39);
            txtDepoAra.TabIndex = 2;
            txtDepoAra.TextChanged += txtDepoAra_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnIlkSayfa);
            groupBox3.Controls.Add(lblSayfa);
            groupBox3.Controls.Add(btnOnceki);
            groupBox3.Controls.Add(btnSonraki);
            groupBox3.Controls.Add(btnSonSayfa);
            groupBox3.Location = new Point(374, 723);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(897, 65);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // btnIlkSayfa
            // 
            btnIlkSayfa.BackColor = SystemColors.Control;
            btnIlkSayfa.FlatStyle = FlatStyle.Flat;
            btnIlkSayfa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIlkSayfa.Location = new Point(47, 21);
            btnIlkSayfa.Name = "btnIlkSayfa";
            btnIlkSayfa.Size = new Size(109, 32);
            btnIlkSayfa.TabIndex = 10;
            btnIlkSayfa.Text = "İlk Sayfa";
            btnIlkSayfa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIlkSayfa.UseVisualStyleBackColor = false;
            // 
            // lblSayfa
            // 
            lblSayfa.AutoSize = true;
            lblSayfa.Location = new Point(330, 28);
            lblSayfa.Name = "lblSayfa";
            lblSayfa.Size = new Size(79, 20);
            lblSayfa.TabIndex = 11;
            lblSayfa.Text = "Sayfa 0/10";
            // 
            // btnOnceki
            // 
            btnOnceki.BackColor = SystemColors.Control;
            btnOnceki.FlatStyle = FlatStyle.Flat;
            btnOnceki.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOnceki.Location = new Point(192, 21);
            btnOnceki.Name = "btnOnceki";
            btnOnceki.Size = new Size(109, 32);
            btnOnceki.TabIndex = 7;
            btnOnceki.Text = "<Önceki<";
            btnOnceki.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOnceki.UseVisualStyleBackColor = false;
            btnOnceki.Click += btnOnceki_Click;
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = SystemColors.Control;
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSonraki.Location = new Point(571, 21);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(109, 32);
            btnSonraki.TabIndex = 8;
            btnSonraki.Text = ">Sonraki>";
            btnSonraki.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // btnSonSayfa
            // 
            btnSonSayfa.BackColor = SystemColors.Control;
            btnSonSayfa.FlatStyle = FlatStyle.Flat;
            btnSonSayfa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSonSayfa.Location = new Point(732, 21);
            btnSonSayfa.Name = "btnSonSayfa";
            btnSonSayfa.Size = new Size(109, 32);
            btnSonSayfa.TabIndex = 9;
            btnSonSayfa.Text = "Son Sayfa";
            btnSonSayfa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSonSayfa.UseVisualStyleBackColor = false;
            // 
            // FormDepoPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1696, 892);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgvDepolar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDepoPanel";
            Text = "Stok Takip Sistemi | Depo Paneli";
            Load += FormDepoPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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

