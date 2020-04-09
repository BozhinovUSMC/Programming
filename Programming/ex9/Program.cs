using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            var Nameandage = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int date = int.Parse(Console.ReadLine());
                Nameandage.Add(name, date);
                Console.WriteLine($"\n{name} {date} was added. ");
            }

            Console.WriteLine("\nDone");
            Console.ReadLine();
        }
    }
}
