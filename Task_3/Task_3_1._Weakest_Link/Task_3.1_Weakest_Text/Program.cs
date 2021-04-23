using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_3._1_Weakest_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Type '1' to choose Task 3.1.1 \"Weakest Link\";");
                Console.WriteLine("Type '2' to choose Task 3.1.2 \"Text Analysis\";");
                Console.WriteLine("Type 'exit' to go back to main menu.");
                Console.Write("Choose option: ");
                string selection = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                switch (selection)
                {
                    case "1":
                        {
                            Console.WriteLine("You chose Task 3.1.1 \"Weakest Link\"");
                            Weakest_Link.WeakestLink();
                            break;
                        }
                    case "2":
                        {
                            Text_Analysis.Analise();
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("Returning to the main menu...");
                            return;
                        }
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }
            }
        }
    }
}
