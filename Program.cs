using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccounts c1 = new CheckingAccounts("Nishat Tasnim Khan", 50000);

            c1.Show();
            c1.CheckAccount();
            c1.Deposit(3500);
            c1.Withdraw(45000);

            Console.WriteLine();

            SavingAccounts s1 = new SavingAccounts("Erfanul Haq", 100000000);

            s1.Show();
            s1.Deposit(25839);
            s1.Interest();
        }
    }
}
