using SEDC.Class07.MovieStore.Entities.Enumerations;
using SEDC.Class07.MovieStore.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        private int Price { get; set; }
        public bool IsAvailable { get; set; }
        public int Id { get; set; }

        public Movie(string title, string description, int year, Genre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            IsAvailable = true;
            Id = IdGenerator.GenerateId();

        }

        public int SetPrice()
        {
            Random r = new Random();            
            if (Year < 2000)
            {
                Price = r.Next(100, 200);
            }
            if (Year <= 2000 && Year < 2010)
            {
                Price = r.Next(200, 300);
            }
            if (Year > 2010)
            {
                Price = r.Next(300, 500);
            }
            return Price;
        }

        public bool ChangeAvailability()
        {
            return IsAvailable = !IsAvailable;
        }

        public string Info()
        {
            return $"{Id} Title: {Title}, year: {Year}, genre: {Genre}";
        }
    }
}
