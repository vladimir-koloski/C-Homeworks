using SEDC.Class07.MovieStore.Entities.Enumerations;
using SEDC.Class07.MovieStore.Entities.Models;
using System;

namespace SEDC.Class07.MovieStore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Vladimir", "Koloski", 25, "vlatko_vin", "ludiot", 075215803, Role.Employee, 162);
            Console.WriteLine(employee.SetSalary());
            Console.ReadLine();
        }
    }
}
