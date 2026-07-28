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
            label1 = new Label();
            btnManuelUrunGiris = new Button();
            btnExcelGiris = new Button();
            btnGuncelle = new Button();
            btnUrunSil = new Button();
            btnTransferGiris = new Button();
            btnTransferRapor = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnManuelUrunGiris
            // 
            btnManuelUrunGiris.Location = new Point(24, 145);
            btnManuelUrunGiris.Name = "btnManuelUrunGiris";
            btnManuelUrunGiris.Size = new Size(207, 40);
            btnManuelUrunGiris.TabIndex = 1;
            btnManuelUrunGiris.Text = "Manuel Ürün Girişi";
            btnManuelUrunGiris.UseVisualStyleBackColor = true;
            btnManuelUrunGiris.Click += btnManuelUrunGiris_Click;
            // 
            // btnExcelGiris
            // 
            btnExcelGiris.Location = new Point(24, 209);
            btnExcelGiris.Name = "btnExcelGiris";
            btnExcelGiris.Size = new Size(207, 52);
            btnExcelGiris.TabIndex = 2;
            btnExcelGiris.Text = "Excel Dosyasından Ürün Girişi";
            btnExcelGiris.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(24, 365);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(207, 40);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Ürün Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(24, 431);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(207, 40);
            btnUrunSil.TabIndex = 4;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            // 
            // btnTransferGiris
            // 
            btnTransferGiris.Location = new Point(609, 145);
            btnTransferGiris.Name = "btnTransferGiris";
            btnTransferGiris.Size = new Size(207, 40);
            btnTransferGiris.TabIndex = 5;
            btnTransferGiris.Text = "Transfer Girişi";
            btnTransferGiris.UseVisualStyleBackColor = true;
            // 
            // btnTransferRapor
            // 
            btnTransferRapor.Location = new Point(609, 215);
            btnTransferRapor.Name = "btnTransferRapor";
            btnTransferRapor.Size = new Size(207, 40);
            btnTransferRapor.TabIndex = 6;
            btnTransferRapor.Text = "Transfer Raporu Çıkart";
            btnTransferRapor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(24, 295);
            button1.Name = "button1";
            button1.Size = new Size(207, 40);
            button1.TabIndex = 7;
            button1.Text = "Ürünleri Listele";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 145);
            button2.Name = "button2";
            button2.Size = new Size(207, 40);
            button2.TabIndex = 8;
            button2.Text = "Depo Ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(314, 221);
            button3.Name = "button3";
            button3.Size = new Size(207, 40);
            button3.TabIndex = 9;
            button3.Text = "Depo Bilgisi Güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(314, 295);
            button4.Name = "button4";
            button4.Size = new Size(207, 40);
            button4.TabIndex = 10;
            button4.Text = "Depo Kaydı Sil";
            button4.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 497);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTransferRapor);
            Controls.Add(btnTransferGiris);
            Controls.Add(btnUrunSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnExcelGiris);
            Controls.Add(btnManuelUrunGiris);
            Controls.Add(label1);
            Name = "AnaForm";
            Text = "Ana Sayfa";
            Load += AnaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnManuelUrunGiris;
        private Button btnExcelGiris;
        private Button btnGuncelle;
        private Button btnUrunSil;
        private Button btnTransferGiris;
        private Button btnTransferRapor;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
