using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            var input = Console.ReadLine().Split(' ');
            string numbers = input[0].ToLower();

            switch (numbers)
            {
                case "A":
                    {
                        phonebook.Add(input[1], input[2]);
                        break;
                    }

                case "S":
                    {
                        if (phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Name: {input[1]} --> {phonebook[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine("Contact doesn't exist");
                        }
                        break;                    
                    }

                case "stop":
                   {
                        return;
                   }
                    
            }
            Console.ReadLine();
        }
    }
}
