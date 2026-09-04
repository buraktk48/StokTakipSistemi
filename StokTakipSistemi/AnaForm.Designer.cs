namespace StokTakipSistemi
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            label1 = new Label();
            lblHeaderUser = new Label();
            btnUrunPanel = new Button();
            btnDepoPanel = new Button();
            panel1 = new Panel();
            btnCikisYap = new Button();
            btnStok = new Button();
            btnTransferPanel = new Button();
            btnTransferRaporuCikart = new Button();
            panel2 = new Panel();
            lblToplamDepo = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblStokluUrun = new Label();
            label5 = new Label();
            panel4 = new Panel();
            lblSonTransfer = new Label();
            lblTransferDepo = new Label();
            label7 = new Label();
            lblFooter = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1463, 93);
            label1.TabIndex = 0;
            label1.Text = "Stok Takip Programı";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHeaderUser
            // 
            lblHeaderUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHeaderUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHeaderUser.ForeColor = Color.FromArgb(226, 232, 240);
            lblHeaderUser.Location = new Point(800, 28);
            lblHeaderUser.Name = "lblHeaderUser";
            lblHeaderUser.Size = new Size(623, 37);
            lblHeaderUser.TabIndex = 1;
            lblHeaderUser.Text = "Hoş Geldin, Kullanıcı | 24 Mayıs 2024, 11:45";
            lblHeaderUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUrunPanel
            // 
            btnUrunPanel.BackColor = Color.FromArgb(241, 245, 249);
            btnUrunPanel.Cursor = Cursors.Hand;
            btnUrunPanel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnUrunPanel.FlatStyle = FlatStyle.Flat;
            btnUrunPanel.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunPanel.ForeColor = Color.FromArgb(30, 41, 59);
            btnUrunPanel.Image = (Image)resources.GetObject("btnUrunPanel.Image");
            btnUrunPanel.Location = new Point(160, 367);
            btnUrunPanel.Name = "btnUrunPanel";
            btnUrunPanel.Size = new Size(526, 87);
            btnUrunPanel.TabIndex = 7;
            btnUrunPanel.Text = "       Ürün Yönetimi";
            btnUrunPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunPanel.UseVisualStyleBackColor = false;
            btnUrunPanel.Click += btnUrunPanel_Click;
            // 
            // btnDepoPanel
            // 
            btnDepoPanel.BackColor = Color.FromArgb(241, 245, 249);
            btnDepoPanel.Cursor = Cursors.Hand;
            btnDepoPanel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDepoPanel.FlatStyle = FlatStyle.Flat;
            btnDepoPanel.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepoPanel.ForeColor = Color.FromArgb(30, 41, 59);
            btnDepoPanel.Image = (Image)resources.GetObject("btnDepoPanel.Image");
            btnDepoPanel.Location = new Point(160, 473);
            btnDepoPanel.Name = "btnDepoPanel";
            btnDepoPanel.Size = new Size(526, 87);
            btnDepoPanel.TabIndex = 8;
            btnDepoPanel.Text = "       Depo Yönetimi";
            btnDepoPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoPanel.UseVisualStyleBackColor = false;
            btnDepoPanel.Click += btnDepoPanel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(lblHeaderUser);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1463, 93);
            panel1.TabIndex = 11;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.White;
            btnCikisYap.Cursor = Cursors.Hand;
            btnCikisYap.FlatAppearance.BorderColor = Color.FromArgb(225, 29, 72);
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikisYap.ForeColor = Color.FromArgb(225, 29, 72);
            btnCikisYap.Image = (Image)resources.GetObject("btnCikisYap.Image");
            btnCikisYap.Location = new Point(560, 707);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(343, 77);
            btnCikisYap.TabIndex = 12;
            btnCikisYap.Text = "       Çıkış Yap";
            btnCikisYap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnStok
            // 
            btnStok.BackColor = Color.FromArgb(241, 245, 249);
            btnStok.Cursor = Cursors.Hand;
            btnStok.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnStok.ForeColor = Color.FromArgb(30, 41, 59);
            btnStok.Image = (Image)resources.GetObject("btnStok.Image");
            btnStok.Location = new Point(160, 580);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(526, 87);
            btnStok.TabIndex = 13;
            btnStok.Text = "       Stok Takip Paneli";
            btnStok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStok.UseVisualStyleBackColor = false;
            btnStok.Click += btnStok_Click;
            // 
            // btnTransferPanel
            // 
            btnTransferPanel.BackColor = Color.FromArgb(241, 245, 249);
            btnTransferPanel.Cursor = Cursors.Hand;
            btnTransferPanel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnTransferPanel.FlatStyle = FlatStyle.Flat;
            btnTransferPanel.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTransferPanel.ForeColor = Color.FromArgb(30, 41, 59);
            btnTransferPanel.Image = (Image)resources.GetObject("btnTransferPanel.Image");
            btnTransferPanel.Location = new Point(777, 367);
            btnTransferPanel.Name = "btnTransferPanel";
            btnTransferPanel.Size = new Size(526, 87);
            btnTransferPanel.TabIndex = 14;
            btnTransferPanel.Text = "       Transfer İşlemleri";
            btnTransferPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferPanel.UseVisualStyleBackColor = false;
            btnTransferPanel.Click += btnTransferPanel_Click;
            // 
            // btnTransferRaporuCikart
            // 
            btnTransferRaporuCikart.BackColor = Color.FromArgb(241, 245, 249);
            btnTransferRaporuCikart.Cursor = Cursors.Hand;
            btnTransferRaporuCikart.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnTransferRaporuCikart.FlatStyle = FlatStyle.Flat;
            btnTransferRaporuCikart.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTransferRaporuCikart.ForeColor = Color.FromArgb(30, 41, 59);
            btnTransferRaporuCikart.Image = (Image)resources.GetObject("btnTransferRaporuCikart.Image");
            btnTransferRaporuCikart.Location = new Point(777, 473);
            btnTransferRaporuCikart.Name = "btnTransferRaporuCikart";
            btnTransferRaporuCikart.Size = new Size(526, 87);
            btnTransferRaporuCikart.TabIndex = 15;
            btnTransferRaporuCikart.Text = "       Transfer Raporları";
            btnTransferRaporuCikart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferRaporuCikart.UseVisualStyleBackColor = false;
            btnTransferRaporuCikart.Click += btnTransferRaporuCikart_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblToplamDepo);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(74, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 180);
            panel2.TabIndex = 16;
            // 
            // lblToplamDepo
            // 
            lblToplamDepo.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamDepo.ForeColor = Color.FromArgb(30, 41, 59);
            lblToplamDepo.Location = new Point(11, 67);
            lblToplamDepo.Name = "lblToplamDepo";
            lblToplamDepo.Size = new Size(383, 80);
            lblToplamDepo.TabIndex = 1;
            lblToplamDepo.Text = "-";
            lblToplamDepo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(100, 116, 139);
            label2.Location = new Point(11, 24);
            label2.Name = "label2";
            label2.Size = new Size(383, 33);
            label2.TabIndex = 0;
            label2.Text = "Toplam Depo Sayısı";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblStokluUrun);
            panel3.Controls.Add(label5);
            panel3.Font = new Font("Segoe UI", 12F);
            panel3.Location = new Point(528, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 180);
            panel3.TabIndex = 17;
            // 
            // lblStokluUrun
            // 
            lblStokluUrun.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStokluUrun.ForeColor = Color.FromArgb(30, 41, 59);
            lblStokluUrun.Location = new Point(11, 67);
            lblStokluUrun.Name = "lblStokluUrun";
            lblStokluUrun.Size = new Size(383, 80);
            lblStokluUrun.TabIndex = 1;
            lblStokluUrun.Text = "-";
            lblStokluUrun.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label5.Location = new Point(11, 24);
            label5.Name = "label5";
            label5.Size = new Size(383, 33);
            label5.TabIndex = 0;
            label5.Text = "Toplam Stoklu Ürün Sayısı";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblSonTransfer);
            panel4.Controls.Add(lblTransferDepo);
            panel4.Controls.Add(label7);
            panel4.Font = new Font("Segoe UI", 12F);
            panel4.Location = new Point(983, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 180);
            panel4.TabIndex = 18;
            // 
            // lblSonTransfer
            // 
            lblSonTransfer.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSonTransfer.ForeColor = Color.FromArgb(30, 41, 59);
            lblSonTransfer.Location = new Point(11, 96);
            lblSonTransfer.Name = "lblSonTransfer";
            lblSonTransfer.Size = new Size(383, 47);
            lblSonTransfer.TabIndex = 1;
            lblSonTransfer.Text = "Yükleniyor, --:--";
            lblSonTransfer.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTransferDepo
            // 
            lblTransferDepo.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTransferDepo.ForeColor = Color.FromArgb(71, 85, 105);
            lblTransferDepo.Location = new Point(11, 59);
            lblTransferDepo.Name = "lblTransferDepo";
            lblTransferDepo.Size = new Size(383, 32);
            lblTransferDepo.TabIndex = 2;
            lblTransferDepo.Text = "Yükleniyor -> Yükleniyor";
            lblTransferDepo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(100, 116, 139);
            label7.Location = new Point(11, 20);
            label7.Name = "label7";
            label7.Size = new Size(383, 32);
            label7.TabIndex = 0;
            label7.Text = "Son Transfer";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFooter
            // 
            lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFooter.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.Location = new Point(1120, 853);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(309, 29);
            lblFooter.TabIndex = 19;
            lblFooter.Text = "© 2024 Kurumsal Yazılım A.Ş.";
            lblFooter.TextAlign = ContentAlignment.MiddleRight;
            lblFooter.Click += lblFooter_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1463, 907);
            Controls.Add(lblFooter);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnTransferRaporuCikart);
            Controls.Add(btnTransferPanel);
            Controls.Add(btnStok);
            Controls.Add(btnCikisYap);
            Controls.Add(panel1);
            Controls.Add(btnDepoPanel);
            Controls.Add(btnUrunPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Programı | Ana Sayfa";
            FormClosing += AnaForm_FormClosing;
            Load += AnaForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblHeaderUser;
        private Button btnUrunPanel;
        private Button btnDepoPanel;
        private Panel panel1;
        private Button btnCikisYap;
        private Button btnStok;
        private Button btnTransferPanel;
        private Button btnTransferRaporuCikart;
        private Panel panel2;
        private Label lblToplamDepo;
        private Label label2;
        private Panel panel3;
        private Label lblStokluUrun;
        private Label label5;
        private Panel panel4;
        private Label lblSonTransfer;
        private Label label7;
        private Label lblTransferDepo;
        private Label lblFooter;
        private System.Windows.Forms.Timer timer1;
    }
}

