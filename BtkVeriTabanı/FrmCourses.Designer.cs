namespace BtkCourseManagement
{
    partial class FrmCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourses));
            dataGridView1 = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            CourseDescription = new DataGridViewTextBoxColumn();
            CourseDate = new DataGridViewTextBoxColumn();
            City = new DataGridViewComboBoxColumn();
            District = new DataGridViewComboBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            Instructor = new DataGridViewComboBoxColumn();
            panel1 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseName, CourseDescription, CourseDate, City, District, Location, Instructor });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 394);
            dataGridView1.TabIndex = 4;
            // 
            // CourseName
            // 
            CourseName.DataPropertyName = "Name";
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 125;
            // 
            // CourseDescription
            // 
            CourseDescription.DataPropertyName = "Description";
            CourseDescription.HeaderText = "Description";
            CourseDescription.MinimumWidth = 6;
            CourseDescription.Name = "CourseDescription";
            CourseDescription.Width = 125;
            // 
            // CourseDate
            // 
            CourseDate.DataPropertyName = "CreatedDate";
            CourseDate.HeaderText = "Date";
            CourseDate.MinimumWidth = 6;
            CourseDate.Name = "CourseDate";
            CourseDate.Width = 125;
            // 
            // City
            // 
            City.DataPropertyName = "LocatedCity";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // District
            // 
            District.DataPropertyName = "LocatedDistrict";
            District.HeaderText = "District";
            District.MinimumWidth = 6;
            District.Name = "District";
            District.Width = 125;
            // 
            // Location
            // 
            Location.DataPropertyName = "CourseLocation";
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            Location.Width = 125;
            // 
            // Instructor
            // 
            Instructor.DataPropertyName = "InstructorId";
            Instructor.HeaderText = "Instructor";
            Instructor.MinimumWidth = 6;
            Instructor.Name = "Instructor";
            Instructor.Width = 125;
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
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCoral;
            textBox1.Cursor = Cursors.No;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBox1.Location = new Point(46, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 41);
            textBox1.TabIndex = 3;
            textBox1.Text = "Courses";
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
            // btnSave
            // 
            btnSave.Location = new Point(701, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(56, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FrmCourses";
            Text = "FrmCourses";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn CourseDescription;
        private DataGridViewTextBoxColumn CourseDate;
        private DataGridViewComboBoxColumn City;
        private DataGridViewComboBoxColumn District;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewComboBoxColumn Instructor;
        private Button btnSave;
    }
}