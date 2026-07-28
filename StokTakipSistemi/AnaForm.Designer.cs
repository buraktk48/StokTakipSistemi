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
            btnGuncelle.Location = new Point(291, 145);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(207, 40);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Ürün Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(291, 215);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(207, 40);
            btnUrunSil.TabIndex = 4;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            // 
            // btnTransferGiris
            // 
            btnTransferGiris.Location = new Point(536, 145);
            btnTransferGiris.Name = "btnTransferGiris";
            btnTransferGiris.Size = new Size(207, 40);
            btnTransferGiris.TabIndex = 5;
            btnTransferGiris.Text = "Transfer Girişi";
            btnTransferGiris.UseVisualStyleBackColor = true;
            // 
            // btnTransferRapor
            // 
            btnTransferRapor.Location = new Point(536, 215);
            btnTransferRapor.Name = "btnTransferRapor";
            btnTransferRapor.Size = new Size(207, 40);
            btnTransferRapor.TabIndex = 6;
            btnTransferRapor.Text = "Transfer Raporu Çıkart";
            btnTransferRapor.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
