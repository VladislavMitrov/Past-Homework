using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int Score = int.Parse(Console.ReadLine());
            switch (Score)

            {
                case 1:
                case 2:
                case 3: Console.WriteLine(Score * 10); break;
                case 4:
                case 5:
                case 6: Console.WriteLine(Score * 100); break;
                case 7:
                case 8:
                case 9: Console.WriteLine(Score * 1000); break;



                default: if  ((Score == 0) || (Score > 9))
                    {
                        Console.WriteLine("Invalid Score"); ;
                    }
                    break;
            }
            
        }
    }
}
