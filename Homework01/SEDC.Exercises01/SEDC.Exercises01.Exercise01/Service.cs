using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercises01.Exercise01
{
    public class Service
    {

        List<string> names = new List<string>();
        public void EnterNames()
        {
            Console.WriteLine("Enter name: ");
        }

        
        public List<string> GetAllNames()
        {            
                return names;           
        }

        public void CountingNames(string text, List<string> names)
        {
            List<string> textList = text.Split().ToList();
            foreach(var name in names)
            {
                List<string> filteredList = textList.Where(textList => textList == name).ToList();
                int counter = filteredList.Count();
                Console.WriteLine($"Entered name: {name} is showing {counter} times in the text");
            }
            

        }

       

        





    }
}
