using System;

namespace Homework01.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic light...");
            Console.BackgroundColor
            = ConsoleColor.Red;
            Console.WriteLine("Red Light - STOP!");
            Console.BackgroundColor
            = ConsoleColor.Yellow;
            Console.WriteLine("Yellow Light - PREPARE.");
            Console.BackgroundColor
            = ConsoleColor.Green;
            Console.WriteLine("Green Light - GO!");

            Console.ReadLine();

          
        }
    }
}
