using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SEDC.TimeTracking.Domain.Entities
{
    public abstract class BaseActivity : BaseEntity
    {
        
        public DateTime StartTracking { get; set; }

        public DateTime StopTracking { get; set; }
        public TimeSpan TrackedTime { get; set; }
        public ActivityType ActivityType { get; set; }  


        public void TrackTime()
        {
            StartTracking = DateTime.Now;
            Console.WriteLine("You have started track your activity");
            Stopwatch timer = new Stopwatch();
            
            timer.Start();

            Console.WriteLine("To stop tracking time choose enter");
            ConsoleKeyInfo key = Console.ReadKey();

            if(key.Key == ConsoleKey.Enter)
            {
                timer.Stop();
                StopTracking = DateTime.Now;
                TrackedTime = StopTracking - StartTracking;
                Console.WriteLine($"You spent {TrackedTime.Minutes} minutes on your activity");
            }
        }

        
    }   
}
