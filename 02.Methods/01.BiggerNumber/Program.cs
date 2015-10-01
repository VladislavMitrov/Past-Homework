using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BiggerNumber
{
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNumber = Math.Max(firstNumber, secondNumber);
            return maxNumber;
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);

        }
    }
}
