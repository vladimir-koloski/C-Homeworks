﻿using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Menus;
using SEDC.VideoRental.Services.Services;
using System;

namespace SEDC.VideoRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Video Rental";

            var _userService = new UserService();
            var _movieService = new MovieService();
            var _adminService = new AdminService();
            User user = null;
            string errorMessage = string.Empty;

            #region Login
            Screen.HomeScreen();
            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                Screen.StartMenu();
                var startMenuInput = InputParser.ToInteger(1, 3);
                switch (startMenuInput)
                {
                    case 1:
                        while (!isLoggedIn)
                        {
                            user = _userService.Login();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 2:
                        while (!isLoggedIn)
                        {
                            user = _userService.SignUp();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion


            if (!user.IsAdmin)
            {
                while (true)
                {
                    Screen.ClearScreen();
                    Screen.ErrorMessage(errorMessage);
                    errorMessage = string.Empty;
                    Screen.MainMenu(user.FullName);
                    var selection = InputParser.ToInteger(1, 4);
                    switch (selection)
                    {
                        case 1:
                            while (!isLoggedIn)
                            {
                                _movieService.ViewMovieList(user);
                                isLoggedIn = !isLoggedIn;
                            }
                            
                            break;
                        case 2:
                            _movieService.ViewRentedVideos(user);
                            break;
                        case 3:
                            try
                            {
                                _movieService.ViewRentedHistoryVideos(user);
                            }
                            catch (Exception ex)
                            {
                                errorMessage = ex.Message;
                            }
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Screen.ClearScreen();
                    Console.WriteLine("Cool you are an admin");
                    Screen.AdminMenu(user.FullName);
                    var selection = InputParser.ToInteger(1, 3);
                    switch (selection)
                    {
                        case 1:
                            _adminService.ViewAllUsers();
                            break;
                        case 2:
                            _adminService.ViewAllVideos();
                            break;

                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                    Console.ReadLine();
                }
                
            }

        }
    }
}
