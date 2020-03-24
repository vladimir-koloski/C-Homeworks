using System;

namespace Homework04
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string message1 = Substrings();
        //    Console.WriteLine("Enter a number");
        //    int n;
        //    int.TryParse(Console.ReadLine(), out n);
        //    if (n > message1.Length)
        //    {
        //        Console.WriteLine($"Please enter number lower than {message1.Length} ");
        //    }
        //    var nCharacter = message1.Substring(n);
        //    Console.WriteLine(nCharacter, nCharacter.Length);
        //    Console.ReadLine();
        //}

        //public static void Substrings()
        //{
        //    string message = "Hello from SEDC Codecademy v7.0";
        //}


        #region Task1
        /*Create a function to say whether a string is symmetric(a palindrome).*/
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(IsPalindrome("racecar"));
        //    Console.WriteLine(IsPalindrome("car"));
        //    Console.ReadLine();
        //}

        //public static bool IsPalindrome(string myString)
        //{

        //    int length = myString.Length;
        //    for (int i = 0; i < length / 2; i++)
        //    {
        //        if (myString[i] != myString[length - i - 1])
        //            return false;
        //    }
        //    return true;
        //}



        #endregion
        #region Task02
        //Create a function which returns the greatest value stored in an array of real numbers which is specified as parameter.
        static void Main(string[] args)
        {
            
            Console.WriteLine(FindMaxNum (new int[] {2, 6, 7, 13, 23, 12 }));
            Console.ReadLine();
        }

        public static int FindMaxNum(int[] realNumbers)
        {
            int [] realNumbers = new int[]{ };
            int maxNum = 0;
            for (int i = 0; i < realNumbers.Length; i++)
            {
                if (realNumbers[i] > maxNum)
                {
                    maxNum = i;
                }
                    
            }
            
        }

        #endregion


    }
}
