using SEDC.Class06.Exercises.Bussiness.Models;
using SEDC.Class06.Exercises.Bussiness.Services;
using System;

namespace SEDC.Class06.Exercises.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[] { };
            bool login = true;
            bool success = true;
            while (login)
            {
                Console.WriteLine("Enter 'Register' if you want to make new profile or 'Login' if you are allready registred");
                if (Console.ReadLine() == "Register")
                {
                    while (success)
                    {
                        Console.WriteLine("Enter email:");
                        string inputEmail = Console.ReadLine();
                        var validationService = new ValidationService();
                        if (!validationService.ValidateEmail(inputEmail))
                        {
                            Console.WriteLine("Enter Valid email");
                        }

                        Console.WriteLine("Enter password:");
                        string inputPasword = Console.ReadLine();
                        if (!validationService.ValidatePassword(inputPasword))
                        {
                            Console.WriteLine("Password is not valid please enter number and one Upper Case letter in password");
                        }

                        Console.WriteLine("Enter First Name:");
                        string inputFirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        string inputLastName = Console.ReadLine();
                        Console.WriteLine("Enter Date of Birth:");
                        DateTime inpututDate = Convert.ToDateTime(Console.ReadLine());



                        User user = new User(inputEmail, inputPasword, inputFirstName, inputLastName, inpututDate);
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = user;

                        Console.WriteLine("Do you want to register another user? Enter yes or no");
                        if (Console.ReadLine() == "no")
                        {
                            success = false;
                        }
                        if (Console.ReadLine() == "yes")
                        {
                            continue;
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
                    login = false;

                }
                Console.ReadLine();
            }


        }


    }
}
