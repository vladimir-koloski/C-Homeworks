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
                string transaction = Console.ReadLine();
                if (transaction == "1")
                {
                    Console.WriteLine($"Your Balance is: {bankServices.CheckBalance(customer)}");
                };
                if (transaction == "2")
                {
                    Console.WriteLine("Enter the amount you want to Withdrawal");
                    int amountWithdrawal;
                    int.TryParse(Console.ReadLine(), out amountWithdrawal);
                    if(amountWithdrawal > bankServices.CheckBalance(customer))
                    {
                        Console.WriteLine($"Your Ballance on account is {bankServices.CheckBalance(customer)} enter valid amount you want to Withdrawal");
                    }
                    else
                    {
                        Console.WriteLine($"You Withdrawal{amountWithdrawal} You have {bankServices.CashWithdrawal(customer, amountWithdrawal)} left on your account.");
                    }                        
                }
                if (transaction == "3")
                {
                    Console.WriteLine("Enter the amount you want to Deposit");
                    int amountDeposit;
                    int.TryParse(Console.ReadLine(), out amountDeposit);
                    Console.WriteLine($"You deposit {amountDeposit}.  You have {bankServices.CashDeposit(customer, amountDeposit)} now on your account.");
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
                    
            }
            Console.ReadLine();


        }

        
    }
}
