using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class01.Interface.Exercise01.Entities
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        void PrintUser()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Username: {Username}");
        }
    }
}
