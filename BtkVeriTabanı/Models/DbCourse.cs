﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkCourseManagement.Models
{
    internal class DbCourse
    {
        public  int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public  DateTime CreatedDate { get; set; }
        public int? LocatedCity {  get; set; }
        public int?  LocatedDistrict {  get; set; }
        public string? CourseLocation {  get; set; }
        public int? InstructorId {get; set; }
        public DbInstructor Instructor { get; set; }
        public DbCourse() { }
    }


}
