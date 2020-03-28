using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05.Classes
{
    class GameService
    {
        public static void InputCarAndDriver(object[] a, object[] b)
        {
            Console.WriteLine($"Chose a driver no.1: {b[0].Name}, {b[1].Name}, {b[2].Name}, {b[3].Name}");
            string inputDriver1 = Console.ReadLine();
            for (int i = 0; i < b.Length; i++)
            {
                if (inputDriver1 == "Vlatko")
                {
                    Object Car.Driver = b.[i];
                };
                if (inputDriver1 == "Stefan")
                {
                    Object Car.Driver = b.[i];
                };
                if (inputDriver1 == "Darko")
                {
                    Object Car.Driver = b.[i];
                };
                if (inputDriver1 == "Zlatan")
                {
                    Object Car.Driver = b.[i];
                };
            }
            Console.WriteLine($"Chose a car no.1: {a[0].Model}, {a[1].Model}, {a[2].Model}, {a[3].Model}");
            string inputCar1 = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (inputCar1 == "Panda")
                {
                    Object Car = a.[i];
                };
                if (inputCar1 == "Megan")
                {
                    Object Car = a.[i];
                };
                if (inputCar1 == "Boxer")
                {
                    Object Car = a.[i];
                };
                if (inputCar1 == "Polo")
                {
                    Object Car = a.[i];
                };
            }
            return Object Car;
        }
    }
}
