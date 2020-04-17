using SEDC.Class07.MovieStore.Entities.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Decription { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        private int Price { get; set; }

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
    }
}
