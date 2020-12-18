using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class OverDraft : Account
    {
        private double overDraftLimit;

        public double OverDraftlimit
        {
            get { return overDraftLimit; }
            set { overDraftLimit = value; }
        }

        public OverDraft()
        {
            Console.WriteLine("Empty Over Draft Constructor.");
        }
        public OverDraft(String accName, string accId, double balance, double overDraftLimit) : base(accName, accId, balance)
        {
            this.overDraftLimit = overDraftLimit;

        }

        public override void Withdraw(int amount)
        {
            if (amount <= (Balance+overDraftLimit))
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
            Console.WriteLine("Over Draft Limit :" + overDraftLimit);

        }
    }
}
