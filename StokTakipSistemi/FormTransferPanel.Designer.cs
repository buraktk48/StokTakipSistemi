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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSifirla = new Button();
            cboxVarisDepo = new ComboBox();
            label4 = new Label();
            cboxCikisDepo = new ComboBox();
            label3 = new Label();
            btnTransferYenile = new Button();
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
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1466, 62);
            label1.TabIndex = 1;
            label1.Text = "TRANSFER YÖNETİMİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnSifirla);
            groupBox2.Controls.Add(cboxVarisDepo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboxCikisDepo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnTransferYenile);
            groupBox2.Controls.Add(btnTransferGirisi);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtFisNoAra);
            groupBox2.Location = new Point(10, 67);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1445, 138);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // btnSifirla
            // 
            btnSifirla.FlatStyle = FlatStyle.Flat;
            btnSifirla.Font = new Font("Segoe UI", 14.25F);
            btnSifirla.Location = new Point(782, 85);
            btnSifirla.Margin = new Padding(3, 2, 3, 2);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(189, 38);
            btnSifirla.TabIndex = 22;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxVarisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxVarisDepo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(1128, 21);
            cboxVarisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(225, 33);
            cboxVarisDepo.TabIndex = 9;
            cboxVarisDepo.SelectedIndexChanged += cboxVarisDepo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(998, 21);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 8;
            label4.Text = "Varış Depo:";
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxCikisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxCikisDepo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(619, 21);
            cboxCikisDepo.Margin = new Padding(3, 2, 3, 2);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(225, 33);
            cboxCikisDepo.TabIndex = 7;
            cboxCikisDepo.SelectedIndexChanged += cboxCikisDepo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(495, 22);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 6;
            label3.Text = "Çıkış Depo:";
            label3.Click += label3_Click;
            // 
            // btnTransferYenile
            // 
            btnTransferYenile.BackColor = SystemColors.Control;
            btnTransferYenile.FlatStyle = FlatStyle.Flat;
            btnTransferYenile.Font = new Font("Segoe UI", 14.25F);
            btnTransferYenile.Image = (Image)resources.GetObject("btnTransferYenile.Image");
            btnTransferYenile.Location = new Point(529, 85);
            btnTransferYenile.Margin = new Padding(3, 2, 3, 2);
            btnTransferYenile.Name = "btnTransferYenile";
            btnTransferYenile.Size = new Size(197, 38);
            btnTransferYenile.TabIndex = 5;
            btnTransferYenile.Text = " Yenile";
            btnTransferYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferYenile.UseVisualStyleBackColor = false;
            btnTransferYenile.Click += btnTransferYenile_Click;
            // 
            // btnTransferGirisi
            // 
            btnTransferGirisi.BackColor = SystemColors.Control;
            btnTransferGirisi.FlatStyle = FlatStyle.Flat;
            btnTransferGirisi.Font = new Font("Segoe UI", 14.25F);
            btnTransferGirisi.Image = (Image)resources.GetObject("btnTransferGirisi.Image");
            btnTransferGirisi.Location = new Point(240, 85);
            btnTransferGirisi.Margin = new Padding(3, 2, 3, 2);
            btnTransferGirisi.Name = "btnTransferGirisi";
            btnTransferGirisi.Size = new Size(227, 38);
            btnTransferGirisi.TabIndex = 3;
            btnTransferGirisi.Text = " Yeni Transfer Girişi";
            btnTransferGirisi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferGirisi.UseVisualStyleBackColor = false;
            btnTransferGirisi.Click += btnTransferGirisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(22, 19);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "Fiş No Ara:";
            // 
            // txtFisNoAra
            // 
            txtFisNoAra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtFisNoAra.Location = new Point(130, 18);
            txtFisNoAra.Margin = new Padding(3, 2, 3, 2);
            txtFisNoAra.Name = "txtFisNoAra";
            txtFisNoAra.Size = new Size(213, 33);
            txtFisNoAra.TabIndex = 2;
            txtFisNoAra.TextChanged += txtFisNoAra_TextChanged;
            // 
            // dgvTransferler
            // 
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLight;
            dgvTransferler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvTransferler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransferler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferler.Location = new Point(10, 229);
            dgvTransferler.Margin = new Padding(3, 2, 3, 2);
            dgvTransferler.Name = "dgvTransferler";
            dgvTransferler.ReadOnly = true;
            dgvTransferler.RowHeadersWidth = 51;
            dgvTransferler.Size = new Size(1428, 214);
            dgvTransferler.TabIndex = 9;
            dgvTransferler.CellClick += dgvTransferler_CellClick;
            // 
            // dgvTransferDetay
            // 
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLight;
            dgvTransferDetay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvTransferDetay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransferDetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferDetay.Location = new Point(10, 499);
            dgvTransferDetay.Margin = new Padding(3, 2, 3, 2);
            dgvTransferDetay.Name = "dgvTransferDetay";
            dgvTransferDetay.ReadOnly = true;
            dgvTransferDetay.RowHeadersWidth = 51;
            dgvTransferDetay.Size = new Size(1428, 244);
            dgvTransferDetay.TabIndex = 10;
            // 
            // FormTransferPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 791);
            Controls.Add(dgvTransferDetay);
            Controls.Add(dgvTransferler);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTransferPanel";
            Text = "Stok Takip Sistemi | Transfer Paneli";
            Load += FormTransferPanel_Load;
            panel1.ResumeLayout(false);
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
        private Button btnTransferGirisi;
        private Button btnTransferYenile;
        private Label label3;
        private ComboBox cboxVarisDepo;
        private Label label4;
        private ComboBox cboxCikisDepo;
        private Button btnSifirla;
    }
}

