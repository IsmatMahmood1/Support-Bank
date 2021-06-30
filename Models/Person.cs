using System.Collections.Generic;
using System.Linq;

namespace Support_Bank.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public List<Transaction> TransactionList { get; set; }
        public Dictionary<string, double> IndividualData { get; set; }

        public Person(string name, List<Transaction> transactionList)
        {
            Name = name;

            var filteredTransactions = transactionList.Where(transaction => transaction.From == Name || transaction.To == Name).ToList();

            TransactionList = filteredTransactions;

            IndividualData = new Dictionary<string, double>();

            foreach (var transaction in TransactionList)
            {
                var isFromThisPerson = transaction.From == Name;
                var otherPerson = !isFromThisPerson ? transaction.From : transaction.To;
                if (!IndividualData.ContainsKey(otherPerson))
                {
                    if (isFromThisPerson)
                    {
                        IndividualData.Add(otherPerson, transaction.Amount * -1);
                    }
                    else
                    {
                        IndividualData.Add(otherPerson, transaction.Amount);
                    }
                }
                else
                {
                    if (isFromThisPerson)
                    {
                        IndividualData[otherPerson] -= transaction.Amount;
                    }
                    else
                    {
                        IndividualData[otherPerson] += transaction.Amount;
                    }
                }
            }
        }
    }
}
