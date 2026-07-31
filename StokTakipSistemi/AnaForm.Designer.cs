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
            btnTransferGiris = new Button();
            btnTransferRapor = new Button();
            btnUrunPanel = new Button();
            btnDepoPanel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(279, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 41);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnTransferGiris
            // 
            btnTransferGiris.Location = new Point(947, 186);
            btnTransferGiris.Name = "btnTransferGiris";
            btnTransferGiris.Size = new Size(207, 40);
            btnTransferGiris.TabIndex = 5;
            btnTransferGiris.Text = "Transfer Girişi";
            btnTransferGiris.UseVisualStyleBackColor = true;
            // 
            // btnTransferRapor
            // 
            btnTransferRapor.Location = new Point(947, 265);
            btnTransferRapor.Name = "btnTransferRapor";
            btnTransferRapor.Size = new Size(207, 40);
            btnTransferRapor.TabIndex = 6;
            btnTransferRapor.Text = "Transfer Raporu Çıkart";
            btnTransferRapor.UseVisualStyleBackColor = true;
            // 
            // btnUrunPanel
            // 
            btnUrunPanel.FlatStyle = FlatStyle.Flat;
            btnUrunPanel.Location = new Point(85, 167);
            btnUrunPanel.Name = "btnUrunPanel";
            btnUrunPanel.Size = new Size(507, 78);
            btnUrunPanel.TabIndex = 7;
            btnUrunPanel.Text = "Ürün Paneli";
            btnUrunPanel.UseVisualStyleBackColor = true;
            btnUrunPanel.Click += btnUrunPanel_Click;
            // 
            // btnDepoPanel
            // 
            btnDepoPanel.FlatStyle = FlatStyle.Flat;
            btnDepoPanel.Location = new Point(85, 280);
            btnDepoPanel.Name = "btnDepoPanel";
            btnDepoPanel.Size = new Size(507, 78);
            btnDepoPanel.TabIndex = 8;
            btnDepoPanel.Text = "Depo Paneli";
            btnDepoPanel.UseVisualStyleBackColor = true;
            btnDepoPanel.Click += btnDepoPanel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 97);
            panel1.TabIndex = 11;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 593);
            Controls.Add(panel1);
            Controls.Add(btnDepoPanel);
            Controls.Add(btnUrunPanel);
            Controls.Add(btnTransferRapor);
            Controls.Add(btnTransferGiris);
            Name = "AnaForm";
            Text = "Stok Takip Sistemi - Ana Sayfa";
            Load += AnaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnTransferGiris;
        private Button btnTransferRapor;
        private Button btnUrunPanel;
        private Button btnDepoPanel;
        private Panel panel1;
    }
}
