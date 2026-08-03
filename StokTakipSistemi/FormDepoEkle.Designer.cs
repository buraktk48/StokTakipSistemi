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
            txtDepoAd.Location = new Point(162, 43);
            txtDepoAd.Name = "txtDepoAd";
            txtDepoAd.Size = new Size(125, 27);
            txtDepoAd.TabIndex = 0;
            // 
            // txtDepoLok
            // 
            txtDepoLok.Location = new Point(162, 103);
            txtDepoLok.Name = "txtDepoLok";
            txtDepoLok.Size = new Size(125, 27);
            txtDepoLok.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 50);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Depo İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "Depo Konumu";
            // 
            // btnDepoGiris
            // 
            btnDepoGiris.FlatStyle = FlatStyle.Flat;
            btnDepoGiris.Location = new Point(162, 166);
            btnDepoGiris.Name = "btnDepoGiris";
            btnDepoGiris.Size = new Size(125, 29);
            btnDepoGiris.TabIndex = 4;
            btnDepoGiris.Text = "Depo Girişi Yap";
            btnDepoGiris.UseVisualStyleBackColor = true;
            btnDepoGiris.Click += btnDepoGiris_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDepoAd);
            groupBox1.Controls.Add(btnDepoGiris);
            groupBox1.Controls.Add(txtDepoLok);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(41, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 226);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 85);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(288, 23);
            label3.Name = "label3";
            label3.Size = new Size(193, 41);
            label3.TabIndex = 6;
            label3.Text = "DEPO GİRİŞİ";
            // 
            // FormDepoEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FormDepoEkle";
            Text = "FormDepoEkle";
            Load += FormDepoEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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