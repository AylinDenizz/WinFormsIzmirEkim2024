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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colSil.Index)
            {
                DbInstructor instructor = dataGridView1.Rows[e.RowIndex].DataBoundItem as DbInstructor;

                if (instructor != null)
                {
                    var response = MessageBox.Show("Would you like to delete the instructor named as " +
                        instructor.AdSoyad, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (response == DialogResult.Yes)
                    {
                        bList.Remove(instructor);
                        context.Instructors.Remove(instructor);

                    }
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == colSil.Index && e.RowIndex >= 0)
            {
                e.PaintContent(e.CellBounds);
                e.PaintBackground(e.ClipBounds, false);

                if (e.RowIndex < dataGridView1.RowCount - 1)
                {
                    e.Graphics.DrawImage(Properties.Resources.delete,
                        new Rectangle(e.CellBounds.Left + 5, e.CellBounds.Top + 3, 20, 20),
                        new Rectangle(0, 0, 24, 24), GraphicsUnit.Pixel);
                }

            }
        }
    }
}
