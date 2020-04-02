using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05.Classes
{
    class GameService
    {
        public static Car InputCarAndDriver(Car[]carArray, Driver[]driverArray)
        {
            Console.WriteLine($"Chose a car no.1: {carArray[0].Model}, {carArray[1].Model}, {carArray[2].Model}, {carArray[3].Model}");
            string inputCar1 = Console.ReadLine();
            Car userCar = new Car();
            
                if (inputCar1 == "Panda")
                {
                    userCar = carArray[0];
                 
                }                
                if (inputCar1 == "Megan")
                {
                    userCar = carArray[1];
                }                
                if (inputCar1 == "Boxer")
                {
                    userCar = carArray[2];                    
                }                
                if (inputCar1 == "Polo")
                {
                    userCar = carArray[3];                    
                }                
            

            Console.WriteLine($"Chose a driver no.1: {driverArray[0].Name}, {driverArray[1].Name}, {driverArray[2].Name}, {driverArray[3].Name}");
            string inputDriver1 = Console.ReadLine();
            Driver userDriver = new Driver();
            
                if (inputDriver1 == "Vlatko")
                {
                    userDriver = driverArray[0];                    
                }
                if (inputDriver1 == "Stefan")
                {
                    userDriver = driverArray[1];                    
                }
                if (inputDriver1 == "Darko")
                {
                    userDriver = driverArray[2];                    
                }
                if (inputDriver1 == "Zlatan")
                {
                    userDriver = driverArray[3];                    
                };           

            userCar.Driver = userDriver;
            return userCar;
        }

    }
}
