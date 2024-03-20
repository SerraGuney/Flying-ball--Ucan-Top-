namespace TopYakalama1
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
            components = new System.ComponentModel.Container();
            LblSol = new Label();
            LblSag = new Label();
            LblUst = new Label();
            BtnTop = new Button();
            BtnTopYakalama = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnBasla = new Button();
            label1 = new Label();
            LblSure = new Label();
            label3 = new Label();
            LblCarpmaSayisi = new Label();
            label5 = new Label();
            LblKalanHak = new Label();
            SuspendLayout();
            // 
            // LblSol
            // 
            LblSol.BackColor = SystemColors.ActiveCaptionText;
            LblSol.Location = new Point(1, 28);
            LblSol.Margin = new Padding(4, 0, 4, 0);
            LblSol.Name = "LblSol";
            LblSol.Size = new Size(23, 497);
            LblSol.TabIndex = 0;
            // 
            // LblSag
            // 
            LblSag.BackColor = SystemColors.ActiveCaptionText;
            LblSag.Location = new Point(895, 28);
            LblSag.Margin = new Padding(4, 0, 4, 0);
            LblSag.Name = "LblSag";
            LblSag.Size = new Size(25, 497);
            LblSag.TabIndex = 2;
            LblSag.Text = "label3";
            // 
            // LblUst
            // 
            LblUst.BackColor = SystemColors.ActiveCaptionText;
            LblUst.Location = new Point(1, -1);
            LblUst.Margin = new Padding(4, 0, 4, 0);
            LblUst.Name = "LblUst";
            LblUst.Size = new Size(919, 29);
            LblUst.TabIndex = 3;
            LblUst.Text = "label2";
            // 
            // BtnTop
            // 
            BtnTop.BackColor = Color.FromArgb(255, 128, 128);
            BtnTop.Enabled = false;
            BtnTop.Location = new Point(271, 78);
            BtnTop.Margin = new Padding(4);
            BtnTop.Name = "BtnTop";
            BtnTop.Size = new Size(32, 31);
            BtnTop.TabIndex = 4;
            BtnTop.UseVisualStyleBackColor = false;
            // 
            // BtnTopYakalama
            // 
            BtnTopYakalama.BackColor = Color.CornflowerBlue;
            BtnTopYakalama.Enabled = false;
            BtnTopYakalama.Location = new Point(341, 546);
            BtnTopYakalama.Margin = new Padding(4);
            BtnTopYakalama.Name = "BtnTopYakalama";
            BtnTopYakalama.Size = new Size(234, 37);
            BtnTopYakalama.TabIndex = 5;
            BtnTopYakalama.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // btnBasla
            // 
            btnBasla.BackColor = Color.DarkKhaki;
            btnBasla.ForeColor = SystemColors.ActiveCaptionText;
            btnBasla.Location = new Point(950, 241);
            btnBasla.Margin = new Padding(4);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(104, 33);
            btnBasla.TabIndex = 6;
            btnBasla.Text = "Basla ";
            btnBasla.UseVisualStyleBackColor = false;
            btnBasla.Click += btnBasla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(950, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 7;
            label1.Text = "Süre (sn):";
            // 
            // LblSure
            // 
            LblSure.AutoSize = true;
            LblSure.Location = new Point(1101, 31);
            LblSure.Margin = new Padding(4, 0, 4, 0);
            LblSure.Name = "LblSure";
            LblSure.Size = new Size(0, 23);
            LblSure.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(934, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 9;
            label3.Text = "Çarpma Sayısı:";
            // 
            // LblCarpmaSayisi
            // 
            LblCarpmaSayisi.AutoSize = true;
            LblCarpmaSayisi.Location = new Point(1101, 82);
            LblCarpmaSayisi.Margin = new Padding(4, 0, 4, 0);
            LblCarpmaSayisi.Name = "LblCarpmaSayisi";
            LblCarpmaSayisi.Size = new Size(0, 23);
            LblCarpmaSayisi.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(938, 155);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 11;
            label5.Text = "Kalan Hakkınız:";
            // 
            // LblKalanHak
            // 
            LblKalanHak.AutoSize = true;
            LblKalanHak.Location = new Point(1101, 155);
            LblKalanHak.Margin = new Padding(4, 0, 4, 0);
            LblKalanHak.Name = "LblKalanHak";
            LblKalanHak.Size = new Size(0, 23);
            LblKalanHak.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 616);
            Controls.Add(LblKalanHak);
            Controls.Add(label5);
            Controls.Add(LblCarpmaSayisi);
            Controls.Add(label3);
            Controls.Add(LblSure);
            Controls.Add(label1);
            Controls.Add(btnBasla);
            Controls.Add(BtnTopYakalama);
            Controls.Add(BtnTop);
            Controls.Add(LblUst);
            Controls.Add(LblSag);
            Controls.Add(LblSol);
            Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Uçan Top";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSol;
        private Label LblSag;
        private Label LblUst;
        private Button BtnTop;
        private Button BtnTopYakalama;
        private System.Windows.Forms.Timer timer1;
        private Button btnBasla;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LblSure;
        private Label LblCarpmaSayisi;
        private Label LblKalanHak;
    }
}
