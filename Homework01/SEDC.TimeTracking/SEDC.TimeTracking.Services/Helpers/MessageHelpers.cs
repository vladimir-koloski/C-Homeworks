using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Services.Helpers
{
    public static class MessageHelpers
    {
        public static void Message(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
