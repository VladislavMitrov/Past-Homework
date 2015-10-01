﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            long decNumber = long.Parse(Console.ReadLine());

            
            string hexNumber = "";
            while (decNumber != 0)
            {
                long remain = decNumber % 16;

                switch (remain)
                {
                    case 10: hexNumber = "A" + hexNumber; break;
                    case 11: hexNumber = "B" + hexNumber; break;
                    case 12: hexNumber = "C" + hexNumber; break;
                    case 13: hexNumber = "D" + hexNumber; break;
                    case 14: hexNumber = "E" + hexNumber; break;
                    case 15: hexNumber = "F" + hexNumber; break;
                    default: hexNumber = remain + hexNumber; break;
                }
                decNumber /= 16;
            }
            Console.WriteLine(hexNumber);
        }
    }
}