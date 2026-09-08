namespace StokTakipSistemi
{
    partial class FormUrunSecim
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
            panel1 = new Panel();
            labelHeader = new Label();
            groupBoxArama = new GroupBox();
            label1 = new Label();
            txtAra = new TextBox();
            dgvUrunler = new DataGridView();
            groupBoxSayfalama = new GroupBox();
            btnIlkSayfa = new Button();
            btnOnceki = new Button();
            lblSayfa = new Label();
            btnSonraki = new Button();
            btnSonSayfa = new Button();
            groupBoxAksiyonlar = new GroupBox();
            btnSec = new Button();
            btnIptal = new Button();
            panel1.SuspendLayout();
            groupBoxArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            groupBoxSayfalama.SuspendLayout();
            groupBoxAksiyonlar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(labelHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 65);
            panel1.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Padding = new Padding(25, 0, 0, 0);
            labelHeader.Size = new Size(1091, 65);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Ürün Seçim Paneli";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxArama
            // 
            groupBoxArama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxArama.Controls.Add(label1);
            groupBoxArama.Controls.Add(txtAra);
            groupBoxArama.Location = new Point(30, 75);
            groupBoxArama.Name = "groupBoxArama";
            groupBoxArama.Size = new Size(1031, 75);
            groupBoxArama.TabIndex = 1;
            groupBoxArama.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 0;
            label1.Text = "Ürün Ara (Kod veya Ad):";
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAra.Location = new Point(250, 26);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "Aramak istediğiniz ürün adını veya kodunu yazınız...";
            txtAra.Size = new Size(747, 32);
            txtAra.TabIndex = 1;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(30, 160);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(1031, 327);
            dgvUrunler.TabIndex = 2;
            // 
            // groupBoxSayfalama
            // 
            groupBoxSayfalama.Anchor = AnchorStyles.Bottom;
            groupBoxSayfalama.Controls.Add(btnIlkSayfa);
            groupBoxSayfalama.Controls.Add(btnOnceki);
            groupBoxSayfalama.Controls.Add(lblSayfa);
            groupBoxSayfalama.Controls.Add(btnSonraki);
            groupBoxSayfalama.Controls.Add(btnSonSayfa);
            groupBoxSayfalama.Location = new Point(185, 497);
            groupBoxSayfalama.Name = "groupBoxSayfalama";
            groupBoxSayfalama.Size = new Size(720, 52);
            groupBoxSayfalama.TabIndex = 3;
            groupBoxSayfalama.TabStop = false;
            // 
            // btnIlkSayfa
            // 
            btnIlkSayfa.BackColor = Color.White;
            btnIlkSayfa.Cursor = Cursors.Hand;
            btnIlkSayfa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnIlkSayfa.FlatStyle = FlatStyle.Flat;
            btnIlkSayfa.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIlkSayfa.ForeColor = Color.FromArgb(30, 41, 59);
            btnIlkSayfa.Location = new Point(20, 14);
            btnIlkSayfa.Name = "btnIlkSayfa";
            btnIlkSayfa.Size = new Size(95, 30);
            btnIlkSayfa.TabIndex = 0;
            btnIlkSayfa.Text = "İlk Sayfa";
            btnIlkSayfa.UseVisualStyleBackColor = false;
            // 
            // btnOnceki
            // 
            btnOnceki.BackColor = Color.White;
            btnOnceki.Cursor = Cursors.Hand;
            btnOnceki.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnOnceki.FlatStyle = FlatStyle.Flat;
            btnOnceki.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOnceki.ForeColor = Color.FromArgb(30, 41, 59);
            btnOnceki.Location = new Point(125, 14);
            btnOnceki.Name = "btnOnceki";
            btnOnceki.Size = new Size(95, 30);
            btnOnceki.TabIndex = 1;
            btnOnceki.Text = "< Önceki";
            btnOnceki.UseVisualStyleBackColor = false;
            // 
            // lblSayfa
            // 
            lblSayfa.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSayfa.ForeColor = Color.FromArgb(71, 85, 105);
            lblSayfa.Location = new Point(230, 15);
            lblSayfa.Name = "lblSayfa";
            lblSayfa.Size = new Size(260, 26);
            lblSayfa.TabIndex = 2;
            lblSayfa.Text = "Sayfa 1 / 1 (Toplam Kayıt: 0)";
            lblSayfa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.White;
            btnSonraki.Cursor = Cursors.Hand;
            btnSonraki.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSonraki.ForeColor = Color.FromArgb(30, 41, 59);
            btnSonraki.Location = new Point(500, 14);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(95, 30);
            btnSonraki.TabIndex = 3;
            btnSonraki.Text = "Sonraki >";
            btnSonraki.UseVisualStyleBackColor = false;
            // 
            // btnSonSayfa
            // 
            btnSonSayfa.BackColor = Color.White;
            btnSonSayfa.Cursor = Cursors.Hand;
            btnSonSayfa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSonSayfa.FlatStyle = FlatStyle.Flat;
            btnSonSayfa.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSonSayfa.ForeColor = Color.FromArgb(30, 41, 59);
            btnSonSayfa.Location = new Point(605, 14);
            btnSonSayfa.Name = "btnSonSayfa";
            btnSonSayfa.Size = new Size(95, 30);
            btnSonSayfa.TabIndex = 4;
            btnSonSayfa.Text = "Son Sayfa";
            btnSonSayfa.UseVisualStyleBackColor = false;
            // 
            // groupBoxAksiyonlar
            // 
            groupBoxAksiyonlar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAksiyonlar.Controls.Add(btnSec);
            groupBoxAksiyonlar.Controls.Add(btnIptal);
            groupBoxAksiyonlar.Location = new Point(30, 557);
            groupBoxAksiyonlar.Name = "groupBoxAksiyonlar";
            groupBoxAksiyonlar.Size = new Size(1031, 70);
            groupBoxAksiyonlar.TabIndex = 4;
            groupBoxAksiyonlar.TabStop = false;
            // 
            // btnSec
            // 
            btnSec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSec.BackColor = Color.FromArgb(30, 41, 59);
            btnSec.Cursor = Cursors.Hand;
            btnSec.FlatAppearance.BorderSize = 0;
            btnSec.FlatStyle = FlatStyle.Flat;
            btnSec.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSec.ForeColor = Color.White;
            btnSec.Location = new Point(329, 18);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(160, 42);
            btnSec.TabIndex = 0;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = false;
            btnSec.Click += btnSec_Click;
            // 
            // btnIptal
            // 
            btnIptal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIptal.BackColor = Color.White;
            btnIptal.Cursor = Cursors.Hand;
            btnIptal.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.ForeColor = Color.FromArgb(71, 85, 105);
            btnIptal.Location = new Point(513, 18);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(115, 42);
            btnIptal.TabIndex = 1;
            btnIptal.Text = "Vazgeç";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // FormUrunSecim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1091, 647);
            Controls.Add(groupBoxAksiyonlar);
            Controls.Add(groupBoxSayfalama);
            Controls.Add(dgvUrunler);
            Controls.Add(groupBoxArama);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "FormUrunSecim";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stok Takip Sistemi | Ürün Seç";
            Load += FormUrunSecimModal_Load;
            panel1.ResumeLayout(false);
            groupBoxArama.ResumeLayout(false);
            groupBoxArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            groupBoxSayfalama.ResumeLayout(false);
            groupBoxAksiyonlar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelHeader;
        private GroupBox groupBoxArama;
        private Label label1;
        private TextBox txtAra;
        private DataGridView dgvUrunler;
        private GroupBox groupBoxSayfalama;
        private Button btnIlkSayfa;
        private Button btnOnceki;
        private Label lblSayfa;
        private Button btnSonraki;
        private Button btnSonSayfa;
        private GroupBox groupBoxAksiyonlar;
        private Button btnSec;
        private Button btnIptal;
    }
}

