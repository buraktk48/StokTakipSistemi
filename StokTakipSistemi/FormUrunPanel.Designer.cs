namespace StokTakipSistemi
{
    partial class FormUrunPanel
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
            dgvUrunler = new DataGridView();
            label1 = new Label();
            txtAra = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnYenile = new Button();
            button3 = new Button();
            button2 = new Button();
            btnUrunEkle = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(21, 192);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(1236, 379);
            dgvUrunler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(445, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 1;
            label1.Text = "Ürün Ara:";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(445, 59);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(312, 27);
            txtAra.TabIndex = 2;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1331, 78);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(536, 19);
            label2.Name = "label2";
            label2.Size = new Size(217, 41);
            label2.TabIndex = 4;
            label2.Text = "ÜRÜN LİSTESİ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnYenile);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnUrunEkle);
            groupBox1.Location = new Point(0, 622);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1331, 97);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnYenile
            // 
            btnYenile.BackColor = SystemColors.Control;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Location = new Point(1023, 26);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(206, 50);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(712, 26);
            button3.Name = "button3";
            button3.Size = new Size(206, 50);
            button3.TabIndex = 2;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(418, 26);
            button2.Name = "button2";
            button2.Size = new Size(206, 50);
            button2.TabIndex = 1;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = SystemColors.Control;
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.Location = new Point(116, 26);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(206, 50);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = "Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtAra);
            groupBox2.Location = new Point(21, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1236, 102);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // FormUrunPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 784);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgvUrunler);
            Name = "FormUrunPanel";
            Text = "Ürün Paneli";
            Load += FormUrunListe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUrunler;
        private Label label1;
        private TextBox txtAra;
        private Panel panel1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button btnUrunEkle;
        private Button btnYenile;
        private GroupBox groupBox2;
    }
}