namespace StokTakipSistemi
{
    partial class FormTransferPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferPanel));
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cboxVarisDepo = new ComboBox();
            label4 = new Label();
            cboxCikisDepo = new ComboBox();
            label3 = new Label();
            btnTransferYenile = new Button();
            button1 = new Button();
            btnTransferGirisi = new Button();
            label2 = new Label();
            txtFisNoAra = new TextBox();
            dgvTransferler = new DataGridView();
            dgvTransferDetay = new DataGridView();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransferDetay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1415, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(505, 19);
            label1.Name = "label1";
            label1.Size = new Size(325, 41);
            label1.TabIndex = 1;
            label1.Text = "TRANSFER YÖNETİMİ";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(cboxVarisDepo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboxCikisDepo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnTransferYenile);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnTransferGirisi);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtFisNoAra);
            groupBox2.Location = new Point(12, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1391, 176);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxVarisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxVarisDepo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(1059, 23);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(257, 31);
            cboxVarisDepo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(944, 24);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 8;
            label4.Text = "Varış Depo:";
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxCikisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxCikisDepo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(593, 23);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(257, 31);
            cboxCikisDepo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(493, 24);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 6;
            label3.Text = "Çıkış Depo:";
            // 
            // btnTransferYenile
            // 
            btnTransferYenile.BackColor = SystemColors.Control;
            btnTransferYenile.FlatStyle = FlatStyle.Flat;
            btnTransferYenile.Image = (Image)resources.GetObject("btnTransferYenile.Image");
            btnTransferYenile.Location = new Point(1031, 105);
            btnTransferYenile.Name = "btnTransferYenile";
            btnTransferYenile.Size = new Size(206, 50);
            btnTransferYenile.TabIndex = 5;
            btnTransferYenile.Text = " Yenile";
            btnTransferYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferYenile.UseVisualStyleBackColor = false;
            btnTransferYenile.Click += btnTransferYenile_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(574, 105);
            button1.Name = "button1";
            button1.Size = new Size(206, 50);
            button1.TabIndex = 4;
            button1.Text = " PDF Rapor Al";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnTransferGirisi
            // 
            btnTransferGirisi.BackColor = SystemColors.Control;
            btnTransferGirisi.FlatStyle = FlatStyle.Flat;
            btnTransferGirisi.Image = (Image)resources.GetObject("btnTransferGirisi.Image");
            btnTransferGirisi.Location = new Point(98, 106);
            btnTransferGirisi.Name = "btnTransferGirisi";
            btnTransferGirisi.Size = new Size(206, 50);
            btnTransferGirisi.TabIndex = 3;
            btnTransferGirisi.Text = " Yeni Transfer Girişi";
            btnTransferGirisi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferGirisi.UseVisualStyleBackColor = false;
            btnTransferGirisi.Click += btnTransferGirisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(41, 24);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 1;
            label2.Text = "Fiş No Ara:";
            // 
            // txtFisNoAra
            // 
            txtFisNoAra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtFisNoAra.Location = new Point(149, 24);
            txtFisNoAra.Name = "txtFisNoAra";
            txtFisNoAra.Size = new Size(220, 30);
            txtFisNoAra.TabIndex = 2;
            txtFisNoAra.TextChanged += txtFisNoAra_TextChanged;
            // 
            // dgvTransferler
            // 
            dgvTransferler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransferler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferler.Location = new Point(12, 305);
            dgvTransferler.Name = "dgvTransferler";
            dgvTransferler.RowHeadersWidth = 51;
            dgvTransferler.Size = new Size(1371, 286);
            dgvTransferler.TabIndex = 9;
            // 
            // dgvTransferDetay
            // 
            dgvTransferDetay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransferDetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferDetay.Location = new Point(12, 665);
            dgvTransferDetay.Name = "dgvTransferDetay";
            dgvTransferDetay.RowHeadersWidth = 51;
            dgvTransferDetay.Size = new Size(1371, 326);
            dgvTransferDetay.TabIndex = 10;
            // 
            // FormTransferPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 1055);
            Controls.Add(dgvTransferDetay);
            Controls.Add(dgvTransferler);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "FormTransferPanel";
            Text = "Stok Takip Sistemi - Transfer Paneli";
            Load += FormTransferPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransferDetay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtFisNoAra;
        private DataGridView dgvTransferler;
        private DataGridView dgvTransferDetay;
        private Button button1;
        private Button btnTransferGirisi;
        private Button btnTransferYenile;
        private Label label3;
        private ComboBox cboxVarisDepo;
        private Label label4;
        private ComboBox cboxCikisDepo;
    }
}