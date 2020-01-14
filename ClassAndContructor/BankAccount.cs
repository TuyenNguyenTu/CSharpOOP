using System;
using System.Collections.Generic;

namespace ClassAndContructor
{
    public class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();
        public long AccountNumber { get; } // có thể set trong hàm contructor
        public string Owner { get; set; }
        public bool Status{get;set;} = true;
        public decimal Balance { 
            
            get {
                decimal balance = 0;
                foreach (var trans in transactions)
                {
                    balance +=trans.Amount;
                }
                return balance;
            }
        
        
        }

 
        
        public void Deposit(decimal amount, DateTime date, string note)
        {
            //Money send to bank account
            var deposit = new Transaction(amount,date,note);
            transactions.Add(deposit);
        }
        public void Withdraw(decimal amount, DateTime date, string note)
        {
                var withDraw = new Transaction(-amount,date,note);
                transactions.Add(withDraw);
        }
        private long GenerateAcountNumber()
        {
            return ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
        }
        public BankAccount(string owner, decimal initialBalance)
        {
            this.Owner = owner;
            this.Deposit(initialBalance,DateTime.Now,"Initial Balance");
            this.AccountNumber = GenerateAcountNumber();
            System.Console.WriteLine($"Object initalized with: \n AccountNumber:  {this.AccountNumber} \n Owner: {this.Owner} \n Balance: {this.Balance}\n Status:{this.Status}");
        }
    }
}