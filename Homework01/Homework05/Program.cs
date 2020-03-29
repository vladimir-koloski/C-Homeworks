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
            //string result = Console.ReadLine();
            //if (result == "Eat")
            //{
            //    dog.Eat();
            //}
            //if (result == "Play")
            //{
            //    dog.Play();
            //}
            //if (result == "Eat")
            //{
            //    dog.ChaseTail();
            //}
            //Console.ReadLine();


            #endregion

            #region Task2
            while (true)
            {
                Car[]carArray = new Car[4]{

                new Car
                {
                    Model = "Panda",
                    Speed = 140,

                },

                new Car
                {
                    Model = "Megan",
                    Speed = 120,

                },

                new Car()
                {
                    Model = "Boxer",
                    Speed = 110,

                },

                new Car()
                {
                    Model = "Polo",
                    Speed = 150,

                }
            };
                Driver[] driverArray = new Driver[4]{
                 new Driver()
                {
                    Name = "Vlatko",
                    Skill = 2
                },

                 new Driver()
                {
                    Name = "Stefan",
                    Skill = 4
                },

                 new Driver()
                {
                    Name = "Darko",
                    Skill = 1
                },

                 new Driver()
                {
                    Name = "Zlatan",
                    Skill = 3
                },
            };

                //Car carInUse1 = new Car();
                //Console.WriteLine($"Chose a car no.1: {carArray[0].Model}, {carArray[1].Model}, {carArray[2].Model}, {carArray[3].Model}");
                //string inputCar1 = Console.ReadLine();


                //Console.WriteLine($"Chose a driver no.1: {driverArray[0].Name}, {driverArray[1].Name}, {driverArray[2].Name}, {driverArray[3].Name}");
                //string inputDriver1 = Console.ReadLine();

                //Car carInUse2 = new Car();
                //Console.WriteLine($"Chose a car no.2: {carArray[0].Model}, {carArray[1].Model}, {carArray[2].Model}, {carArray[3].Model}");
                //string inputCar2 = Console.ReadLine();

                //Console.WriteLine($"Chose a driver no.2: {driverArray[0].Name}, {driverArray[1].Name}, {driverArray[2].Name}, {driverArray[3].Name}");
                //string inputDriver2 = Console.ReadLine();

                
                //GameService.InputCarAndDriver(carArray, driverArray);
                //GameService.InputCarAndDriver(carArray, driverArray);
                Car.RaceCars(GameService.InputCarAndDriver(carArray, driverArray), GameService.InputCarAndDriver(carArray, driverArray));


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
