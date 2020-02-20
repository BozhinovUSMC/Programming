using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] Arrays = new string[n];

            for (int i = 0; i < n; i++)
            {
                Arrays[i] = Console.ReadLine();
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(Arrays[i]);
            }

            Console.ReadLine();

        }
    }
}
