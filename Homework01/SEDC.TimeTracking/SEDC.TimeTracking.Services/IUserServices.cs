using SEDC.TimeTracking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Services
{
    public interface IUserServices<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstName, string lastName);
        bool DeactivateAccount(T user);
        T LogIn(string username, string password);
        T Register(T user);
        void UserStatistics(User user, int choice);
        bool AccountSettings(int id, int choice, T user);
    }
}
