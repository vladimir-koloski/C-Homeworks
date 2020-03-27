using Homework05.Classes;
using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //Console.WriteLine("Input: Name, race, color of some dog");
            //Dog dog = new Dog()
            //{
            //    Name = Console.ReadLine(),
            //    Race = Console.ReadLine(),
            //    Color = Console.ReadLine(),

            //};
            //Console.WriteLine("Input: choose does the dog Eat, Play or ChaseTail");
            //Console.ReadLine();
            //if(Console.ReadLine() == "Eat")
            //{
            //    dog.Eat();
            //}
            //if (Console.ReadLine() == "Play")
            //{
            //    dog.Play();
            //}
            //if (Console.ReadLine() == "Eat")
            //{
            //    dog.ChaseTail();
            //}

            #endregion

            #region Task2
            while (true)
            {

                Car car1 = new Car()
            {
                Model = "Panda",
                Speed = 140,
             
            };

            Car car2 = new Car()
            {
                Model = "Megan",
                Speed = 120,
                
            };

            Car car3 = new Car()
            {
                Model = "Boxer",
                Speed = 110,
                
            };

            Car car4 = new Car()
            {
                Model = "Polo",
                Speed = 150,
                
            };

            Driver driver1 = new Driver()
            {
                Name = "Vlatko",
                Skill = 2
            };

            Driver driver2 = new Driver()
            {
                Name = "Stefan",
                Skill = 4
            };

            Driver driver3 = new Driver()
            {
                Name = "Darko",
                Skill = 1
            };

            Driver driver4 = new Driver()
            {
                Name = "Zlatan",
                Skill = 3
            };

            Car carInUse1 = new Car();
            Console.WriteLine($"Chose a car no.1: {car1.Model}, {car2.Model}, {car3.Model}, {car4.Model}");
            string inputCar1 = Console.ReadLine();
            if(inputCar1 == "Panda")
            {
                carInUse1 = car1;
            };
            if (inputCar1 == "Megan")
            {
                carInUse1 = car2;
            };
            if (inputCar1 == "Boxer")
            {
                carInUse1 = car3;
            };
            if (inputCar1 == "Polo")
            {
                carInUse1 = car4;
            };
            Driver driverInUse1 = new Driver();
            Console.WriteLine($"Chose a driver no.1: {driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name}");
            string inputDriver1 = Console.ReadLine();
            if (inputDriver1 == "Vlatko")
            {
                driverInUse1 = driver1;
            };
            if (inputDriver1 == "Stefan")
            {
                driverInUse1 = driver2;
            };
            if (inputDriver1 == "Darko")
            {
                driverInUse1 = driver3;
            };
            if (inputDriver1 == "Zlatan")
            {
                driverInUse1 = driver4;
            };
            Car carInUse2 = new Car();
            Console.WriteLine($"Chose a car no.2: {car1.Model}, {car2.Model}, {car3.Model}, {car4.Model}");
            string inputCar2 = Console.ReadLine();
            if (inputCar2 == "Panda")
            {
                carInUse2 = car1;
            };
            if (inputCar2 == "Megan")
            {
                carInUse2 = car2;
            };
            if (inputCar2 == "Boxer")
            {
                carInUse2 = car3;
            };
            if (inputCar2 == "Polo")
            {
                carInUse2 = car4;
            };
            Driver driverInUse2 = new Driver();
            Console.WriteLine($"Chose a driver no.2: {driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name}");
            string inputDriver2 = Console.ReadLine();
            if (inputDriver2 == "Vlatko")
            {
                driverInUse2 = driver1;
            };
            if (inputDriver2 == "Stefan")
            {
                driverInUse2 = driver2;
            };
            if (inputDriver2 == "Darko")
            {
                driverInUse2 = driver3;
            };
            if (inputDriver2 == "Zlatan")
            {
                driverInUse2 = driver4;
            };

            Car.RaceCars(carInUse1, carInUse2);

            
                Console.WriteLine("Do you want to play again [Y/N]?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    continue;
                if (answer == "N")
                    break;
            }

            Console.ReadLine();
            #endregion
        }
    }
}
