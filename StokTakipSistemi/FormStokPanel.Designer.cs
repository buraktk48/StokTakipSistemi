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
            btnYenile = new Button();
            cboxUrun = new ComboBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtArama = new TextBox();
            groupBox3 = new GroupBox();
            btnIlkSayfa = new Button();
            lblSayfa = new Label();
            btnOnceki = new Button();
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
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1581, 79);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1581, 79);
            label5.TabIndex = 13;
            label5.Text = "DEPO-STOK YÖNETİMİ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 1;
            label1.Text = "Depo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(516, 35);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 2;
            label2.Text = "Ürün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(999, 35);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 3;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(514, 116);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 4;
            label4.Text = "İşlem";
            // 
            // cboxDepo
            // 
            cboxDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxDepo.Font = new Font("Microsoft Sans Serif", 14.25F);
            cboxDepo.FormattingEnabled = true;
            cboxDepo.Location = new Point(147, 35);
            cboxDepo.Name = "cboxDepo";
            cboxDepo.Size = new Size(308, 37);
            cboxDepo.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericUpDown1.Location = new Point(1118, 35);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(309, 39);
            numericUpDown1.TabIndex = 7;
            // 
            // rbtnStokEkle
            // 
            rbtnStokEkle.AutoSize = true;
            rbtnStokEkle.Font = new Font("Segoe UI", 14.25F);
            rbtnStokEkle.Location = new Point(633, 116);
            rbtnStokEkle.Name = "rbtnStokEkle";
            rbtnStokEkle.Size = new Size(131, 36);
            rbtnStokEkle.TabIndex = 8;
            rbtnStokEkle.TabStop = true;
            rbtnStokEkle.Text = "Stok Ekle";
            rbtnStokEkle.UseVisualStyleBackColor = true;
            // 
            // rbtnStokDus
            // 
            rbtnStokDus.AutoSize = true;
            rbtnStokDus.Font = new Font("Segoe UI", 14.25F);
            rbtnStokDus.Location = new Point(785, 116);
            rbtnStokDus.Name = "rbtnStokDus";
            rbtnStokDus.Size = new Size(129, 36);
            rbtnStokDus.TabIndex = 9;
            rbtnStokDus.TabStop = true;
            rbtnStokDus.Text = "Stok Düş";
            rbtnStokDus.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 14.25F);
            btnKaydet.Location = new Point(466, 186);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(162, 47);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 14.25F);
            btnTemizle.Location = new Point(658, 186);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(163, 47);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvDepoStok
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvDepoStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepoStok.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepoStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDepoStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepoStok.Location = new Point(12, 448);
            dgvDepoStok.Name = "dgvDepoStok";
            dgvDepoStok.ReadOnly = true;
            dgvDepoStok.RowHeadersWidth = 51;
            dgvDepoStok.Size = new Size(1512, 497);
            dgvDepoStok.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnYenile);
            groupBox1.Controls.Add(cboxUrun);
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
            groupBox1.Location = new Point(18, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1617, 250);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnYenile
            // 
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 14.25F);
            btnYenile.Location = new Point(855, 186);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(165, 47);
            btnYenile.TabIndex = 13;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // cboxUrun
            // 
            cboxUrun.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxUrun.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxUrun.Font = new Font("Microsoft Sans Serif", 14.25F);
            cboxUrun.FormattingEnabled = true;
            cboxUrun.Location = new Point(635, 35);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(308, 37);
            cboxUrun.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtArama);
            groupBox2.Location = new Point(18, 341);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1617, 101);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(518, 19);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 1;
            label6.Text = "Arama Yap: ";
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtArama.Location = new Point(518, 52);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(425, 39);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnIlkSayfa);
            groupBox3.Controls.Add(lblSayfa);
            groupBox3.Controls.Add(btnOnceki);
            groupBox3.Controls.Add(btnSonraki);
            groupBox3.Controls.Add(btnSonSayfa);
            groupBox3.Location = new Point(303, 951);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(897, 65);
            groupBox3.TabIndex = 16;
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
            // FormStokPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 1055);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvDepoStok);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStokPanel";
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
            groupBox3.PerformLayout();
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
        private ComboBox cboxUrun;
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
    }
}

