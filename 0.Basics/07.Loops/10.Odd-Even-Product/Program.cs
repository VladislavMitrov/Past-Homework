using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int number = int.Parse(inputArray[i]);
                if (i % 2 == 0 || i == 0)
                {
                    oddProduct *= number;
                }
                else
                {
                    evenProduct *= number;
                }
            }

            
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("YES");
                Console.WriteLine("Product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine("Odd Product = {0}", oddProduct);
                Console.WriteLine("Even Product = {0}", evenProduct);
            }
        }
    }
}
