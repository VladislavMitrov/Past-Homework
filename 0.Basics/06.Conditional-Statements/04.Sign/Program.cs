using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C: ");
            double c = double.Parse(Console.ReadLine());

            double result = a * b * c;

            if (result > 0)
            {
                Console.WriteLine("+");
            }

            if (result % 2 == 0)
            {
                Console.WriteLine("-");
            }

            if (result == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
