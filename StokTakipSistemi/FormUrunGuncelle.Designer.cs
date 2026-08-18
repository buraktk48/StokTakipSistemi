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
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnUrunGuncelleme = new Button();
            txtGUrunKodu = new TextBox();
            label4 = new Label();
            txtGUrunAdi = new TextBox();
            txtGKdv = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtGBirim = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1471, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1471, 64);
            label1.TabIndex = 0;
            label1.Text = "ÜRÜN GÜNCELLEME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnUrunGuncelleme);
            groupBox1.Controls.Add(txtGUrunKodu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGUrunAdi);
            groupBox1.Controls.Add(txtGKdv);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtGBirim);
            groupBox1.Location = new Point(39, 78);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1282, 495);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(440, 54);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 11;
            label2.Text = "Ürün Kodu";
            // 
            // btnUrunGuncelleme
            // 
            btnUrunGuncelleme.FlatStyle = FlatStyle.Flat;
            btnUrunGuncelleme.Font = new Font("Segoe UI", 14.25F);
            btnUrunGuncelleme.Location = new Point(576, 237);
            btnUrunGuncelleme.Margin = new Padding(3, 2, 3, 2);
            btnUrunGuncelleme.Name = "btnUrunGuncelleme";
            btnUrunGuncelleme.Size = new Size(237, 36);
            btnUrunGuncelleme.TabIndex = 17;
            btnUrunGuncelleme.Text = "Ürünü Güncelle";
            btnUrunGuncelleme.UseVisualStyleBackColor = true;
            btnUrunGuncelleme.Click += btnUrunGuncelleme_Click;
            // 
            // txtGUrunKodu
            // 
            txtGUrunKodu.Font = new Font("Segoe UI", 14.25F);
            txtGUrunKodu.Location = new Point(576, 50);
            txtGUrunKodu.Margin = new Padding(3, 2, 3, 2);
            txtGUrunKodu.Name = "txtGUrunKodu";
            txtGUrunKodu.Size = new Size(236, 33);
            txtGUrunKodu.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(441, 190);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 16;
            label4.Text = "KDV Oranı";
            // 
            // txtGUrunAdi
            // 
            txtGUrunAdi.Font = new Font("Segoe UI", 14.25F);
            txtGUrunAdi.Location = new Point(576, 91);
            txtGUrunAdi.Margin = new Padding(3, 2, 3, 2);
            txtGUrunAdi.Name = "txtGUrunAdi";
            txtGUrunAdi.Size = new Size(236, 33);
            txtGUrunAdi.TabIndex = 10;
            // 
            // txtGKdv
            // 
            txtGKdv.Font = new Font("Segoe UI", 14.25F);
            txtGKdv.Location = new Point(576, 182);
            txtGKdv.Margin = new Padding(3, 2, 3, 2);
            txtGKdv.Name = "txtGKdv";
            txtGKdv.Size = new Size(236, 33);
            txtGKdv.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(440, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 12;
            label3.Text = "Ürün Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(440, 143);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 14;
            label5.Text = "Birim";
            // 
            // txtGBirim
            // 
            txtGBirim.Font = new Font("Segoe UI", 14.25F);
            txtGBirim.Location = new Point(576, 135);
            txtGBirim.Margin = new Padding(3, 2, 3, 2);
            txtGBirim.Name = "txtGBirim";
            txtGBirim.Size = new Size(236, 33);
            txtGBirim.TabIndex = 13;
            // 
            // FormUrunGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 641);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUrunGuncelle";
            Text = "Stok Takip Sistemi | Ürün Güncelle";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnUrunGuncelleme;
        private TextBox txtGUrunKodu;
        private Label label4;
        private TextBox txtGUrunAdi;
        private TextBox txtGKdv;
        private Label label3;
        private Label label5;
        private TextBox txtGBirim;
    }
}

