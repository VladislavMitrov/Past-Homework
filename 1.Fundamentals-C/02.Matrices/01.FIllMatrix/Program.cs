using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FIllMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int rows = 0;
            int cols = 0;
            string direction = "down";

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "down" && (rows > n - 1 || matrix[rows, cols] != 0))
                {
                    direction = "up";
                    rows--;
                    cols++;
                }

                else if (direction == "up" && (rows < 0 || matrix[rows, cols] != 0))
                {
                    direction = "down";
                    rows++;
                    cols++;
                }
                matrix[rows, cols] = i;

                if (direction == "down")
                {
                    rows++;
                }

                else if (direction == "up")
                {
                    rows--;
                }



            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int number = 1;



            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = number;
                    number++;
                }
            }


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }



        }
    }

}