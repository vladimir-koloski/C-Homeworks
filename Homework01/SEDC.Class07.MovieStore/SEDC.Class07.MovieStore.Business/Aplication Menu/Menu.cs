using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Business.Aplication_Menu
{
    public class Menu
    {
        public static void PrintMovies(Movie[] movies)
        {
            foreach(Movie movie in movies)
            {
                Console.WriteLine(movie.Info());
            }
        }

        public static void PrintUsers(User[] users)
        {
            foreach(User user in users)
            {
                Console.WriteLine(user.DysplayInfo());
            }
        }


    }
}
