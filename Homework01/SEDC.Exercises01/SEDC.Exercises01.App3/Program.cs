using SEDC.Exercises01.Task03;
using System;

namespace SEDC.Exercises01.App3
{
    class Program
    {
        static void Main(string[] args)
        {

            var gameService = new GameService();

            gameService.WellcomeMessage();
            bool isFinished = false;
            while (!isFinished)
            {
                gameService.Menu();
                int selection;
                int.TryParse(Console.ReadLine(), out selection);
                switch (selection)
                {
                    case 1:
                        gameService.PlayGame();
                        break;
                    case 2:
                        gameService.Stats();
                        break;
                    case 3:
                        isFinished = !isFinished;
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
