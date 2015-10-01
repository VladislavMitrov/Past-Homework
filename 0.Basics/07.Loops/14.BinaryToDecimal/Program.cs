using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binNumber = Console.ReadLine();

            
            long result = 0;
            int power = 1;
            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                int number = binNumber[i] - '0';
                result += number * power;
                power *= 2;
            }

            
            Console.WriteLine(result);
        }
    }
}
