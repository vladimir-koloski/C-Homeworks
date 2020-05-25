using SEDC.VideoRental.Data.DataBase;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Loaders;
using SEDC.VideoRental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.VideoRental.Services.Services
{
    public class AdminService
    {
        private MovieRepository _movieRepository;
        private UserRepository _userRepository;
        private MovieService _movieService;
        

        public AdminService()
        {
            _movieRepository = new MovieRepository();
            _userRepository = new UserRepository();
            _movieService = new MovieService();
        }

        public void ViewAllUsers()
        {
            Screen.ClearScreen();
            bool isFinished = false;
            while (!isFinished)
            {
                Screen.AdminMenuShowUsers();
                var selection = InputParser.ToInteger(0, 3);
                switch (selection)
                {
                    case 1:
                        PrintAllUsers();
                        break;
                    case 2:
                        RegistrateNewUser();
                        break;
                    case 3:
                        DeleteUser();
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }
            }
        }

        public void RegistrateNewUser()
        {
            Console.WriteLine("Enter a full Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a date of Birth:");
            var dob = InputParser.ToDateTime();
            int cardNumber = GenerateNewCardNumber();
            User user = new User(name, dob, cardNumber);
            var users = _userRepository.GetAllUsers();
            users.Add(user);
            Console.WriteLine($"You Have succesfully registred user: {user.FullName}");
        }

        public void PrintAllUsers()
        {
            var allUsers = _userRepository.GetAllUsers();
            foreach (var user in allUsers)
            {
                Console.WriteLine($"Name: {user.FullName}, CardNumber: {user.CardNumber}, DateOfBirth: {user.DateOfBirth}, " +
                    $"is subcsxribtion expired: {user.IsSubscrioptionExpired}");
            }
        }

        public void DeleteUser()
        {
            Console.WriteLine("Enter a id number of a User you want to delete");
            var userId = InputParser.ToInteger(100, 999);
            var user = _userRepository.GetUserByIdCard(userId);
            var allUsers = _userRepository.GetAllUsers();
            allUsers.Remove(user);
            Console.WriteLine($"You Have succesfully deleted user: {user.FullName}");
        }

        public void ViewAllVideos()
        {
            Screen.ClearScreen();
            bool isFinished = false;
            while (!isFinished)
            {
                Screen.AdminMenuShowVideos();
                var selection = InputParser.ToInteger(0, 3);
                switch (selection)
                {
                    case 1:
                        var movies = _movieRepository.GetAllMovies();
                        _movieService.PrintMoviesInfo(movies);
                        break;
                    case 2:
                        AddNewVideo();
                        break;
                    case 3:
                        DeleteVideo();
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }
            }
        }

        public void AddNewVideo()
        {
            Console.WriteLine("Enter a title of a movie:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter a Genre - 1, 2 or 3:");
            var genre = InputParser.ToGenre();
            Console.WriteLine("Enter a Id:");
            int id = InputParser.ToInteger(18, 30);
            Console.WriteLine("Enter a laungage:");
            string language = Console.ReadLine();
            Console.WriteLine("Enter release date:");
            var releaseDate = InputParser.ToDateTime();
            Console.WriteLine("Enter a Length of a movie:");
            var length = InputParser.ToInteger(20, 300);
            Console.WriteLine("Enter a Age Restriction:");
            var ageRestriction = InputParser.ToInteger(8, 18);
            Console.WriteLine("Enter a Quantity:");
            var quantity = InputParser.ToInteger(0, 100);
            var isAvailable = true;
            if(quantity == 0)
            {
                isAvailable = false;
            }
            var movie = new Movie
            {
                Title = title,
                AgeRestriction = ageRestriction,
                Genre = genre,
                Id = id,
                Language = language,
                ReleaseDate = releaseDate,
                Length = length,
                IsAvailable = isAvailable,
                Quantity = quantity
            };
            Console.WriteLine("Adding movie, please wait...");
            LoadingHelpers.Spiner();
            var movies = _movieRepository.GetAllMovies();
            movies.Add(movie);
            
            Console.WriteLine($"You Have succesfully added new Movie: {movie.Title}");
        }

        public void DeleteVideo()
        {
            Console.WriteLine("Enter a id number of a Movie you want to delete");
            var movieId = InputParser.ToInteger(1, 100);
            var movie = _movieRepository.GetMovieById(movieId);
            var allMovies = _movieRepository.GetAllMovies();
            allMovies.Remove(movie);
            Console.WriteLine($"You Have succesfully deleted user: {movie.Title}");
        }

        private int GenerateNewCardNumber()
        {
            const int max = 1000;
            const int min = 100;
            var rand = new Random();
            var takenCardNumbers = _userRepository.GetAllCardNumbers();

            int cardNumber;
            do
            {
                cardNumber = rand.Next(min, max);
            }
            while (takenCardNumbers.Contains(cardNumber));
            return cardNumber;
        }
    }
}
