using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.N_K_Factorials
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

            int result = 1;
        while (n > k)
        {
            result *= n;
            n--;
        }
        Console.WriteLine(result);

            
        }
    }
}
