using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[r,c];
            Random ng = new Random();

            for (int b = 0; b < r; b++)
            {
                for (int a = 0; a < c; a++)
                {
                    Matrix[b, a] = ng.Next(1, 30);
                }
            }
            for (int b = 0; b < r; b++)
            {
                for (int a = 0; a < c; a++)
                {
                    Console.WriteLine(Matrix[b, a] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
