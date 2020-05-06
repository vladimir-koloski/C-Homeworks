using Homework08.Linq.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08.Linq.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre favoriteMusicType)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;

        }
        public void GetFavSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
                       
        }

    }



    
}
