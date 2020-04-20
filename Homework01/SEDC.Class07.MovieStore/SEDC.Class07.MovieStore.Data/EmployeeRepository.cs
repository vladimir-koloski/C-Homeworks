﻿using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Data
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
            return Movies;
        }

        public Movie[] GetAvailableMovies()
        {
            foreach(Movie movie in Movies)
            {
                if(movie.IsAvailable == false)
                {
                    return null;
                }
            }
            return Movies;
        }

        
    }
}