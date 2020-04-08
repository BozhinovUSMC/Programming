using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, int>();                               
            materials.Add("gold", 0);
            materials.Add("silver", 0);
            materials.Add("copper", 0);

            while (true)
            {
                Console.WriteLine("Enter type of material :");
                string comm = Console.ReadLine().ToLower();                
                if (comm == "gold" || comm == "silver" || comm == "copper" || comm == "stop");
                {
                    
                    if (comm != "stop")
                    {
                        Console.WriteLine($"Enter amount{comm}:");
                        int amount = int.Parse(Console.ReadLine());
                        switch (comm)
                        {

                            case "Gold":
                                {
                                    materials["Gold"] += amount;
                                    break;
                                }

                            case "Silver":
                                {
                                    materials["Silver"] += amount;
                                    break;
                                }

                            case "Copper":
                                {
                                    materials["Copper"] += amount;
                                    break;
                                }

                        }

                    }
                    else
                    {
                        Console.WriteLine($"Gold --> {materials["Gold"]}");
                        Console.WriteLine($"Silver --> {materials["Silver"]}");
                        Console.WriteLine($"Copper --> {materials["Copper"]}");
                        break;
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}
