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
            btnUrunPanel = new Button();
            btnDepoPanel = new Button();
            panel1 = new Panel();
            btnCikisYap = new Button();
            btnStok = new Button();
            btnTransferPanel = new Button();
            btnTransferRaporuCikart = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(279, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 41);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnUrunPanel
            // 
            btnUrunPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUrunPanel.FlatStyle = FlatStyle.Flat;
            btnUrunPanel.Location = new Point(56, 167);
            btnUrunPanel.Name = "btnUrunPanel";
            btnUrunPanel.Size = new Size(507, 78);
            btnUrunPanel.TabIndex = 7;
            btnUrunPanel.Text = "Ürün Paneli";
            btnUrunPanel.UseVisualStyleBackColor = true;
            btnUrunPanel.Click += btnUrunPanel_Click;
            // 
            // btnDepoPanel
            // 
            btnDepoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDepoPanel.FlatStyle = FlatStyle.Flat;
            btnDepoPanel.Location = new Point(56, 279);
            btnDepoPanel.Name = "btnDepoPanel";
            btnDepoPanel.Size = new Size(507, 78);
            btnDepoPanel.TabIndex = 8;
            btnDepoPanel.Text = "Depo Paneli";
            btnDepoPanel.UseVisualStyleBackColor = true;
            btnDepoPanel.Click += btnDepoPanel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 97);
            panel1.TabIndex = 11;
            // 
            // btnCikisYap
            // 
            btnCikisYap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.Location = new Point(56, 405);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(507, 78);
            btnCikisYap.TabIndex = 12;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnStok
            // 
            btnStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Location = new Point(624, 167);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(507, 78);
            btnStok.TabIndex = 13;
            btnStok.Text = "Stok Paneli";
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // btnTransferPanel
            // 
            btnTransferPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTransferPanel.FlatStyle = FlatStyle.Flat;
            btnTransferPanel.Location = new Point(624, 279);
            btnTransferPanel.Name = "btnTransferPanel";
            btnTransferPanel.Size = new Size(507, 78);
            btnTransferPanel.TabIndex = 14;
            btnTransferPanel.Text = "Transfer Paneli";
            btnTransferPanel.UseVisualStyleBackColor = true;
            btnTransferPanel.Click += btnTransferPanel_Click;
            // 
            // btnTransferRaporuCikart
            // 
            btnTransferRaporuCikart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTransferRaporuCikart.FlatStyle = FlatStyle.Flat;
            btnTransferRaporuCikart.Location = new Point(624, 405);
            btnTransferRaporuCikart.Name = "btnTransferRaporuCikart";
            btnTransferRaporuCikart.Size = new Size(507, 78);
            btnTransferRaporuCikart.TabIndex = 15;
            btnTransferRaporuCikart.Text = "Transfer Raporu Çıkart";
            btnTransferRaporuCikart.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 593);
            Controls.Add(btnTransferRaporuCikart);
            Controls.Add(btnTransferPanel);
            Controls.Add(btnStok);
            Controls.Add(btnCikisYap);
            Controls.Add(panel1);
            Controls.Add(btnDepoPanel);
            Controls.Add(btnUrunPanel);
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
        private Button btnCikisYap;
        private Button btnStok;
        private Button btnTransferPanel;
        private Button btnTransferRaporuCikart;
        private Button btntransferknk;
    }
}
