using SEDC.Class01.Interface.Exercise01.Entities;
using System;

namespace SEDC.Class01.Interface.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student(123, "Bob Bobsky", "superbob", "bob123" );
            Student student2 = new Student(12, "Jill Wane", "jill_wane", "jill321");
            Teacher teacher1 = new Teacher(432, "Rob Sneider", "superrob", "rob123");
            Teacher teacher2 = new Teacher(222, "Romelu Lukaku", "extrarom", "rom123");
            student1.PrintUser();
            student2.PrintUser();
            teacher1.PrintUser();
            teacher2.PrintUser();
            Console.ReadLine();
        }
    }
}
