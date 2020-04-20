
using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Services
{
    public class Authentication
    {
        public static User Register(User[] users, ValidationService validationService)
        {
            string userName = EnterUserName(validationService, users);
            string password = EnterPassword(validationService);
            return CreateUser(userName, password);
        }

        public static User Login(User[] users, ValidationService validationService)
        {
            while (true)
            {
                Console.WriteLine("Enter email: ");
                string userName = Console.ReadLine();
                if (!validationService.ValidateUserName(userName))
                {
                    Console.WriteLine("Enter Valid Mail");
                    continue;
                }

                User user = FindUser(userName, users);
                if (user == null)
                {
                    Console.WriteLine("User does not exists");
                    continue;
                }
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (user.Password != password)
                {
                    Console.WriteLine("Password is incorect.");
                    continue;
                }

                return user;
            }
        }

        public static string EnterUserName(ValidationService validationService, User[] users)
        {
            while (true)
            {
                Console.WriteLine("Enter UserName(email): ");
                string userName = Console.ReadLine();
                if (!validationService.IsUserNameUnique(userName, users))
                {
                    Console.WriteLine("Email is allready taken");
                    continue;
                }
                if (!validationService.ValidateUserName(userName))
                {
                    Console.WriteLine("Enter Valid UserName (email)");
                    continue;
                }
                return userName;
            }
        }


        public static string EnterPassword(ValidationService validationService)
        {
            while (true)
            {
                Console.WriteLine("Enter password. Password should contain at least 8 characters, one big letter, and one digit");
                string password = Console.ReadLine();
                if (!validationService.ValidatePassword(password))
                {
                    Console.WriteLine("Enter valid password");
                    continue;
                }
                return password;

            }
        }

        private static User CreateUser(string userName, string password)
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter age: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            Console.Write("Enter phone Number: ");
            int phoneNumber;
            int.TryParse(Console.ReadLine(), out phoneNumber);

            Console.Write("Enter subsctiption: ");
            string typeOfSubscription = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Enter date of birth (format 02/19/1998)");
                string dob = Console.ReadLine();
                if (!DateTime.TryParse(dob, out DateTime dateOfBirth))
                {
                    Console.WriteLine("Please enter valid date of birth.");
                    continue;
                }

                User user = new User(firstName, lastName, age, userName, password, phoneNumber, Enumerations.Role.User, Enumerations.TypeOfSubscription.Montly);
                return user;
            }
        }

        private static User FindUser(string userName, User[] users)
        {
            foreach (var user in users)
            {
                if (user.UserName.ToLower() == userName.Trim().ToLower())
                {
                    return user;
                }
            }
            return null;
        }

        //public void DeleteUser(int deleteUserId, User[] users)
        //{
        //    foreach (User user in users)
        //    {
        //        if (user.Id == deleteUserId)
        //        {
        //            users.Remove(user);
        //        }
        //    }
        //}
    }
}
