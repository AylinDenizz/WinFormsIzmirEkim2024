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
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void btnOturumAc_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;

            DbUser user = null;

            BtkCourseDbContext context = new BtkCourseDbContext();

            user = context.Users.FirstOrDefault(
                e =>
                e.UserName == txtKullaniciAdi.Text &&
                e.Password == txtParola.Text);
            pbLoading.Visible = false;

            if (user == null)//hatalı parola
            {
                lblBilgi.Visible = true;
            }
            else
            {
                AppData.user = user;

                DialogResult = DialogResult.OK;//formu kapatıp deger döndürür
            }
        }
    }
}
}
