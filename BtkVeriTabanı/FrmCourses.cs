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
        BindingList<DbCourse> bList; public FrmCourses()
        
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Courses.ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
