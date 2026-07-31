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
            groupBox1.Controls.Add(txtGDepoAd);
            groupBox1.Controls.Add(btnDepoGuncelle);
            groupBox1.Controls.Add(txtGDepoLok);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(52, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 226);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // txtGDepoAd
            // 
            txtGDepoAd.Location = new Point(162, 43);
            txtGDepoAd.Name = "txtGDepoAd";
            txtGDepoAd.Size = new Size(125, 27);
            txtGDepoAd.TabIndex = 0;
            // 
            // btnDepoGuncelle
            // 
            btnDepoGuncelle.FlatStyle = FlatStyle.Flat;
            btnDepoGuncelle.Location = new Point(147, 155);
            btnDepoGuncelle.Name = "btnDepoGuncelle";
            btnDepoGuncelle.Size = new Size(140, 34);
            btnDepoGuncelle.TabIndex = 4;
            btnDepoGuncelle.Text = "Depoyu Güncelle";
            btnDepoGuncelle.UseVisualStyleBackColor = true;
            btnDepoGuncelle.Click += btnDepoGuncelle_Click;
            // 
            // txtGDepoLok
            // 
            txtGDepoLok.Location = new Point(162, 103);
            txtGDepoLok.Name = "txtGDepoLok";
            txtGDepoLok.Size = new Size(125, 27);
            txtGDepoLok.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 50);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Depo İsmi";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 83);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(221, 22);
            label3.Name = "label3";
            label3.Size = new Size(298, 41);
            label3.TabIndex = 0;
            label3.Text = "DEPO GÜNCELLEME";
            // 
            // FormDepoGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FormDepoGuncelle";
            Text = "FormDepoGuncelle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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