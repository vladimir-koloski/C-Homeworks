using Bussines.Models;
using Bussines.Services;
using System;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM app");            
            Console.WriteLine("Please enter your card numer:");
            long cardNumber;
            long.TryParse(Console.ReadLine(), out cardNumber);
            Console.WriteLine("Enter Pin:");
            int pin;
            int.TryParse(Console.ReadLine(), out pin);

            var bankServices = new BankServices();


            Customer customer = new Customer("Bob", "Bobsky", 1234123412341234, 4325, 1000);
            Console.WriteLine($"Welkome {customer.GetInfo()}");
            while(true)
            {
                Console.WriteLine("What would like to do:");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Cash Withdrawal");
                Console.WriteLine("3.Cash Deposit");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine($"Your Balance is: {bankServices.CheckBalance(customer)}");
                }
                if (Console.ReadLine() == "2")
                {
                    Console.WriteLine("Enter the amount you want to Withdrawal");
                    int amountWithdrawal;
                    int.TryParse(Console.ReadLine(), out amountWithdrawal);
                    Console.WriteLine($"You Withdrawal{amountWithdrawal} You have {bankServices.CashWithdrawal(customer.AccountBalance, amountWithdrawal)} left on your account.");
                }
                if (Console.ReadLine() == "3")
                {
                    Console.WriteLine("Enter the amount you want to Withdrawal");
                    int amountDeposit;
                    int.TryParse(Console.ReadLine(), out amountDeposit);
                    Console.WriteLine($"You Withdrawal{amountDeposit} You have {bankServices.CashDeposit(customer.AccountBalance, amountDeposit)} now on your account.");
                }

                Console.WriteLine("If you want another transaction enter yes. Otherwise enter no");
                if(Console.ReadLine() == "yes")
                {
                    continue;
                }
                if (Console.ReadLine() == "no")
                {
                    break;
                }
                    Console.ReadLine();
            }
                
            
            

        }

        
    }
}
