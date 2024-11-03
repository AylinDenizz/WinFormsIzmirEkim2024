namespace ControlToolExercise
{
    partial class ControlToolExercise
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btkSwitchBotton1 = new BTKSwitchBotton();
            btkButton1 = new BTKButton();
            SuspendLayout();
            // 
            // btkSwitchBotton1
            // 
            btkSwitchBotton1.Location = new Point(166, 102);
            btkSwitchBotton1.Name = "btkSwitchBotton1";
            btkSwitchBotton1.Size = new Size(74, 46);
            btkSwitchBotton1.TabIndex = 0;
            btkSwitchBotton1.Text = "btkSwitchBotton1";
            // 
            // btkButton1
            // 
            btkButton1.BackColor = Color.ForestGreen;
            btkButton1.ForeColor = Color.Fuchsia;
            btkButton1.Location = new Point(556, 259);
            btkButton1.Name = "btkButton1";
            btkButton1.Size = new Size(94, 29);
            btkButton1.TabIndex = 1;
            btkButton1.Text = "btkButton1";
            btkButton1.UseVisualStyleBackColor = false;
            // 
            // ControlToolExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btkButton1);
            Controls.Add(btkSwitchBotton1);
            Name = "ControlToolExercise";
            Text = "ControlToolExercise";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BTKSwitchBotton btkSwitchBotton1;
        private BTKButton btkButton1;
    }
}
