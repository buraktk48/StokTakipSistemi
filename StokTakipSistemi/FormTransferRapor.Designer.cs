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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnSifirla = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(1474, 67);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1474, 67);
            label1.TabIndex = 0;
            label1.Text = "TRANSFER RAPORU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.Font = new Font("Segoe UI", 14.25F);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(95, 45);
            cboxCikisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(207, 33);
            cboxCikisDepo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(124, 18);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 7;
            label2.Text = "Çıkış Deposu ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(497, 13);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 8;
            label3.Text = "Varış Deposu";
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.Font = new Font("Segoe UI", 14.25F);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(464, 41);
            cboxVarisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(207, 33);
            cboxVarisDepo.TabIndex = 9;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.CalendarFont = new Font("Segoe UI", 10.2F);
            dtpBaslangic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpBaslangic.Location = new Point(42, 124);
            dtpBaslangic.Margin = new Padding(3, 2, 3, 2);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(219, 33);
            dtpBaslangic.TabIndex = 10;
            // 
            // dtpBitis
            // 
            dtpBitis.CalendarFont = new Font("Segoe UI", 10.2F);
            dtpBitis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpBitis.Location = new Point(354, 124);
            dtpBitis.Margin = new Padding(3, 2, 3, 2);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(219, 33);
            dtpBitis.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(74, 97);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 12;
            label4.Text = "Başlangıç Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(410, 97);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 13;
            label5.Text = "Bitiş Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(1249, 13);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 14;
            label6.Text = "Ürün";
            // 
            // cboxUrun
            // 
            cboxUrun.Font = new Font("Segoe UI", 14.25F);
            cboxUrun.FormattingEnabled = true;
            cboxUrun.Location = new Point(1180, 40);
            cboxUrun.Margin = new Padding(3, 2, 3, 2);
            cboxUrun.Name = "cboxUrun";
            cboxUrun.Size = new Size(207, 33);
            cboxUrun.TabIndex = 15;
            // 
            // btnPdfRapor
            // 
            btnPdfRapor.BackColor = SystemColors.Control;
            btnPdfRapor.FlatStyle = FlatStyle.Flat;
            btnPdfRapor.Font = new Font("Segoe UI", 14.25F);
            btnPdfRapor.Image = (Image)resources.GetObject("btnPdfRapor.Image");
            btnPdfRapor.Location = new Point(1107, 119);
            btnPdfRapor.Margin = new Padding(3, 2, 3, 2);
            btnPdfRapor.Name = "btnPdfRapor";
            btnPdfRapor.Size = new Size(180, 38);
            btnPdfRapor.TabIndex = 16;
            btnPdfRapor.Text = " PDF Rapor Al";
            btnPdfRapor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPdfRapor.UseVisualStyleBackColor = false;
            btnPdfRapor.Click += btnPdfRapor_Click;
            // 
            // dgvRapor
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dgvRapor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvRapor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Location = new Point(40, 268);
            dgvRapor.Margin = new Padding(3, 2, 3, 2);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.ReadOnly = true;
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRapor.Size = new Size(1397, 365);
            dgvRapor.TabIndex = 17;
            // 
            // btnListele
            // 
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 14.25F);
            btnListele.Location = new Point(883, 119);
            btnListele.Margin = new Padding(3, 2, 3, 2);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(180, 38);
            btnListele.TabIndex = 18;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // txtFisNum
            // 
            txtFisNum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtFisNum.Location = new Point(809, 40);
            txtFisNum.Margin = new Padding(3, 2, 3, 2);
            txtFisNum.Name = "txtFisNum";
            txtFisNum.Size = new Size(207, 33);
            txtFisNum.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(847, 12);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 20;
            label7.Text = "Fiş Numarası";
            // 
            // btnSifirla
            // 
            btnSifirla.FlatStyle = FlatStyle.Flat;
            btnSifirla.Font = new Font("Segoe UI", 14.25F);
            btnSifirla.Location = new Point(657, 119);
            btnSifirla.Margin = new Padding(3, 2, 3, 2);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(180, 38);
            btnSifirla.TabIndex = 21;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtFisNum);
            groupBox1.Controls.Add(btnSifirla);
            groupBox1.Controls.Add(cboxCikisDepo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(cboxVarisDepo);
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Controls.Add(btnPdfRapor);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(cboxUrun);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(10, 81);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1454, 169);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // FormTransferRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 649);
            Controls.Add(groupBox1);
            Controls.Add(dgvRapor);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTransferRapor";
            Text = "Stok Takip Sistemi | Transfer Rapor Paneli";
            Load += FormTransferRapor_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Button btnSifirla;
        private GroupBox groupBox1;
    }
}

