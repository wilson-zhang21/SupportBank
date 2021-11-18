using System.Collections.Generic;
using System.IO;
using System;

namespace SupportBank
{
    public class ListOfTransactions
    {
        public List<Transaction> AllTransactions = new List<Transaction>();

        public void ReadCSV(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            line = sr.ReadLine();  // read the first row
            
            while ((line = sr.ReadLine()) != null)
            {
                
                AllTransactions.Add(new Transaction(line));
            }
        }


    }
}