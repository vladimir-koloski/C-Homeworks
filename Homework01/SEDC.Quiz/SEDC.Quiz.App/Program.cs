using SEDC.Quiz.Data.BaseData;
using SEDC.Quiz.Data.Models;
using System;

namespace SEDC.Quiz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = null;
            var _questionRepository = new QuestionRepository();
            var _userRepository = new UserRepository();
            bool isFinished = true;
            while (isFinished)
            {
                user = _userRepository.Login();
                bool takenTest =_userRepository.CheckIfStudentTakeTest(user);
                if (takenTest == true)
                {
                    if (!user.IsTeacher)
                    {
                        Console.WriteLine($"Welcome {user.FullName}");
                        _questionRepository.AskQuestion(user);
                    }
                    else
                    {
                        Console.WriteLine($"Welcome {user.FullName}");
                        _userRepository.SeeTheGrades();
                    };
                    Console.WriteLine("If you want to log as different user press Enter, If you want to exit enter 'x'");
                    string selection = Console.ReadLine();
                    if (selection == "x")
                    {
                        isFinished = false;
                    }
                }
                
            }
            
            

            Console.ReadLine();
        }
    }
}
