using System;

namespace Real_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Option of the type of arithmetic operation");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");

            while (true)
            {
                Console.WriteLine("Enter your operation: ");
                string operators = Console.ReadLine();

                string numInputOne;
                string numInputTwo;
                Console.WriteLine("Enter the first number");
                numInputOne = Console.ReadLine();
                int numOne;
                while (!int.TryParse(numInputOne, out numOne))
                {
                    Console.WriteLine("Invalid number input. The aplication wil be closed");
                    return;
                }

                Console.WriteLine("Enter the second number");
                numInputTwo = Console.ReadLine();
                int numTwo;
                while (!int.TryParse(numInputTwo, out numTwo))
                {
                    Console.WriteLine("Invalid number input. The aplication wil be closed");
                    return;
                }

                switch (operators)
                {
                    case "+":
                        Console.WriteLine($"Result of {numOne} + {numTwo} =" + (numOne + numTwo));
                        break;
                    case "-":
                        Console.WriteLine($"Result of {numOne} - {numTwo} =" + (numOne - numTwo));
                        break;
                    case "*":
                        Console.WriteLine($"Result of {numOne} * {numTwo} =" + (numOne * numTwo));
                        break;
                    case "/":
                        if (numOne == 0 || numTwo == 0)
                        {
                            Console.WriteLine("Division with zero is not possible!");
                            break;
                        }
                        Console.WriteLine($"Result of {numOne} / {numTwo} =" + (numOne / numTwo));
                        break;
                    default:
                        Console.WriteLine("Invalid inpit entered. The aplication will automaticly shut down");
                        break;
                }
                if (Console.ReadLine() == "s" || Console.ReadLine() == "S")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you for using calculator! The aplication will automatically close.");
                    return;
                }
            }
        }
    }
}
    