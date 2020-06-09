using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class01.Interface.Exercise01.Entities
{
    public class Student : User, IStudent
    {
        public int Grades { get; set; } = 5;
        public Student( int id, string name, string userName, string password)
            :base( id,  name,  userName,  password)
        {

        }

        public override void PrintUser()
        {
            Console.WriteLine($"Grades: {Grades}");
        }
    }
}
