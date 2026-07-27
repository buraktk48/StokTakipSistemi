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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(72, 76);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Adınız";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 122);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyadınız";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(72, 166);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adınız";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(72, 216);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            label4.Click += label4_Click;
            // 
            // AdTxtBox
            // 
            AdTxtBox.Location = new Point(203, 75);
            AdTxtBox.Name = "AdTxtBox";
            AdTxtBox.Size = new Size(153, 27);
            AdTxtBox.TabIndex = 4;
            // 
            // SoyadTxtBox
            // 
            SoyadTxtBox.Location = new Point(203, 117);
            SoyadTxtBox.Name = "SoyadTxtBox";
            SoyadTxtBox.Size = new Size(153, 27);
            SoyadTxtBox.TabIndex = 5;
            // 
            // KulAdTxtBox
            // 
            KulAdTxtBox.Location = new Point(203, 163);
            KulAdTxtBox.Name = "KulAdTxtBox";
            KulAdTxtBox.Size = new Size(153, 27);
            KulAdTxtBox.TabIndex = 6;
            // 
            // SifTxtBox
            // 
            SifTxtBox.Location = new Point(203, 209);
            SifTxtBox.Name = "SifTxtBox";
            SifTxtBox.Size = new Size(153, 27);
            SifTxtBox.TabIndex = 7;
            // 
            // BtnKayitOnayla
            // 
            BtnKayitOnayla.Location = new Point(72, 284);
            BtnKayitOnayla.Name = "BtnKayitOnayla";
            BtnKayitOnayla.Size = new Size(94, 29);
            BtnKayitOnayla.TabIndex = 8;
            BtnKayitOnayla.Text = "Kayıt Ol";
            BtnKayitOnayla.UseVisualStyleBackColor = true;
            BtnKayitOnayla.Click += BtnKayitOnayla_Click;
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnKayitOnayla);
            Controls.Add(SifTxtBox);
            Controls.Add(KulAdTxtBox);
            Controls.Add(SoyadTxtBox);
            Controls.Add(AdTxtBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KayitForm";
            Text = "KayitForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}