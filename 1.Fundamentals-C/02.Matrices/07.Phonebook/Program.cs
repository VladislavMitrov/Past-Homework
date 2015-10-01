using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
           

            while (true)
            {
                string input = Console.ReadLine();
                string[] contact;


                if (input != "search")
                {
                    contact = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = contact[0];
                    string number = contact[1];

                    if (!phonebook.ContainsKey(name))
                    {
                        List<string> phoneNumbers = new List<string>();
                        phoneNumbers.Add(number);
                        phonebook.Add(name, phoneNumbers);


                    }
                    else
                    {
                        if (!phonebook[name].Contains(number)) ;
                        {
                            phonebook[name].Add(number);
                        }
                    }


                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                string contactName = Console.ReadLine();

                if (phonebook.ContainsKey(contactName))
                {
                    Console.WriteLine("{0} -> {1}", contactName, string.Join(", ", phonebook[contactName]));
                }
                else
                {
                    Console.WriteLine("Contact {0} doesn't exist.", contactName);
                }
            }
        }
    }
}