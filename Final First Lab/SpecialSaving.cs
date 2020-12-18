using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class SpecialSaving:Account
    {
        private int limitOfMonthlyTransaction;

        public int LimitOfMonthlyTransaction
        {
            get { return limitOfMonthlyTransaction; }
            set { limitOfMonthlyTransaction = value; }
        }
        public int AvailableTransactionLimit { get; set; }
        public double OpeningBalance { get; set; }

        public SpecialSaving()
        {
            Console.WriteLine("Empty special savings Constructor.");
        }
        public SpecialSaving(String accName, string accId, double balance, int limitOfMonthlyTransaction) : base(accName, accId, balance)
        {
            this.limitOfMonthlyTransaction =limitOfMonthlyTransaction;
            AvailableTransactionLimit = limitOfMonthlyTransaction;
            OpeningBalance = balance;
        }

        public override void Withdraw(int amount)
        {
            if (AvailableTransactionLimit>0 && amount <= (Balance - (OpeningBalance*20)/100))
            {
                Balance -= amount;
                AvailableTransactionLimit--;
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
