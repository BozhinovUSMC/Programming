using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_April
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
                var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int col = 0; col < cols; col++) matrix[row, row] = line[col];       
            }

            int MSum = 0, MRow = -1, MCol = -1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int tempSum = matrix[row, col] + matrix[row + 1, col] +
                        matrix[row, col + 1] + matrix[row +1, col +1];

                    if (tempSum > MSum)
                    {
                        MSum = tempSum;
                        MRow = row;
                        MCol = col;
                        Console.WriteLine("Sum {0} at [{1},{2}]", MSum, MRow, MCol);
                    }
                }
            }

            for (int row = MRow; row < MRow + 2; row++)
            {
                for (int col = MCol; col < MCol + 2; col++)
                Console.WriteLine(matrix[row, col] + " ");
                Console.WriteLine();
                
            }

            Console.ReadLine();
        }
    }
}
