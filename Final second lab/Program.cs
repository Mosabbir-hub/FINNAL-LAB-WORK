using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_second_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalCalculator n1 = new NormalCalculator();
            n1.sum(10, 15);
            n1.sub(15, 10);
            n1.multiplication(15, 10);
            n1.division(150, 10);
            Console.WriteLine();
            ScientificCalculator s1 = new ScientificCalculator();
            s1.XtoY(3, 4);
            s1.SquareRoot(9);
            
        }
    }
}
