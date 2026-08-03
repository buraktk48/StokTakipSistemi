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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AdTxtBox = new TextBox();
            SoyadTxtBox = new TextBox();
            KulAdTxtBox = new TextBox();
            SifTxtBox = new TextBox();
            BtnKayitOnayla = new Button();
            chkSifreGoster = new CheckBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label5 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Chartreuse;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 42);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "Adınız";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Chartreuse;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(37, 88);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyadınız";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Chartreuse;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 132);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adınız";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Chartreuse;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(37, 182);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            label4.Click += label4_Click;
            // 
            // AdTxtBox
            // 
            AdTxtBox.Location = new Point(202, 38);
            AdTxtBox.Name = "AdTxtBox";
            AdTxtBox.Size = new Size(153, 27);
            AdTxtBox.TabIndex = 4;
            // 
            // SoyadTxtBox
            // 
            SoyadTxtBox.Location = new Point(202, 84);
            SoyadTxtBox.Name = "SoyadTxtBox";
            SoyadTxtBox.Size = new Size(153, 27);
            SoyadTxtBox.TabIndex = 5;
            // 
            // KulAdTxtBox
            // 
            KulAdTxtBox.Location = new Point(202, 128);
            KulAdTxtBox.Name = "KulAdTxtBox";
            KulAdTxtBox.Size = new Size(153, 27);
            KulAdTxtBox.TabIndex = 6;
            // 
            // SifTxtBox
            // 
            SifTxtBox.Location = new Point(202, 175);
            SifTxtBox.Name = "SifTxtBox";
            SifTxtBox.Size = new Size(153, 27);
            SifTxtBox.TabIndex = 7;
            SifTxtBox.UseSystemPasswordChar = true;
            // 
            // BtnKayitOnayla
            // 
            BtnKayitOnayla.BackColor = Color.Cyan;
            BtnKayitOnayla.Location = new Point(52, 250);
            BtnKayitOnayla.Name = "BtnKayitOnayla";
            BtnKayitOnayla.Size = new Size(94, 29);
            BtnKayitOnayla.TabIndex = 8;
            BtnKayitOnayla.Text = "Kayıt Ol";
            BtnKayitOnayla.UseVisualStyleBackColor = false;
            BtnKayitOnayla.Click += BtnKayitOnayla_Click;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.BackColor = Color.Cyan;
            chkSifreGoster.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkSifreGoster.Location = new Point(214, 221);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(176, 27);
            chkSifreGoster.TabIndex = 9;
            chkSifreGoster.Text = "Şifreyi Göster/Gizle";
            chkSifreGoster.UseVisualStyleBackColor = false;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkSifreGoster);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnKayitOnayla);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(SifTxtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(KulAdTxtBox);
            groupBox1.Controls.Add(AdTxtBox);
            groupBox1.Controls.Add(SoyadTxtBox);
            groupBox1.Location = new Point(47, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 334);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 79);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(338, 20);
            label5.Name = "label5";
            label5.Size = new Size(220, 41);
            label5.TabIndex = 0;
            label5.Text = "KAYIT EKRANI";
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(938, 554);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "KayitForm";
            Text = "Stok Takip Sistemi - Kayıt Ol";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label5;
    }
}