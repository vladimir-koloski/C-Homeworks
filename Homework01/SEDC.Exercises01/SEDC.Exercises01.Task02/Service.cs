using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercises01.Task02
{
    public class Service
    {
        public DateTime EnterDateTime()
        {
            Console.WriteLine("Enter year");
            int year;
            int.TryParse(Console.ReadLine(), out year);
            Console.WriteLine("Enter Month");
            int month;
            int.TryParse(Console.ReadLine(), out month);
            Console.WriteLine("Enter day");
            int day;
            int.TryParse(Console.ReadLine(), out day);
            var date = new DateTime(year, month, day);
            return date;
            
        }

        public void CheckIfItsWeekend(DateTime date)
        {
            //string dateInWeek = date.DayOfWeek.ToString();
            //string mm = date.Month.ToString();
            //string dd = date.Day.ToString();

            //string dayAndMOnth = dd+mm;
            //Console.WriteLine(dayAndMOnth);

            if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Its Weekend and its non working day");
            }else if( (date.Month == 01 && date.Day == 01) || (date.Month == 01 && date.Day == 07) ||
                    (date.Month == 04 && date.Day == 20) || (date.Month == 08 && date.Day == 03) ||
                    (date.Month == 09 && date.Day == 08) || (date.Month == 10 && date.Day == 12) ||
                    (date.Month == 10 && date.Day == 23) || (date.Month == 12 && date.Day == 08))
            {
                Console.WriteLine("Its Hollyday and its non working day");
            }
            else
            {
                Console.WriteLine("Its working day");
            }

        }
    }
}
