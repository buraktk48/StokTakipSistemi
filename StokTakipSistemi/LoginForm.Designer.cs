namespace StokTakipSistemi
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtGirisKulAd = new TextBox();
            txtGirisSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnGiris = new Button();
            BtnKayitOl = new Button();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            lblSubTitle = new Label();
            label3 = new Label();
            pnlLoginCard = new Panel();
            lblCardTitle = new Label();
            panel1.SuspendLayout();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // txtGirisKulAd
            // 
            txtGirisKulAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGirisKulAd.Location = new Point(45, 103);
            txtGirisKulAd.Name = "txtGirisKulAd";
            txtGirisKulAd.Size = new Size(330, 34);
            txtGirisKulAd.TabIndex = 0;
            // 
            // txtGirisSifre
            // 
            txtGirisSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGirisSifre.Location = new Point(45, 178);
            txtGirisSifre.Name = "txtGirisSifre";
            txtGirisSifre.Size = new Size(330, 34);
            txtGirisSifre.TabIndex = 1;
            txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(45, 75);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(100, 116, 139);
            label2.Location = new Point(45, 150);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // BtnGiris
            // 
            BtnGiris.BackColor = Color.FromArgb(30, 41, 59);
            BtnGiris.Cursor = Cursors.Hand;
            BtnGiris.FlatAppearance.BorderSize = 0;
            BtnGiris.FlatStyle = FlatStyle.Flat;
            BtnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGiris.ForeColor = Color.White;
            BtnGiris.Image = (Image)resources.GetObject("BtnGiris.Image");
            BtnGiris.Location = new Point(45, 275);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(155, 48);
            BtnGiris.TabIndex = 4;
            BtnGiris.Text = "  Giriş Yap";
            BtnGiris.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGiris.UseVisualStyleBackColor = false;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.BackColor = Color.FromArgb(226, 232, 240);
            BtnKayitOl.Cursor = Cursors.Hand;
            BtnKayitOl.FlatAppearance.BorderSize = 0;
            BtnKayitOl.FlatStyle = FlatStyle.Flat;
            BtnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKayitOl.ForeColor = Color.FromArgb(30, 41, 59);
            BtnKayitOl.Image = (Image)resources.GetObject("BtnKayitOl.Image");
            BtnKayitOl.Location = new Point(220, 275);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(155, 48);
            BtnKayitOl.TabIndex = 5;
            BtnKayitOl.Text = "  Kayıt Ol";
            BtnKayitOl.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnKayitOl.UseVisualStyleBackColor = false;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = Color.FromArgb(71, 85, 105);
            checkBox1.Location = new Point(45, 226);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(183, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Şifreyi Göster/Gizle";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(lblSubTitle);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 70);
            panel1.TabIndex = 7;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSubTitle.ForeColor = Color.FromArgb(226, 232, 240);
            lblSubTitle.Location = new Point(950, 21);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(295, 28);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Oturum Açma Paneli";
            lblSubTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 16);
            label3.Name = "label3";
            label3.Size = new Size(350, 38);
            label3.TabIndex = 0;
            label3.Text = "Stok Takip Programı";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.White;
            pnlLoginCard.Controls.Add(lblCardTitle);
            pnlLoginCard.Controls.Add(label1);
            pnlLoginCard.Controls.Add(txtGirisKulAd);
            pnlLoginCard.Controls.Add(label2);
            pnlLoginCard.Controls.Add(txtGirisSifre);
            pnlLoginCard.Controls.Add(checkBox1);
            pnlLoginCard.Controls.Add(BtnGiris);
            pnlLoginCard.Controls.Add(BtnKayitOl);
            pnlLoginCard.Location = new Point(430, 140);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(420, 390);
            pnlLoginCard.TabIndex = 8;
            // 
            // lblCardTitle
            // 
            lblCardTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCardTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblCardTitle.Location = new Point(10, 25);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(400, 35);
            lblCardTitle.TabIndex = 7;
            lblCardTitle.Text = "Oturum Aç";
            lblCardTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 680);
            Controls.Add(pnlLoginCard);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Programı | Giriş Yap";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtGirisKulAd;
        private TextBox txtGirisSifre;
        private Label label1;
        private Label label2;
        private Button BtnGiris;
        private Button BtnKayitOl;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label label3;
        private Label lblSubTitle;
        private Panel pnlLoginCard;
        private Label lblCardTitle;
    }
}