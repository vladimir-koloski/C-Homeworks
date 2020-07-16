using SEDC.TimeTracking.Domain.Database;
using SEDC.TimeTracking.Domain.Entities;
using SEDC.TimeTracking.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracking.Services
{
    public class UserServices<T> : IUserServices<T> where T : User
    {
        private Db<T> _dB;
        private ActivityServices<BaseActivity> activityServices = new ActivityServices<BaseActivity>();
        public UserServices()
        {
            _dB = new Db<T>();
        }
        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            var user = _dB.GetUserById(userId);

            if (ValidationHelpers.ValidateFirstNameAndLastName(firstName, lastName) == null)
            {
                MessageHelpers.Message("The first and last name should not be shorter than 2 characters and must not contain numbers!", ConsoleColor.Red);
                return;

            }
            user.FirstName = firstName;
            user.LastName = lastName;
            _dB.UpdateUser(user);
            MessageHelpers.Message("You succesfully changed your info", ConsoleColor.Green);
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = _dB.GetUserById(userId);
            if(ValidationHelpers.ValidatePassword(newPassword) == null)
            {
                MessageHelpers.Message("The password you entered must contain at least one capital letter, at least one number " +
                    "and should not be shorter than 6 characters", ConsoleColor.Red);
                return;
            }
            user.Password = newPassword;
            _dB.UpdateUser(user);
            MessageHelpers.Message("You succesfully changed your password", ConsoleColor.Green);
        }

        public bool DeactivateAccount(T user)
        {
            throw new NotImplementedException();
        }

        public T LogIn(string username, string password)
        {
            var users = _dB.GetAll();
            T user = null;

            if(!ValidationHelpers.DoesUserNameExists(users, username))
            {
                for (int i = 1; i <= 3; i++)
                {
                    MessageHelpers.Message("You have been entered userName that not exixst", ConsoleColor.Red);
                    Console.WriteLine("Enter your username again: ");
                    username = Console.ReadLine();
                    if(ValidationHelpers.DoesUserNameExists(users, username))
                    {
                        break;
                    }
                    if(i == 3 && !ValidationHelpers.DoesUserNameExists(users, username)){
                        Environment.Exit(0);
                    }
                }
            }
            Console.Clear();
            user = users.FirstOrDefault(user => user.Username == username);

            if(!ValidationHelpers.ThreeChanceForLogin(user, password))
            {
                Environment.Exit(0);
            }
            Console.Clear();
            MessageHelpers.Message("You succesfully logged in!", ConsoleColor.Green);
            return user;
        }

        public T Register(T user)
        {
            if(ValidationHelpers.ValidateFirstNameAndLastName(user.FirstName, user.LastName) == null
                || ValidationHelpers.AgeValidation(user.Age) == -1
                || ValidationHelpers.ValidateUserName(user.Username) == null
                || ValidationHelpers.ValidatePassword(user.Password) == null)
            {
                MessageHelpers.Message("You have entered something wrong!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }
            int id = _dB.Insert(user);
            return _dB.GetUserById(id);

        }

        public void UserStatistics(User user, int choice)
        {
            switch (choice)
            {
                case 1: //Reading
                    activityServices.ReadingStatistics(user);
                    break;
                case 2: //Working
                    activityServices.WorkingStatistics(user);
                    break;
                case 3: // Exercising
                    activityServices.ExercisingStatistics(user);
                    break;
                case 4: // Other hobbies
                    activityServices.OtherHobbiesStatistics(user);
                    break;
                case 5: // General
                    activityServices.GeneralStatistics(user);
                    break;
                default:
                    break;
            }
        }
        public bool AccountSettings(int id, int choice, T user)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter your new first and last name!");
                    Console.Write("Fisrt name: ");
                    string fisrtName = Console.ReadLine();
                    Console.Write("Last name: ");
                    string lastName = Console.ReadLine();
                    ChangeInfo(id, fisrtName, lastName);
                    break;
                case 2:
                    Console.WriteLine("Enter your old password");
                    Console.Write("Old password: ");
                    string oldPassword = Console.ReadLine();
                    Console.WriteLine("Enter your new password");
                    Console.Write("New password: ");
                    string newPassword = Console.ReadLine();
                    ChangePassword(id, oldPassword, newPassword);
                    break;
                case 3:
                    if (DeactivateAccount(user))
                    {
                        return true;
                    }
                    break;
                case 4:
                    break;
            }
            return false;
        }
    }
}
