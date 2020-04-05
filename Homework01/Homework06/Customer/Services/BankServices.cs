using System;
using System.Collections.Generic;
using System.Text;
using Bussines.Models;

namespace Bussines.Services
{ 
    public class BankServices
    {
        public int CheckBalance(Customer customer)
        {
            return customer.AccountBalance;
        }

        
    }
}
