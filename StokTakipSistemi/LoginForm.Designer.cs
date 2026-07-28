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
            txtGirisKulAd = new TextBox();
            txtGirisSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnGiris = new Button();
            BtnKayitOl = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtGirisKulAd
            // 
            txtGirisKulAd.Location = new Point(338, 79);
            txtGirisKulAd.Name = "txtGirisKulAd";
            txtGirisKulAd.Size = new Size(138, 27);
            txtGirisKulAd.TabIndex = 0;
            // 
            // txtGirisSifre
            // 
            txtGirisSifre.Location = new Point(338, 160);
            txtGirisSifre.Name = "txtGirisSifre";
            txtGirisSifre.Size = new Size(138, 27);
            txtGirisSifre.TabIndex = 1;
            txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 82);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 160);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // BtnGiris
            // 
            BtnGiris.Location = new Point(195, 245);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(105, 29);
            BtnGiris.TabIndex = 4;
            BtnGiris.Text = "Giriş Yap";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.Location = new Point(371, 245);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(105, 29);
            BtnKayitOl.TabIndex = 5;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = true;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(338, 205);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Şifreyi Göster/Gizle";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(txtGirisSifre);
            Controls.Add(label1);
            Controls.Add(txtGirisKulAd);
            Controls.Add(label2);
            Controls.Add(BtnKayitOl);
            Controls.Add(BtnGiris);
            Name = "LoginForm";
            Text = "Giriş Yap";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGirisKulAd;
        private TextBox txtGirisSifre;
        private Label label1;
        private Label label2;
        private Button BtnGiris;
        private Button BtnKayitOl;
        private CheckBox checkBox1;
    }
}