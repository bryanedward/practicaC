using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get{
                decimal balance = 0;
                foreach (var item in ListTransaction)
                {
                    balance += item.Cantidad;
                }
                return balance;
        } }

        
        public BankAccount(String Owner, Decimal Balance){
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = Owner;
            MakeDeposit(Balance, DateTime.Now, "Inicio de balance");
        }

        private List<Transaction> ListTransaction = new List<Transaction>();


        public void MakeDeposit(decimal cantidad, DateTime time, string note)
        // hacer depositivo enuna cuenta bancaria
        {
        if(cantidad < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(cantidad), "cantidad debe ser positivo");             
        }
        else
        {
            var deposit = new Transaction(cantidad, time, note);
            ListTransaction.Add(deposit);
        }
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            ListTransaction.Add(withdrawal);   
        }
    }
}