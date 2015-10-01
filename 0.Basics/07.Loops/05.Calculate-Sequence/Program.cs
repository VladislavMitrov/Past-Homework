using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            double nFactorial = 1;
            double xPoweredByN = x;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                double result = nFactorial / xPoweredByN;
                sum += result;
                xPoweredByN *= x;
            }
            Console.WriteLine("S: {0:F5}", sum);
        }
    }
}
