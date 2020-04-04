using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        public int Pin { get; set; }
        public int AccountBalance { get; set; }

        public Customer(string firstName, string lastName,long cardNumber, int pin, int accountBalance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            AccountBalance = accountBalance;
        }

        public string GetInfo()
        {
            return GetFullName();
        }

        public string GetFullName()
        {
            return $"{FirstName}{LastName}";
        }

        
    }
}
