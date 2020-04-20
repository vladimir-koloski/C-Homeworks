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
            User[] users = employeeRepository.GetUsers();
            //Console.WriteLine(users);
            var validationService = new ValidationService();

            Menu.PrintMovies(employeeRepository.GetMovies());
            Menu.PrintUsers(employeeRepository.GetUsers());

            Menu.PrintMovies(employeeRepository.GetAvailableMovies());
            Movie movie = movieRepository.GetMovieById(3);

            movie.ChangeAvailability();
            Menu.PrintMovies(employeeRepository.GetAvailableMovies());


            Employee employee = new Employee("Vladimir", "Koloski", 25, "vlatko_vin", "ludiot", 075215803, Role.Employee, 162);
            Console.WriteLine(employee.SetSalary());
            Console.ReadLine();
        }
    }
}
