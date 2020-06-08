using SEDC.Quiz.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Quiz.Data.BaseData
{
    public class UserRepository : InMemoryDataBase
    {
        public List<User> GetAllUsers()
        {
            return Users;
        }

        public List<User> GetAllStudents()
        {
            return Users.Where(_user => _user.IsTeacher == false).ToList();
        }

        public User GetUserByUserName(string userName)
        {
            return Users.FirstOrDefault(_user => _user.UserName == userName);
        }
        public User Login()
        {
            var counter = 0;
            while (true)
            {
                
                Console.WriteLine("Enter userName: ");
                var userName = Console.ReadLine();
                Console.WriteLine("Enter password:");
                var password = Console.ReadLine();
                var userList = GetAllUsers();
                if(!ValidationOfUser(userList, userName, password))
                {
                    counter++;
                    if (counter >= 3)
                    {
                        Environment.Exit(0);
                    }                    
                    continue;
                }
                var user = GetUserByUserName(userName);

                if (user == null)
                {
                    Console.WriteLine("User does not exist");
                }
                
                return user;
            }
            
        }

        public void SeeTheGrades()
        {
            List<User> users = GetAllStudents();
            foreach (var user in users)
            {
                if (user.DoneTest == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The student: {user.FullName} has grade: {user.Grade}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The Student: {user.FullName} did not take the test");
                    Console.ResetColor();
                }          

            }
        }

        public bool CheckIfStudentTakeTest(User user)
        {
            if(user.DoneTest == true)
            {
                Console.WriteLine("You have allready taken the test, You dont have permition to take again");
                return false;
            }
            return true;                
        }

        public bool ValidationOfUser(List<User> users, string userName, string password)
        {
            
            foreach(var user in users)
            {
                if(user.UserName == userName && user.Password == password)
                {
                    return true;
                }                
            }
            Console.WriteLine("Wrong user or pasword, please enter again");
            return false;
        }
        

        
        
    }
}
