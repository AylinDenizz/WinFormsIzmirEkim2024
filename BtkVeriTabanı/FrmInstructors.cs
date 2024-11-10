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
    public partial class FrmInstructors : Form
    {
        BtkCourseDbContext context = new BtkCourseDbContext();
        BindingList<DbInstructor> bList;
        public FrmInstructors()

        {
            bList = new BindingList<DbInstructor>(context.Instructors.ToList());
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bList;
        }

  
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            foreach (DbInstructor instructor in bList)
            {
                if (instructor.Id == 0)
                {
                    context.Instructors.Add(instructor);
                }
            }
            context.SaveChanges();
            Close();
        }
    }
}
