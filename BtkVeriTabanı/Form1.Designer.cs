namespace BtkVeriTabanı
{
    partial class Courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbKurslar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnInstructors = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, tsbKurslar, toolStripSeparator2, BtnInstructors });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // tsbKurslar
            // 
            tsbKurslar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbKurslar.Image = (Image)resources.GetObject("tsbKurslar.Image");
            tsbKurslar.ImageTransparentColor = Color.Magenta;
            tsbKurslar.Name = "tsbKurslar";
            tsbKurslar.Size = new Size(36, 36);
            tsbKurslar.Text = "toolStripButton2";
            tsbKurslar.Click += tsbKurslar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // BtnInstructors
            // 
            BtnInstructors.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnInstructors.Image = (Image)resources.GetObject("BtnInstructors.Image");
            BtnInstructors.ImageTransparentColor = Color.Magenta;
            BtnInstructors.Name = "BtnInstructors";
            BtnInstructors.Size = new Size(36, 36);
            BtnInstructors.Text = "toolStripButton3";
            BtnInstructors.Click += BtnInstructors_Click;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "Courses";
            Text = "Courses";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbKurslar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnInstructors;
    }
}
