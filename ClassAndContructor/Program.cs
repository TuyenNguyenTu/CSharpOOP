using System;

namespace ClassAndContructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var account = new BankAccount("Tuyên",2000);
            System.Console.WriteLine("Account has been created");
            account.Deposit(3000,DateTime.Now,"Receive this month's salary.");
            account.Withdraw(100,DateTime.Now,"Buy a keyword");
            account.Withdraw(120,DateTime.Now,"Buy a mouse");
            System.Console.WriteLine(account.Balance);
        }
    }
}
