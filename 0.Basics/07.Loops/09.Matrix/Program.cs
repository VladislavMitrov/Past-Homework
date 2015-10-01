using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if ((1 <= n) && (n <= 20))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= n; i++)
                    {
                        Console.WriteLine(i + j + " ");
                    }

                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Number not between 1 and 20");
            }

	        
            
        }
    }
}
