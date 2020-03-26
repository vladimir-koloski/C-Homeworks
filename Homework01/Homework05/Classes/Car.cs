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

        public void RaceCars(string car1, string car2)
        {
           
            if (car1.Speed > car2.Speed)
            {
                Console.WriteLine($"Car no. 1 was faster.");
            }
            else
            {
                Console.WriteLine($"Car no. 2 was faster.");
            }
        }
    }
}
