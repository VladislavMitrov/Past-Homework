﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NotDivisible_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
			{
                if (((i % 3) !=0) && ((i % 7) !=0))
                {
                    Console.Write("{0} ", i);
                }

               
	
		 
	
			 
			}
        }
    }
}
