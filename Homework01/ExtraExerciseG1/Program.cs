using System;

namespace ExtraExerciseG1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to find the sum of first 10 natural numbers
            //*Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10
            //int sum = 0;
            //for(int i = 1; i < 11; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);



            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            //int sum = 0;
            //int average = 0;
            //int number;
            //Console.WriteLine("Enter ten numbers");
            //for (int i = 0; i < 10; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out number);
            //    //int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    average = sum / 10;
            //}
            //Console.WriteLine("The sum is: " + sum);
            //Console.WriteLine("The average is: " + average);


            //3.Declare and init array of 10 integers by your choise. 
            //Find maximum and minimum element in that array and their indexes.
            //int[] arrayOfNumbers = new int[] { 7, 4, 6, 8, 5, 22, 13, 15, 25, 30 };
            //int min = arrayOfNumbers[0];
            //int max = arrayOfNumbers[0];
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    if (arrayOfNumbers[i] < min)
            //    {
            //        min = arrayOfNumbers[i];
            //    }
            //    if (arrayOfNumbers[i] > max)
            //    {
            //        max = arrayOfNumbers[i];
            //    }
            //}
            //int maxIndex = Array.IndexOf(arrayOfNumbers, max);
            //int minIndex = Array.IndexOf(arrayOfNumbers, min);
            //Console.WriteLine("The max number is: " + max);
            //Console.WriteLine("Minimum element index :" + maxIndex);
            //Console.WriteLine("The min number is: " + min);
            //Console.WriteLine("Minimum element index :" + minIndex);


            //4.arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            //Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            //int[] arr = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            //int count = 0;

            ////Find all duplicate elements in array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        // If duplicate element found then increment count by 1
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine("Total number of duplicate elements found in array:" + count);

            //5.
            //Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays
            //int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            //int[] oddArray = new int[10];
            //int[] evenArray = new int[10];
            //int i;
            //int n = 0;
            //int m = 0;

            //for (i = 0; i < oddEvenArray.Length; i++)
            //{
            //    if (oddEvenArray[i] % 2 == 0)
            //    {
            //        evenArray[n] = oddEvenArray[i];
            //        n++;
            //    }
            //    else
            //    {
            //        oddArray[m] = oddEvenArray[i];
            //        m++;
            //    }
            //}

            //for (i = 0; i < n; i++)
            //{
            //    Console.WriteLine("EvenArray elements are: " + evenArray[i]);
            //}

            //for (i = 0; i < m; i++)
            //{
            //    Console.WriteLine("OddArray elements are:" + oddArray[i]);
            //}


            //6.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //the day with strings.Example: user enters 1, you should print Monday.

            //Console.WriteLine("Input a number to get Day displayed:");
            //int dayNum = Convert.ToInt32(Console.ReadLine());

            //switch (dayNum)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number. Please try again!");
            //        break;
            //}


            //7. Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password
            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".

            string[] userNames = new string[] { "user1", "user2", "user3" };
            string[] passwords = new string[] { "first", "second", "third" };

            Console.WriteLine("Enter username");
            string userInput = (Console.ReadLine());
            Console.WriteLine("Enter password");
            string passwordInput = (Console.ReadLine());

            for (int i = 0; i < userNames.Length; i++)
            {
                if (userInput != userNames[i] || passwordInput != passwords[i])
                {
                    Console.WriteLine("Incorrect username or password");
                
                    
                }
                else
                {
                    Console.WriteLine("You are logged in successfully");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
