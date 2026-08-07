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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            label1 = new Label();
            btnUrunPanel = new Button();
            btnDepoPanel = new Button();
            panel1 = new Panel();
            btnCikisYap = new Button();
            btnStok = new Button();
            btnTransferPanel = new Button();
            btnTransferRaporuCikart = new Button();
            panel2 = new Panel();
            lblToplamDepo = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblStokluUrun = new Label();
            label5 = new Label();
            panel4 = new Panel();
            lblTransferDepo = new Label();
            lblSonTransfer = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            btnUrunPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUrunPanel.FlatStyle = FlatStyle.Flat;
            btnUrunPanel.Font = new Font("Segoe UI", 10.2F);
            btnUrunPanel.Image = (Image)resources.GetObject("btnUrunPanel.Image");
            btnUrunPanel.Location = new Point(121, 354);
            btnUrunPanel.Name = "btnUrunPanel";
            btnUrunPanel.Size = new Size(449, 80);
            btnUrunPanel.TabIndex = 7;
            btnUrunPanel.Text = "           Ürün Paneli";
            btnUrunPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunPanel.UseVisualStyleBackColor = true;
            btnUrunPanel.Click += btnUrunPanel_Click;
            // 
            // btnDepoPanel
            // 
            btnDepoPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDepoPanel.FlatStyle = FlatStyle.Flat;
            btnDepoPanel.Font = new Font("Segoe UI", 10.2F);
            btnDepoPanel.Image = (Image)resources.GetObject("btnDepoPanel.Image");
            btnDepoPanel.Location = new Point(121, 466);
            btnDepoPanel.Name = "btnDepoPanel";
            btnDepoPanel.Size = new Size(449, 80);
            btnDepoPanel.TabIndex = 8;
            btnDepoPanel.Text = "           Depo Paneli";
            btnDepoPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            panel1.Size = new Size(1335, 97);
            panel1.TabIndex = 11;
            // 
            // btnCikisYap
            // 
            btnCikisYap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.Font = new Font("Segoe UI", 10.2F);
            btnCikisYap.Image = (Image)resources.GetObject("btnCikisYap.Image");
            btnCikisYap.Location = new Point(689, 592);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(449, 80);
            btnCikisYap.TabIndex = 12;
            btnCikisYap.Text = "            Çıkış Yap";
            btnCikisYap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnStok
            // 
            btnStok.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Segoe UI", 10.2F);
            btnStok.Image = (Image)resources.GetObject("btnStok.Image");
            btnStok.Location = new Point(121, 592);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(449, 80);
            btnStok.TabIndex = 13;
            btnStok.Text = "          Stok Paneli";
            btnStok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // btnTransferPanel
            // 
            btnTransferPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTransferPanel.FlatStyle = FlatStyle.Flat;
            btnTransferPanel.Font = new Font("Segoe UI", 10.2F);
            btnTransferPanel.Image = (Image)resources.GetObject("btnTransferPanel.Image");
            btnTransferPanel.Location = new Point(689, 354);
            btnTransferPanel.Name = "btnTransferPanel";
            btnTransferPanel.Size = new Size(449, 80);
            btnTransferPanel.TabIndex = 14;
            btnTransferPanel.Text = "           Transfer Paneli";
            btnTransferPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferPanel.UseVisualStyleBackColor = true;
            btnTransferPanel.Click += btnTransferPanel_Click;
            // 
            // btnTransferRaporuCikart
            // 
            btnTransferRaporuCikart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTransferRaporuCikart.FlatStyle = FlatStyle.Flat;
            btnTransferRaporuCikart.Font = new Font("Segoe UI", 10.2F);
            btnTransferRaporuCikart.Image = (Image)resources.GetObject("btnTransferRaporuCikart.Image");
            btnTransferRaporuCikart.Location = new Point(689, 466);
            btnTransferRaporuCikart.Name = "btnTransferRaporuCikart";
            btnTransferRaporuCikart.Size = new Size(449, 80);
            btnTransferRaporuCikart.TabIndex = 15;
            btnTransferRaporuCikart.Text = "      Transfer Raporu Çıkart";
            btnTransferRaporuCikart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransferRaporuCikart.UseVisualStyleBackColor = true;
            btnTransferRaporuCikart.Click += btnTransferRaporuCikart_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblToplamDepo);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(81, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 169);
            panel2.TabIndex = 16;
            // 
            // lblToplamDepo
            // 
            lblToplamDepo.AutoSize = true;
            lblToplamDepo.Font = new Font("Segoe UI", 10.2F);
            lblToplamDepo.Location = new Point(125, 107);
            lblToplamDepo.Name = "lblToplamDepo";
            lblToplamDepo.Size = new Size(19, 23);
            lblToplamDepo.TabIndex = 1;
            lblToplamDepo.Text = "T";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(74, 32);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 0;
            label2.Text = "Toplam Depo Sayısı";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lblStokluUrun);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(505, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 169);
            panel3.TabIndex = 17;
            // 
            // lblStokluUrun
            // 
            lblStokluUrun.AutoSize = true;
            lblStokluUrun.Font = new Font("Segoe UI", 10.2F);
            lblStokluUrun.Location = new Point(138, 107);
            lblStokluUrun.Name = "lblStokluUrun";
            lblStokluUrun.Size = new Size(19, 23);
            lblStokluUrun.TabIndex = 1;
            lblStokluUrun.Text = "T";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(49, 32);
            label5.Name = "label5";
            label5.Size = new Size(205, 23);
            label5.TabIndex = 0;
            label5.Text = "Toplam Stoklu Ürün Sayısı";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(lblTransferDepo);
            panel4.Controls.Add(lblSonTransfer);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(936, 119);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 169);
            panel4.TabIndex = 18;
            // 
            // lblTransferDepo
            // 
            lblTransferDepo.AutoSize = true;
            lblTransferDepo.Font = new Font("Segoe UI", 10.2F);
            lblTransferDepo.Location = new Point(73, 121);
            lblTransferDepo.Name = "lblTransferDepo";
            lblTransferDepo.Size = new Size(19, 23);
            lblTransferDepo.TabIndex = 2;
            lblTransferDepo.Text = "T";
            // 
            // lblSonTransfer
            // 
            lblSonTransfer.AutoSize = true;
            lblSonTransfer.Font = new Font("Segoe UI", 10.2F);
            lblSonTransfer.Location = new Point(82, 87);
            lblSonTransfer.Name = "lblSonTransfer";
            lblSonTransfer.Size = new Size(19, 23);
            lblSonTransfer.TabIndex = 1;
            lblSonTransfer.Text = "T";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(100, 32);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 0;
            label7.Text = "Son Transfer";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 736);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnTransferRaporuCikart);
            Controls.Add(btnTransferPanel);
            Controls.Add(btnStok);
            Controls.Add(btnCikisYap);
            Controls.Add(panel1);
            Controls.Add(btnDepoPanel);
            Controls.Add(btnUrunPanel);
            Name = "AnaForm";
            Text = "Stok Takip Sistemi | Ana Sayfa";
            Load += AnaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnUrunPanel;
        private Button btnDepoPanel;
        private Panel panel1;
        private Button btnCikisYap;
        private Button btnStok;
        private Button btnTransferPanel;
        private Button btnTransferRaporuCikart;
        private Panel panel2;
        private Label lblToplamDepo;
        private Label label2;
        private Panel panel3;
        private Label lblStokluUrun;
        private Label label5;
        private Panel panel4;
        private Label lblSonTransfer;
        private Label label7;
        private Label lblTransferDepo;
    }
}
