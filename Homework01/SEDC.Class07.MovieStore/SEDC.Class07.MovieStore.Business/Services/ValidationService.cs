using SEDC.Class07.MovieStore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.MovieStore.Entities.Services
{
    public class ValidationService
    {
        public bool ValidateUserName(string userName)
        {
            if (!userName.Contains('@'))
            {
                return false;
            }
            string[] userNameParts = userName.Split('@');
            if (userNameParts.Length != 2)
            {
                return false;
            }
            if (userNameParts[userNameParts.Length - 1].Length <= 6
                && !userNameParts[userNameParts.Length - 1].Contains('.'))
            {
                return false;
            }
            return true;
        }

        public bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            char[] passwordParts = password.ToCharArray();
            int counterUpperLetters = 0;
            int counterDigits = 0;
            foreach (char part in passwordParts)
            {
                if (char.IsWhiteSpace(part))
                {
                    return false;
                }
                if (char.IsDigit(part))
                {
                    counterDigits++;
                }
                if (char.IsUpper(part))
                {
                    counterUpperLetters++;
                }
            }
            return counterDigits != 0 && counterUpperLetters != 0;
        }

        public bool IsUserNameUnique(string userName, User[] users)
        {
            foreach (var user in users)
            {
                if (userName.ToLower() == user.UserName.ToLower())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
