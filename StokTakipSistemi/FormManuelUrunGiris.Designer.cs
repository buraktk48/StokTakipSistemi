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
            SuspendLayout();
            // 
            // TxtUrunKodu
            // 
            TxtUrunKodu.Location = new Point(162, 42);
            TxtUrunKodu.Name = "TxtUrunKodu";
            TxtUrunKodu.Size = new Size(125, 27);
            TxtUrunKodu.TabIndex = 0;
            // 
            // TxtUrunAdi
            // 
            TxtUrunAdi.Location = new Point(162, 97);
            TxtUrunAdi.Name = "TxtUrunAdi";
            TxtUrunAdi.Size = new Size(125, 27);
            TxtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 104);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı";
            // 
            // TxtBirim
            // 
            TxtBirim.Location = new Point(162, 156);
            TxtBirim.Name = "TxtBirim";
            TxtBirim.Size = new Size(125, 27);
            TxtBirim.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 163);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Birim";
            // 
            // txtKdv
            // 
            txtKdv.Location = new Point(162, 219);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(125, 27);
            txtKdv.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 226);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "KDV Oranı";
            // 
            // btnUrunGiris
            // 
            btnUrunGiris.Location = new Point(151, 274);
            btnUrunGiris.Name = "btnUrunGiris";
            btnUrunGiris.Size = new Size(136, 29);
            btnUrunGiris.TabIndex = 8;
            btnUrunGiris.Text = "Ürün Girişi Yap";
            btnUrunGiris.UseVisualStyleBackColor = true;
            btnUrunGiris.Click += btnUrunGiris_Click;
            // 
            // FormManuelUrunGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUrunGiris);
            Controls.Add(label4);
            Controls.Add(txtKdv);
            Controls.Add(label3);
            Controls.Add(TxtBirim);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtUrunAdi);
            Controls.Add(TxtUrunKodu);
            Name = "FormManuelUrunGiris";
            Text = "Manuel Ürün Giriş ";
            Load += FormManuelUrunGiris_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}