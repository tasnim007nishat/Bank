using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bank
{
    class SavingAccounts:Accounts
    {
        private int sAccNo;

        public SavingAccounts() { }

        public SavingAccounts(string name, double balance)
        {
            this.sAccNo = this.GenerateAccountNo();
            this.name = name;
            this.balance = balance;
        }

        public override int GenerateAccountNo()
        {
            Random r = new Random();
            return r.Next(500000, 999999);
        }

        public void Interest()
        {
            double rate;

            if (balance>10000)
            {
                rate = balance * 0.06;
                balance = balance + rate;
                Console.WriteLine("Rate:{0} and Total Balance:{1}", rate, balance);
            }

            else
            {
                rate = balance * 0.03;
                balance = balance + rate;
                Console.WriteLine("Rate:{0} and Total Balance:{1}", rate, balance);
            }
        }
    }
}
