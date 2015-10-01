using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThanNeighbours
{
    class Program
    {
        static int[] arr;

        static bool LargerThanNext(int index)
        {
            bool isGreater;
            if (index == 0)
            {
                isGreater = arr[index] > arr[index + 1];
            }
            else if (index == arr.Length - 1)
            {
                isGreater = arr[index] > arr[index - 1];
            }
            else
            {
                isGreater = arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
            }
            return isGreater;
        }
        static void Main(string[] args)
        {
            string inputArray = Console.ReadLine();
            arr = inputArray.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(LargerThanNext(i));
            }
        }
    }
}