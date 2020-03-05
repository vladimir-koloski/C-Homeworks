using System;
using System.Threading;

namespace Homework01.Exercise01

{
    class Program
    {
        public class ThreadExample
        {
            
            public static void ThreadProc()
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("ThreadProc: {0}", i);
                    Thread.Sleep(0);
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Traffic light...");
                Console.BackgroundColor
                = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Red Light - STOP!");
                Console.BackgroundColor
                = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("Yellow Light - PREPARE.");
                Console.BackgroundColor
                = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Green Light - GO!");

                Console.ReadLine();


            }
        }
    }
}
