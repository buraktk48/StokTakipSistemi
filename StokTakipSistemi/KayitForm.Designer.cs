namespace StokTakipSistemi
{
    partial class KayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitForm));
            pnlCard = new Panel();
            label1 = new Label();
            chkSifreGoster = new CheckBox();
            label2 = new Label();
            BtnKayitOnayla = new Button();
            label3 = new Label();
            SifTxtBox = new TextBox();
            label4 = new Label();
            KulAdTxtBox = new TextBox();
            AdTxtBox = new TextBox();
            SoyadTxtBox = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            pnlCard.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(248, 250, 252);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(chkSifreGoster);
            pnlCard.Controls.Add(label2);
            pnlCard.Controls.Add(BtnKayitOnayla);
            pnlCard.Controls.Add(label3);
            pnlCard.Controls.Add(SifTxtBox);
            pnlCard.Controls.Add(label4);
            pnlCard.Controls.Add(KulAdTxtBox);
            pnlCard.Controls.Add(AdTxtBox);
            pnlCard.Controls.Add(SoyadTxtBox);
            pnlCard.Location = new Point(390, 110);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(500, 440);
            pnlCard.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(50, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Adınız";
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Cursor = Cursors.Hand;
            chkSifreGoster.Font = new Font("Segoe UI", 10.5F);
            chkSifreGoster.ForeColor = Color.FromArgb(71, 85, 105);
            chkSifreGoster.Location = new Point(50, 315);
            chkSifreGoster.Margin = new Padding(3, 2, 3, 2);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(183, 29);
            chkSifreGoster.TabIndex = 9;
            chkSifreGoster.Text = "Şifreyi Göster/Gizle";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(50, 89);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 1;
            label2.Text = "Soyadınız";
            // 
            // BtnKayitOnayla
            // 
            BtnKayitOnayla.BackColor = Color.FromArgb(30, 41, 59);
            BtnKayitOnayla.Cursor = Cursors.Hand;
            BtnKayitOnayla.FlatAppearance.BorderSize = 0;
            BtnKayitOnayla.FlatStyle = FlatStyle.Flat;
            BtnKayitOnayla.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            BtnKayitOnayla.ForeColor = Color.White;
            BtnKayitOnayla.Location = new Point(50, 360);
            BtnKayitOnayla.Margin = new Padding(3, 2, 3, 2);
            BtnKayitOnayla.Name = "BtnKayitOnayla";
            BtnKayitOnayla.Size = new Size(400, 45);
            BtnKayitOnayla.TabIndex = 8;
            BtnKayitOnayla.Text = "Kayıt Ol";
            BtnKayitOnayla.UseVisualStyleBackColor = false;
            BtnKayitOnayla.Click += BtnKayitOnayla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F);
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(50, 164);
            label3.Name = "label3";
            label3.Size = new Size(154, 30);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adınız";
            // 
            // SifTxtBox
            // 
            SifTxtBox.Font = new Font("Segoe UI", 12.5F);
            SifTxtBox.Location = new Point(50, 270);
            SifTxtBox.Margin = new Padding(3, 2, 3, 2);
            SifTxtBox.Name = "SifTxtBox";
            SifTxtBox.Size = new Size(400, 35);
            SifTxtBox.TabIndex = 7;
            SifTxtBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.5F);
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(50, 240);
            label4.Name = "label4";
            label4.Size = new Size(54, 30);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            label4.Click += label4_Click;
            // 
            // KulAdTxtBox
            // 
            KulAdTxtBox.Font = new Font("Segoe UI", 12.5F);
            KulAdTxtBox.Location = new Point(50, 195);
            KulAdTxtBox.Margin = new Padding(3, 2, 3, 2);
            KulAdTxtBox.Name = "KulAdTxtBox";
            KulAdTxtBox.Size = new Size(400, 35);
            KulAdTxtBox.TabIndex = 6;
            // 
            // AdTxtBox
            // 
            AdTxtBox.Font = new Font("Segoe UI", 12.5F);
            AdTxtBox.Location = new Point(50, 45);
            AdTxtBox.Margin = new Padding(3, 2, 3, 2);
            AdTxtBox.Name = "AdTxtBox";
            AdTxtBox.Size = new Size(400, 35);
            AdTxtBox.TabIndex = 4;
            AdTxtBox.TextChanged += AdTxtBox_TextChanged;
            // 
            // SoyadTxtBox
            // 
            SoyadTxtBox.Font = new Font("Segoe UI", 12.5F);
            SoyadTxtBox.Location = new Point(50, 120);
            SoyadTxtBox.Margin = new Padding(3, 2, 3, 2);
            SoyadTxtBox.Name = "SoyadTxtBox";
            SoyadTxtBox.Size = new Size(400, 35);
            SoyadTxtBox.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 70);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1280, 70);
            label5.TabIndex = 0;
            label5.Text = "Stok Takip Sistemi | Kayıt Ekranı";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            Controls.Add(pnlCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "KayitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Kayıt Ol";
            Load += KayitForm_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AdTxtBox;
        private TextBox SoyadTxtBox;
        private TextBox KulAdTxtBox;
        private TextBox SifTxtBox;
        private Button BtnKayitOnayla;
        private CheckBox chkSifreGoster;
        private Panel pnlCard;
        private Panel panel1;
        private Label label5;
    }
}