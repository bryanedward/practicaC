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
                    balance += item.Cantidad;
                }
                return balance;
        } }

        
        public BankAccount(String Owner, Decimal Balance){
            this.Owner = Owner;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            Console.WriteLine(accountNumberSeed);
            MakeDispost(Balance, DateTime.Now, "Inicio de balance");
        }
        
        public void MakeDispost(decimal cantidad, DateTime time, string note)
        // hacer depositivo enuna cuenta bancaria
        {
        if(cantidad <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(cantidad), "cantidad debe ser positivo");             
        }
        else
        {
            var deposit = new Transaction(cantidad, time, note);
            ListTransaction.Add(deposit);
        }
            

        }
    }
}