using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class01.Interface.Exercise01.Entities
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; } = "CSharp";
        public Teacher(int id, string name, string userName, string password)
            :base(id, name, userName, password)
        {

        }
        
        public override void PrintUser()
        {
            Console.WriteLine($"{Subject}");
        }
    }
}
