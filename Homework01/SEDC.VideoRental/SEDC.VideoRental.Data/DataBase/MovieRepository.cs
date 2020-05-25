﻿using SEDC.VideoRental.Data.Database;
using SEDC.VideoRental.Data.Enums;
using SEDC.VideoRental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.VideoRental.Data.DataBase
{
    public class MovieRepository : InMemoryDatabase
    {
        public List<Movie> GetAllMovies()
        {
            return Movies;
        }

        public List<Movie> GetByGenre(Genre genre)
        {
            return Movies.Where(_movie => _movie.Genre == genre).ToList();
        }

        public List<Movie> OrderByGenre()
        {
            return Movies.OrderBy(_movie => _movie.Genre).ToList();
        }

        public List<Movie> OrederByReleaseDate(bool desc = false)
        {
            if (desc)
            {
                return Movies.OrderByDescending(_movie => _movie.ReleaseDate).ToList();
            }
            return Movies.OrderBy(_movie => _movie.ReleaseDate).ToList();
        }
        
        public List<Movie> GetByYear(int year)
        {
            return Movies.Where(_movie => _movie.ReleaseDate.Year == year).ToList();
        }

        public List<Movie> GetAvailableMovies()
        {
            return Movies.Where(_movie => _movie.IsAvailable).ToList();
        }

        public List<Movie> OrderByAvailability(bool desc = false)
        {
            if (desc)
            {
                return Movies.OrderByDescending(_movie => _movie.IsAvailable).ToList();
            }
            return Movies.OrderBy(_movie => _movie.IsAvailable).ToList();
        }

        public List<Movie> SearchMoviesByTitle(string titlePart)
        {
            return Movies.Where(_movie => _movie.Title.ToLower().Contains(titlePart)).ToList();
        }

        public Movie GetMovieById(int id)
        {
            return Movies.FirstOrDefault(_movie => _movie.Id == id);
        }

    }
}
