using SEDC.Class07.MovieStore.Entities.BaseModels;
using SEDC.Class07.MovieStore.Entities.Enumerations;
using SEDC.Class07.MovieStore.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Models
{
    public class User : Member
    {
        public int Id { get; set; }
        public TypeOfSubscription TypeOfSubscription { get; set; }
        public Movie[] Movie { get; set; }

        public User(string firstName, string lastName, int age, string userName, string password, int phoneNumber, Role role, TypeOfSubscription typeOfSubscription )
            : base (firstName, lastName, age, userName, password, phoneNumber, role)
        {
            Id = IdGenerator.GenerateId();
        }
    }
}
