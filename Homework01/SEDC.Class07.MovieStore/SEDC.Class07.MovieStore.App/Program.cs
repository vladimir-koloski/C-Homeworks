using SEDC.Class07.MovieStore.Business.Aplication_Menu;
using SEDC.Class07.MovieStore.Data;
using SEDC.Class07.MovieStore.Entities.Enumerations;
using SEDC.Class07.MovieStore.Entities.Models;
using SEDC.Class07.MovieStore.Entities.Services;
using System;

namespace SEDC.Class07.MovieStore.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            var movieRepository = new MovieRepository();
            var userRepository = new UserRepository();
            User[] users = userRepository.GetUsers();
            //Console.WriteLine(users);
            var validationService = new ValidationService();

            Menu.PrintMovies(movieRepository.GetMovies());
            

            movieRepository.GetAvailableMovies();
            Movie movie = movieRepository.GetMovieById(18);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(movie.Info());

            movie.ChangeAvailability();
            movieRepository.GetAvailableMovies();
            Console.WriteLine("---------------------------------");
            Menu.PrintUsers(userRepository.GetUsers());

            Console.WriteLine(userRepository.CalcMembershipLeft(users[0]));

            


            Employee employee = new Employee("Vladimir", "Koloski", 25, "vlatko_vin", "vlatko@vlatko.com", 075215803, Role.Employee, 162);
            Console.WriteLine(employee.SetSalary());
            Console.ReadLine();
        }
    }
}
