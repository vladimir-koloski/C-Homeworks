using System;

namespace Homework04
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Substrings());
        //}

        //public static void Substrings()
        //{
        //    string message = "Hello from SEDC Codecademy v7.0";
        //    Console.WriteLine("Enter a number");
        //    int n;
        //    int.TryParse(Console.ReadLine(), out n);
        //    if (n > message.Length)
        //    {
        //        Console.WriteLine($"Please enter number lower than {message.Length} ");
        //    }
        //    string nCharacter = message.Substring(n);
        //    Console.WriteLine(nCharacter, nCharacter.Length);

        //    Console.ReadLine();
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
        //static void Main(string[] args)
        //{

        //    Console.WriteLine(FindMaxNum(new int[] { -5, -6, -3, -2, -12, 25, 13, 6, 15}));
        //    Console.ReadLine();
        //}

        //public static int FindMaxNum(int[] realNumbers)
        //{
        //    //int[] realNumbers = new int[] { };
        //    int maxNum = realNumbers[0];
        //    for (int i = 0; i < realNumbers.Length; i++)
        //    {
        //        if (realNumbers[i] > maxNum)
        //        {
        //            maxNum = realNumbers[i];
        //        }
        //    }
        //    return maxNum;

        //}

        #endregion

        #region Task03
        //static void Main(string[] args)
        //{

        //    Console.WriteLine(DigitsCounter("academy"));
        //    Console.ReadLine();
        //}

        //public static int DigitsCounter(string word)
        //{
        //    char[] charArray = word.ToCharArray();
        //    int counter = 0;
        //    foreach (char item in charArray)
        //    {
        //        if (item != 'a' && item != 'e'&& item != 'o' && item != 'i' && item != 'u')
        //        {
        //            counter ++;
        //        }

        //    }
        //    return counter;

        //}

        #endregion

        #region Task04
        //Create a function to read a sentence from input and replace lowercase characters by uppercase and vice-versa.

        //public static void ReplaceLowUp()
        //{

        //    Console.WriteLine("Enter a sentence");
        //    string sentence = Console.ReadLine();
        //    char[] charArray = sentence.ToCharArray();

        //    for (int i = 0; i < charArray.Length; i++)
        //    {
        //        if (Char.IsLower(charArray[i]) )
        //        {
        //            Char.ToUpper(charArray[i]);
        //        }
        //        else
        //        {
        //            Char.ToLower(charArray[i]);
        //        }
        //    }

        //    Console.WriteLine(charArray);
        //            Console.ReadLine();

        //}
        #endregion

        //Task 5:
        //Create a function to check whether a character is an alphabet or not and if so go to check for the case.

        //Task 6:
        //Create a function to find the number of times a substring appears in a given string.

        //Task 7:
        //Create a function that calculates the result of raising an integer to another integer(eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125).
    }
}
