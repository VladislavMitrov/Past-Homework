using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Deck_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] suitsCharArray = { '\u2660', '\u2663', '\u2665', '\u2666' };

            for (int i = 2; i <= 14; i++)
            {
               if (i <= 10)
               {
                   for (int j = 0; j < suitsCharArray.Length; j++)
                   {
                       Console.Write(i + "" + suitsCharArray[j] + " "); 
                   }

                   Console.WriteLine();
               }

               switch (i)
               {
                   case 11: for (int j = 0; j <= 3; j++)
                       {
                           Console.Write("J" + suitsCharArray[j] + " ");
                           
                       } break;
                       
                   case 12: for (int q = 0; q <= 3; q++)
                       {
                           Console.Write("Q" + suitsCharArray[q] + " ");
                           
                       } break;
                       
                   case 13: for (int k = 0; k <= 3; k++)
                       {
                           Console.Write("K" + suitsCharArray[k] + " ");
                          
                       } break;

                   case 14: for (int a = 0; a <= 3; a++)
                       {
                           Console.Write("A" + suitsCharArray[a] + " ");
                         
                       } break;
                       
                   default:
                       break;
               }
            }
        }
    }
}
