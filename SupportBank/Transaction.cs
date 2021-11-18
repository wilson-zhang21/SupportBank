using System;
using System.Collections.Generic;
using System.IO;

namespace SupportBank
{
    public class Transaction
    {
        public DateTime Date { get; private set; }
        public string From { get; private set; }
        public string To { get; private set; }
        public string Narrative { get; private set; }
        public decimal Amount { get; private set; }


        public Transaction(string line)
        {
            string[] row = line.Split(",");
            Date = DateTime.Parse(row[0]);
            From = row[1];
            To = row[2];
            Narrative = row[3];
            Amount = decimal.Parse(row[4]);
        }

    }
}