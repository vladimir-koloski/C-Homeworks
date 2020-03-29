using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05.Classes
{
    class GameService
    {
        public static void InputCarAndDriver(Car[]carArray, Driver[]driverArray)
        {
            Console.WriteLine($"Chose a car no.1: {carArray[0].Model}, {carArray[1].Model}, {carArray[2].Model}, {carArray[3].Model}");
            string inputCar1 = Console.ReadLine();
            Car userCar = new Car();
            for (int i = 0; i < carArray.Length; i++)
            {
                
                if (inputCar1 == "Panda")
                {
                    userCar = carArray[i];
                };
                if (inputCar1 == "Megan")
                {
                    userCar = carArray[i];
                };
                if (inputCar1 == "Boxer")
                {
                    userCar = carArray[i];
                };
                if (inputCar1 == "Polo")
                {
                    userCar = carArray[i];
                };
            }
            Console.WriteLine($"Chose a driver no.1: {driverArray[0].Name}, {driverArray[1].Name}, {driverArray[2].Name}, {driverArray[3].Name}");
            string inputDriver1 = Console.ReadLine();
            Driver userDriver = new Driver();
            for (int i = 0; i < driverArray.Length; i++)
            {
                if (inputDriver1 == "Vlatko")
                {
                    userDriver = driverArray[i];
                };
                if (inputDriver1 == "Stefan")
                {
                    userDriver = driverArray[i];
                };
                if (inputDriver1 == "Darko")
                {
                    userDriver = driverArray[i];
                };
                if (inputDriver1 == "Zlatan")
                {
                    userDriver = driverArray[i];
                };
                
            }
            userDriver = userCar.Driver;
            //return Car userCar;
        }

    }
}
