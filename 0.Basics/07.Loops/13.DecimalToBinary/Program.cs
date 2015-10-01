using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long decimalNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(decimalNumber, 2));
        }
    }
}
