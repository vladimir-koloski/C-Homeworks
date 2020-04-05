using SEDC.Class06.Exercises.Bussiness.Models;
using SEDC.Class06.Exercises.Bussiness.Services;
using System;

namespace SEDC.Class06.Exercises.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'Register' if you want to make new profile or 'Login' if you are allready registred");
            if (Console.ReadLine() == "Register")
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
            Register(User[] users, user);
                   
            }
            //Console.WriteLine("Do you want to register another user? Enter yes or no");
            //string action = Console.ReadLine();

            //if (action == "yes")
            //{
            //    Register();
            //}
            //else
            //{
            //    registration = false;
            //}
            //if (Console.ReadLine() == "Login")
            {
                Console.WriteLine("Enter email:");
                string inputEmail = Console.ReadLine();                
                Console.WriteLine("Enter password:");
                string inputPasword = Console.ReadLine();
                if(Login(inputEmail, inputPasword) == true)
                {
                    PrintUsers(User[] users);
                }              
                
                
            }

                Console.ReadLine();
        }

        public void PrintUsers(User [] users)
        {
            foreach (var user in users)
            {
               Console.WriteLine(user.GetInfo());
            }
        }

        
        public static void Register(User[] users, User user)            
        {      
        
            {
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = user;               
            }
        }
        
        public bool Login(string email, string password)
            {
                foreach (var user in users)
                {
                    if (email == user.Email && password == user.Password);
                       
                }
                return true;
                
            }

             public static void EnterEmail(string email)
            {
                var validationService = new ValidationService();
                if (!validationService.ValidateEmail(email))
                {
                    Console.WriteLine("Enter Valid email");
                }

            }
            public static string EnterPassword(string password)
            {
                var validationService = new ValidationService();
                if (!validationService.ValidatePassword(password))
                {
                    Console.WriteLine("Password is not valid please enter number and one Upper Case letter in password");
                }
                return password;
            }


        }


    }



 
