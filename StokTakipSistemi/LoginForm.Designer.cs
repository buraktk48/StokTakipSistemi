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
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtGirisKulAd
            // 
            txtGirisKulAd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGirisKulAd.Location = new Point(441, 92);
            txtGirisKulAd.Margin = new Padding(3, 2, 3, 2);
            txtGirisKulAd.Name = "txtGirisKulAd";
            txtGirisKulAd.Size = new Size(211, 33);
            txtGirisKulAd.TabIndex = 0;
            // 
            // txtGirisSifre
            // 
            txtGirisSifre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGirisSifre.Location = new Point(441, 147);
            txtGirisSifre.Margin = new Padding(3, 2, 3, 2);
            txtGirisSifre.Name = "txtGirisSifre";
            txtGirisSifre.Size = new Size(211, 33);
            txtGirisSifre.TabIndex = 1;
            txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(301, 94);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(301, 152);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // BtnGiris
            // 
            BtnGiris.BackColor = SystemColors.Control;
            BtnGiris.FlatStyle = FlatStyle.Flat;
            BtnGiris.Font = new Font("Segoe UI", 14.25F);
            BtnGiris.Image = (Image)resources.GetObject("BtnGiris.Image");
            BtnGiris.ImageAlign = ContentAlignment.TopLeft;
            BtnGiris.Location = new Point(301, 245);
            BtnGiris.Margin = new Padding(3, 2, 3, 2);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(166, 34);
            BtnGiris.TabIndex = 4;
            BtnGiris.Text = "Giriş Yap";
            BtnGiris.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGiris.UseVisualStyleBackColor = false;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.BackColor = SystemColors.Control;
            BtnKayitOl.FlatStyle = FlatStyle.Flat;
            BtnKayitOl.Font = new Font("Segoe UI", 14.25F);
            BtnKayitOl.Image = (Image)resources.GetObject("BtnKayitOl.Image");
            BtnKayitOl.Location = new Point(523, 245);
            BtnKayitOl.Margin = new Padding(3, 2, 3, 2);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(166, 34);
            BtnKayitOl.TabIndex = 5;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnKayitOl.UseVisualStyleBackColor = false;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(460, 194);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(192, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Şifreyi Göster/Gizle";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1473, 68);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1473, 68);
            label3.TabIndex = 0;
            label3.Text = "GİRİŞ EKRANI";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnGiris);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(BtnKayitOl);
            groupBox1.Controls.Add(txtGirisSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtGirisKulAd);
            groupBox1.Location = new Point(255, 96);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1001, 488);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1473, 640);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Stok Takip Sistemi | Giriş Yap";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
    }
}