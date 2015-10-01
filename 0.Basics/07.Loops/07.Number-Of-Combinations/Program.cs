using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Number_Of_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables need to be 1 < k < n < 100");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K: ");
            int k = int.Parse(Console.ReadLine());
            int numerator = 1;
            int denominator = 1;

            for (int i = n; i > k; i--)
            {
                numerator *= i;

            }
            for (int i = 1; i <= (n - k); i++)
            {
                denominator *= i;
            }

            int Result = numerator / denominator;

            Console.WriteLine(Result);
        }
    }
}
