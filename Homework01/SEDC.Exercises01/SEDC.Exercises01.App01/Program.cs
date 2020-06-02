using SEDC.Exercises01.Exercise01;
using System;
using System.Collections.Generic;

namespace SEDC.Exercises01.App01
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var isFinished = false;
            
            List<string> finalList;
            while (!isFinished)
            {
                
                service.EnterNames();
                string inputName = Console.ReadLine();
                List<string> namesList = service.GetAllNames();
                namesList.Add(inputName);
                Console.WriteLine("If you want to stop enter names enter x, else enter another name");
                var selection = Console.ReadLine();
                if(selection == "x")
                {
                    isFinished = !isFinished;
                }

            }
            Console.WriteLine("Now enter some text that include some of the names that you previosly entered");
            string text = Console.ReadLine();
            service.CountingNames(text, service.GetAllNames());



            Console.ReadLine();
        }
    }
}
