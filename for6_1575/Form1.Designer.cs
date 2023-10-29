namespace for6_1575
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            txtBaslangic = new TextBox();
            txtBitis = new TextBox();
            lbTek = new ListBox();
            lbCift = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Aquamarine;
            btnEkle.Location = new Point(117, 51);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(107, 39);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtBaslangic
            // 
            txtBaslangic.Location = new Point(12, 12);
            txtBaslangic.Name = "txtBaslangic";
            txtBaslangic.Size = new Size(125, 27);
            txtBaslangic.TabIndex = 1;
            // 
            // txtBitis
            // 
            txtBitis.Location = new Point(205, 12);
            txtBitis.Name = "txtBitis";
            txtBitis.Size = new Size(125, 27);
            txtBitis.TabIndex = 2;
            // 
            // lbTek
            // 
            lbTek.FormattingEnabled = true;
            lbTek.ItemHeight = 20;
            lbTek.Location = new Point(12, 135);
            lbTek.Name = "lbTek";
            lbTek.Size = new Size(150, 264);
            lbTek.TabIndex = 3;
            // 
            // lbCift
            // 
            lbCift.FormattingEnabled = true;
            lbCift.ItemHeight = 20;
            lbCift.Location = new Point(180, 135);
            lbCift.Name = "lbCift";
            lbCift.Size = new Size(150, 264);
            lbCift.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "TEK :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Location = new Point(183, 111);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "ÇİFT :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(359, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbCift);
            Controls.Add(lbTek);
            Controls.Add(txtBitis);
            Controls.Add(txtBaslangic);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtBaslangic;
        private TextBox txtBitis;
        private ListBox lbTek;
        private ListBox lbCift;
        private Label label1;
        private Label label2;
    }
}