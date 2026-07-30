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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepoPanel));
            dgvDepolar = new DataGridView();
            panel1 = new Panel();
            btnDepoEkle = new Button();
            btnDepoYenile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).BeginInit();
            SuspendLayout();
            // 
            // dgvDepolar
            // 
            dgvDepolar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepolar.Location = new Point(3, 133);
            dgvDepolar.Name = "dgvDepolar";
            dgvDepolar.RowHeadersWidth = 51;
            dgvDepolar.Size = new Size(973, 306);
            dgvDepolar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 82);
            panel1.TabIndex = 1;
            // 
            // btnDepoEkle
            // 
            btnDepoEkle.FlatStyle = FlatStyle.Flat;
            btnDepoEkle.Location = new Point(57, 479);
            btnDepoEkle.Name = "btnDepoEkle";
            btnDepoEkle.Size = new Size(165, 47);
            btnDepoEkle.TabIndex = 2;
            btnDepoEkle.Text = "Ekle";
            btnDepoEkle.UseVisualStyleBackColor = true;
            btnDepoEkle.Click += btnDepoEkle_Click;
            // 
            // btnDepoYenile
            // 
            btnDepoYenile.FlatStyle = FlatStyle.Flat;
            btnDepoYenile.Location = new Point(319, 479);
            btnDepoYenile.Name = "btnDepoYenile";
            btnDepoYenile.Size = new Size(165, 47);
            btnDepoYenile.TabIndex = 3;
            btnDepoYenile.Text = "Yenile";
            btnDepoYenile.UseVisualStyleBackColor = true;
            btnDepoYenile.Click += btnDepoYenile_Click;
            // 
            // FormDepoPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 561);
            Controls.Add(btnDepoYenile);
            Controls.Add(btnDepoEkle);
            Controls.Add(panel1);
            Controls.Add(dgvDepolar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDepoPanel";
            Text = "Stok Takip Sistemi - Depo Paneli";
            Load += FormDepoPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDepolar;
        private Panel panel1;
        private Button btnDepoEkle;
        private Button btnDepoYenile;
    }
}