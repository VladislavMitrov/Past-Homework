using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShuffleMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            string command = Console.ReadLine();
            string temp = string.Empty;

            while (command != "END")
            {
                string[] commandItems = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandItems.Length == 5 && commandItems[0] == "swap")
                {
                    x1 = int.Parse(commandItems[1]);
                    x2 = int.Parse(commandItems[3]);
                    y1 = int.Parse(commandItems[2]);
                    y2 = int.Parse(commandItems[4]);

                    if ((x1 >= 0 && x1 < rows) && (y1 >= 0 && y1 < cols) &&
                    (x2 >= 0 && x2 < rows) && (y2 >= 0 && y2 < cols))
                    {
                        temp = matrix[x1,y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;

                        Console.WriteLine("After swapping {0} and {1}: ", matrix[x2, y2], matrix[x1, y1]);

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write("{0,2}", matrix[row, col]);
                            }
                            Console.WriteLine();
                           
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!!");
                }


                command = Console.ReadLine();

            }


            

        }
    }
}
