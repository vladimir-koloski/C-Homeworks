using SEDC.Class07.MovieStore.Entities.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.BaseModels
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }

        public Member(string firstName, string lastName, int age, string userName, string password, int phoneNumber, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = DateTime.Now;
            Role = role;
        }

        public string DysplayInfo()
        {
            return $"1. {FirstName} {LastName} Registred on: {DateOfRegistration}";
        }
    }
}
