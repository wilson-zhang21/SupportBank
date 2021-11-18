using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Globalization;
using NLog;




namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account2014 = new Bank();
            account2014.ReadAndUpdateFromCSV(@"C:\Work\Training\SupportBank\SupportBank\inputfiles\Transactions2014.csv");
            account2014.PrintUserInfo("Tim L");


        }
    }
}

