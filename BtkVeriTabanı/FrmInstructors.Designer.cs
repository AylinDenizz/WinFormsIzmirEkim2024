﻿namespace BtkCourseManagement
{
    partial class FrmInstructors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstructors));
            dataGridView1 = new DataGridView();
            InstructorName = new DataGridViewTextBoxColumn();
            InstructorSurName = new DataGridViewTextBoxColumn();
            colSil = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnSave = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { InstructorName, InstructorSurName, colSil });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 394);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // InstructorName
            // 
            InstructorName.DataPropertyName = "Name";
            InstructorName.HeaderText = "Instructor Name";
            InstructorName.MinimumWidth = 6;
            InstructorName.Name = "InstructorName";
            InstructorName.Width = 200;
            // 
            // InstructorSurName
            // 
            InstructorSurName.DataPropertyName = "Surname";
            InstructorSurName.HeaderText = "Instructor Surname";
            InstructorSurName.MinimumWidth = 6;
            InstructorSurName.Name = "InstructorSurName";
            InstructorSurName.Width = 200;
            // 
            // colSil
            // 
            colSil.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSil.FlatStyle = FlatStyle.Flat;
            colSil.HeaderText = "";
            colSil.MinimumWidth = 6;
            colSil.Name = "colSil";
            colSil.Resizable = DataGridViewTriState.True;
            colSil.SortMode = DataGridViewColumnSortMode.Automatic;
            colSil.Text = "Sil";
            colSil.ToolTipText = "Sil";
            colSil.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(677, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(56, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCoral;
            textBox1.Cursor = Cursors.No;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBox1.Location = new Point(46, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 41);
            textBox1.TabIndex = 3;
            textBox1.Text = "Instructors";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmInstructors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmInstructors";
            Text = "FrmInstructors";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnSave;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn InstructorName;
        private DataGridViewTextBoxColumn InstructorSurName;
        private DataGridViewButtonColumn colSil;
    }
}