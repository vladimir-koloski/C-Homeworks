using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Quiz.Data.Models
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorectAnswer { get; set; }

        public Question()
        {

        }

    }

    
}
