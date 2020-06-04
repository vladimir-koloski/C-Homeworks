using SEDC.Quiz.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Quiz.Data.BaseData
{
    public class InMemoryDataBase
    {
        protected List<User> Users { get; set; }
        protected List<Question> Questions { get; set; }

        public InMemoryDataBase()
        {
            Users = new List<User>
            {
                new User() {FullName = "Trajan Stevkovski", UserName = "trajan@gmail.com", Password = "123", IsTeacher = true, DoneTest = false  },
                new User() { FullName = "Vladimir Koloski", UserName = "vladimir@gmail.com", Password = "321", IsTeacher = false, DoneTest = false  },
                new User() { FullName = "Mirko Mitrevski", UserName = "mirko@gmail.com", Password = "122", IsTeacher = false, DoneTest = false  },
                new User() { FullName = "Risto Bombata", UserName = "risto@gmail.com", Password = "112", IsTeacher = false, DoneTest = false  }
            };

            Questions = new List<Question>
            {
                new Question() {QuestionText = "What is the capital of Tasmania?", AnswerA = "Dodoma", AnswerB = "Hobart", AnswerC = "Launceston", AnswerD = "Wellington", CorectAnswer = "Hobart"},
                new Question() {QuestionText = "What is the tallest building in the Republic of the Congo?", AnswerA = "Kinshasa Democratic Republic of the Congo Temple", AnswerB = "Palais de la Nation", AnswerC = "Kongo Trade Centre", AnswerD = "Nabemba Tower", CorectAnswer = "Nabemba Tower"},
                new Question() {QuestionText = "Which of these is not one of Pluto's moons?", AnswerA = "Styx", AnswerB = "Hydra", AnswerC = "Nix", AnswerD = "Lugia", CorectAnswer = "Lugia"},
                new Question() {QuestionText = "What is the smallest lake in the world?", AnswerA = "Onega Lake", AnswerB = "Benxi Lake", AnswerC = "Kivu Lake", AnswerD = "Wakatipu Lake", CorectAnswer = "Benxi Lake"},
                new Question() {QuestionText = "What country has the largest population of alpacas?", AnswerA = "Chad", AnswerB = "Peru", AnswerC = "Australia", AnswerD = "Niger", CorectAnswer = "Peru"}
            };
        }
    }

}

