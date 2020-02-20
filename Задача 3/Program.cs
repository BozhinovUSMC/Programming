using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                arr1[i] = input;
            }

            int[] arr2 = new int[n];
            arr1.CopyTo(arr2, 0);

            Array.Reverse(arr2);
            for (int i = 0; i < n; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }

            foreach (int val in arr3)
            {               
                Console.Write($" {val} ");
            }

            Console.ReadLine();
        }
    }
}
