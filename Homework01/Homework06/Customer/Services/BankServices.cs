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

        public int CashWithdrawal (int CheckBalance, int inputAmount)
        {
            return CheckBalance - inputAmount;
        }

        public int CashDeposit(int CheckBalance, int inputAmount)
        {
            return CheckBalance + inputAmount;
        }
    }
}
