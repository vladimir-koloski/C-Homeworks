using System;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[0];
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter integer no.1");
                int number = int.Parse(Console.ReadLine());
                Array.Resize(ref numberArray, numberArray.Length + 1);
                numberArray[numberArray.Length - 1] = number;
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine("The result is: " + sum);



            string[][] arraysOfNames = new string[][]
           {
                new string[] {"Mite", "Jane", "Vlatko", "Goran", "Goran"},
                new string[] { "Tose", "Trajan", "Dejan", "Stojan", "Ana" }
           };

            for (int i = 0; i < arraysOfNames.Length; i++)
            {

                for (int j = 0; j < arraysOfNames[i].Length; j++)
                {
                    Console.WriteLine("Do you want print first or second array: 1/2");
                    int selectArray = int.Parse(Console.ReadLine());
                    if (selectArray == 1;)
                    {
                    Console.WriteLine(arraysOfNames[i]);
                    }
                    if (selectArray == 2;)
                    {
                    Console.WriteLine(arraysOfNames[i][j]);
                    }

                }

            }

                Console.ReadLine();

                
            }
    

        }

    }



