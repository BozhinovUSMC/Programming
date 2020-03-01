using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_Substring_Broken
{
    class Program
    {
        static void Main(string[] args)
        {
			string text = Console.ReadLine();
			int jump = int.Parse(Console.ReadLine());

			const char Search = 'p';
			bool hasMatch = false;

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == Search)
				{
					hasMatch = true;

					int endIndex = jump;

					if (endIndex > text.Length)
					{
						endIndex = text.Length;
					}

					string matchedString = text.Substring(i, endIndex + 1);
					Console.WriteLine(matchedString);
					i += jump;
				}
			}

			if (!hasMatch)
			{
				Console.WriteLine("no");
			}

			Console.ReadLine();
		}
    }
}
