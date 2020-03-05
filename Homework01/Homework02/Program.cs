using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task1

            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operation");
            char operation;
            operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("The result is", a + b);
            else if (operation == '-')
                Console.WriteLine("The result is", a - b);
            else if (operation == '*')
                Console.WriteLine("The result is", a * b);
            else if (operation == '/')
                Console.WriteLine("The result is", a / b);
            else
                Console.WriteLine("Wrong Character");


            #endregion
            #region Task2

            Console.WriteLine("Enter the first number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the four number");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("The Average of", c, d, e, "and", f, "is", (c + d + e + f) / 4);
            #endregion

            #region Task3
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("After swaping");
            Console.WriteLine("First Number:", firstNumber);
            Console.WriteLine("Second Number:", secondNumber);

            #endregion
            Console.ReadLine();


        }

    }
}