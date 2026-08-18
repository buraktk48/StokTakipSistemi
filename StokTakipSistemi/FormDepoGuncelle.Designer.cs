namespace StokTakipSistemi
{
    partial class FormDepoGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepoGuncelle));
            groupBox1 = new GroupBox();
            txtGDepoAd = new TextBox();
            btnDepoGuncelle = new Button();
            txtGDepoLok = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtGDepoAd);
            groupBox1.Controls.Add(btnDepoGuncelle);
            groupBox1.Controls.Add(txtGDepoLok);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 80);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1291, 426);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // txtGDepoAd
            // 
            txtGDepoAd.Font = new Font("Segoe UI", 14.25F);
            txtGDepoAd.Location = new Point(529, 45);
            txtGDepoAd.Margin = new Padding(3, 2, 3, 2);
            txtGDepoAd.Name = "txtGDepoAd";
            txtGDepoAd.Size = new Size(221, 33);
            txtGDepoAd.TabIndex = 0;
            // 
            // btnDepoGuncelle
            // 
            btnDepoGuncelle.FlatStyle = FlatStyle.Flat;
            btnDepoGuncelle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDepoGuncelle.Location = new Point(529, 152);
            btnDepoGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnDepoGuncelle.Name = "btnDepoGuncelle";
            btnDepoGuncelle.Size = new Size(172, 37);
            btnDepoGuncelle.TabIndex = 4;
            btnDepoGuncelle.Text = "Depoyu Güncelle";
            btnDepoGuncelle.UseVisualStyleBackColor = true;
            btnDepoGuncelle.Click += btnDepoGuncelle_Click;
            // 
            // txtGDepoLok
            // 
            txtGDepoLok.Font = new Font("Segoe UI", 14.25F);
            txtGDepoLok.Location = new Point(529, 92);
            txtGDepoLok.Margin = new Padding(3, 2, 3, 2);
            txtGDepoLok.Name = "txtGDepoLok";
            txtGDepoLok.Size = new Size(221, 33);
            txtGDepoLok.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(370, 95);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "Depo Konumu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(370, 45);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "Depo İsmi";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1408, 62);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1408, 62);
            label3.TabIndex = 0;
            label3.Text = "DEPO GÜNCELLEME";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDepoGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 640);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDepoGuncelle";
            Text = "Stok Takip Sistemi | Depo Güncelle";
            Load += FormDepoGuncelle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGDepoAd;
        private Button btnDepoGuncelle;
        private TextBox txtGDepoLok;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
    }
}

