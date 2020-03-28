using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }

        public static void RaceCars(Car a, Car b)
        {

            if (a.CalculateSpeed() > b.CalculateSpeed())
            {
                Console.WriteLine($"Car no. 1 was faster.");
                Console.WriteLine($"{a.Model} won the Race, with speed {a.Speed} km/h, and the driver was {a.Driver.Name}");
            }
            else
            {
                Console.WriteLine($"Car no. 2 was faster.");
                Console.WriteLine($"{b.Model} won the Race, with speed {b.Speed} km/h, and the driver was {b.Driver.Name}");
            }
        }
    }
}
