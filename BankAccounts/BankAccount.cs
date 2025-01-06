using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BankAccounts
{
    public class BankAccount
    {
        public int account_number { get; set; }
        public string account_holder { get; set; }
        private double balance { get; set; } = 0;
        public BankAccount(int account_number, string account_holder, double balance)
        {
            this.account_number = account_number;
            this.account_holder = account_holder;
            this.balance = balance;
        }

        public void deposit(double value)
        {
            balance += value;
        }
        public void withdraw(double value)
        {
            if (balance - value <= 0)
                Console.WriteLine($"The amount in your account {balance} is less than what you want to withdraw {value}.");
            else
            {
                balance -= value;
                balance = Math.Round(balance);
            }
        }
        public void display_data()
        {
            Console.WriteLine($"Hi, {account_holder}, you have ${balance} in your account.");
        }
    }
}
