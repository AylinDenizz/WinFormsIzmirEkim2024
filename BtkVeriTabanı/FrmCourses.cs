using BtkCourseManagement.Db;
using BtkCourseManagement.Models;
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

            GetCities();
        }

        private async void GetCities()
        {
            List<City> sehirler = await TurkiyeAPI.SehirleriGetir();
            colCity.DataSource = sehirler;
            colCity.DisplayMember = "name";
            colCity.ValueMember = "id";

            TurkiyeAPI.GetDistricts(35);

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

        private async void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colCity.Index)
            {
                int? id = (int?)dataGridView1.Rows[e.RowIndex].Cells[colCity.Index].Value;

                dataGridView1.Rows[e.RowIndex].Cells[colDistrict.Index].Value = null;

                if (id.HasValue)
                {
                    colDistrict.DataSource = await TurkiyeAPI.GetDistricts((int)id);
                    colDistrict.DisplayMember = "name";
                    colDistrict.ValueMember = "id";
                }
            }
        }

    
    }
}
