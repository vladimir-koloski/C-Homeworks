using System;
using SEDC.TimeTracking.Services.Menus;
using SEDC.TimeTracking.Services.Helpers;
using SEDC.TimeTracking.Domain.Entities;
using SEDC.TimeTracking.Services;
using System.Collections.Generic;
using System.Threading;
using SEDC.TimeTracking.Domain.Enums;

namespace SEDC.TimeTracking.App
{
    class Program
    {
        public static Menu _menu = new Menu();
        public static User _currentUser = new User();
        public static IUserServices<User> _userService = new UserServices<User>();
        public static ActivityServices<BaseActivity> _activityServices = new ActivityServices<BaseActivity>();

        static void Main(string[] args)
        {
            UsersList();
            //_menu.HomeScreen();

            while (true)
            {
                int menuChoice = _menu.LogInMenu();
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter username: ");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string password = Console.ReadLine();

                        _currentUser = _userService.LogIn(userName, password);
                        break;
                    case 2:
                        Console.WriteLine("Enter your First Name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter your Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter your userName: ");
                        string nameUser = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        string userPassword = Console.ReadLine();
                        Console.WriteLine("Enter your age: ");
                        int age = ValidationHelpers.TryParseNumber(Console.ReadLine(), 120);

                        var user = new User(firstName, lastName, nameUser, userPassword, age);
                        
                        _currentUser = _userService.Register(user);
                        if(_currentUser == null)
                        {
                            MessageHelpers.Message("Unsuccesful registration please try again", ConsoleColor.Red);
                            Thread.Sleep(1500);
                            continue;
                        }                        
                        MessageHelpers.Message("You succesfully registered!", ConsoleColor.Green);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;

                }

                bool isLoggedIn = true;
                while (isLoggedIn)
                {
                    Console.WriteLine($"Hi {_currentUser.FirstName} choose one of the following?");
                    int choice = _menu.MainMenu();
                    ActivityType currentActivity = (ActivityType)choice;
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            _activityServices.TrackingTime(currentActivity, _currentUser);
                            break;
                        case 5:
                            if (!ValidationHelpers.CheckIfListIsEmpty(_currentUser.ListOfActivities, "statistics")) continue;
                            int statisticsMenu = _menu.StatisticsMenu();
                            _userService.UserStatistics(_currentUser, statisticsMenu);
                            break;
                        case 6:
                            int accountMenu = _menu.AccountMenu();
                            if (_userService.AccountSettings(_currentUser.Id, accountMenu, _currentUser))
                            {
                                isLoggedIn = !isLoggedIn;
                            }
                            break;
                        case 7:
                            isLoggedIn = !isLoggedIn;
                            break;
                        default:
                            break;
                    }
                }
            }           
        }
        public static List<User> UsersList()
        {
            List<User> users = new List<User>()
            {
                 _userService.Register(new User("John", "Smith", "smith", "Smith123", 33)),
                 _userService.Register(new User("Bob", "Bobsky", "bobsky", "Bobsky123", 22)),
            };

            return users;
        }
    }
}
