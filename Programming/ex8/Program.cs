using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exercise(double.Parse(Console.ReadLine())));
            Console.ReadLine();
        }
        static double Exercise(double r)
        {

            double solution = Math.PI * (r * 2);
            return solution;
        }
    }
}
