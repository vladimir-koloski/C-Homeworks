using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class01.Interface.Exercise01.Entities
{
    public interface ITeacher
    {
         string Subject { get; set; }

         void PrintUser()
        {
            Console.WriteLine($"{Subject}");
        }
    }
}
