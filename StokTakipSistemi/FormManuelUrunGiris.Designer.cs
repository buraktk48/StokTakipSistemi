namespace StokTakipSistemi
{
    partial class FormManuelUrunGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManuelUrunGiris));
            pnlCard = new Panel();
            TxtUrunKodu = new TextBox();
            TxtUrunAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtBirim = new TextBox();
            label3 = new Label();
            txtKdv = new TextBox();
            label4 = new Label();
            btnUrunGiris = new Button();
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
            pnlCard.Controls.Add(btnUrunGiris);
            pnlCard.Controls.Add(TxtUrunKodu);
            pnlCard.Controls.Add(label4);
            pnlCard.Controls.Add(TxtUrunAdi);
            pnlCard.Controls.Add(txtKdv);
            pnlCard.Controls.Add(label2);
            pnlCard.Controls.Add(label3);
            pnlCard.Controls.Add(TxtBirim);
            pnlCard.Location = new Point(390, 110);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(500, 440);
            pnlCard.TabIndex = 9;
            // 
            // TxtUrunKodu
            // 
            TxtUrunKodu.Font = new Font("Segoe UI", 12.5F);
            TxtUrunKodu.Location = new Point(50, 50);
            TxtUrunKodu.Margin = new Padding(3, 2, 3, 2);
            TxtUrunKodu.Name = "TxtUrunKodu";
            TxtUrunKodu.Size = new Size(400, 35);
            TxtUrunKodu.TabIndex = 0;
            // 
            // TxtUrunAdi
            // 
            TxtUrunAdi.Font = new Font("Segoe UI", 12.5F);
            TxtUrunAdi.Location = new Point(50, 130);
            TxtUrunAdi.Margin = new Padding(3, 2, 3, 2);
            TxtUrunAdi.Name = "TxtUrunAdi";
            TxtUrunAdi.Size = new Size(400, 35);
            TxtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 2;
            label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(50, 100);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı";
            // 
            // TxtBirim
            // 
            TxtBirim.Font = new Font("Segoe UI", 12.5F);
            TxtBirim.Location = new Point(50, 210);
            TxtBirim.Margin = new Padding(3, 2, 3, 2);
            TxtBirim.Name = "TxtBirim";
            TxtBirim.Size = new Size(400, 35);
            TxtBirim.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F);
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(50, 180);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 5;
            label3.Text = "Birim";
            // 
            // txtKdv
            // 
            txtKdv.Font = new Font("Segoe UI", 12.5F);
            txtKdv.Location = new Point(50, 290);
            txtKdv.Margin = new Padding(3, 2, 3, 2);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(400, 35);
            txtKdv.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.5F);
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(50, 260);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 7;
            label4.Text = "KDV Oranı";
            // 
            // btnUrunGiris
            // 
            btnUrunGiris.BackColor = Color.FromArgb(30, 41, 59);
            btnUrunGiris.Cursor = Cursors.Hand;
            btnUrunGiris.FlatAppearance.BorderSize = 0;
            btnUrunGiris.FlatStyle = FlatStyle.Flat;
            btnUrunGiris.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            btnUrunGiris.ForeColor = Color.White;
            btnUrunGiris.Location = new Point(50, 360);
            btnUrunGiris.Margin = new Padding(3, 2, 3, 2);
            btnUrunGiris.Name = "btnUrunGiris";
            btnUrunGiris.Size = new Size(400, 45);
            btnUrunGiris.TabIndex = 8;
            btnUrunGiris.Text = "Ürün Girişi Yap";
            btnUrunGiris.UseVisualStyleBackColor = false;
            btnUrunGiris.Click += btnUrunGiris_Click;
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
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1280, 70);
            label5.TabIndex = 11;
            label5.Text = "Stok Takip Sistemi | Ürün Girişi";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormManuelUrunGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            Controls.Add(pnlCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormManuelUrunGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Manuel Ürün Giriş";
            Load += FormManuelUrunGiris_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtUrunKodu;
        private TextBox TxtUrunAdi;
        private Label label1;
        private Label label2;
        private TextBox TxtBirim;
        private Label label3;
        private TextBox txtKdv;
        private Label label4;
        private Button btnUrunGiris;
        private Panel pnlCard;
        private Panel panel1;
        private Label label5;
    }
}

