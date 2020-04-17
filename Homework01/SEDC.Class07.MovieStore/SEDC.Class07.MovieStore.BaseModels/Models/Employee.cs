using SEDC.Class07.MovieStore.Entities.BaseModels;
using SEDC.Class07.MovieStore.Entities.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Models
{
    public class Employee : Member
    {
        private double Salary { get; set; }

        public double HoursPerMonth { get; set; }
        public double Bonus { get; set; }

        public Employee(string firstName, string lastName, int age, string userName, string password, int phoneNumber, Role role, double hoursPerMonth)
            : base(firstName, lastName, age, userName, password, phoneNumber, role)
        {
            Salary = 300;
            HoursPerMonth = hoursPerMonth;
        }

        public double SetBonus(double hoursPerMonth)
        {
            if (HoursPerMonth <= 160)
            {
                Bonus = 1;
            }
            else
            {
                Bonus = 1.3;
            }
            return Bonus;          

        }

        public double GetBasicSalary() 
        {
            return Salary;
        }

        public double SetSalary()
        {
            Salary = Salary * SetBonus(HoursPerMonth);
            return Salary;
        }


    }
}
