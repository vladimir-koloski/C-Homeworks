using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Data
{
    public class MovieRepository : Database
    {
        public MovieRepository()
            : base()
        {    
        }

        public Movie[] GetMovies()
        {
            return Movies;
        }

        public void GetAvailableMovies()
        {
            foreach (Movie movie in Movies)
            {
                if (movie.IsAvailable)
                {
                    Console.WriteLine(movie.Info());
                }
            }
            
        }
        public Movie GetMovieById(int movieId)
        {
            foreach (Movie movie in Movies)
            {
                if (movie.Id == movieId)
                {
                    return movie;
                }
            }
            return null;
        }
    }
}
