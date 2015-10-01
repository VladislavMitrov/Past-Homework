using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurences = new Dictionary<char,int>();
 
            foreach (var symbol in input)
	{
        if (occurences.ContainsKey(symbol))
        {
            occurences[symbol]++;
        }

        else
        {
            occurences.Add(symbol, 1);
        }
	}
            foreach (KeyValuePair<char, int> pair in occurences)
            {
                Console.WriteLine(" :{0} {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
