using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkVeriTabanı.Models
{
    internal class DbInstructor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        public DbInstructor() { }
        public  List<DbCourse> Courses { get; set; } = new List<DbCourse>();

        [NotMapped]
        public string AdSoyad { get { return Name + " " + Surname; } }
    }
}
