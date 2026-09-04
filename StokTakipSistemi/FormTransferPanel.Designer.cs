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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            groupBox3 = new GroupBox();
            btnIlkSayfa = new Button();
            lblSayfa = new Label();
            btnOnceki = new Button();
            btnSonraki = new Button();
            btnSonSayfa = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransferDetay).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1422, 70);
            label1.TabIndex = 1;
            label1.Text = "Stok Takip Sistemi | Transfer Yönetimi";
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
            groupBox2.Location = new Point(40, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1342, 95);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // btnSifirla
            // 
            btnSifirla.BackColor = Color.White;
            btnSifirla.Cursor = Cursors.Hand;
            btnSifirla.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSifirla.FlatStyle = FlatStyle.Flat;
            btnSifirla.Font = new Font("Segoe UI", 10F);
            btnSifirla.ForeColor = Color.FromArgb(30, 41, 59);
            btnSifirla.Location = new Point(600, 50);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(131, 33);
            btnSifirla.TabIndex = 22;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = false;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // cboxVarisDepo
            // 
            cboxVarisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxVarisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxVarisDepo.Font = new Font("Segoe UI", 11F);
            cboxVarisDepo.FormattingEnabled = true;
            cboxVarisDepo.Location = new Point(400, 50);
            cboxVarisDepo.Name = "cboxVarisDepo";
            cboxVarisDepo.Size = new Size(180, 33);
            cboxVarisDepo.TabIndex = 9;
            cboxVarisDepo.SelectedIndexChanged += cboxVarisDepo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(400, 24);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 8;
            label4.Text = "Varış Depo:";
            // 
            // cboxCikisDepo
            // 
            cboxCikisDepo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboxCikisDepo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboxCikisDepo.Font = new Font("Segoe UI", 11F);
            cboxCikisDepo.FormattingEnabled = true;
            cboxCikisDepo.Location = new Point(200, 50);
            cboxCikisDepo.Name = "cboxCikisDepo";
            cboxCikisDepo.Size = new Size(180, 33);
            cboxCikisDepo.TabIndex = 7;
            cboxCikisDepo.SelectedIndexChanged += cboxCikisDepo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(71, 85, 105);
            label3.Location = new Point(200, 24);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 6;
            label3.Text = "Çıkış Depo:";
            label3.Click += label3_Click;
            // 
            // btnTransferYenile
            // 
            btnTransferYenile.BackColor = Color.White;
            btnTransferYenile.Cursor = Cursors.Hand;
            btnTransferYenile.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnTransferYenile.FlatStyle = FlatStyle.Flat;
            btnTransferYenile.Font = new Font("Segoe UI", 10F);
            btnTransferYenile.ForeColor = Color.FromArgb(30, 41, 59);
            btnTransferYenile.Image = (Image)resources.GetObject("btnTransferYenile.Image");
            btnTransferYenile.Location = new Point(758, 50);
            btnTransferYenile.Name = "btnTransferYenile";
            btnTransferYenile.Size = new Size(143, 33);
            btnTransferYenile.TabIndex = 5;
            btnTransferYenile.Text = " Yenile";
            btnTransferYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferYenile.UseVisualStyleBackColor = false;
            btnTransferYenile.Click += btnTransferYenile_Click;
            // 
            // btnTransferGirisi
            // 
            btnTransferGirisi.BackColor = Color.FromArgb(30, 41, 59);
            btnTransferGirisi.Cursor = Cursors.Hand;
            btnTransferGirisi.FlatAppearance.BorderSize = 0;
            btnTransferGirisi.FlatStyle = FlatStyle.Flat;
            btnTransferGirisi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTransferGirisi.ForeColor = Color.White;
            btnTransferGirisi.Image = (Image)resources.GetObject("btnTransferGirisi.Image");
            btnTransferGirisi.Location = new Point(1086, 42);
            btnTransferGirisi.Name = "btnTransferGirisi";
            btnTransferGirisi.Size = new Size(234, 45);
            btnTransferGirisi.TabIndex = 3;
            btnTransferGirisi.Text = " Yeni Transfer Girişi";
            btnTransferGirisi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferGirisi.UseVisualStyleBackColor = false;
            btnTransferGirisi.Click += btnTransferGirisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "Fiş No Ara:";
            // 
            // txtFisNoAra
            // 
            txtFisNoAra.Font = new Font("Segoe UI", 11F);
            txtFisNoAra.Location = new Point(20, 50);
            txtFisNoAra.Name = "txtFisNoAra";
            txtFisNoAra.Size = new Size(160, 32);
            txtFisNoAra.TabIndex = 2;
            txtFisNoAra.TextChanged += txtFisNoAra_TextChanged;
            // 
            // dgvTransferler
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvTransferler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransferler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvTransferler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransferler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferler.Location = new Point(40, 195);
            dgvTransferler.Name = "dgvTransferler";
            dgvTransferler.ReadOnly = true;
            dgvTransferler.RowHeadersWidth = 51;
            dgvTransferler.Size = new Size(650, 340);
            dgvTransferler.TabIndex = 9;
            dgvTransferler.CellClick += dgvTransferler_CellClick;
            // 
            // dgvTransferDetay
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dgvTransferDetay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransferDetay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransferDetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransferDetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferDetay.Location = new Point(732, 195);
            dgvTransferDetay.Name = "dgvTransferDetay";
            dgvTransferDetay.ReadOnly = true;
            dgvTransferDetay.RowHeadersWidth = 51;
            dgvTransferDetay.Size = new Size(650, 340);
            dgvTransferDetay.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(btnIlkSayfa);
            groupBox3.Controls.Add(lblSayfa);
            groupBox3.Controls.Add(btnOnceki);
            groupBox3.Controls.Add(btnSonraki);
            groupBox3.Controls.Add(btnSonSayfa);
            groupBox3.Location = new Point(40, 545);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(650, 60);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // btnIlkSayfa
            // 
            btnIlkSayfa.BackColor = Color.White;
            btnIlkSayfa.Cursor = Cursors.Hand;
            btnIlkSayfa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnIlkSayfa.FlatStyle = FlatStyle.Flat;
            btnIlkSayfa.Font = new Font("Segoe UI", 9F);
            btnIlkSayfa.ForeColor = Color.FromArgb(30, 41, 59);
            btnIlkSayfa.Location = new Point(10, 18);
            btnIlkSayfa.Name = "btnIlkSayfa";
            btnIlkSayfa.Size = new Size(80, 32);
            btnIlkSayfa.TabIndex = 10;
            btnIlkSayfa.Text = "İlk Sayfa";
            btnIlkSayfa.UseVisualStyleBackColor = false;
            btnIlkSayfa.Click += btnIlkSayfa_Click;
            // 
            // lblSayfa
            // 
            lblSayfa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSayfa.ForeColor = Color.FromArgb(71, 85, 105);
            lblSayfa.Location = new Point(190, 24);
            lblSayfa.Name = "lblSayfa";
            lblSayfa.Size = new Size(260, 20);
            lblSayfa.TabIndex = 11;
            lblSayfa.Text = "Sayfa 0/10";
            lblSayfa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOnceki
            // 
            btnOnceki.BackColor = Color.White;
            btnOnceki.Cursor = Cursors.Hand;
            btnOnceki.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnOnceki.FlatStyle = FlatStyle.Flat;
            btnOnceki.Font = new Font("Segoe UI", 9F);
            btnOnceki.ForeColor = Color.FromArgb(30, 41, 59);
            btnOnceki.Location = new Point(100, 18);
            btnOnceki.Name = "btnOnceki";
            btnOnceki.Size = new Size(80, 32);
            btnOnceki.TabIndex = 7;
            btnOnceki.Text = "Önceki";
            btnOnceki.UseVisualStyleBackColor = false;
            btnOnceki.Click += btnOnceki_Click;
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.White;
            btnSonraki.Cursor = Cursors.Hand;
            btnSonraki.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Font = new Font("Segoe UI", 9F);
            btnSonraki.ForeColor = Color.FromArgb(30, 41, 59);
            btnSonraki.Location = new Point(460, 18);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(80, 32);
            btnSonraki.TabIndex = 8;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // btnSonSayfa
            // 
            btnSonSayfa.BackColor = Color.White;
            btnSonSayfa.Cursor = Cursors.Hand;
            btnSonSayfa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSonSayfa.FlatStyle = FlatStyle.Flat;
            btnSonSayfa.Font = new Font("Segoe UI", 9F);
            btnSonSayfa.ForeColor = Color.FromArgb(30, 41, 59);
            btnSonSayfa.Location = new Point(550, 18);
            btnSonSayfa.Name = "btnSonSayfa";
            btnSonSayfa.Size = new Size(80, 32);
            btnSonSayfa.TabIndex = 9;
            btnSonSayfa.Text = "Son Sayfa";
            btnSonSayfa.UseVisualStyleBackColor = false;
            btnSonSayfa.Click += btnSonSayfa_Click;
            // 
            // FormTransferPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1422, 693);
            Controls.Add(groupBox3);
            Controls.Add(dgvTransferDetay);
            Controls.Add(dgvTransferler);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTransferPanel";
            Text = "Stok Takip Sistemi | Transfer Paneli";
            Load += FormTransferPanel_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransferDetay).EndInit();
            groupBox3.ResumeLayout(false);
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
        private GroupBox groupBox3;
        private Button btnIlkSayfa;
        private Label lblSayfa;
        private Button btnOnceki;
        private Button btnSonraki;
        private Button btnSonSayfa;
    }
}

