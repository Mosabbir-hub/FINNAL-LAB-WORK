using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Savings:Account
    {
        private int limitOfMonthlyTransaction;

        public int LimitOfMonthlyTransaction
        {
            get { return limitOfMonthlyTransaction; }
            set { limitOfMonthlyTransaction = value; }
        }
        public int AvailableTransactionLimit { get; set; }
        public Savings()
        {
            Console.WriteLine("Empty savings Constructor.");
        }
        public Savings(String accName,string accId,double balance,int limitOfMonthlyTransaction) :base(accName,accId,balance)
        {
            this.limitOfMonthlyTransaction = limitOfMonthlyTransaction;
            AvailableTransactionLimit = limitOfMonthlyTransaction;

        }

        public override void Withdraw(int amount)
        {
            if (AvailableTransactionLimit > 0 && amount <= (Balance - 500))
            {
                Balance -= amount;
                Console.WriteLine("Withdraw amount : " + amount);
            }
            else
                Console.WriteLine("Withdraw failed.");
        }

       public override void ShowInfo()
        {
            Console.WriteLine("Account Holder Name : " + AccountHolderName);
            Console.WriteLine("Account ID : " + AccId);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("Monthly transaction Limit :" + limitOfMonthlyTransaction);
            Console.WriteLine("Available transaction Limit : " + AvailableTransactionLimit);

        }
    }
}
