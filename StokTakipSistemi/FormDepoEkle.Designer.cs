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
            SuspendLayout();
            // 
            // txtDepoAd
            // 
            txtDepoAd.Location = new Point(220, 86);
            txtDepoAd.Name = "txtDepoAd";
            txtDepoAd.Size = new Size(125, 27);
            txtDepoAd.TabIndex = 0;
            // 
            // txtDepoLok
            // 
            txtDepoLok.Location = new Point(220, 146);
            txtDepoLok.Name = "txtDepoLok";
            txtDepoLok.Size = new Size(125, 27);
            txtDepoLok.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 93);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Depo İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 149);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "Depo Konumu";
            // 
            // btnDepoGiris
            // 
            btnDepoGiris.FlatStyle = FlatStyle.Flat;
            btnDepoGiris.Location = new Point(220, 209);
            btnDepoGiris.Name = "btnDepoGiris";
            btnDepoGiris.Size = new Size(125, 29);
            btnDepoGiris.TabIndex = 4;
            btnDepoGiris.Text = "Depo Girişi Yap";
            btnDepoGiris.UseVisualStyleBackColor = true;
            btnDepoGiris.Click += btnDepoGiris_Click;
            // 
            // FormDepoEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDepoGiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepoLok);
            Controls.Add(txtDepoAd);
            Name = "FormDepoEkle";
            Text = "FormDepoEkle";
            Load += FormDepoEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDepoAd;
        private TextBox txtDepoLok;
        private Label label1;
        private Label label2;
        private Button btnDepoGiris;
    }
}