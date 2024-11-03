namespace BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lblDesteKartSayisi = new Label();
            pbDeste = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            pnlOyuncu2Butonlar = new Panel();
            btnPas2 = new Button();
            btnKartCek2 = new Button();
            pnlOyuncu2 = new Panel();
            lblOyuncu2 = new Label();
            pnlOyuncu1Butonlar = new Panel();
            btnPas1 = new Button();
            btnKartCek1 = new Button();
            pnlOyuncu1 = new Panel();
            lblOyuncu1 = new Label();
            button7 = new Button();
            label5 = new Label();
            lblOyuncu2Sayi = new Label();
            label7 = new Label();
            lblOyuncu1Sayi = new Label();
            button3 = new Button();
            btnSkorlar = new Button();
            btnBaslat = new Button();
            lblKazanan = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDeste).BeginInit();
            panel3.SuspendLayout();
            pnlOyuncu2Butonlar.SuspendLayout();
            pnlOyuncu1Butonlar.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDesteKartSayisi);
            panel1.Controls.Add(pbDeste);
            panel1.Location = new Point(526, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 194);
            panel1.TabIndex = 0;
            // 
            // lblDesteKartSayisi
            // 
            lblDesteKartSayisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDesteKartSayisi.ForeColor = SystemColors.ButtonHighlight;
            lblDesteKartSayisi.Location = new Point(0, 158);
            lblDesteKartSayisi.Name = "lblDesteKartSayisi";
            lblDesteKartSayisi.Size = new Size(103, 25);
            lblDesteKartSayisi.TabIndex = 1;
            lblDesteKartSayisi.Text = "0";
            lblDesteKartSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbDeste
            // 
            pbDeste.BorderStyle = BorderStyle.FixedSingle;
            pbDeste.Image = (Image)resources.GetObject("pbDeste.Image");
            pbDeste.Location = new Point(-3, 15);
            pbDeste.Name = "pbDeste";
            pbDeste.Size = new Size(103, 140);
            pbDeste.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeste.TabIndex = 0;
            pbDeste.TabStop = false;
            pbDeste.Click += pbDeste_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(100, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 190);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(99, 516);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 61);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(129, 13);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(14, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Green;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(99, 263);
            label2.Name = "label2";
            label2.Size = new Size(469, 38);
            label2.TabIndex = 1;
            label2.Text = "Oyuncu 1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOyuncu2Butonlar
            // 
            pnlOyuncu2Butonlar.Controls.Add(btnPas2);
            pnlOyuncu2Butonlar.Controls.Add(btnKartCek2);
            pnlOyuncu2Butonlar.Enabled = false;
            pnlOyuncu2Butonlar.Location = new Point(586, 516);
            pnlOyuncu2Butonlar.Name = "pnlOyuncu2Butonlar";
            pnlOyuncu2Butonlar.Size = new Size(238, 61);
            pnlOyuncu2Butonlar.TabIndex = 0;
            // 
            // btnPas2
            // 
            btnPas2.Location = new Point(129, 13);
            btnPas2.Name = "btnPas2";
            btnPas2.Size = new Size(94, 29);
            btnPas2.TabIndex = 0;
            btnPas2.Text = "Pas";
            btnPas2.UseVisualStyleBackColor = true;
            // 
            // btnKartCek2
            // 
            btnKartCek2.Location = new Point(14, 13);
            btnKartCek2.Name = "btnKartCek2";
            btnKartCek2.Size = new Size(94, 29);
            btnKartCek2.TabIndex = 0;
            btnKartCek2.Text = "Kart Çek";
            btnKartCek2.UseVisualStyleBackColor = true;
            btnKartCek2.Click += btnKartCek2_Click;
            // 
            // pnlOyuncu2
            // 
            pnlOyuncu2.BorderStyle = BorderStyle.FixedSingle;
            pnlOyuncu2.Enabled = false;
            pnlOyuncu2.Location = new Point(587, 304);
            pnlOyuncu2.Name = "pnlOyuncu2";
            pnlOyuncu2.Size = new Size(468, 190);
            pnlOyuncu2.TabIndex = 2;
            pnlOyuncu2.SizeChanged += pnlOyuncu2_SizeChanged;
            // 
            // lblOyuncu2
            // 
            lblOyuncu2.BackColor = Color.Green;
            lblOyuncu2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOyuncu2.ForeColor = SystemColors.ButtonHighlight;
            lblOyuncu2.Location = new Point(586, 263);
            lblOyuncu2.Name = "lblOyuncu2";
            lblOyuncu2.Size = new Size(469, 38);
            lblOyuncu2.TabIndex = 1;
            lblOyuncu2.Text = "Oyuncu 2";
            lblOyuncu2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOyuncu1Butonlar
            // 
            pnlOyuncu1Butonlar.Controls.Add(btnPas1);
            pnlOyuncu1Butonlar.Controls.Add(btnKartCek1);
            pnlOyuncu1Butonlar.Enabled = false;
            pnlOyuncu1Butonlar.Location = new Point(96, 516);
            pnlOyuncu1Butonlar.Name = "pnlOyuncu1Butonlar";
            pnlOyuncu1Butonlar.Size = new Size(241, 61);
            pnlOyuncu1Butonlar.TabIndex = 0;
            // 
            // btnPas1
            // 
            btnPas1.Location = new Point(129, 13);
            btnPas1.Name = "btnPas1";
            btnPas1.Size = new Size(94, 29);
            btnPas1.TabIndex = 0;
            btnPas1.Text = "Pas";
            btnPas1.UseVisualStyleBackColor = true;
            // 
            // btnKartCek1
            // 
            btnKartCek1.Location = new Point(14, 13);
            btnKartCek1.Name = "btnKartCek1";
            btnKartCek1.Size = new Size(94, 29);
            btnKartCek1.TabIndex = 0;
            btnKartCek1.Text = "Kart Çek";
            btnKartCek1.UseVisualStyleBackColor = true;
            btnKartCek1.Click += btnKartCek1_Click;
            // 
            // pnlOyuncu1
            // 
            pnlOyuncu1.BorderStyle = BorderStyle.FixedSingle;
            pnlOyuncu1.Enabled = false;
            pnlOyuncu1.Location = new Point(97, 304);
            pnlOyuncu1.Name = "pnlOyuncu1";
            pnlOyuncu1.Size = new Size(471, 190);
            pnlOyuncu1.TabIndex = 2;
            // 
            // lblOyuncu1
            // 
            lblOyuncu1.BackColor = Color.Green;
            lblOyuncu1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOyuncu1.ForeColor = SystemColors.ButtonHighlight;
            lblOyuncu1.Location = new Point(96, 263);
            lblOyuncu1.Name = "lblOyuncu1";
            lblOyuncu1.Size = new Size(472, 38);
            lblOyuncu1.TabIndex = 1;
            lblOyuncu1.Text = "Oyuncu 1";
            lblOyuncu1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            button7.BackColor = Color.LightYellow;
            button7.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(890, 81);
            button7.Name = "button7";
            button7.Size = new Size(140, 53);
            button7.TabIndex = 0;
            button7.Text = "Skorlar";
            button7.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(418, 529);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 1;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOyuncu2Sayi
            // 
            lblOyuncu2Sayi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOyuncu2Sayi.ForeColor = SystemColors.ButtonHighlight;
            lblOyuncu2Sayi.Location = new Point(908, 528);
            lblOyuncu2Sayi.Name = "lblOyuncu2Sayi";
            lblOyuncu2Sayi.Size = new Size(103, 25);
            lblOyuncu2Sayi.TabIndex = 1;
            lblOyuncu2Sayi.Text = "0";
            lblOyuncu2Sayi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(407, 529);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 1;
            label7.Text = "0";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOyuncu1Sayi
            // 
            lblOyuncu1Sayi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOyuncu1Sayi.ForeColor = SystemColors.ButtonHighlight;
            lblOyuncu1Sayi.Location = new Point(419, 529);
            lblOyuncu1Sayi.Name = "lblOyuncu1Sayi";
            lblOyuncu1Sayi.Size = new Size(103, 25);
            lblOyuncu1Sayi.TabIndex = 1;
            lblOyuncu1Sayi.Text = "0";
            lblOyuncu1Sayi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.LightYellow;
            button3.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(113, 81);
            button3.Name = "button3";
            button3.Size = new Size(140, 53);
            button3.TabIndex = 0;
            button3.Text = "Skorlar";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnSkorlar
            // 
            btnSkorlar.BackColor = Color.LightYellow;
            btnSkorlar.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSkorlar.Location = new Point(887, 81);
            btnSkorlar.Name = "btnSkorlar";
            btnSkorlar.Size = new Size(140, 53);
            btnSkorlar.TabIndex = 0;
            btnSkorlar.Text = "Skorlar";
            btnSkorlar.UseVisualStyleBackColor = false;
            btnSkorlar.Click += btnSkorlar_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.LightYellow;
            btnBaslat.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaslat.Location = new Point(110, 81);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(140, 53);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Start Game";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // lblKazanan
            // 
            lblKazanan.AutoSize = true;
            lblKazanan.BackColor = Color.DarkGreen;
            lblKazanan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKazanan.ForeColor = Color.Red;
            lblKazanan.Location = new Point(228, 203);
            lblKazanan.Name = "lblKazanan";
            lblKazanan.Size = new Size(189, 46);
            lblKazanan.TabIndex = 3;
            lblKazanan.Text = "KAZANAN";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblOyuncu1Sayi);
            panel4.Controls.Add(btnBaslat);
            panel4.Controls.Add(lblKazanan);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(lblOyuncu2Sayi);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pnlOyuncu1Butonlar);
            panel4.Controls.Add(lblOyuncu2);
            panel4.Controls.Add(pnlOyuncu2Butonlar);
            panel4.Controls.Add(pnlOyuncu1);
            panel4.Controls.Add(btnSkorlar);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(lblOyuncu1);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(pnlOyuncu2);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(1085, 612);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1113, 636);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "BlackJack";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDeste).EndInit();
            panel3.ResumeLayout(false);
            pnlOyuncu2Butonlar.ResumeLayout(false);
            pnlOyuncu1Butonlar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbDeste;
        private Label lblDesteKartSayisi;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Label label2;
        private Panel pnlOyuncu2Butonlar;
        private Button btnPas2;
        private Button btnKartCek2;
        private Panel pnlOyuncu2;
        private Label lblOyuncu2;
        private Panel pnlOyuncu1Butonlar;
        private Button btnPas1;
        private Button btnKartCek1;
        private Panel pnlOyuncu1;
        private Label lblOyuncu1;
        private Button button7;
        private Label label5;
        private Label lblOyuncu2Sayi;
        private Label label7;
        private Label lblOyuncu1Sayi;
        private Button button3;
        private Button btnSkorlar;
        private Button btnBaslat;
        private Label lblKazanan;
        private Panel panel4;
    }
}
