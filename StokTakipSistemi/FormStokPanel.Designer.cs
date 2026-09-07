namespace StokTakipSistemi
{
    partial class FormStokPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStokPanel));
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboxDepo = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            rbtnStokEkle = new RadioButton();
            rbtnStokDus = new RadioButton();
            btnKaydet = new Button();
            btnTemizle = new Button();
            dgvDepoStok = new DataGridView();
            groupBox1 = new GroupBox();
            btnUrunSecim = new Button();
            btnYenile = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtArama = new TextBox();
            groupBox3 = new GroupBox();
            btnIlkSayfa = new Button();
            btnOnceki = new Button();
            lblSayfa = new Label();
            btnSonraki = new Button();
            btnSonSayfa = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepoStok).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 70);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 16);
            label5.Name = "label5";
            label5.Size = new Size(600, 38);
            label5.TabIndex = 13;
            label5.Text = "Stok Takip Sistemi | Depo-Stok Yönetimi";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 1;
            label1.Text = "Depo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(430, 30);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 2;
            label2.Text = "Ürün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(820, 30);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 3;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.5F);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(1060, 30);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 4;
            label4.Text = "İşlem";
            // 
            // cboxDepo
            // 
            cboxDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxDepo.Font = new Font("Segoe UI", 12.5F);
            cboxDepo.FormattingEnabled = true;
            cboxDepo.Location = new Point(40, 65);
            cboxDepo.Name = "cboxDepo";
            cboxDepo.Size = new Size(350, 38);
            cboxDepo.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12.5F);
            numericUpDown1.Location = new Point(820, 65);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 35);
            numericUpDown1.TabIndex = 7;
            // 
            // rbtnStokEkle
            // 
            rbtnStokEkle.AutoSize = true;
            rbtnStokEkle.Font = new Font("Segoe UI", 12.5F);
            rbtnStokEkle.ForeColor = Color.FromArgb(30, 41, 59);
            rbtnStokEkle.Location = new Point(1060, 65);
            rbtnStokEkle.Name = "rbtnStokEkle";
            rbtnStokEkle.Size = new Size(116, 34);
            rbtnStokEkle.TabIndex = 8;
            rbtnStokEkle.TabStop = true;
            rbtnStokEkle.Text = "Stok Ekle";
            rbtnStokEkle.UseVisualStyleBackColor = true;
            // 
            // rbtnStokDus
            // 
            rbtnStokDus.AutoSize = true;
            rbtnStokDus.Font = new Font("Segoe UI", 12.5F);
            rbtnStokDus.ForeColor = Color.FromArgb(30, 41, 59);
            rbtnStokDus.Location = new Point(1190, 65);
            rbtnStokDus.Name = "rbtnStokDus";
            rbtnStokDus.Size = new Size(115, 34);
            rbtnStokDus.TabIndex = 9;
            rbtnStokDus.TabStop = true;
            rbtnStokDus.Text = "Stok Düş";
            rbtnStokDus.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(30, 41, 59);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(366, 140);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(180, 48);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.White;
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.FromArgb(30, 41, 59);
            btnTemizle.Location = new Point(576, 140);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(180, 48);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvDepoStok
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvDepoStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepoStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepoStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepoStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepoStok.Location = new Point(40, 415);
            dgvDepoStok.Name = "dgvDepoStok";
            dgvDepoStok.ReadOnly = true;
            dgvDepoStok.RowHeadersWidth = 51;
            dgvDepoStok.Size = new Size(1342, 320);
            dgvDepoStok.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnUrunSecim);
            groupBox1.Controls.Add(btnYenile);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(cboxDepo);
            groupBox1.Controls.Add(rbtnStokDus);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(rbtnStokEkle);
            groupBox1.Location = new Point(40, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1342, 210);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnUrunSecim
            // 
            btnUrunSecim.BackColor = Color.White;
            btnUrunSecim.Cursor = Cursors.Hand;
            btnUrunSecim.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnUrunSecim.FlatStyle = FlatStyle.Flat;
            btnUrunSecim.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            btnUrunSecim.ForeColor = Color.FromArgb(30, 41, 59);
            btnUrunSecim.Location = new Point(446, 63);
            btnUrunSecim.Name = "btnUrunSecim";
            btnUrunSecim.Size = new Size(283, 48);
            btnUrunSecim.TabIndex = 14;
            btnUrunSecim.Text = "Ürün Seçim Paneli";
            btnUrunSecim.UseVisualStyleBackColor = false;
            btnUrunSecim.Click += btnUrunSecim_Click;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.White;
            btnYenile.Cursor = Cursors.Hand;
            btnYenile.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            btnYenile.ForeColor = Color.FromArgb(30, 41, 59);
            btnYenile.Location = new Point(786, 140);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(180, 48);
            btnYenile.TabIndex = 13;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtArama);
            groupBox2.Location = new Point(40, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1342, 95);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.5F);
            label6.ForeColor = Color.FromArgb(71, 85, 105);
            label6.Location = new Point(611, 16);
            label6.Name = "label6";
            label6.Size = new Size(118, 30);
            label6.TabIndex = 1;
            label6.Text = "Arama Yap:";
            // 
            // txtArama
            // 
            txtArama.Anchor = AnchorStyles.Top;
            txtArama.Font = new Font("Segoe UI", 12.5F);
            txtArama.Location = new Point(491, 48);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(360, 35);
            txtArama.TabIndex = 2;
            txtArama.TextAlign = HorizontalAlignment.Center;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom;
            groupBox3.Controls.Add(btnIlkSayfa);
            groupBox3.Controls.Add(btnOnceki);
            groupBox3.Controls.Add(lblSayfa);
            groupBox3.Controls.Add(btnSonraki);
            groupBox3.Controls.Add(btnSonSayfa);
            groupBox3.Location = new Point(311, 745);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 58);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // btnIlkSayfa
            // 
            btnIlkSayfa.BackColor = Color.White;
            btnIlkSayfa.Cursor = Cursors.Hand;
            btnIlkSayfa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnIlkSayfa.FlatStyle = FlatStyle.Flat;
            btnIlkSayfa.Font = new Font("Segoe UI", 10F);
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
            btnOnceki.Font = new Font("Segoe UI", 10F);
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
            lblSayfa.Font = new Font("Segoe UI", 10F);
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
            btnSonraki.Font = new Font("Segoe UI", 10F);
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
            btnSonSayfa.Font = new Font("Segoe UI", 10F);
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
            // FormStokPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1422, 848);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvDepoStok);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStokPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Depo-Stok Paneli";
            Load += FormStokPanel_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepoStok).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboxDepo;
        private NumericUpDown numericUpDown1;
        private RadioButton rbtnStokEkle;
        private RadioButton rbtnStokDus;
        private Button btnKaydet;
        private Button btnTemizle;
        private DataGridView dgvDepoStok;
        private GroupBox groupBox1;
        private Label label5;
        private Button btnYenile;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtArama;
        private GroupBox groupBox3;
        private Button btnIlkSayfa;
        private Label lblSayfa;
        private Button btnOnceki;
        private Button btnSonraki;
        private Button btnSonSayfa;
        private Button btnUrunSecim;
    }
}

