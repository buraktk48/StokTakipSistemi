namespace StokTakipSistemi
{
    partial class FormDepoPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepoPanel));
            dgvDepolar = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            btnDepoEkle = new Button();
            btnDepoYenile = new Button();
            groupBox1 = new GroupBox();
            btnDepoSil = new Button();
            btnDepoGuncelle = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtDepoAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDepolar
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvDepolar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepolar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepolar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepolar.Location = new Point(47, 193);
            dgvDepolar.Margin = new Padding(3, 2, 3, 2);
            dgvDepolar.Name = "dgvDepolar";
            dgvDepolar.ReadOnly = true;
            dgvDepolar.RowHeadersWidth = 51;
            dgvDepolar.Size = new Size(1367, 342);
            dgvDepolar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1471, 58);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1471, 58);
            label2.TabIndex = 5;
            label2.Text = "DEPO YÖNETİMİ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDepoEkle
            // 
            btnDepoEkle.FlatStyle = FlatStyle.Flat;
            btnDepoEkle.Font = new Font("Segoe UI", 14.25F);
            btnDepoEkle.Image = (Image)resources.GetObject("btnDepoEkle.Image");
            btnDepoEkle.Location = new Point(180, 20);
            btnDepoEkle.Margin = new Padding(3, 2, 3, 2);
            btnDepoEkle.Name = "btnDepoEkle";
            btnDepoEkle.Size = new Size(200, 38);
            btnDepoEkle.TabIndex = 2;
            btnDepoEkle.Text = "Ekle";
            btnDepoEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoEkle.UseVisualStyleBackColor = true;
            btnDepoEkle.Click += btnDepoEkle_Click;
            // 
            // btnDepoYenile
            // 
            btnDepoYenile.FlatStyle = FlatStyle.Flat;
            btnDepoYenile.Font = new Font("Segoe UI", 14.25F);
            btnDepoYenile.Image = (Image)resources.GetObject("btnDepoYenile.Image");
            btnDepoYenile.Location = new Point(1036, 20);
            btnDepoYenile.Margin = new Padding(3, 2, 3, 2);
            btnDepoYenile.Name = "btnDepoYenile";
            btnDepoYenile.Size = new Size(200, 38);
            btnDepoYenile.TabIndex = 3;
            btnDepoYenile.Text = " Yenile";
            btnDepoYenile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoYenile.UseVisualStyleBackColor = true;
            btnDepoYenile.Click += btnDepoYenile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDepoSil);
            groupBox1.Controls.Add(btnDepoGuncelle);
            groupBox1.Controls.Add(btnDepoYenile);
            groupBox1.Controls.Add(btnDepoEkle);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(9, 558);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1450, 78);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnDepoSil
            // 
            btnDepoSil.FlatStyle = FlatStyle.Flat;
            btnDepoSil.Font = new Font("Segoe UI", 14.25F);
            btnDepoSil.Image = (Image)resources.GetObject("btnDepoSil.Image");
            btnDepoSil.Location = new Point(759, 20);
            btnDepoSil.Margin = new Padding(3, 2, 3, 2);
            btnDepoSil.Name = "btnDepoSil";
            btnDepoSil.Size = new Size(200, 38);
            btnDepoSil.TabIndex = 5;
            btnDepoSil.Text = "  Sil";
            btnDepoSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoSil.UseVisualStyleBackColor = true;
            btnDepoSil.Click += btnDepoSil_Click;
            // 
            // btnDepoGuncelle
            // 
            btnDepoGuncelle.FlatStyle = FlatStyle.Flat;
            btnDepoGuncelle.Font = new Font("Segoe UI", 14.25F);
            btnDepoGuncelle.Image = (Image)resources.GetObject("btnDepoGuncelle.Image");
            btnDepoGuncelle.Location = new Point(448, 20);
            btnDepoGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnDepoGuncelle.Name = "btnDepoGuncelle";
            btnDepoGuncelle.Size = new Size(200, 38);
            btnDepoGuncelle.TabIndex = 4;
            btnDepoGuncelle.Text = " Güncelle";
            btnDepoGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepoGuncelle.UseVisualStyleBackColor = true;
            btnDepoGuncelle.Click += btnDepoGuncelle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtDepoAra);
            groupBox2.Location = new Point(47, 71);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1367, 102);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(464, 18);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 1;
            label1.Text = "Depo Ara:";
            // 
            // txtDepoAra
            // 
            txtDepoAra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDepoAra.Location = new Point(464, 58);
            txtDepoAra.Margin = new Padding(3, 2, 3, 2);
            txtDepoAra.Name = "txtDepoAra";
            txtDepoAra.Size = new Size(427, 33);
            txtDepoAra.TabIndex = 2;
            txtDepoAra.TextChanged += txtDepoAra_TextChanged;
            // 
            // FormDepoPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 657);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dgvDepolar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDepoPanel";
            Text = "Stok Takip Sistemi | Depo Paneli";
            Load += FormDepoPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDepolar;
        private Panel panel1;
        private Button btnDepoEkle;
        private Button btnDepoYenile;
        private GroupBox groupBox1;
        private Button btnDepoSil;
        private Button btnDepoGuncelle;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtDepoAra;
    }
}

