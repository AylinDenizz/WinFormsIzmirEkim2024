using BtkCourseManagement.Models;
using BtkCourseManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BtkCourseManagement.Db
{
    internal class BtkCourseDbContext : DbContext
    {
        public DbSet<DbCourse> Courses { get; set; }
        public DbSet<DbInstructor> Instructors { get; set; }
        public DbSet<DbUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; " +
                "Initial Catalog = BtkCourseDb; Integrated Security = True;" +
                " Encrypt = False; Trust Server Certificate = False;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbCourse>().HasOne(e => e.Instructor)
                .WithMany(e => e.Courses).HasForeignKey(e=>e.InstructorId)
                .HasPrincipalKey(e=>e.Id);

            modelBuilder.Entity<DbUser>().HasData(new DbUser() { Id = 1, UserName = "Admin", 
                AuthorizationStatus = AuthorizationStatus.Admin, Password = "Aa12345" });
        }
    }

}
