using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberCalculations
{
    class Program
    {
               
        static int Min(int[] arr)
        {
            int minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            return minValue;
        }
          static double Min1(double[] arr)
        {
            double minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            return minValue;
        }

        static int Max(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }
        static double Max1(double[] arr)
        {
            double maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }

         static int Sum(int[] arr)
        {
            int sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
         static double Sum1(double[] arr)
        {
            double sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
          static int Product(int[] arr)
        {
            int product = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
          static double Product1(double[] arr)
        {
            double product = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
         static int Average(int[] arr)
        {
            int sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            sum = sum / arr.Length;
            return sum;
        }
         static double Average1(double[] arr)
        {
            double sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            sum = sum / arr.Length;
            return sum;
        }
         static void Main(string[] args)
        {
            double[] doubleArr = { 5.6, 7.2, 12.1, 4.2, 0.5, 6.9, 1.7, 5.3, 9.6 };
            int[] intArr = { 16, 32, 7, 42, 5, 1, 69, 38, 23 };
            Console.WriteLine("Min member -> double: {0}  integer: {1}",Min1(doubleArr),Min(intArr));
            Console.WriteLine("Max member -> double: {0}  integer: {1}", Max1(doubleArr), Max(intArr));
            Console.WriteLine("Sum of elements -> double: {0}  integer: {1}",Sum1(doubleArr),Sum(intArr));
            Console.WriteLine("Products of elements -> double: {0}  integer: {1}", Product1(doubleArr), Product(intArr));
            Console.WriteLine("Avarage -> double: {0}  integer: {1}", Average1(doubleArr), Average(intArr));
           
        }
        
    }
}
