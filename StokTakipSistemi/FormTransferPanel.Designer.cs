namespace StokTakipSistemi
{
    partial class FormTransferPanel
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txtTransferAra = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(439, 19);
            label1.Name = "label1";
            label1.Size = new Size(325, 41);
            label1.TabIndex = 1;
            label1.Text = "TRANSFER YÖNETİMİ";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtTransferAra);
            groupBox2.Location = new Point(12, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1274, 102);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(445, 20);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 1;
            label2.Text = "Transfer Ara:";
            // 
            // txtTransferAra
            // 
            txtTransferAra.Location = new Point(445, 59);
            txtTransferAra.Name = "txtTransferAra";
            txtTransferAra.Size = new Size(312, 27);
            txtTransferAra.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1274, 392);
            dataGridView1.TabIndex = 9;
            // 
            // FormTransferPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 777);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "FormTransferPanel";
            Text = "Stok Takip Sistemi - Transfer Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtTransferAra;
        private DataGridView dataGridView1;
    }
}