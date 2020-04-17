using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Database
{
    public class EmployeeRepository : Database
    {
        public EmployeeRepository()
            : base()
        {
        }

        public User[] GetUsers()
        {
            return Users;
        }
        public Movie[] GetMovies()
        {
            foreach(Movie movie in Movies)
            {
                if(movie.IsAvailable == true)
                {
                    return movie;
                }
            }
            return null;
        }
    }
}
