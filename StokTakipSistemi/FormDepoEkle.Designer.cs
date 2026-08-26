namespace StokTakipSistemi
{
    partial class FormDepoEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepoEkle));
            pnlCard = new Panel();
            txtDepoAd = new TextBox();
            btnDepoGiris = new Button();
            txtDepoLok = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pnlCard.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(248, 250, 252);
            pnlCard.Controls.Add(txtDepoAd);
            pnlCard.Controls.Add(btnDepoGiris);
            pnlCard.Controls.Add(txtDepoLok);
            pnlCard.Controls.Add(label2);
            pnlCard.Controls.Add(label1);
            pnlCard.Location = new Point(390, 150);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(500, 320);
            pnlCard.TabIndex = 5;
            // 
            // txtDepoAd
            // 
            txtDepoAd.Font = new Font("Segoe UI", 12.5F);
            txtDepoAd.Location = new Point(50, 75);
            txtDepoAd.Margin = new Padding(3, 2, 3, 2);
            txtDepoAd.Name = "txtDepoAd";
            txtDepoAd.Size = new Size(400, 35);
            txtDepoAd.TabIndex = 0;
            // 
            // btnDepoGiris
            // 
            btnDepoGiris.BackColor = Color.FromArgb(30, 41, 59);
            btnDepoGiris.Cursor = Cursors.Hand;
            btnDepoGiris.FlatAppearance.BorderSize = 0;
            btnDepoGiris.FlatStyle = FlatStyle.Flat;
            btnDepoGiris.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            btnDepoGiris.ForeColor = Color.White;
            btnDepoGiris.Location = new Point(50, 230);
            btnDepoGiris.Margin = new Padding(3, 2, 3, 2);
            btnDepoGiris.Name = "btnDepoGiris";
            btnDepoGiris.Size = new Size(400, 45);
            btnDepoGiris.TabIndex = 4;
            btnDepoGiris.Text = "Depo Girişi Yap";
            btnDepoGiris.UseVisualStyleBackColor = false;
            btnDepoGiris.Click += btnDepoGiris_Click;
            // 
            // txtDepoLok
            // 
            txtDepoLok.Font = new Font("Segoe UI", 12.5F);
            txtDepoLok.Location = new Point(50, 165);
            txtDepoLok.Margin = new Padding(3, 2, 3, 2);
            txtDepoLok.Name = "txtDepoLok";
            txtDepoLok.Size = new Size(400, 35);
            txtDepoLok.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(50, 130);
            label2.Name = "label2";
            label2.Size = new Size(147, 30);
            label2.TabIndex = 3;
            label2.Text = "Depo Konumu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.5F);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 2;
            label1.Text = "Depo İsmi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 70);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1280, 70);
            label3.TabIndex = 6;
            label3.Text = "Stok Takip Sistemi | Depo Girişi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDepoEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            Controls.Add(pnlCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDepoEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Sistemi | Depo Ekle";
            Load += FormDepoEkle_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDepoAd;
        private TextBox txtDepoLok;
        private Label label1;
        private Label label2;
        private Button btnDepoGiris;
        private Panel pnlCard;
        private Panel panel1;
        private Label label3;
    }
}

