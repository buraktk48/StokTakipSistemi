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
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 70);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1422, 70);
            label1.TabIndex = 0;
            label1.Text = "Stok Takip Sistemi | Transfer Girişi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFisNum);
            groupBox1.Controls.Add(cboxVarisDepo);
            groupBox1.Controls.Add(cboxCikisDepo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(40, 85);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1342, 95);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.5F);
            label6.ForeColor = Color.FromArgb(71, 85, 105);
            label6.Location = new Point(770, 38);
            label6.Name = "label6";
            label6.Size = new Size(143, 30);
            label6.TabIndex = 20;
            label6.Text = "Fiş Numarası: ";
            // 
            // txtFisNum
            // 
            txtFisNum.Font = new Font("Segoe UI", 12.5F);
            txtFisNum.Location = new Point(918, 38);
            txtFisNum.Margin = new Padding(3, 2, 3, 2);
            txtFisNum.Name = "txtFisNum";
            txtFisNum.Size = new Size(220, 35);
            txtFisNum.TabIndex = 19;
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxVarisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxVarisDepo.Font = new Font("Segoe UI", 12.5F);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(505, 34);
            cboxVarisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(220, 38);
            cboxVarisDepo.TabIndex = 13;
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxCikisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxCikisDepo.Font = new Font("Segoe UI", 12.5F);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(135, 34);
            cboxCikisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(220, 38);
            cboxCikisDepo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.5F);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(400, 38);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 12;
            label4.Text = "Varış Depo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(30, 38);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 10;
            label3.Text = "Çıkış Depo:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnListeyeEkle);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(cboxUrun);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(40, 195);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1342, 95);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // btnListeyeEkle
            // 
            btnListeyeEkle.BackColor = Color.White;
            btnListeyeEkle.Cursor = Cursors.Hand;
            btnListeyeEkle.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnListeyeEkle.FlatStyle = FlatStyle.Flat;
            btnListeyeEkle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnListeyeEkle.ForeColor = Color.FromArgb(30, 41, 59);
            btnListeyeEkle.Image = (Image)resources.GetObject("btnListeyeEkle.Image");
            btnListeyeEkle.Location = new Point(760, 32);
            btnListeyeEkle.Margin = new Padding(3, 2, 3, 2);
            btnListeyeEkle.Name = "btnListeyeEkle";
            btnListeyeEkle.Size = new Size(180, 37);
            btnListeyeEkle.TabIndex = 17;
            btnListeyeEkle.Text = "Listeye Ekle";
            btnListeyeEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListeyeEkle.UseVisualStyleBackColor = false;
            btnListeyeEkle.Click += btnListeyeEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.5F);
            label5.ForeColor = Color.FromArgb(71, 85, 105);
            label5.Location = new Point(460, 38);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 14;
            label5.Text = "Miktar:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12.5F);
            numericUpDown1.Location = new Point(545, 34);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 35);
            numericUpDown1.TabIndex = 16;
            // 
            // cboxUrun
            // 
            cboxUrun.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxUrun.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxUrun.Font = new Font("Segoe UI", 12.5F);
            cboxUrun.FormattingEnabled = true;
            cboxUrun.Location = new Point(190, 34);
            cboxUrun.Margin = new Padding(3, 2, 3, 2);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(250, 38);
            cboxUrun.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(30, 38);
            label2.Name = "label2";
            label2.Size = new Size(157, 30);
            label2.TabIndex = 14;
            label2.Text = "Taşınacak Ürün:";
            // 
            // dgvListe
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dgvListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvListe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Location = new Point(40, 305);
            dgvListe.Margin = new Padding(3, 2, 3, 2);
            dgvListe.Name = "dgvListe";
            dgvListe.ReadOnly = true;
            dgvListe.RowHeadersWidth = 51;
            dgvListe.Size = new Size(1342, 280);
            dgvListe.TabIndex = 15;
            // 
            // btnTransferiKaydet
            // 
            btnTransferiKaydet.Anchor = AnchorStyles.Bottom;
            btnTransferiKaydet.BackColor = Color.FromArgb(30, 41, 59);
            btnTransferiKaydet.Cursor = Cursors.Hand;
            btnTransferiKaydet.FlatAppearance.BorderSize = 0;
            btnTransferiKaydet.FlatStyle = FlatStyle.Flat;
            btnTransferiKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTransferiKaydet.ForeColor = Color.White;
            btnTransferiKaydet.Image = (Image)resources.GetObject("btnTransferiKaydet.Image");
            btnTransferiKaydet.Location = new Point(700, 605);
            btnTransferiKaydet.Margin = new Padding(3, 2, 3, 2);
            btnTransferiKaydet.Name = "btnTransferiKaydet";
            btnTransferiKaydet.Size = new Size(220, 45);
            btnTransferiKaydet.TabIndex = 18;
            btnTransferiKaydet.Text = "Transferi Kaydet";
            btnTransferiKaydet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferiKaydet.UseVisualStyleBackColor = false;
            btnTransferiKaydet.Click += btnTransferiKaydet_Click;
            // 
            // btnTransferSil
            // 
            btnTransferSil.Anchor = AnchorStyles.Bottom;
            btnTransferSil.BackColor = Color.White;
            btnTransferSil.Cursor = Cursors.Hand;
            btnTransferSil.FlatAppearance.BorderColor = Color.FromArgb(225, 29, 72);
            btnTransferSil.FlatStyle = FlatStyle.Flat;
            btnTransferSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTransferSil.ForeColor = Color.FromArgb(225, 29, 72);
            btnTransferSil.Image = (Image)resources.GetObject("btnTransferSil.Image");
            btnTransferSil.Location = new Point(480, 605);
            btnTransferSil.Margin = new Padding(3, 2, 3, 2);
            btnTransferSil.Name = "btnTransferSil";
            btnTransferSil.Size = new Size(200, 45);
            btnTransferSil.TabIndex = 19;
            btnTransferSil.Text = "   Sil";
            btnTransferSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferSil.UseVisualStyleBackColor = false;
            btnTransferSil.Click += btnTransferSil_Click;
            // 
            // FormTransferGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1422, 693);
            Controls.Add(btnTransferSil);
            Controls.Add(btnTransferiKaydet);
            Controls.Add(dgvListe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTransferGiris";
            StartPosition = FormStartPosition.CenterScreen;
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

