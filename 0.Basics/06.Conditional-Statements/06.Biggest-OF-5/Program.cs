using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Biggest_OF_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                Console.WriteLine(a);
            }

            if ((b > a) && (b > c) && (b > d) && (b > e))
            {
                Console.WriteLine(b);
            }

            if ((c > b) && (c > a) && (c > d) && (c > e))
            {
                Console.WriteLine(c);
            }

            if ((d > b) && (d > a) && (d > c) && (d > e))
            {
                Console.WriteLine(d);
            }

            if ((e > b) && (e > a) && (e > d) && (e > c))
            {
                Console.WriteLine(c);
            }
           
        }
    }
}
