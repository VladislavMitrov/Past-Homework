using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Trailing_Zeros_In_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number N: ");
            int n = int.Parse(Console.ReadLine());


            int factorial = 1;
            int trailingZeroes = 0;
            int sum = 5;
            while (n >= sum)
            {
                trailingZeroes += (n / sum);
                sum *= 5;
            }
            Console.Write("The number of the trailing zeroes at the end of ({0}!) is: {1}\n", n, trailingZeroes);
        }

    }
}
