using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("Nayamet Ullah", "A101", 5000,5);
            a1.ShowInfo();
            a1.Deposit(5000);
            a1.Withdraw(9700);
            a1.ShowInfo();
            Console.WriteLine();
           
            Account a2 = new Fixed("Anik", "A201", 5000,5,2015);
            a2.ShowInfo();
            a2.Deposit(5000);
            a2.Withdraw(9700);
            a2.ShowInfo();
            Console.WriteLine();

            Account a3 = new SpecialSaving("Fahim", "A301", 2000, 5);
            a3.ShowInfo();
            a3.Deposit(5000);
            a3.Withdraw(6600);
            a3.ShowInfo();
            Console.WriteLine();
            Account a4 = new OverDraft("Refayet", "A401", 3000, 1000);
            a4.ShowInfo();
            a4.Transfer(2000, a1);
            a4.ShowInfo();
            

        }
    }
}
