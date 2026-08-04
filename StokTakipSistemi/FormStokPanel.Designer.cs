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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 79);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(508, 18);
            label5.Name = "label5";
            label5.Size = new Size(340, 41);
            label5.TabIndex = 13;
            label5.Text = "DEPO-STOK YÖNETİMİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(106, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 1;
            label1.Text = "Depo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(106, 90);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 2;
            label2.Text = "Ürün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(106, 156);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 3;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(106, 225);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 4;
            label4.Text = "İşlem";
            // 
            // cboxDepo
            // 
            cboxDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxDepo.Font = new Font("Segoe UI", 10.2F);
            cboxDepo.FormattingEnabled = true;
            cboxDepo.Location = new Point(225, 26);
            cboxDepo.Name = "cboxDepo";
            cboxDepo.Size = new Size(282, 31);
            cboxDepo.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.2F);
            numericUpDown1.Location = new Point(225, 156);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(282, 30);
            numericUpDown1.TabIndex = 7;
            // 
            // rbtnStokEkle
            // 
            rbtnStokEkle.AutoSize = true;
            rbtnStokEkle.Font = new Font("Segoe UI", 10.2F);
            rbtnStokEkle.Location = new Point(225, 225);
            rbtnStokEkle.Name = "rbtnStokEkle";
            rbtnStokEkle.Size = new Size(98, 27);
            rbtnStokEkle.TabIndex = 8;
            rbtnStokEkle.TabStop = true;
            rbtnStokEkle.Text = "Stok Ekle";
            rbtnStokEkle.UseVisualStyleBackColor = true;
            // 
            // rbtnStokDus
            // 
            rbtnStokDus.AutoSize = true;
            rbtnStokDus.Font = new Font("Segoe UI", 10.2F);
            rbtnStokDus.Location = new Point(386, 225);
            rbtnStokDus.Name = "rbtnStokDus";
            rbtnStokDus.Size = new Size(97, 27);
            rbtnStokDus.TabIndex = 9;
            rbtnStokDus.TabStop = true;
            rbtnStokDus.Text = "Stok Düş";
            rbtnStokDus.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10.2F);
            btnKaydet.Location = new Point(106, 282);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(127, 35);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10.2F);
            btnTemizle.Location = new Point(245, 282);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(127, 35);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvDepoStok
            // 
            dgvDepoStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepoStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepoStok.Location = new Point(18, 550);
            dgvDepoStok.Name = "dgvDepoStok";
            dgvDepoStok.RowHeadersWidth = 51;
            dgvDepoStok.Size = new Size(1316, 453);
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
            groupBox1.Size = new Size(1316, 338);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnYenile
            // 
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 10.2F);
            btnYenile.Location = new Point(386, 282);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(127, 35);
            btnYenile.TabIndex = 13;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // cboxUrun
            // 
            cboxUrun.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxUrun.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxUrun.FormattingEnabled = true;
            cboxUrun.Location = new Point(225, 90);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(282, 28);
            cboxUrun.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtArama);
            groupBox2.Location = new Point(18, 429);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1316, 102);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(518, 19);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 1;
            label6.Text = "Arama Yap: ";
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtArama.Location = new Point(518, 58);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(312, 30);
            txtArama.TabIndex = 2;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // FormStokPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 1024);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvDepoStok);
            Controls.Add(panel1);
            Name = "FormStokPanel";
            Text = "Stok Takip Sistemi - Depo-Stok Paneli";
            Load += FormStokPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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