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
            else if (user.TypeOfSubscription.ToString() == "Annually")
            {
                daysLeft = 365 - (DateTime.Now - user.DateOfRegistration).TotalDays;
            }
            return daysLeft;
        }

        public string ExpirationMembership(User user)
        {
            return $"You have {CalcMembershipLeft(user)} days left till expiration od Membership";
        }

        public Movie[] ShowMovieList(Movie[] movies)
        {
            foreach(var movie in movies)
            {
                if(!movie.IsAvailable)
                {
                    movie.Title = movie.Title + "*";
                }
            }
            return movies;
        }

        public void RentMovie(int id, Movie[] movies)
        {
            foreach (var movie in movies)
            {
                if(movie.Id == id)
                {
                    AddRentedMovie(movie);
                }
            }
        }
    }
}
