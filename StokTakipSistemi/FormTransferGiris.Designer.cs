namespace StokTakipSistemi
{
    partial class FormTransferGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferGiris));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtFisNum = new TextBox();
            cboxVarisDepo = new ComboBox();
            cboxCikisDepo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnListeyeEkle = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            cboxUrun = new ComboBox();
            label2 = new Label();
            dgvListe = new DataGridView();
            btnTransferiKaydet = new Button();
            btnTransferSil = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1477, 64);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1477, 64);
            label1.TabIndex = 0;
            label1.Text = "TRANSFER EKLEME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFisNum);
            groupBox1.Controls.Add(cboxVarisDepo);
            groupBox1.Controls.Add(cboxCikisDepo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(10, 76);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1442, 75);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(1029, 28);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 20;
            label6.Text = "Fiş Numarası: ";
            // 
            // txtFisNum
            // 
            txtFisNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtFisNum.Location = new Point(1164, 25);
            txtFisNum.Margin = new Padding(3, 2, 3, 2);
            txtFisNum.Name = "txtFisNum";
            txtFisNum.Size = new Size(185, 33);
            txtFisNum.TabIndex = 19;
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxVarisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxVarisDepo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(698, 25);
            cboxVarisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(185, 33);
            cboxVarisDepo.TabIndex = 13;
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxCikisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxCikisDepo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(206, 28);
            cboxCikisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(185, 33);
            cboxCikisDepo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(585, 28);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 12;
            label4.Text = "Varış Depo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(62, 28);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 10;
            label3.Text = "Çıkış Depo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnListeyeEkle);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(cboxUrun);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(10, 163);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1442, 75);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // btnListeyeEkle
            // 
            btnListeyeEkle.BackColor = SystemColors.Control;
            btnListeyeEkle.FlatStyle = FlatStyle.Flat;
            btnListeyeEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnListeyeEkle.Image = (Image)resources.GetObject("btnListeyeEkle.Image");
            btnListeyeEkle.Location = new Point(1018, 26);
            btnListeyeEkle.Margin = new Padding(3, 2, 3, 2);
            btnListeyeEkle.Name = "btnListeyeEkle";
            btnListeyeEkle.Size = new Size(180, 38);
            btnListeyeEkle.TabIndex = 17;
            btnListeyeEkle.Text = "Listeye Ekle";
            btnListeyeEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListeyeEkle.UseVisualStyleBackColor = false;
            btnListeyeEkle.Click += btnListeyeEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(585, 32);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 14;
            label5.Text = "Miktar:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numericUpDown1.Location = new Point(674, 29);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(209, 33);
            numericUpDown1.TabIndex = 16;
            // 
            // cboxUrun
            // 
            cboxUrun.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxUrun.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxUrun.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxUrun.FormattingEnabled = true;
            cboxUrun.Location = new Point(213, 29);
            cboxUrun.Margin = new Padding(3, 2, 3, 2);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(178, 33);
            cboxUrun.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(24, 33);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 14;
            label2.Text = "Taşınacak Ürün:";
            // 
            // dgvListe
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dgvListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Location = new Point(10, 261);
            dgvListe.Margin = new Padding(3, 2, 3, 2);
            dgvListe.Name = "dgvListe";
            dgvListe.ReadOnly = true;
            dgvListe.RowHeadersWidth = 51;
            dgvListe.Size = new Size(1442, 266);
            dgvListe.TabIndex = 15;
            // 
            // btnTransferiKaydet
            // 
            btnTransferiKaydet.BackColor = SystemColors.Control;
            btnTransferiKaydet.FlatStyle = FlatStyle.Flat;
            btnTransferiKaydet.Font = new Font("Segoe UI", 14.25F);
            btnTransferiKaydet.Image = (Image)resources.GetObject("btnTransferiKaydet.Image");
            btnTransferiKaydet.Location = new Point(793, 542);
            btnTransferiKaydet.Margin = new Padding(3, 2, 3, 2);
            btnTransferiKaydet.Name = "btnTransferiKaydet";
            btnTransferiKaydet.Size = new Size(226, 38);
            btnTransferiKaydet.TabIndex = 18;
            btnTransferiKaydet.Text = "Transferi Kaydet";
            btnTransferiKaydet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferiKaydet.UseVisualStyleBackColor = false;
            btnTransferiKaydet.Click += btnTransferiKaydet_Click;
            // 
            // btnTransferSil
            // 
            btnTransferSil.BackColor = SystemColors.Control;
            btnTransferSil.FlatStyle = FlatStyle.Flat;
            btnTransferSil.Font = new Font("Segoe UI", 14.25F);
            btnTransferSil.Image = (Image)resources.GetObject("btnTransferSil.Image");
            btnTransferSil.Location = new Point(540, 542);
            btnTransferSil.Margin = new Padding(3, 2, 3, 2);
            btnTransferSil.Name = "btnTransferSil";
            btnTransferSil.Size = new Size(208, 38);
            btnTransferSil.TabIndex = 19;
            btnTransferSil.Text = "   Sil";
            btnTransferSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferSil.UseVisualStyleBackColor = false;
            btnTransferSil.Click += btnTransferSil_Click;
            // 
            // FormTransferGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 644);
            Controls.Add(btnTransferSil);
            Controls.Add(btnTransferiKaydet);
            Controls.Add(dgvListe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTransferGiris";
            Text = "Stok Takip Sistemi | Transfer Girişi";
            Load += FormTransferGiris_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboxVarisDepo;
        private ComboBox cboxCikisDepo;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private ComboBox cboxUrun;
        private Label label2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button btnListeyeEkle;
        private DataGridView dgvListe;
        private Button btnTransferiKaydet;
        private Label label6;
        private TextBox txtFisNum;
        private Button btnTransferSil;
    }
}

