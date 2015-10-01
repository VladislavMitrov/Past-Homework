using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastDigitAsWord
{
    class Program
    {
        
             static string[] number = { "zero", "one", "two", "three", "four", "five",
                              "six", "seven", "eight", "nine"};
 
        static void GetLastDigitAsWord(int num)
        {
            int lastDigit = num % 10;
            Console.WriteLine(number[lastDigit]);
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());

            GetLastDigitAsWord(number1);
        }
        
    }
}


