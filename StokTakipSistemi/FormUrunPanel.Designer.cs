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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunPanel));
            dgvUrunler = new DataGridView();
            label1 = new Label();
            txtAra = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnExcelEkle = new Button();
            btnUrunYenile = new Button();
            btnUrunSil = new Button();
            btnUrunGuncelle = new Button();
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
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(21, 192);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(1641, 471);
            dgvUrunler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(682, 16);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 1;
            label1.Text = "Ürün Ara:";
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 14.25F);
            txtAra.Location = new Point(682, 52);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(313, 39);
            txtAra.TabIndex = 2;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1675, 77);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1675, 77);
            label2.TabIndex = 4;
            label2.Text = "ÜRÜN YÖNETİMİ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnExcelEkle);
            groupBox1.Controls.Add(btnUrunYenile);
            groupBox1.Controls.Add(btnUrunSil);
            groupBox1.Controls.Add(btnUrunGuncelle);
            groupBox1.Controls.Add(btnUrunEkle);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(10, 668);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1651, 167);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnExcelEkle
            // 
            btnExcelEkle.BackColor = SystemColors.Control;
            btnExcelEkle.FlatStyle = FlatStyle.Flat;
            btnExcelEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnExcelEkle.Image = (Image)resources.GetObject("btnExcelEkle.Image");
            btnExcelEkle.Location = new Point(415, 27);
            btnExcelEkle.Name = "btnExcelEkle";
            btnExcelEkle.Size = new Size(294, 51);
            btnExcelEkle.TabIndex = 4;
            btnExcelEkle.Text = " Excel Üzerinden Ekle";
            btnExcelEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcelEkle.UseVisualStyleBackColor = false;
            btnExcelEkle.Click += btnExcelEkle_Click;
            // 
            // btnUrunYenile
            // 
            btnUrunYenile.BackColor = SystemColors.Control;
            btnUrunYenile.FlatStyle = FlatStyle.Flat;
            btnUrunYenile.Font = new Font("Segoe UI", 14.25F);
            btnUrunYenile.Image = (Image)resources.GetObject("btnUrunYenile.Image");
            btnUrunYenile.Location = new Point(1392, 27);
            btnUrunYenile.Name = "btnUrunYenile";
            btnUrunYenile.Size = new Size(206, 51);
            btnUrunYenile.TabIndex = 3;
            btnUrunYenile.Text = " Yenile";
            btnUrunYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunYenile.UseVisualStyleBackColor = false;
            btnUrunYenile.Click += btnYenile_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.BackColor = SystemColors.Control;
            btnUrunSil.FlatStyle = FlatStyle.Flat;
            btnUrunSil.Font = new Font("Segoe UI", 14.25F);
            btnUrunSil.Image = (Image)resources.GetObject("btnUrunSil.Image");
            btnUrunSil.Location = new Point(1105, 27);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(206, 51);
            btnUrunSil.TabIndex = 2;
            btnUrunSil.Text = "   Sil";
            btnUrunSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunSil.UseVisualStyleBackColor = false;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.BackColor = SystemColors.Control;
            btnUrunGuncelle.FlatStyle = FlatStyle.Flat;
            btnUrunGuncelle.Font = new Font("Segoe UI", 14.25F);
            btnUrunGuncelle.Image = (Image)resources.GetObject("btnUrunGuncelle.Image");
            btnUrunGuncelle.Location = new Point(799, 27);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(206, 51);
            btnUrunGuncelle.TabIndex = 1;
            btnUrunGuncelle.Text = "Güncelle";
            btnUrunGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunGuncelle.UseVisualStyleBackColor = false;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = SystemColors.Control;
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.Font = new Font("Segoe UI", 14.25F);
            btnUrunEkle.Image = (Image)resources.GetObject("btnUrunEkle.Image");
            btnUrunEkle.Location = new Point(99, 27);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(206, 51);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = " Ekle";
            btnUrunEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtAra);
            groupBox2.Location = new Point(21, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1641, 101);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // FormUrunPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1675, 848);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgvUrunler);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUrunPanel";
            Text = " Stok Takip Sistemi | Ürün Paneli";
            Load += FormUrunListe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            panel1.ResumeLayout(false);
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
        private Button btnUrunSil;
        private Button btnUrunGuncelle;
        private Button btnUrunEkle;
        private Button btnUrunYenile;
        private GroupBox groupBox2;
        private Button btnExcelEkle;
    }
}

