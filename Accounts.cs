using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public abstract class Accounts
    {
        protected string name;
        protected double balance;
        protected int accNo;
        //protected string accountNo;
        public virtual void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;
                Console.WriteLine("Balance: {0} \nWithdrawed: {1}", balance, amount);
            }
            else { Console.WriteLine("Insufficient Balance"); }
        }
        public virtual void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Balance: {0} \nDiposited: {1}", balance, amount);
        }

        public virtual int GenerateAccountNo()
        {
            Random r = new Random();
            return r.Next(100000, 999999);
        }

        public Accounts()
        {
            this.name = "none";
            this.accNo = this.GenerateAccountNo();
            this.balance = 0;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public int AccNo
        {
            set { this.accNo = value; }
            get { return this.accNo; }
        }

        public void Show()
        {
            Console.WriteLine("Name:{0} \nAccount No:{1} \nBalance:{2}",name,accNo,balance);
        }
    }
}
