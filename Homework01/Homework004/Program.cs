using System;

namespace Homework04
{
    class Program
    {


        //public static void Main()
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
        //    Console.WriteLine($"The new string is: {nCharacter}, the length is: {nCharacter.Length}");

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
        //    Console.WriteLine(VowelsCounter("Console Something 352")); 
        //    Console.WriteLine(DigitsCounter("352"));
        //    Console.ReadLine();
        //}

        public static int VowelsCounter(string word)
        {
            char[] charArray = word.ToCharArray();
            int counter = 0;
            foreach (char item in charArray)
            {
                if (item != 'a' && item != 'e' && item != 'o' && item != 'i' && item != 'u' && !Char.IsDigit(item) && !Char.IsWhiteSpace(item))
                {
                    counter++;
                }

            }
            return counter;

        }
        public static int DigitsCounter(string word)
        {
            char[] charArray = word.ToCharArray();
            int counter = 0;
            foreach (char item in charArray)
            {

                if (Char.IsDigit(item))
                {
                    counter++;
                }
            }
            return counter;

        }

        #endregion

        #region Task04
        //Create a function to read a sentence from input and replace lowercase characters by uppercase and vice-versa.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ReplaceLowUp());
        //    Console.ReadLine();
        //}
        //public static string ReplaceLowUp()
        //{

        //    Console.WriteLine("Enter a sentence");
        //    string sentence = Console.ReadLine();
        //    char[] charArray = sentence.ToCharArray();

        //    for (int i = 0; i < charArray.Length; i++)
        //    {
        //        if (Char.IsLower(charArray[i]))
        //        {
        //            Char.ToUpper(charArray[i]);
        //        }
        //        else
        //        {
        //            Char.ToLower(charArray[i]);
        //        }
        //    }

        //    Console.WriteLine(charArray);
           
        //}
        #endregion
        #region Task05

        //Create a function to check whether a character is an alphabet or not and if so go to check for the case.
        //public static void Main()
        //{

        //    Console.WriteLine("Check whether a character is alphabet or not and if so, check for case :");
        //    Console.WriteLine("Input a character: ");
        //    char ch = char.Parse(Console.ReadLine());
        //    if (Char.IsLetter(ch))
        //    {
        //        if (Char.IsUpper(ch))
        //        {
        //            Console.WriteLine("The character is uppercase.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("The character is lowercase.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("The entered character is not an alphabetic character.");
        //    }

        //    Console.ReadLine();
        //}



        #endregion
        //Task 6:
        //Create a function to find the number of times a substring appears in a given string.
        //public static void Main()
        //{
        //    string str1;
        //    string findstring;
        //    int strt = 0;
        //    int counter = -1;
        //    int index = -1;

        //    Console.WriteLine("Find the number of times a specific string appears in a string :");

        //    Console.WriteLine("Input the original string : ");
        //    str1 = Console.ReadLine();
        //    Console.WriteLine("Input the string to be searched for : ");
        //    findstring = Console.ReadLine();


        //    while (strt != -1)
        //    {
        //        strt = str1.IndexOf(findstring, index + 1);
        //        counter += 1;
        //        index = strt;
        //    }
        //    Console.WriteLine($"The string {findstring} occurs " + counter + " times.");
        //    Console.ReadLine();
        //}



        #region Task07
        //Create a function that calculates the result of raising an integer to another integer(eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125).
        //public static void Main()
        //{
        //    Console.WriteLine(NumberPow(5, 3));
        //    Console.ReadLine();
        //}

        //public static int NumberPow(int num1, int exp)
        //{
        //    int result = 1;
        //    for (int i = 0; i < exp; i++)
        //    {
        //        result = result * num1;
        //    }
        //    return result;

        //}
        #endregion
    }
}


