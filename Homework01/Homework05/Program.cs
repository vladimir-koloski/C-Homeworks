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
            Car[] carArray = new Car[4]{

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
            while (true)
            {
                
                               
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
