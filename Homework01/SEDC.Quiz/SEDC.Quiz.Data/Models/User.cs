using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Quiz.Data.Models
{
    public class User
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Grade { get; set; }
        public bool IsTeacher  { get; set; }
        public bool DoneTest { get; set; }

        public User( )
        {
            

        }
    }
}
