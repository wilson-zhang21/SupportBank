using System;
namespace SupportBank
{
    public class Account
    {
        public string name;
        public decimal balance;

        public Account(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void AddMoney(decimal amount)
        {
            balance += amount;
        }
    }
}