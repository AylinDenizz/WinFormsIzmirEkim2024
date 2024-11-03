namespace PersonelBilgiFormu
{
    partial class dsf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dsf));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lboxPersoneller = new ListBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            btnYeni = new Button();
            chkPaz = new CheckBox();
            chkCmt = new CheckBox();
            rdPartTime = new RadioButton();
            rdStajyer = new RadioButton();
            rdKadrolu = new RadioButton();
            rdSureliSozlesmeli = new RadioButton();
            chkCum = new CheckBox();
            chkPrs = new CheckBox();
            chkCrs = new CheckBox();
            chkSal = new CheckBox();
            chkPzt = new CheckBox();
            txtCalistigiBirim = new TextBox();
            txtAdSoyad = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cBoxCalisanTipi = new ComboBox();
            cBoxCinsiyet = new ComboBox();
            toolStrip1 = new ToolStrip();
            StripButtonSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            StripButtonDelete = new ToolStripButton();
            btnEkleGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(153, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 60);
            label1.TabIndex = 1;
            label1.Text = "Personel Bilgileri";
            // 
            // lboxPersoneller
            // 
            lboxPersoneller.Dock = DockStyle.Fill;
            lboxPersoneller.FormattingEnabled = true;
            lboxPersoneller.Location = new Point(0, 35);
            lboxPersoneller.Name = "lboxPersoneller";
            lboxPersoneller.Size = new Size(266, 415);
            lboxPersoneller.TabIndex = 2;
            lboxPersoneller.SelectedIndexChanged += lboxPersoneller_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 35);
            label2.TabIndex = 3;
            label2.Text = "Personel Listesi";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnYeni);
            splitContainer1.Panel1.Controls.Add(lboxPersoneller);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chkPaz);
            splitContainer1.Panel2.Controls.Add(chkCmt);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(rdPartTime);
            splitContainer1.Panel2.Controls.Add(rdStajyer);
            splitContainer1.Panel2.Controls.Add(rdKadrolu);
            splitContainer1.Panel2.Controls.Add(rdSureliSozlesmeli);
            splitContainer1.Panel2.Controls.Add(chkCum);
            splitContainer1.Panel2.Controls.Add(chkPrs);
            splitContainer1.Panel2.Controls.Add(chkCrs);
            splitContainer1.Panel2.Controls.Add(chkSal);
            splitContainer1.Panel2.Controls.Add(chkPzt);
            splitContainer1.Panel2.Controls.Add(txtCalistigiBirim);
            splitContainer1.Panel2.Controls.Add(txtAdSoyad);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(cBoxCalisanTipi);
            splitContainer1.Panel2.Controls.Add(cBoxCinsiyet);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(toolStrip1);
            splitContainer1.Panel2.Controls.Add(btnEkleGuncelle);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 4;
            // 
            // btnYeni
            // 
            btnYeni.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnYeni.Location = new Point(57, 411);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(136, 27);
            btnYeni.TabIndex = 11;
            btnYeni.Text = "YENİ PERSONEL";
            btnYeni.UseMnemonic = false;
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // chkPaz
            // 
            chkPaz.AutoSize = true;
            chkPaz.Location = new Point(340, 384);
            chkPaz.Name = "chkPaz";
            chkPaz.Size = new Size(66, 24);
            chkPaz.TabIndex = 10;
            chkPaz.Text = "Pazar";
            chkPaz.UseVisualStyleBackColor = true;
            // 
            // chkCmt
            // 
            chkCmt.AutoSize = true;
            chkCmt.Location = new Point(340, 359);
            chkCmt.Name = "chkCmt";
            chkCmt.Size = new Size(97, 24);
            chkCmt.TabIndex = 9;
            chkCmt.Text = "Cumartesi";
            chkCmt.UseVisualStyleBackColor = true;
            // 
            // rdPartTime
            // 
            rdPartTime.AutoSize = true;
            rdPartTime.Location = new Point(177, 358);
            rdPartTime.Name = "rdPartTime";
            rdPartTime.Size = new Size(91, 24);
            rdPartTime.TabIndex = 7;
            rdPartTime.TabStop = true;
            rdPartTime.Text = "Part-time";
            rdPartTime.UseVisualStyleBackColor = true;
            // 
            // rdStajyer
            // 
            rdStajyer.AutoSize = true;
            rdStajyer.Location = new Point(42, 349);
            rdStajyer.Name = "rdStajyer";
            rdStajyer.Size = new Size(75, 24);
            rdStajyer.TabIndex = 7;
            rdStajyer.TabStop = true;
            rdStajyer.Text = "Stajyer";
            rdStajyer.UseVisualStyleBackColor = true;
            // 
            // rdKadrolu
            // 
            rdKadrolu.AutoSize = true;
            rdKadrolu.Location = new Point(177, 328);
            rdKadrolu.Name = "rdKadrolu";
            rdKadrolu.Size = new Size(82, 24);
            rdKadrolu.TabIndex = 7;
            rdKadrolu.TabStop = true;
            rdKadrolu.Text = "Kadrolu";
            rdKadrolu.UseVisualStyleBackColor = true;
            // 
            // rdSureliSozlesmeli
            // 
            rdSureliSozlesmeli.AutoSize = true;
            rdSureliSozlesmeli.Location = new Point(16, 328);
            rdSureliSozlesmeli.Name = "rdSureliSozlesmeli";
            rdSureliSozlesmeli.Size = new Size(142, 24);
            rdSureliSozlesmeli.TabIndex = 6;
            rdSureliSozlesmeli.TabStop = true;
            rdSureliSozlesmeli.Text = "Süreli Sözleşmeli";
            rdSureliSozlesmeli.UseVisualStyleBackColor = true;
            // 
            // chkCum
            // 
            chkCum.AutoSize = true;
            chkCum.Location = new Point(340, 331);
            chkCum.Name = "chkCum";
            chkCum.Size = new Size(69, 24);
            chkCum.TabIndex = 5;
            chkCum.Text = "Cuma";
            chkCum.UseVisualStyleBackColor = true;
            // 
            // chkPrs
            // 
            chkPrs.AutoSize = true;
            chkPrs.Location = new Point(340, 301);
            chkPrs.Name = "chkPrs";
            chkPrs.Size = new Size(95, 24);
            chkPrs.TabIndex = 5;
            chkPrs.Text = "Perşembe";
            chkPrs.UseVisualStyleBackColor = true;
            // 
            // chkCrs
            // 
            chkCrs.AutoSize = true;
            chkCrs.Location = new Point(340, 271);
            chkCrs.Name = "chkCrs";
            chkCrs.Size = new Size(97, 24);
            chkCrs.TabIndex = 5;
            chkCrs.Text = "Çarşamba";
            chkCrs.UseVisualStyleBackColor = true;
            // 
            // chkSal
            // 
            chkSal.AutoSize = true;
            chkSal.Location = new Point(340, 241);
            chkSal.Name = "chkSal";
            chkSal.Size = new Size(55, 24);
            chkSal.TabIndex = 5;
            chkSal.Text = "Salı";
            chkSal.UseVisualStyleBackColor = true;
            // 
            // chkPzt
            // 
            chkPzt.AutoSize = true;
            chkPzt.Location = new Point(340, 211);
            chkPzt.Name = "chkPzt";
            chkPzt.Size = new Size(89, 24);
            chkPzt.TabIndex = 5;
            chkPzt.Text = "Pazartesi";
            chkPzt.UseVisualStyleBackColor = true;
            // 
            // txtCalistigiBirim
            // 
            txtCalistigiBirim.Location = new Point(9, 149);
            txtCalistigiBirim.Name = "txtCalistigiBirim";
            txtCalistigiBirim.Size = new Size(422, 27);
            txtCalistigiBirim.TabIndex = 4;
            txtCalistigiBirim.TextChanged += txtCalistigiBirim_TextChanged;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(9, 94);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(422, 27);
            txtAdSoyad.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F);
            label8.Location = new Point(9, 303);
            label8.Name = "label8";
            label8.Size = new Size(149, 22);
            label8.TabIndex = 2;
            label8.Text = "Personel Durumu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F);
            label7.Location = new Point(329, 179);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 2;
            label7.Text = "Mesai Günleri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F);
            label6.Location = new Point(9, 235);
            label6.Name = "label6";
            label6.Size = new Size(105, 22);
            label6.TabIndex = 2;
            label6.Text = "Çalışan Tipi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F);
            label5.Location = new Point(9, 179);
            label5.Name = "label5";
            label5.Size = new Size(78, 22);
            label5.TabIndex = 2;
            label5.Text = "Cinsiyeti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F);
            label4.Location = new Point(9, 124);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 2;
            label4.Text = "Departman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F);
            label3.Location = new Point(9, 69);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad";
            // 
            // cBoxCalisanTipi
            // 
            cBoxCalisanTipi.FormattingEnabled = true;
            cBoxCalisanTipi.Items.AddRange(new object[] { "Yonetici", "BeyazYaka", "GriYaka", "MaviYaka" });
            cBoxCalisanTipi.Location = new Point(9, 260);
            cBoxCalisanTipi.Name = "cBoxCalisanTipi";
            cBoxCalisanTipi.Size = new Size(284, 28);
            cBoxCalisanTipi.TabIndex = 1;
            // 
            // cBoxCinsiyet
            // 
            cBoxCinsiyet.FormattingEnabled = true;
            cBoxCinsiyet.Items.AddRange(new object[] { "Kadın", "Erkek", "NonBinary" });
            cBoxCinsiyet.Location = new Point(9, 204);
            cBoxCinsiyet.Name = "cBoxCinsiyet";
            cBoxCinsiyet.Size = new Size(284, 28);
            cBoxCinsiyet.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { StripButtonSave, toolStripSeparator1, StripButtonDelete });
            toolStrip1.Location = new Point(26, 402);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(81, 39);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // StripButtonSave
            // 
            StripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            StripButtonSave.Image = (Image)resources.GetObject("StripButtonSave.Image");
            StripButtonSave.ImageTransparentColor = Color.Magenta;
            StripButtonSave.Name = "StripButtonSave";
            StripButtonSave.Size = new Size(36, 36);
            StripButtonSave.Text = "toolStripButton1";
            StripButtonSave.Click += tsbKaydet_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // StripButtonDelete
            // 
            StripButtonDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            StripButtonDelete.Image = (Image)resources.GetObject("StripButtonDelete.Image");
            StripButtonDelete.ImageTransparentColor = Color.Magenta;
            StripButtonDelete.Name = "StripButtonDelete";
            StripButtonDelete.Size = new Size(36, 36);
            StripButtonDelete.Text = "toolStripButton3";
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkleGuncelle.Location = new Point(121, 405);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(204, 36);
            btnEkleGuncelle.TabIndex = 11;
            btnEkleGuncelle.Text = "EKLE/GUNCELLE";
            btnEkleGuncelle.UseVisualStyleBackColor = true;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // dsf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "dsf";
            Text = "Personel Bilgi Formu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ListBox lboxPersoneller;
        private Label label2;
        private SplitContainer splitContainer1;
        private CheckBox chkCum;
        private CheckBox chkPrs;
        private CheckBox chkCrs;
        private CheckBox chkSal;
        private CheckBox chkPzt;
        private TextBox txtCalistigiBirim;
        private TextBox txtAdSoyad;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cBoxCalisanTipi;
        private ComboBox cBoxCinsiyet;
        private Label label8;
        private RadioButton rdPartTime;
        private RadioButton rdStajyer;
        private RadioButton rdKadrolu;
        private RadioButton rdSureliSozlesmeli;
        private ToolStrip toolStrip1;
        private ToolStripButton StripButtonSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton StripButtonDelete;
        private CheckBox chkCmt;
        private CheckBox chkPaz;
        private Button btnEkleGuncelle;
        private Button btnYeni;
    }
}
