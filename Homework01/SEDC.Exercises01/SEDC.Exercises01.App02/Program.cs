using SEDC.Exercises01.Task02;
using System;

namespace SEDC.Exercises01.App02
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            bool isRunning = false;
            while (!isRunning)
            {
                Console.WriteLine("Enter some date:");
                DateTime date = service.EnterDateTime();
                service.CheckIfItsWeekend(date);
                Console.WriteLine("Do you want to check another date? Enter yes or no");
                string selection = Console.ReadLine();
                if(selection == "no")
                {
                    isRunning = !isRunning;
                }
            }
            
            

            Console.ReadLine();
        }
    }
}
