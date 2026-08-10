namespace StokTakipSistemi
{
    partial class FormTransferRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferRapor));
            panel1 = new Panel();
            label1 = new Label();
            cboxCikisDepo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cboxVarisDepo = new ComboBox();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboxUrun = new ComboBox();
            btnPdfRapor = new Button();
            dgvRapor = new DataGridView();
            btnListele = new Button();
            txtFisNum = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 89);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(460, 25);
            label1.Name = "label1";
            label1.Size = new Size(302, 41);
            label1.TabIndex = 0;
            label1.Text = "TRANSFER RAPORU";
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.Font = new Font("Segoe UI", 10.2F);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(46, 138);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(236, 31);
            cboxCikisDepo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(105, 112);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 7;
            label2.Text = "Çıkış Deposu ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(403, 110);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 8;
            label3.Text = "Varış Deposu";
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.Font = new Font("Segoe UI", 10.2F);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(345, 136);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(236, 31);
            cboxVarisDepo.TabIndex = 9;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.CalendarFont = new Font("Segoe UI", 10.2F);
            dtpBaslangic.Location = new Point(46, 247);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 10;
            // 
            // dtpBitis
            // 
            dtpBitis.CalendarFont = new Font("Segoe UI", 10.2F);
            dtpBitis.Location = new Point(403, 247);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(105, 221);
            label4.Name = "label4";
            label4.Size = new Size(126, 23);
            label4.TabIndex = 12;
            label4.Text = "Başlangıç Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(473, 221);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 13;
            label5.Text = "Bitiş Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(1063, 112);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 14;
            label6.Text = "Ürün";
            // 
            // cboxUrun
            // 
            cboxUrun.Font = new Font("Segoe UI", 10.2F);
            cboxUrun.FormattingEnabled = true;
            cboxUrun.Location = new Point(977, 138);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(236, 31);
            cboxUrun.TabIndex = 15;
            // 
            // btnPdfRapor
            // 
            btnPdfRapor.BackColor = SystemColors.Control;
            btnPdfRapor.FlatStyle = FlatStyle.Flat;
            btnPdfRapor.Image = (Image)resources.GetObject("btnPdfRapor.Image");
            btnPdfRapor.Location = new Point(1007, 234);
            btnPdfRapor.Name = "btnPdfRapor";
            btnPdfRapor.Size = new Size(206, 50);
            btnPdfRapor.TabIndex = 16;
            btnPdfRapor.Text = " PDF Rapor Al";
            btnPdfRapor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPdfRapor.UseVisualStyleBackColor = false;
            btnPdfRapor.Click += btnPdfRapor_Click;
            // 
            // dgvRapor
            // 
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Location = new Point(46, 338);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.Size = new Size(1167, 437);
            dgvRapor.TabIndex = 17;
            // 
            // btnListele
            // 
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Location = new Point(770, 234);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(206, 50);
            btnListele.TabIndex = 18;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // txtFisNum
            // 
            txtFisNum.Location = new Point(672, 138);
            txtFisNum.Name = "txtFisNum";
            txtFisNum.Size = new Size(236, 27);
            txtFisNum.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(731, 112);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 20;
            label7.Text = "Fiş Numarası";
            // 
            // FormTransferRapor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 798);
            Controls.Add(label7);
            Controls.Add(txtFisNum);
            Controls.Add(btnListele);
            Controls.Add(dgvRapor);
            Controls.Add(btnPdfRapor);
            Controls.Add(cboxUrun);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(cboxVarisDepo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboxCikisDepo);
            Controls.Add(panel1);
            Name = "FormTransferRapor";
            Text = "Stok Takip Sistemi | Transfer Rapor Paneli";
            Load += FormTransferRapor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cboxCikisDepo;
        private Label label2;
        private Label label3;
        private ComboBox cboxVarisDepo;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboxUrun;
        private Button btnPdfRapor;
        private DataGridView dgvRapor;
        private Button btnListele;
        private TextBox txtFisNum;
        private Label label7;
    }
}