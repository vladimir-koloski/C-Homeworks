using SEDC.Quiz.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Quiz.Data.BaseData
{
    public class QuestionRepository : InMemoryDataBase
    {
        public List<Question> GetAllQuestion()
        {
            return Questions;
        }

        public void AskQuestion(User user)
        {
             List<Question> questionList = GetAllQuestion();
            
            foreach (var question in questionList)
            {
                

                Console.WriteLine($"{question.QuestionText}");
                Console.WriteLine($"{question.AnswerA}");
                Console.WriteLine($"{question.AnswerB}");
                Console.WriteLine($"{question.AnswerC}");
                Console.WriteLine($"{question.AnswerD}");
                Console.WriteLine("Choose beetwen four possible answer and enter the corect answer");
                string selection = Console.ReadLine();
                if(selection.ToLower() == question.CorectAnswer.ToLower())
                {
                    user.Grade++;
                }
                Console.Clear();
            }
            user.DoneTest = true;

        }
    }
}
