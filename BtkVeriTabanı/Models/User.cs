using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkCourseManagement.Models
{
    public enum AuthorizationStatus { Admin = 0, User = 1 };
    public class DbUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public AuthorizationStatus AuthorizationStatus { get; set; }
        public int? EmailAdress { get; set; }
        public int? PhoneNumber { get; set; }

    }
}
