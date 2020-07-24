using System;

namespace classes
{
    public class Transaction
    {
        public decimal Cantidad { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Cantidad = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}