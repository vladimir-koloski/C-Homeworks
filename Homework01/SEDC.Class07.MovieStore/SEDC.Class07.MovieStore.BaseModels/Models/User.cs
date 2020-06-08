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
        
        public TypeOfSubscription TypeOfSubscription { get; set; }
        private Movie[] _movies = new Movie[0];

        public User(string firstName, string lastName, int age, string userName, string password, int phoneNumber, Role role, TypeOfSubscription typeOfSubscription)
            : base (firstName, lastName, age, userName, password, phoneNumber, role)
        {
            TypeOfSubscription = typeOfSubscription;
            //Movies = new Movie[0];
        }

        public void AddRentedMovie(Movie movie)
        {
            Array.Resize(ref _movies, _movies.Length + 1);
            _movies[_movies.Length - 1] = movie;
        }
    }
}
