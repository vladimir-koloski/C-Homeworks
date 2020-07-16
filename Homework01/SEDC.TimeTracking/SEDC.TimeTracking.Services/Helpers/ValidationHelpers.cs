using SEDC.TimeTracking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracking.Services.Helpers
{
    public static class ValidationHelpers
    {
        public static int TryParseNumber(string number, int range)
        {
            int parsedNum = 0;
            bool IsNumParsed = int.TryParse(number, out parsedNum);

            if (!IsNumParsed)
            {
                return -1;
            }
            if (parsedNum <= 0 || parsedNum > range)
            {
                return -1;
            }
            return parsedNum;
        }

        public static string ValidateUserName(string userName)
        {
            bool isFalse = false;
            while (isFalse)
            {
                if (userName.Length < 5)
                {
                    Console.WriteLine("Enter name longer than 5 characters");
                }
                else
                {                    
                    isFalse = true;
                }
            }
            return userName;
        }

        public static string ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                return null;
            }

            foreach (var letter in password)
            {
                if (Char.IsUpper(letter) && !Char.IsNumber(letter))
                {
                    return password;
                }
            }

            return null;
        }

        public static string ValidateFirstNameAndLastName(string firstName, string lastName)
        {
            if(firstName.Length < 2 || lastName.Length < 2)
            {
                return null;
            }
             
            foreach (var character in firstName.ToCharArray())
            {
                if (char.IsNumber(character))
                {
                    return firstName;
                }
            }
            foreach (var character in lastName.ToCharArray())
            {
                if (char.IsNumber(character))
                {
                    return lastName;
                }
            }

            return null;
        }

        public static int AgeValidation(int age)
        {
            if(age < 18 && age > 120)
            {
                return -1;
            }
            return age;
        }

        public static bool ThreeChanceForLogin(User user, string password)
        {
            for (int i = 0; i < 3; i++)
            {
                if(user.Password != password)
                {
                    Console.WriteLine("Wrong password. Please enter a valid password");
                    password = Console.ReadLine();

                    if (i == 3 && user.Password != password)
                    {
                        return false;
                    };
                }
            }
            return true;
        }

        public static bool DoesUserNameExists<T>(List<T> users, string userName) where T : User
        {
            foreach (var user in users)
            {
                if(user.Username == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetFavouriteType<T>(T type, List<T> listOfactivities) where T : BaseActivity
        {
            int count = listOfactivities.Where(x => x.Equals(type)).Count();

            return count;
        }

        public static bool CheckIfListIsEmpty<T>(List<T> list, string activity)
        {
            if (list.Count == 0)
            {
                MessageHelpers.Message($"Sorry your {activity} are empty because you haven't tracked any activity!", ConsoleColor.Red);
                return false;
            }
            return true;


        }
    }
}
