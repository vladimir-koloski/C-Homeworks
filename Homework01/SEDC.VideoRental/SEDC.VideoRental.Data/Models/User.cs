using SEDC.VideoRental.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.VideoRental.Data.Models
{
    public class User :BaseEntity
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CardNumber { get; set; }
        public bool IsSubscrioptionExpired { get; set; }
        public bool IsAdmin { get; set; }
        public List<RentalInfo> RentedMovies { get; set; }
        public List<RentalInfo> RentedMoviesHistory { get; set; }

        public User(string name, DateTime dateOfBirth, int cardNumber)
        {
            FullName = name;
            DateOfBirth = dateOfBirth;
            CardNumber = cardNumber;
        }

        public User()
        {
            IsSubscrioptionExpired = false;
            RentedMovies = new List<RentalInfo>();
            RentedMoviesHistory = new List<RentalInfo>();
        }

        

    }
}
