using Homework05.Classes;
using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: Name, race, color of some dog, and choose if its Eat, Play or ChaseTail");
            Dog dog = new Dog()
            {
                Name = Console.ReadLine(),
                Race = Console.ReadLine(),
                Color = Console.ReadLine(),

            };
            

            Console.WriteLine($"{dog.Name}, {dog.Race}, {dog.Color}");

            Console.ReadLine();
        }
    }
}
