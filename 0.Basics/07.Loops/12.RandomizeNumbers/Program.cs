using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
		int[] myArray = new int[n];
		
        
		for (int i = 0; i < n; i++)
		{
			myArray[i] = i + 1;
		}
        Console.WriteLine("Initial sequence of numbers : " + String.Join(" ", myArray));

        
        Random rnd = new Random();
        for (int j = 0; j < n; j++)
        {
            int randomIndex = rnd.Next(0, n);
			int temp = myArray[randomIndex];
			myArray[randomIndex] = myArray[j];
            myArray[j] = temp;
        }

        
        Console.WriteLine("Randomized sequence of numbers : " + String.Join(" ", myArray));
	
        }
    }
}
