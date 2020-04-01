using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> res = new List<int>();
            List<int> res1 = new List<int>();
            List<int> res2 = new List<int>();

            int len1 = nums1.Count;
            int len2 = nums2.Count;

            for (int i = 0; i < len1; i++)
            {
                if (nums2.Contains(nums1[i]))
                {
                    res.Add(nums1[i]);
                }
            }

            for (int i = 0; i < len1; i++)
            {
                if (!nums2.Contains(nums1[i]))
                {
                    res1.Add(nums1[i]);
                }
            }

            for (int i = 0; i < len2; i++)
            {
                if (!nums1.Contains(nums2[i]))
                {
                    res2.Add(nums2[i]);
                }
            }

            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
                      
            foreach (var item in res1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            foreach (var item in res2)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
