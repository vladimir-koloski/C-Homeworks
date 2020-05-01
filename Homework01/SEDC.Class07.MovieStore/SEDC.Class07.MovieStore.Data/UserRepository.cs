using SEDC.Class07.MovieStore.Entities.Enumerations;
using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Data
{
    public class UserRepository : Database
    {
        public UserRepository()
            : base()
        {
        }
        public User[] GetUsers()
        {
            return Users;
        }

        public double CalcMembershipLeft(User user)
        {
            double daysLeft = 0.0;
            if(user.TypeOfSubscription.ToString() == "Montly")
            {
                daysLeft = 30 - (DateTime.Now - user.DateOfRegistration).TotalDays;
            }
            else if (user.TypeOfSubscription.ToString() == "Annualy")
            {
                daysLeft = 365 - (DateTime.Now - user.DateOfRegistration).TotalDays;
            }
            return daysLeft;
        }

        //public void ExpirationMembership()
        //{
        //    return $"You have {CalcMembershipLeft()} left till expiration od Membership";
        //}
    }
}
