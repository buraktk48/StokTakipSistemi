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
            TxtUrunKodu = new TextBox();
            TxtUrunAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtBirim = new TextBox();
            label3 = new Label();
            txtKdv = new TextBox();
            label4 = new Label();
            btnUrunGiris = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label5 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtUrunKodu
            // 
            TxtUrunKodu.Font = new Font("Segoe UI", 10.2F);
            TxtUrunKodu.Location = new Point(180, 37);
            TxtUrunKodu.Name = "TxtUrunKodu";
            TxtUrunKodu.Size = new Size(138, 30);
            TxtUrunKodu.TabIndex = 0;
            // 
            // TxtUrunAdi
            // 
            TxtUrunAdi.Font = new Font("Segoe UI", 10.2F);
            TxtUrunAdi.Location = new Point(180, 92);
            TxtUrunAdi.Name = "TxtUrunAdi";
            TxtUrunAdi.Size = new Size(138, 30);
            TxtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 2;
            label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(50, 100);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı";
            // 
            // TxtBirim
            // 
            TxtBirim.Font = new Font("Segoe UI", 10.2F);
            TxtBirim.Location = new Point(180, 152);
            TxtBirim.Name = "TxtBirim";
            TxtBirim.Size = new Size(138, 30);
            TxtBirim.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(50, 159);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 5;
            label3.Text = "Birim";
            // 
            // txtKdv
            // 
            txtKdv.Font = new Font("Segoe UI", 10.2F);
            txtKdv.Location = new Point(180, 214);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(138, 30);
            txtKdv.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(51, 222);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 7;
            label4.Text = "KDV Oranı";
            // 
            // btnUrunGiris
            // 
            btnUrunGiris.FlatStyle = FlatStyle.Flat;
            btnUrunGiris.Location = new Point(180, 271);
            btnUrunGiris.Name = "btnUrunGiris";
            btnUrunGiris.Size = new Size(136, 34);
            btnUrunGiris.TabIndex = 8;
            btnUrunGiris.Text = "Ürün Girişi Yap";
            btnUrunGiris.UseVisualStyleBackColor = true;
            btnUrunGiris.Click += btnUrunGiris_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnUrunGiris);
            groupBox1.Controls.Add(TxtUrunKodu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtUrunAdi);
            groupBox1.Controls.Add(txtKdv);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtBirim);
            groupBox1.Location = new Point(48, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 357);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 77);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(333, 21);
            label5.Name = "label5";
            label5.Size = new Size(202, 41);
            label5.TabIndex = 11;
            label5.Text = "ÜRÜN GİRİŞİ";
            // 
            // FormManuelUrunGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 495);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FormManuelUrunGiris";
            Text = "Stok Takip Sistemi | Manuel Ürün Giriş";
            Load += FormManuelUrunGiris_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label5;
    }
}