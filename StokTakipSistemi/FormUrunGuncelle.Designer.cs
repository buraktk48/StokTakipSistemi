namespace StokTakipSistemi
{
    partial class FormUrunGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunGuncelle));
            panel1 = new Panel();
            label1 = new Label();
            pnlCard = new Panel();
            label2 = new Label();
            txtGUrunKodu = new TextBox();
            label3 = new Label();
            txtGUrunAdi = new TextBox();
            label5 = new Label();
            txtGBirim = new TextBox();
            label4 = new Label();
            txtGKdv = new TextBox();
            btnUrunGuncelleme = new Button();
            lblFooter = new Label();
            panel1.SuspendLayout();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1280, 70);
            label1.TabIndex = 0;
            label1.Text = "Stok Takip Sistemi | Ürün Güncelleme";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(248, 250, 252);
            pnlCard.Controls.Add(label2);
            pnlCard.Controls.Add(txtGUrunKodu);
            pnlCard.Controls.Add(label3);
            pnlCard.Controls.Add(txtGUrunAdi);
            pnlCard.Controls.Add(label5);
            pnlCard.Controls.Add(txtGBirim);
            pnlCard.Controls.Add(label4);
            pnlCard.Controls.Add(txtGKdv);
            pnlCard.Controls.Add(btnUrunGuncelleme);
            pnlCard.Location = new Point(390, 140);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(500, 340);
            pnlCard.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(50, 38);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 11;
            label2.Text = "Ürün Kodu";
            // 
            // txtGUrunKodu
            // 
            txtGUrunKodu.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGUrunKodu.Location = new Point(180, 35);
            txtGUrunKodu.Name = "txtGUrunKodu";
            txtGUrunKodu.Size = new Size(270, 35);
            txtGUrunKodu.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            label3.Location = new Point(50, 88);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 12;
            label3.Text = "Ürün Adı";
            // 
            // txtGUrunAdi
            // 
            txtGUrunAdi.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGUrunAdi.Location = new Point(180, 85);
            txtGUrunAdi.Name = "txtGUrunAdi";
            txtGUrunAdi.Size = new Size(270, 35);
            txtGUrunAdi.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(30, 41, 59);
            label5.Location = new Point(50, 138);
            label5.Name = "label5";
            label5.Size = new Size(59, 30);
            label5.TabIndex = 14;
            label5.Text = "Birim";
            // 
            // txtGBirim
            // 
            txtGBirim.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGBirim.Location = new Point(180, 135);
            txtGBirim.Name = "txtGBirim";
            txtGBirim.Size = new Size(270, 35);
            txtGBirim.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(30, 41, 59);
            label4.Location = new Point(50, 188);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 16;
            label4.Text = "KDV Oranı";
            // 
            // txtGKdv
            // 
            txtGKdv.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtGKdv.Location = new Point(180, 185);
            txtGKdv.Name = "txtGKdv";
            txtGKdv.Size = new Size(270, 35);
            txtGKdv.TabIndex = 15;
            // 
            // btnUrunGuncelleme
            // 
            btnUrunGuncelleme.BackColor = Color.FromArgb(30, 41, 59);
            btnUrunGuncelleme.Cursor = Cursors.Hand;
            btnUrunGuncelleme.FlatAppearance.BorderSize = 0;
            btnUrunGuncelleme.FlatStyle = FlatStyle.Flat;
            btnUrunGuncelleme.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunGuncelleme.ForeColor = Color.White;
            btnUrunGuncelleme.Location = new Point(180, 245);
            btnUrunGuncelleme.Name = "btnUrunGuncelleme";
            btnUrunGuncelleme.Size = new Size(270, 46);
            btnUrunGuncelleme.TabIndex = 17;
            btnUrunGuncelleme.Text = "Ürünü Güncelle";
            btnUrunGuncelleme.UseVisualStyleBackColor = false;
            btnUrunGuncelleme.Click += btnUrunGuncelleme_Click;
            // 
            // lblFooter
            // 
            lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFooter.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.Location = new Point(980, 640);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(270, 22);
            lblFooter.TabIndex = 18;
            lblFooter.Text = "© 2026 Dalaman Belediyesi";
            lblFooter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormUrunGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 680);
            Controls.Add(lblFooter);
            Controls.Add(pnlCard);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUrunGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Ürün Güncelleme";
            Load += FormUrunGuncelle_Load;
            panel1.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel pnlCard;
        private Label label2;
        private Button btnUrunGuncelleme;
        private TextBox txtGUrunKodu;
        private Label label4;
        private TextBox txtGUrunAdi;
        private TextBox txtGKdv;
        private Label label3;
        private Label label5;
        private TextBox txtGBirim;
        private Label lblFooter;
    }
}

