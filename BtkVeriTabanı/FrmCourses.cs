using BtkVeriTabanı.Db;
using BtkVeriTabanı.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkCourseManagement
{
    public partial class FrmCourses : Form
    {
        BtkCourseDbContext context = new BtkCourseDbContext();
        BindingList<DbCourse> bList;
        public FrmCourses()

        {
            bList = new BindingList<DbCourse>(context.Courses.ToList());
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bList;

            colInstructor.DataSource = context.Instructors.ToList();
            colInstructor.DisplayMember = "AdSoyad";
            colInstructor.ValueMember = "Id";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DbCourse course in bList)
            {
                if (course.Id == 0)
                {
                    context.Courses.Add(course);
                }
            }
            context.SaveChanges();
            Close();
        }
    }
}
