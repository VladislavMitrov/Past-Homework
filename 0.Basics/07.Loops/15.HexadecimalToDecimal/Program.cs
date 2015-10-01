using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            long result = 0;
            long power = 1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int number = 0;
                switch (input[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = input[i] - '0'; break;
                }
                result += power * number;
                power *= 16;
            }

           
            Console.WriteLine(result);
        }
    }
}
