using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class Program
    {
        static double ReverseNumber(double num)
        {
            string number = num.ToString();
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);
            string reverseNumber = new string(reverse);
            double newNumber = double.Parse(reverseNumber);

            return newNumber;
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(ReverseNumber(number));
        }
    }
}