using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_3._3_Pizza_Time
{
    class SuperString
    {
        
        public static void StringDisplay()
        {
            Console.WriteLine("Navigation: type any kind of string you want to check.");
            Console.WriteLine("Type \"exit\" to stop execution.");
            string s;
            do
            {
                Console.Write("Input word to check: ");
                s = Console.ReadLine();
                if (Regex.IsMatch(s, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("This string is written in English language.");
                }

                else if (Regex.IsMatch(s, @"^[а-яёА-ЯЁ]+$"))
                {
                    Console.WriteLine("This string is written in Russian language.");
                }

                else if (Regex.IsMatch(s, @"^[0-9]+$"))
                {
                    Console.WriteLine("This string consists of numbers");
                }
                else
                {
                    Console.WriteLine("This string is mixed");
                }
            } while (s != "exit");
            Console.WriteLine("Exiting program...");
        }
        
    }
}
