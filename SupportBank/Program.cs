using System;
using System.Data;
using System.IO;
using System.Globalization;
using CsvHelper;



namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            using var streamReader = File.OpenText(@"C:\Work\Training\SupportBank\SupportBank\Transactions2014.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);
            
            var allTransactions = csvReader.GetRecords<Transaction>();
            foreach (var transaction in allTransactions)
            {
                Console.WriteLine(transaction);
            }
            
        }
    }
}

public record Transaction
{
    public DateTime Date { get; init; }
    public string From { get; init; }
    public string To { get; init; }
    public string Narrative { get; init; }
    public float Amount { get; init; }
    
}