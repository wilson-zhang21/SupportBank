using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using SupportBank;

namespace SupportBank
{
    public class Bank
    {
        public ListOfAccounts Accounts = new ListOfAccounts();
        public ListOfTransactions Transactions = new ListOfTransactions();

        public void ReadAndUpdateFromCSV(string filename)
        {
            Transactions.ReadCSV(filename);
            Accounts.Update(Transactions);
        }

        public void PrintUserInfo(string name)
        {
            var result = Accounts.GetUserInfo(name);
            Console.WriteLine($"The user {name} has a balance of {result[name]}");
        }
    }
}