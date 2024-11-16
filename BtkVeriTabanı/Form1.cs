using BtkCourseManagement;
using BtkCourseManagement.Db;
using BtkCourseManagement.Models;
using System.ComponentModel;

namespace BtkCourseManagement
{
    public partial class Courses : Form
    {


        public Courses()
        {
            InitializeComponent();

        }

        private void tsbKurslar_Click(object sender, EventArgs e)
        {
            FrmCourses courses = new FrmCourses();
            courses.ShowDialog();
        }

        private void BtnInstructors_Click(object sender, EventArgs e)
        {
            FrmInstructors ınstructors = new FrmInstructors();
            ınstructors.ShowDialog();

        }
    }
}
