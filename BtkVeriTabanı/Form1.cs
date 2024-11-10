using BtkCourseManagement;
using BtkVeriTabanı.Db;
using BtkVeriTabanı.Models;
using System.ComponentModel;

namespace BtkVeriTabanı
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
