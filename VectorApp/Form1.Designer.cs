namespace VectorApp
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
            panel1 = new Panel();
            btnRenk1 = new Button();
            numCizgiKalinlik = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btnPointer = new Button();
            btnElips = new Button();
            BtnLine = new Button();
            btnRect = new Button();
            canvas1 = new Canvas();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCizgiKalinlik).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnRenk1);
            panel1.Controls.Add(numCizgiKalinlik);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPointer);
            panel1.Controls.Add(btnElips);
            panel1.Controls.Add(BtnLine);
            panel1.Controls.Add(btnRect);
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 61);
            panel1.TabIndex = 0;
            // 
            // btnRenk1
            // 
            btnRenk1.ForeColor = SystemColors.ControlText;
            btnRenk1.Location = new Point(722, 32);
            btnRenk1.Name = "btnRenk1";
            btnRenk1.Size = new Size(64, 25);
            btnRenk1.TabIndex = 3;
            btnRenk1.Text = "button1";
            btnRenk1.UseVisualStyleBackColor = true;
            btnRenk1.Click += btnRenk1_Click;
            // 
            // numCizgiKalinlik
            // 
            numCizgiKalinlik.DecimalPlaces = 1;
            numCizgiKalinlik.Location = new Point(734, 3);
            numCizgiKalinlik.Name = "numCizgiKalinlik";
            numCizgiKalinlik.Size = new Size(52, 27);
            numCizgiKalinlik.TabIndex = 2;
            numCizgiKalinlik.ValueChanged += numCizgiKalinlik_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(628, 35);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Çizgi Rengi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(628, 3);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Çizgi Kalınlığı";
            // 
            // btnPointer
            // 
            btnPointer.BackColor = SystemColors.GradientInactiveCaption;
            btnPointer.Location = new Point(474, 3);
            btnPointer.Name = "btnPointer";
            btnPointer.Size = new Size(148, 54);
            btnPointer.TabIndex = 0;
            btnPointer.Text = "Pointer";
            btnPointer.UseVisualStyleBackColor = false;
            btnPointer.Click += btnPointer_Click;
            // 
            // btnElips
            // 
            btnElips.BackColor = SystemColors.GradientInactiveCaption;
            btnElips.Location = new Point(320, 3);
            btnElips.Name = "btnElips";
            btnElips.Size = new Size(148, 54);
            btnElips.TabIndex = 0;
            btnElips.Text = "Elips";
            btnElips.UseVisualStyleBackColor = false;
            btnElips.Click += btnElips_Click;
            // 
            // BtnLine
            // 
            BtnLine.BackColor = SystemColors.GradientInactiveCaption;
            BtnLine.Location = new Point(166, 3);
            BtnLine.Name = "BtnLine";
            BtnLine.Size = new Size(148, 54);
            BtnLine.TabIndex = 0;
            BtnLine.Text = "Line";
            BtnLine.UseVisualStyleBackColor = false;
            BtnLine.Click += BtnLine_Click;
            // 
            // btnRect
            // 
            btnRect.BackColor = SystemColors.GradientInactiveCaption;
            btnRect.Location = new Point(12, 3);
            btnRect.Name = "btnRect";
            btnRect.Size = new Size(148, 54);
            btnRect.TabIndex = 0;
            btnRect.Text = "Rectangle";
            btnRect.UseVisualStyleBackColor = false;
            btnRect.Click += btnRect_Click;
            // 
            // canvas1
            // 
            canvas1.Location = new Point(12, 12);
            canvas1.Name = "canvas1";
            canvas1.SekilTuru = Canvas.SekilTurleri.Pointer;
            canvas1.Size = new Size(776, 368);
            canvas1.TabIndex = 1;
            canvas1.Text = "canvas1";
            canvas1.Click += canvas1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(canvas1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCizgiKalinlik).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPointer;
        private Button btnElips;
        private Button BtnLine;
        private Button btnRect;
        private Canvas canvas1;
        private Label label2;
        private Label label1;
        private Button btnRenk1;
        private NumericUpDown numCizgiKalinlik;
    }
}
