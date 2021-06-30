using Support_Bank.Models;
using System;
using System.IO;
using System.Linq;

namespace SupportBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var transactions = ParseFile.Parse("./support-bank-resources/Transactions2014.csv");

            UserResponses.AskUser(out var name, out var statement, out var summary);
            
            var person = new Person(name, transactions);

            if (statement)
            {
                foreach (var t in person.TransactionList)
                {
                    Console.WriteLine($"Date: {t.Date}, from: {t.From}, to: {t.To}, reason: {t.Narrative} amount: {t.Amount.ToString("C")}");
                }
            }

            if (summary)
            {
                Console.WriteLine("----------------------------------");
                foreach (var entry in person.IndividualData)
                {

                    Console.WriteLine(entry.Key + " " + entry.Value.ToString("C"));
                }
            }
        }
    }
}
