using System;
using SEDC.TimeTracking.Services.Helpers;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.TimeTracking.Services.Menus
{
    public class Menu
    {
        public void HomeScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==  \\\\    //\\    // ||||||   ||      |||||  ||||||   |||  |||  ||||||   ==");
            Console.WriteLine("==   \\\\  //  \\  //  ||=      ||      ||     ||  ||   || || ||  ||=      ==");
            Console.WriteLine("==    \\\\//    \\//   ||||||   ||||||  |||||  ||||||   ||    ||  ||||||   ==");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==========================================================================");
            Console.ResetColor();
        }
        public int ChooseOnMenu<T>(List<T> list)
        {
            Console.WriteLine("Enter a number to choose");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.) {list[i]} ");
            }

            int choice = ValidationHelpers.TryParseNumber(Console.ReadLine(), list.Count);

            if (choice == -1)
            {
                MessageHelpers.Message("You've entered something wrong! Try again!", ConsoleColor.Red);
                Thread.Sleep(2000);
            }
            return choice;
        }

        public int LogInMenu()
        {
            List<string> list = new List<string>() { "Log in", "Register", "Exit" };
            return ChooseOnMenu(list);
        }

        public int MainMenu()
        {
            List<string> list = new List<string>() {  "Track reading activity", "Track exercising activity", "Track working activity",
                                                    "Track other hobbies", "Statistics", "Account", "Log Out"};
            return ChooseOnMenu(list);
        }

        public int ShowBookTypes()
        {
            List<string> list = new List<string>() { "BellesLettres", "Fiction", "Professional Literature" };
            return ChooseOnMenu(list);
        }

        public int ShowExercise()
        {
            List<string> list = new List<string>() { "General", "Running", "Sport" };
            return ChooseOnMenu(list);
        }

        public int ShowWorkingPlace()
        {
            List<string> list = new List<string>() { "Home", "Office" };
            return ChooseOnMenu(list);
        }

        public int AccountMenu()
        {
            List<string> list = new List<string>() { "Change info", "Change password", "Deactive account", "<= Back" };
            return ChooseOnMenu(list);
        }

        public int StatisticsMenu()
        {
            List<string> list = new List<string>() { "Reading", "Working", "Exercising", "Other hobbies", "General", "<= Back" };
            return ChooseOnMenu(list);
        }
    }
}
