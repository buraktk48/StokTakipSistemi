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
            txtDepoAd = new TextBox();
            txtDepoLok = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDepoGiris = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDepoAd
            // 
            txtDepoAd.Font = new Font("Segoe UI", 14.25F);
            txtDepoAd.Location = new Point(294, 69);
            txtDepoAd.Margin = new Padding(3, 2, 3, 2);
            txtDepoAd.Name = "txtDepoAd";
            txtDepoAd.Size = new Size(201, 33);
            txtDepoAd.TabIndex = 0;
            // 
            // txtDepoLok
            // 
            txtDepoLok.Font = new Font("Segoe UI", 14.25F);
            txtDepoLok.Location = new Point(294, 114);
            txtDepoLok.Margin = new Padding(3, 2, 3, 2);
            txtDepoLok.Name = "txtDepoLok";
            txtDepoLok.Size = new Size(201, 33);
            txtDepoLok.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(137, 72);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "Depo İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(113, 122);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "Depo Konumu";
            // 
            // btnDepoGiris
            // 
            btnDepoGiris.FlatStyle = FlatStyle.Flat;
            btnDepoGiris.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDepoGiris.Location = new Point(294, 182);
            btnDepoGiris.Margin = new Padding(3, 2, 3, 2);
            btnDepoGiris.Name = "btnDepoGiris";
            btnDepoGiris.Size = new Size(172, 35);
            btnDepoGiris.TabIndex = 4;
            btnDepoGiris.Text = "Depo Girişi Yap";
            btnDepoGiris.UseVisualStyleBackColor = true;
            btnDepoGiris.Click += btnDepoGiris_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtDepoAd);
            groupBox1.Controls.Add(btnDepoGiris);
            groupBox1.Controls.Add(txtDepoLok);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(285, 97);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(773, 355);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 64);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1371, 64);
            label3.TabIndex = 6;
            label3.Text = "DEPO GİRİŞİ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDepoEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 610);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDepoEkle";
            Text = "Stok Takip Sistemi | Depo Ekle";
            Load += FormDepoEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDepoAd;
        private TextBox txtDepoLok;
        private Label label1;
        private Label label2;
        private Button btnDepoGiris;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label3;
    }
}

