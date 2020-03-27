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

        public int CalculateSpeed(int Skill)
        {
            return Skill * Speed;
        }

        public void RaceCars(Car a, Car b)
        {

            if (a.Speed > b.Speed)
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
