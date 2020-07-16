using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int Age { get; set; }
        public bool IsActive { get; set; }
        public List<BaseActivity> ListOfActivities { get; set; }

        public User(string firstName, string lastName, string userName, string password, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = userName;
            Password = password;
            Age = age;
            IsActive = true;
            ListOfActivities = new List<BaseActivity>();
        }

        public User()
        {
        }
    }

    
}
