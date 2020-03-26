using System;
using System.Collections.Generic;
using System.Text;

namespace Homework05.Classes
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        public int CalculateSpeed(int Driver)
        {
            return Driver.Skill * Speed;
        }

        public int RaceCars(string car1, string car2)
        {
            if (Car.Speed > car2.Speed)
            {
                Console.WriteLine($"Will win {car1}");
            }
            else
            {
                Console.WriteLine($"Will win {car2}");
            }
        }
    }
}
