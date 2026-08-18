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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepoStok).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 59);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1475, 59);
            label5.TabIndex = 13;
            label5.Text = "DEPO-STOK YÖNETİMİ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(93, 20);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 1;
            label1.Text = "Depo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(93, 68);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Ürün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(93, 117);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(93, 169);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 4;
            label4.Text = "İşlem";
            // 
            // cboxDepo
            // 
            cboxDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxDepo.Font = new Font("Microsoft Sans Serif", 14.25F);
            cboxDepo.FormattingEnabled = true;
            cboxDepo.Location = new Point(197, 20);
            cboxDepo.Margin = new Padding(3, 2, 3, 2);
            cboxDepo.Name = "cboxDepo";
            cboxDepo.Size = new Size(270, 32);
            cboxDepo.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericUpDown1.Location = new Point(197, 117);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(270, 33);
            numericUpDown1.TabIndex = 7;
            // 
            // rbtnStokEkle
            // 
            rbtnStokEkle.AutoSize = true;
            rbtnStokEkle.Font = new Font("Segoe UI", 14.25F);
            rbtnStokEkle.Location = new Point(197, 169);
            rbtnStokEkle.Margin = new Padding(3, 2, 3, 2);
            rbtnStokEkle.Name = "rbtnStokEkle";
            rbtnStokEkle.Size = new Size(104, 29);
            rbtnStokEkle.TabIndex = 8;
            rbtnStokEkle.TabStop = true;
            rbtnStokEkle.Text = "Stok Ekle";
            rbtnStokEkle.UseVisualStyleBackColor = true;
            // 
            // rbtnStokDus
            // 
            rbtnStokDus.AutoSize = true;
            rbtnStokDus.Font = new Font("Segoe UI", 14.25F);
            rbtnStokDus.Location = new Point(338, 169);
            rbtnStokDus.Margin = new Padding(3, 2, 3, 2);
            rbtnStokDus.Name = "rbtnStokDus";
            rbtnStokDus.Size = new Size(102, 29);
            rbtnStokDus.TabIndex = 9;
            rbtnStokDus.TabStop = true;
            rbtnStokDus.Text = "Stok Düş";
            rbtnStokDus.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 14.25F);
            btnKaydet.Location = new Point(63, 202);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(142, 35);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 14.25F);
            btnTemizle.Location = new Point(231, 202);
            btnTemizle.Margin = new Padding(3, 2, 3, 2);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(143, 35);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvDepoStok
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dgvDepoStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDepoStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepoStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepoStok.Location = new Point(16, 412);
            dgvDepoStok.Margin = new Padding(3, 2, 3, 2);
            dgvDepoStok.Name = "dgvDepoStok";
            dgvDepoStok.ReadOnly = true;
            dgvDepoStok.RowHeadersWidth = 51;
            dgvDepoStok.Size = new Size(1415, 368);
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
            groupBox1.Location = new Point(16, 64);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1415, 254);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnYenile
            // 
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 14.25F);
            btnYenile.Location = new Point(403, 202);
            btnYenile.Margin = new Padding(3, 2, 3, 2);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(144, 35);
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
            cboxUrun.Location = new Point(197, 68);
            cboxUrun.Margin = new Padding(3, 2, 3, 2);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(270, 32);
            cboxUrun.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtArama);
            groupBox2.Location = new Point(16, 322);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1415, 76);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(453, 14);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 1;
            label6.Text = "Arama Yap: ";
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtArama.Location = new Point(453, 39);
            txtArama.Margin = new Padding(3, 2, 3, 2);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(372, 33);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // FormStokPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 796);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvDepoStok);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
    }
}

