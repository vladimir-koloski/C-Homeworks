using System;

namespace Exercises
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Task1

            //Console.WriteLine("Enter a number higher than 3");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 3)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region Task2

            //Console.WriteLine("Enter a number higher than 5");
            //int number1 = int.Parse(Console.ReadLine());
            //if (number1 > 5)
            //{
            //    for (int i = 1; i <= number1; i++)
            //    {
            //        if (i % 2 == 0 && i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region Task3

            //Console.WriteLine("Enter a number");
            //int number2 = int.Parse(Console.ReadLine());
            //    int product = 1;
            //    while (number2 != 0)
            //    {
            //        int d = number2 % 10;
            //        number2 = number2 / 10;
            //        product *= d;

            //    }
            //    Console.WriteLine(product);
            #endregion
            #region Task4

            //Console.WriteLine("Enter a number");
            //int number3 = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for(int i = 1; i <= number3; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task5

            //Console.WriteLine("Enter a number");
            //int number4 = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= number4; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task6

            //Console.WriteLine("Enter a number");
            //int number5 = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= number5; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task7

            //string[] arrayOfLetters = new string[] {"a","b", "c", "d"};
            //Array.Reverse(arrayOfLetters);
            //foreach (string element in arrayOfLetters)
            //    {
            //        Console.WriteLine(element);
            //    }
            #endregion
            #region Task8

            //Write a program that will read two arrays from console input.Then the program has to make a comparison 
            //of the arrays and determine whether they are equal or not. { 1, 2, 3, 4 } == { 1, 2, 3, 4 }
            //{ 1, 2, 3, 4 } != { 2, 1, 3, 4 }

            int[] arr1 = new int[] { 1, 2, 3, 4 };
            int[] arr2 = new int[] { 1, 2, 4, 4 };
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    Console.WriteLine("The arr1 and arr2 are equal");
                }
            }
            #endregion
            #region 9

            //for (int i = 1; i < 1001; i++)
            //{
            //    int sum = 0;
            //    int j = i;
            //    while (j != 0)
            //    {
            //        int d = j % 10;
            //        j = j / 10;
            //        sum += d;
            //    }
            //    if (i % sum == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task10


            //for (int i = 1; i < 1001; i++)
            //{
            //    int product = 1;
            //    int j = i;
            //    while (j != 0)
            //    {
            //        int d = j % 10;
            //        j = j / 10;
            //        product *= d;
            //    }
            //    //Console.WriteLine(product);
            //    if (product == 0)
            //    {
            //        continue;
            //    }
            //    if (i % product == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task12


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {

            //        Console.WriteLine("Fizz");
            //    }
            //    if (i % 5 == 0)
            //    {

            //        Console.WriteLine("Buzz");
            //    }
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {

            //        Console.WriteLine("FizzBuzz");
            //    }

            //}
            #endregion
            #region Bonus
            //Console.WriteLine("Enter Mode: easy/normal/hard");
            //string mode = Console.ReadLine();
            //Console.WriteLine("Press 1 to start a new game");
            //string newGame = Console.ReadLine();
            //Console.WriteLine("Press 2 to quit game");
            //string quitGame = Console.ReadLine();
            //if (quitGame == "2")
            //{

            //}
            //if (mode == "easy")
            //{
            //    var random = new Random();
            //    int randomnumber = random.Next(100);
            //    //Console.WriteLine(randomnumber);
            //    for (int i = 0; i < 9; i++)
            //    {
            //        Console.WriteLine("Guess the number");
            //        int answer = int.Parse(Console.ReadLine());
            //        if (randomnumber == answer)
            //        {
            //            Console.WriteLine("Nailed it.number entered: " + answer);
            //            if (i == 0)
            //            {
            //                Console.WriteLine("Lucky guess");
            //            }
            //            break;
            //        }
            //        if (randomnumber > answer && randomnumber - answer > 10)
            //        {
            //            Console.WriteLine("Your guess is far to low, number entered:" + answer);
            //        }
            //        if (randomnumber > answer && randomnumber - answer < 10)
            //        {
            //            Console.WriteLine("Your guess is little bit lower, number entered:" + answer);
            //        }
            //        if (randomnumber < answer && answer - randomnumber > 10)
            //        {
            //            Console.WriteLine("Your guess is far to high, number entered:" + answer);
            //        }
            //        if (randomnumber < answer && answer - randomnumber < 10)
            //        {
            //            Console.WriteLine("Your guess is little bit higher, number entered:" + answer);
            //        }
            //    }
            //}
            //if (mode == "normal")
            //{
            //    var random = new Random();
            //    int randomnumber = random.Next(500);
            //    Console.WriteLine(randomnumber);
            //    for (int i = 0; i < 7; i++)
            //    {
            //        Console.WriteLine("Guess the number");
            //        int answer = int.Parse(Console.ReadLine());
            //        if (randomnumber == answer)
            //        {
            //            Console.WriteLine("Nailed it.number entered: " + answer);
            //            if (i == 0)
            //            {
            //                Console.WriteLine("Lucky guess");
            //            }
            //            break;
            //        }
            //        if (randomnumber > answer && randomnumber - answer > 20)
            //        {
            //            Console.WriteLine("Your guess is far to low, number entered:" + answer);
            //        }
            //        if (randomnumber > answer && randomnumber - answer < 20)
            //        {
            //            Console.WriteLine("Your guess is little bit lower, number entered:" + answer);
            //        }
            //        if (randomnumber < answer && answer - randomnumber > 20)
            //        {
            //            Console.WriteLine("Your guess is far to high, number entered:" + answer);
            //        }
            //        if (randomnumber < answer && answer - randomnumber < 20)
            //        {
            //            Console.WriteLine("Your guess is little bit higher, number entered:" + answer);
            //        }
            //    }
            //}
            //if (mode == "hard")
            //{
            //    var random = new Random();
            //    int randomnumber = random.Next(1000);
            //    Console.WriteLine(randomnumber);
            //    Console.WriteLine("Guess the number");
            //    for (int i = 0; i < 5; i++)
            //    {
            //        int answer = int.Parse(Console.ReadLine());
            //        if (randomnumber == answer)
            //        {
            //            Console.WriteLine("Nailed it.number entered: " + answer);
            //            if (i == 0)
            //            {
            //                Console.WriteLine("Lucky guess");
            //            }
            //            break;
            //        }
            //        if (randomnumber > answer && randomnumber - answer > 20)
            //        {
            //            Console.WriteLine("Your guess is far to low, number entered:" + answer);
            //        }
            //        if (randomnumber > answer && randomnumber - answer < 20)
            //        {
            //            Console.WriteLine("Your guess is little bit lower, number entered:" + answer);
            //        }
            //        if (randomnumber < answer && answer - randomnumber > 20)
            //        {
            //            Console.WriteLine("Your guess is far to high, number entered:" + answer);
            //        }
            //        if (randomnumber < answer && answer - randomnumber < 20)
            //        {
            //            Console.WriteLine("Your guess is little bit higher, number entered:" + answer);
            //        }
            //        Console.WriteLine("Try again");
            //    }
            //}


            //Optional: Give the user a chance to restart the game(ex Press 1 to start a new game, press 2 to quit game) without starting the project from scratch.
            #endregion

            Console.ReadLine();
        }
    }
}
