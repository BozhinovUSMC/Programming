using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[rows, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

            for (int col = 0; col < cols; col++)
            {
                int m = 1000;
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < m) m = matrix[row, col];
                }
                Console.WriteLine("{0} ", m);
            }
            Console.ReadLine();
        }
    }
}
