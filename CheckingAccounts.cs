using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CheckingAccounts:Accounts
    {
        private int cAccNo;
        private Boolean checkbookIssued;

        public CheckingAccounts() { }

        public CheckingAccounts(string name, double balance)
        {
            this.cAccNo = this.GenerateAccountNo();
            this.name = name;
            this.balance = balance;
            this.checkbookIssued = false;
        }

        public override int GenerateAccountNo() 
        {
            Random r = new Random();
            return r.Next(100000, 499999);
        }

        public void CheckBook()
        {
            this.checkbookIssued = true;
        }

        public void CheckAccount()
        {
            Console.WriteLine("Account balance is {0}",balance);
        }
    }
}
