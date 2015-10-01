using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variable needs to be 1 < n < 100");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int numerator = 1;
            int denominator = 1;

            for (int i = 2 * n; i >= n + 2; i--)
            {
                numerator *= i;
            }

            for (int i = 1; i <= n; i++)
            {
                denominator *= i;
            }

            int catalanNumber = numerator / denominator;

            Console.WriteLine(catalanNumber);
        }
    }
}
