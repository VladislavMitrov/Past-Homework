using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)

            {
                Console.WriteLine("{0} {1}", b, a);
            }
            if (b > a)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
