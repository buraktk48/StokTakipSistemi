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
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1475, 73);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUrunPanel
            // 
            btnUrunPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUrunPanel.FlatStyle = FlatStyle.Flat;
            btnUrunPanel.Font = new Font("Segoe UI", 14.25F);
            btnUrunPanel.Image = (Image)resources.GetObject("btnUrunPanel.Image");
            btnUrunPanel.Location = new Point(204, 340);
            btnUrunPanel.Margin = new Padding(3, 2, 3, 2);
            btnUrunPanel.Name = "btnUrunPanel";
            btnUrunPanel.Size = new Size(427, 69);
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
            btnDepoPanel.Font = new Font("Segoe UI", 14.25F);
            btnDepoPanel.Image = (Image)resources.GetObject("btnDepoPanel.Image");
            btnDepoPanel.Location = new Point(204, 433);
            btnDepoPanel.Margin = new Padding(3, 2, 3, 2);
            btnDepoPanel.Name = "btnDepoPanel";
            btnDepoPanel.Size = new Size(427, 69);
            btnDepoPanel.TabIndex = 8;
            btnDepoPanel.Text = "           Depo Paneli";
            btnDepoPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoPanel.UseVisualStyleBackColor = true;
            btnDepoPanel.Click += btnDepoPanel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 73);
            panel1.TabIndex = 11;
            // 
            // btnCikisYap
            // 
            btnCikisYap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.Font = new Font("Segoe UI", 14.25F);
            btnCikisYap.Image = (Image)resources.GetObject("btnCikisYap.Image");
            btnCikisYap.Location = new Point(758, 527);
            btnCikisYap.Margin = new Padding(3, 2, 3, 2);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(427, 69);
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
            btnStok.Font = new Font("Segoe UI", 14.25F);
            btnStok.Image = (Image)resources.GetObject("btnStok.Image");
            btnStok.Location = new Point(204, 527);
            btnStok.Margin = new Padding(3, 2, 3, 2);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(427, 69);
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
            btnTransferPanel.Font = new Font("Segoe UI", 14.25F);
            btnTransferPanel.Image = (Image)resources.GetObject("btnTransferPanel.Image");
            btnTransferPanel.Location = new Point(758, 340);
            btnTransferPanel.Margin = new Padding(3, 2, 3, 2);
            btnTransferPanel.Name = "btnTransferPanel";
            btnTransferPanel.Size = new Size(427, 69);
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
            btnTransferRaporuCikart.Font = new Font("Segoe UI", 14.25F);
            btnTransferRaporuCikart.Image = (Image)resources.GetObject("btnTransferRaporuCikart.Image");
            btnTransferRaporuCikart.Location = new Point(758, 433);
            btnTransferRaporuCikart.Margin = new Padding(3, 2, 3, 2);
            btnTransferRaporuCikart.Name = "btnTransferRaporuCikart";
            btnTransferRaporuCikart.Size = new Size(427, 69);
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
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(131, 103);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 127);
            panel2.TabIndex = 16;
            // 
            // lblToplamDepo
            // 
            lblToplamDepo.AutoSize = true;
            lblToplamDepo.Font = new Font("Segoe UI", 14.25F);
            lblToplamDepo.Location = new Point(109, 80);
            lblToplamDepo.Name = "lblToplamDepo";
            lblToplamDepo.Size = new Size(22, 25);
            lblToplamDepo.TabIndex = 1;
            lblToplamDepo.Text = "T";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(65, 24);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 0;
            label2.Text = "Toplam Depo Sayısı";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lblStokluUrun);
            panel3.Controls.Add(label5);
            panel3.Font = new Font("Segoe UI", 12F);
            panel3.Location = new Point(575, 103);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 127);
            panel3.TabIndex = 17;
            // 
            // lblStokluUrun
            // 
            lblStokluUrun.AutoSize = true;
            lblStokluUrun.Font = new Font("Segoe UI", 14.25F);
            lblStokluUrun.Location = new Point(121, 80);
            lblStokluUrun.Name = "lblStokluUrun";
            lblStokluUrun.Size = new Size(22, 25);
            lblStokluUrun.TabIndex = 1;
            lblStokluUrun.Text = "T";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(50, 24);
            label5.Name = "label5";
            label5.Size = new Size(228, 25);
            label5.TabIndex = 0;
            label5.Text = "Toplam Stoklu Ürün Sayısı";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(lblTransferDepo);
            panel4.Controls.Add(lblSonTransfer);
            panel4.Controls.Add(label7);
            panel4.Font = new Font("Segoe UI", 12F);
            panel4.Location = new Point(1031, 103);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(312, 127);
            panel4.TabIndex = 18;
            // 
            // lblTransferDepo
            // 
            lblTransferDepo.AutoSize = true;
            lblTransferDepo.Font = new Font("Segoe UI", 14.25F);
            lblTransferDepo.Location = new Point(64, 91);
            lblTransferDepo.Name = "lblTransferDepo";
            lblTransferDepo.Size = new Size(22, 25);
            lblTransferDepo.TabIndex = 2;
            lblTransferDepo.Text = "T";
            // 
            // lblSonTransfer
            // 
            lblSonTransfer.AutoSize = true;
            lblSonTransfer.Font = new Font("Segoe UI", 14.25F);
            lblSonTransfer.Location = new Point(72, 65);
            lblSonTransfer.Name = "lblSonTransfer";
            lblSonTransfer.Size = new Size(22, 25);
            lblSonTransfer.TabIndex = 1;
            lblSonTransfer.Text = "T";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(96, 21);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 0;
            label7.Text = "Son Transfer";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 661);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaForm";
            Text = "Stok Takip Sistemi | Ana Sayfa";
            Load += AnaForm_Load;
            panel1.ResumeLayout(false);
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

