namespace Support_Bank.Models
{
    public class Transaction
    {
        public string Date { get; }
        public string From { get; }
        public string To { get; }
        public string Narrative { get; }
        public double Amount { get; }

        public Transaction(string[] cells)
        {
            Date = cells[0];
            From = cells[1];
            To = cells[2];
            Narrative = cells[3];

            double.TryParse(cells[4], out var amount);
            Amount = amount;
        }
    }
}