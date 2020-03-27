using Homework05.Classes;
using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: Name, race, color of some dog");
            Dog dog = new Dog()
            {
                Name = Console.ReadLine(),
                Race = Console.ReadLine(),
                Color = Console.ReadLine(),

            };
            Console.WriteLine("Input: choose does the dog Eat, Play or ChaseTail");
            Console.ReadLine();
            if(Console.ReadLine() == "Eat")
            {
                dog.Eat();
            }
            if (Console.ReadLine() == "Play")
            {
                dog.Play();
            }
            if (Console.ReadLine() == "Eat")
            {
                dog.ChaseTail();
            }

            


            

            Car car1 = new Car()
            {
                Model = "Panda",
                Speed = 140,
                Driver = "Dejan"
            };

            Car car2 = new Car()
            {
                Model = "Megan",
                Speed = 120,
                Driver = "Jonce"
            };

            Car car3 = new Car()
            {
                Model = "Boxer",
                Speed = 110,
                Driver = "Bosko"
            };

            Car car4 = new Car()
            {
                Model = "Polo",
                Speed = 150,
                Driver = "Mile"
            };

            Driver driver1 = new Driver()
            {
                Name = "Vlatko",
                Skill = 2
            };

            Driver driver2 = new Driver()
            {
                Name = "Stefan",
                Skill = 6
            };

            Driver driver3 = new Driver()
            {
                Name = "Darko",
                Skill = 1
            };

            Driver driver4 = new Driver()
            {
                Name = "Zlatan",
                Skill = 4
            };

            Console.WriteLine($"Chose a car no.1: {car1.Model}, {car2.Model}, {car3.Model}, {car4.Model}");
            string inputCar1 = Console.ReadLine();
            if(inputCar1 == "Panda")
            {
                return car1;
            };
            if (inputCar1 == "Megan")
            {
                return car2;
            };
            if (inputCar1 == "Boxer")
            {
                return car3;
            };
            if (inputCar1 == "Polo")
            {
                return car4;
            };
            Console.WriteLine($"Chose a driver no.1: {driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name}");
            string inputDriver1 = Console.ReadLine();
            if (inputDriver1 == "Vlatko")
            {
                return driver1;
            };
            if (inputDriver1 == "Stefan")
            {
                return driver2;
            };
            if (inputDriver1 == "Darko")
            {
                return driver3;
            };
            if (inputDriver1 == "Zlatan")
            {
                return driver4;
            };
            Console.WriteLine($"Chose a car no.2: {car1.Model}, {car2.Model}, {car3.Model}, {car4.Model}");
            string inputCar2 = Console.ReadLine();
            Console.WriteLine($"Chose a driver no.2: {driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name}");
            string inputDrive2 = Console.ReadLine();

            Car.RaceCars(inputCar1, inputCar2);
            

            Console.ReadLine();
        }
    }
}
