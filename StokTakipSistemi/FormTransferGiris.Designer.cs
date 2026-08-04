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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
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
            dataGridView1 = new DataGridView();
            btnTransferiKaydet = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 86);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(417, 25);
            label1.Name = "label1";
            label1.Size = new Size(289, 41);
            label1.TabIndex = 0;
            label1.Text = "TRANSFER EKLEME";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboxVarisDepo);
            groupBox1.Controls.Add(cboxCikisDepo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1148, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxVarisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxVarisDepo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(724, 38);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(178, 31);
            cboxVarisDepo.TabIndex = 13;
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxCikisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxCikisDepo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(258, 38);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(203, 31);
            cboxCikisDepo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(609, 39);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 12;
            label4.Text = "Varış Depo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(130, 39);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
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
            groupBox2.Location = new Point(12, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1148, 100);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // btnListeyeEkle
            // 
            btnListeyeEkle.BackColor = SystemColors.Control;
            btnListeyeEkle.FlatStyle = FlatStyle.Flat;
            btnListeyeEkle.Image = (Image)resources.GetObject("btnListeyeEkle.Image");
            btnListeyeEkle.Location = new Point(867, 28);
            btnListeyeEkle.Name = "btnListeyeEkle";
            btnListeyeEkle.Size = new Size(206, 50);
            btnListeyeEkle.TabIndex = 17;
            btnListeyeEkle.Text = "Listeye Ekle";
            btnListeyeEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListeyeEkle.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(466, 41);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 14;
            label5.Text = "Miktar:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.2F);
            numericUpDown1.Location = new Point(550, 39);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(211, 30);
            numericUpDown1.TabIndex = 16;
            // 
            // cboxUrun
            // 
            cboxUrun.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxUrun.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxUrun.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxUrun.FormattingEnabled = true;
            cboxUrun.Location = new Point(181, 39);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(203, 31);
            cboxUrun.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(47, 42);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 14;
            label2.Text = "Taşınacak Ürün:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1162, 354);
            dataGridView1.TabIndex = 15;
            // 
            // btnTransferiKaydet
            // 
            btnTransferiKaydet.BackColor = SystemColors.Control;
            btnTransferiKaydet.FlatStyle = FlatStyle.Flat;
            btnTransferiKaydet.Image = (Image)resources.GetObject("btnTransferiKaydet.Image");
            btnTransferiKaydet.Location = new Point(879, 722);
            btnTransferiKaydet.Name = "btnTransferiKaydet";
            btnTransferiKaydet.Size = new Size(206, 50);
            btnTransferiKaydet.TabIndex = 18;
            btnTransferiKaydet.Text = "Transferi Kaydet";
            btnTransferiKaydet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferiKaydet.UseVisualStyleBackColor = false;
            // 
            // FormTransferGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 784);
            Controls.Add(btnTransferiKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormTransferGiris";
            Text = "Stok Takip Sistemi - Transfer Girişi";
            Load += FormTransferGiris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnTransferiKaydet;
    }
}