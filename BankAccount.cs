using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> ListTransaction = new List<Transaction>();
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get{
                decimal balance = 0;
                foreach (var item in ListTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
        } }

        
        public BankAccount(String Owner, Decimal Balance){
            this.Owner = Owner;
        }
        
        public void MakeDispost(decimal amount, DateTime time, string note)
        // hacer depositivo enuna cuenta bancaria
        {
        if(amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount debe ser positivo");             
        }
        else
        {
            var deposit = new Transaction(amount, time, note);
            ListTransaction.Add(deposit);
        }
            

        }
    }
}