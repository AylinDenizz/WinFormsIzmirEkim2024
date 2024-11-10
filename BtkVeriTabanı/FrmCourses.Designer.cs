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
            panel1 = new Panel();
            btnSave = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            CourseName = new DataGridViewTextBoxColumn();
            CourseDescription = new DataGridViewTextBoxColumn();
            CourseDate = new DataGridViewTextBoxColumn();
            colCity = new DataGridViewComboBoxColumn();
            colDistrict = new DataGridViewComboBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            colInstructor = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseName, CourseDescription, CourseDate, colCity, colDistrict, Location, colInstructor });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.MinimumSize = new Size(50, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(929, 394);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
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
            panel1.Size = new Size(929, 56);
            panel1.TabIndex = 3;
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
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CourseName.DataPropertyName = "Name";
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 127;
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
            // colCity
            // 
            colCity.DataPropertyName = "LocatedCity";
            colCity.HeaderText = "City";
            colCity.MinimumWidth = 6;
            colCity.Name = "colCity";
            colCity.Width = 125;
            // 
            // colDistrict
            // 
            colDistrict.DataPropertyName = "LocatedDistrict";
            colDistrict.HeaderText = "District";
            colDistrict.MinimumWidth = 6;
            colDistrict.Name = "colDistrict";
            colDistrict.Width = 125;
            // 
            // Location
            // 
            Location.DataPropertyName = "CourseLocation";
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            Location.Width = 125;
            // 
            // colInstructor
            // 
            colInstructor.DataPropertyName = "InstructorId";
            colInstructor.HeaderText = "Instructor";
            colInstructor.MinimumWidth = 6;
            colInstructor.Name = "colInstructor";
            colInstructor.Width = 125;
            // 
            // FrmCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 450);
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
        private Button btnSave;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn CourseDescription;
        private DataGridViewTextBoxColumn CourseDate;
        private DataGridViewComboBoxColumn colCity;
        private DataGridViewComboBoxColumn colDistrict;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewComboBoxColumn colInstructor;
    }
}