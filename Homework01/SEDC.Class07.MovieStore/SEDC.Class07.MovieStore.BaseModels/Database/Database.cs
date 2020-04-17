using SEDC.Class07.MovieStore.Entities.Enumerations;
using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Database
{
    public class Database
    {
        protected Movie[] Movies { get; set; }
        protected Employee[] Employees { get; set; }
        protected User[] Users { get; set; }

        public Database()
        {
            GenerateDb();
        }

        public void GenerateDb()
        {
            Movies = new Movie[]
            {
                new Movie("Rambo", "Vietnam war", 1987, Genre.Action),
                new Movie("Liar Liar", "Something", 2001, Genre.Commedy),
                new Movie("Negotiator", "Something", 1995, Genre.Action),
                new Movie("Terminator 3", "Something", 2015, Genre.Commedy),
                new Movie("Bad Boys", "Something", 2020, Genre.Commedy),
                new Movie("Avatar", "Something", 2009, Genre.SF),
                new Movie("The Hunt", "Something", 2012, Genre.Drama),
                new Movie("Next three days", "Something", 2008, Genre.Triler),
                new Movie("Naked gun", "Something", 1985, Genre.Commedy),
            };

            Users = new User[]
            {
                new User("john", "malcovich", 35, "john@yahoo.com", "Malcovich123", 078888777, Role.User, TypeOfSubscription.Annually),
                new User("Majk", "Tajson", 35, "majk@yahoo.com", "Tajson123", 077888333, Role.User, TypeOfSubscription.Annually)
            };

            Employees = new Employee[]
            {
                new Employee("Vladimir", "Koloski", 35,"vlatko@vlatko.com", "Vlatko12", 075222777, Role.Employee, 162)
            };
        }
    }
}
