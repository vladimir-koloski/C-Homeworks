using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class01.Interface.Exercise01.Entities
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string userName, string password)
        {
            Id = id;
            Name = name;
            Username = userName;
            Password = password;
        }

        public abstract void PrintUser();
        
         
    }
}
