using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercises01.Task03
{
    public class GameService
    {
         List<string> optionList = new List<string>  { "rock", "paper", "scissors"};
        int counterUserWins = 0;
        int counterComputerWins = 0;

        public void WellcomeMessage()
        {
            Console.WriteLine("Wellcome to the rock - paper - scissors Game");
            
        }
        public void Menu()
        {
            Console.WriteLine("To start game press 1");
            Console.WriteLine("To see the stats press 2");
            Console.WriteLine("To exit press 3");
        }

        public void PlayGame()
        {
            Console.WriteLine("Choose beetwen rock - paper - scissors and enter your choise:");
            string userSelection = Console.ReadLine().ToLower();
            Random randNum = new Random();
            int RandomIndex = randNum.Next(optionList.Count);
            string computerSelection = optionList[RandomIndex].ToLower();
            Console.WriteLine($"Your choice was: {userSelection}, and computer choice was: {computerSelection}");
            CompareTheChoise(userSelection, computerSelection);
        }

        public void CompareTheChoise(string userChoise, string computerChoise)
        {
            if (userChoise == computerChoise)
            {
                Console.WriteLine("Nobody won");

            }
            else if (userChoise == "rock" && computerChoise == "scissors")
            {
                Console.WriteLine("You won");
                counterUserWins++;
            }
            else if (userChoise == "scissors" && computerChoise == "paper")
            {
                Console.WriteLine("You won");
                counterUserWins++;
            }
            else if (userChoise == "paper" && computerChoise == "rock")
            {
                Console.WriteLine("You won");
                counterUserWins++;
            }
            else
            {
                Console.WriteLine("Computer won");
                counterComputerWins++;
            }
        }

        
        public void Stats()
        {
            if(counterUserWins == counterComputerWins)
            {
                Console.WriteLine($"The result is equal {counterUserWins} : {counterComputerWins}");
            }
            else if(counterUserWins > counterComputerWins)
            {
                Console.WriteLine($"You are in lead with {counterUserWins} : {counterComputerWins}");
                Console.WriteLine($"Your percentage of won is: {counterUserWins/(counterComputerWins + counterUserWins)*100}%");
            }
            Console.WriteLine($"The computer wins {counterComputerWins} : {counterUserWins}");
            Console.WriteLine($"Your percentage of lose is: {counterUserWins / (counterComputerWins + counterUserWins) * 100}%");
        }
        
    }
}
