using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task_3._1_Weakest_Text
{
    class Text_Analysis
    {
        public static void Analise()
        {
            //the string (text) to check. I was needed to add \n to strings and include it in separator,
            //because I couldn`t write it in a way of seeing correctly.
            string text = "";
            Console.WriteLine("Caution. This task will work perfctly on huge string.");
            Console.WriteLine("To end the input line press \"Enter\" key twice!");

            Console.WriteLine("Input string to analyse:");
            
            {
                string temp;
                while ((temp = Console.ReadLine()) != "")
                {
                    text += temp + Environment.NewLine;
                }
            }
            //"I want to heal" + Environment.NewLine +
            //"I want to feel" + Environment.NewLine +
            //"What I thought was never real" + Environment.NewLine +
            //"I want to let go of the pain I have held so long" + Environment.NewLine +
            //"Erase all the pain till it is gone" + Environment.NewLine +
            //"I want to heal" + Environment.NewLine +
            //"I want to feel" + Environment.NewLine +
            //"Like I am close to something real" + Environment.NewLine +
            //"I want to find something I have wanted all along" + Environment.NewLine +
            //"Somewhere I belong";

            //Creating list with separated text.

            string[] words = Regex.Split(text, @"\W+");

            int count = 0;

            //The next step is to create dictionary with words from text
            //in order to create pairs (word, count of appearances).
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (word == "")
                {
                    continue;
                }
                string lower = word.ToLower(); //rewriting text in the new one but in lower register in order to ignore it.
                if (dictionary.ContainsKey(lower))//If the current word has already appeared, then counter increases.
                {
                    dictionary[lower]++;
                }
                else //else we initiate the current word with count = 1.
                {
                    dictionary.Add(lower, 1);
                }
                count++;
            }
            


            foreach (KeyValuePair<string, int> elem in dictionary)
            {
                Console.WriteLine($"Element \"{elem.Key}\" has {elem.Value} entry(ies) in text");
                
            }

            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine();

            foreach (KeyValuePair<string, int> elem in dictionary)
            {
                if (elem.Value < count * 0.38)
                {
                    Console.WriteLine($"Congratulations! You don`t use the word {elem.Key} too often!");
                    
                }
                if (elem.Value > count * 0.62)
                {
                    Console.WriteLine($"You use the word {elem.Key} too often!");
                }
            }

            //int maxValue = dictionary.Values.Max();
            //int minValue = dictionary.Values.Min();

            //foreach (KeyValuePair<string, int> elem in dictionary)
            //{
            //    //if (elem.Value == maxValue)
            //    //{
            //    //    Console.WriteLine($"The most frequently used word is \"{elem.Key}\" with \"{elem.Value}\" entries");
            //    //}
            //    //else if ((elem.Value != minValue) && (elem.Value != maxValue))
            //    //{
            //    //    Console.WriteLine();
            //    //}
            //    //else if (elem.Value == minValue)
            //    //{
            //    //    Console.WriteLine($"The least frequently used word is \"{elem.Key}\" with \"{elem.Value}\" entries");
            //    //}

            //}


        }
    }
}
