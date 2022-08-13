using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate_the_relational_and_logical_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            int i, j;
            bool b1, b2;

            i = 5;
            j = 6;

            if (i < j) Console.WriteLine("i < j");
            if (i <= j) Console.WriteLine("i <= j");
            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("this won't execute");
            if (i >= j) Console.WriteLine("this won't execute");
            if (i > j) Console.WriteLine("this won't execute");

            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("this won't execute");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) is true");
            if (b1 | b2) Console.WriteLine("b1 | b2 is true");
            if (b1 ^ b2) Console.WriteLine("b1 ^ b2 is true");

            Console.ReadKey();

        }
    }
}
