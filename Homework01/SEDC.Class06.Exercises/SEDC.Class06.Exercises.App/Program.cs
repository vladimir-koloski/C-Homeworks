﻿using SEDC.Class06.Exercises.Bussiness.Models;
using SEDC.Class06.Exercises.Bussiness.Services;
using System;

namespace SEDC.Class06.Exercises.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.ReadLine();
        }

        public static bool Register()
        {
            bool registration = true;
            while (registration)
            {
                Console.WriteLine("Enter 'Register' if you want to make new profile or 'Login' if you are allready registred");
                if (Console.ReadLine() == "Register")
                {
                    while (registration)
                    {
                        Console.WriteLine("Enter email:");
                        string inputEmail = Console.ReadLine();
                        EnterEmail(inputEmail);
                        Console.WriteLine("Enter password:");
                        string inputPasword = Console.ReadLine();
                        EnterPassword(inputPasword);
                        Console.WriteLine("Enter First Name:");
                        string inputFirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        string inputLastName = Console.ReadLine();
                        Console.WriteLine("Enter Date of Birth:");
                        DateTime inpututDate = Convert.ToDateTime(Console.ReadLine());


                        User[] users = new User[] { };
                        User user = new User(inputEmail, inputPasword, inputFirstName, inputLastName, inpututDate);
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = user;
                        foreach (var user1 in users)
                        {
                            if (inputEmail == user1.Email && inputPasword == user1.Password)
                                Console.WriteLine(user.GetInfo());
                        }
                        Console.WriteLine("Do you want to register another user? Enter yes or no");
                        string action = Console.ReadLine();
                        AnotherRegistration();
                    }
                                        
                                                       
                    }
                }
    
                if (Console.ReadLine() == "Login")
                {
                    Console.WriteLine("Enter email:");
                    string inputEmail = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string inputPasword = Console.ReadLine();
                    foreach (var user in users)
                    {
                        if (inputEmail == user.Email && inputPasword == user.Password)
                            Console.WriteLine(user.GetInfo());
                    }
                registration = false;
                }           
         
        }
        static string EnterEmail(string email)
        {
            var validationService = new ValidationService();
            if (!validationService.ValidateEmail(email))
            {
                Console.WriteLine("Enter Valid email");
            }
            return email;
        }
        static string EnterPassword(string password)
        {
            var validationService = new ValidationService();
            if (!validationService.ValidatePassword(password))
            {
                Console.WriteLine("Password is not valid please enter number and one Upper Case letter in password");
            }
            return password;
        }

        static bool AnotherRegistration(string action)
        {
            if (action == "no")
            {
                registration = false;
            }
            if (action == "yes")
            {
                Register();
            }
        }
    }


}


 
