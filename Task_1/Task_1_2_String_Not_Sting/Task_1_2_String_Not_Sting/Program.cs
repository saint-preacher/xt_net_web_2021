using System;
using System.Globalization;

namespace Task_1_2_String_Not_Sting
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Navigation: type 'exit' if you want to stop the execution");
                Console.Write("Type from '1' to '4' to pick the task to execute: ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Averages();
                        break;
                    case "2":
                        Doubler();
                        break;
                    case "3":
                        Lowercase();
                        break;
                    case "4":
                        Validator();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }



            }

            static void Averages()
            {
                Console.WriteLine("You chose task 1.2.1 \"Averages\"");
                Console.WriteLine("Enter your string:");
                string s = Console.ReadLine();
                int n = s.Length;
                char[] array = new char[n];
                array = s.ToCharArray();
                int count1 = 0;
                int count2 = 0;
                for (int i = 0; i < n; i++)
                {
                    string s1 = "";
                    while ((i < n) && (!char.IsPunctuation(array[i])) && (!char.IsSeparator(array[i]))) //Check if current char doesn`t
                    {                                                                     //belong to Punctuation or Separation symbols
                        s1 += array[i];                                                   //then it writes to the output string. 
                        count1++;
                        i++;
                    }
                    if (s1 != "")                                                         //If an output string isn`t empty then
                    {                                                                     //then the word outputs to console.
                        Console.WriteLine($"The word is: {s1}, the length of the word is: {s1.Length}");
                        count2++;
                    }

                }
                Console.WriteLine($"Count of letters is: {count1}, count of words is: {count2}");
                Console.WriteLine($"The average length of word in string is: {(double)count1 / count2}"); //The result isn`t rounded.
            }

            static void Doubler()
            {
                Console.WriteLine("You chose task 1.2.2 \"Doubler\"");
                Console.WriteLine("Enter the first string:");
                string enter1 = Console.ReadLine();
                Console.WriteLine("Enter the secind string:");
                string enter2 = Console.ReadLine();
                int n1 = enter1.Length;
                int n2 = enter2.Length;
                var resultString = "";
                foreach (var c in enter1)                                       //For each symbol in the string 1 there is a check
                {                                                               //if it matches a symbol in the string 2. If true, then such 
                    resultString += enter2.Contains(c) ? $"{c}{c}" : $"{c}";    //symbol becomes doubled. Else not.
                }

                Console.WriteLine($"Result string with duplications: {resultString}");
            }

            static void Lowercase()
            {
                Console.WriteLine("You chose task 1.2.3 \"Lowercase\"");
                Console.WriteLine("Input your string:");
                string s = Console.ReadLine();
                int n = s.Length;
                int count = 0;
                int i = 0;
                while (i < n)
                {
                    int j = i;
                    if (!char.IsPunctuation(s[j]) && !char.IsSeparator(s[j])) //If current char in string doesn`t belong to Punctuation
                    {                                                         //or Separation symbols, then there is a check if it is a Letter
                        while ((j < n) && (char.IsLetter(s[j])))              //symbol. If true, then the iterator increments.
                        {
                            j++;
                        }
                        string temp = s.Substring(i, j - i);                  //Cut a substring which is the whole word.


                        if (temp.ToLower() == temp)                           //If the word consists of lower chars, then
                        {                                                     //the counter of words increments.
                            count++;
                            Console.WriteLine(temp);
                        }
                    }
                    i = j + 1;

                }
                Console.WriteLine($"Amount of words with first symbol low: {count}");

            }

            static void Validator()
            {
                Console.WriteLine("You chose task 1.2.4 \"Validator\"");
                Console.WriteLine("Input your string:");
                string s = Console.ReadLine();
                int n = s.Length;

                string result = "";
                int i = 0;
                while (i < n)
                {
                    int j = i;
                    if (!char.IsPunctuation(s[i]) && !char.IsSeparator(s[i]))
                    {
                        while ((j < n) && s[j] != '.' && s[j] != '?' && s[j] != '!')
                        {
                            j++;
                        }

                        int endMark = j == n ? 1 : 0;
                        if (!char.IsUpper(s[i]))
                        {
                            result += char.ToUpper(s[i]) + s.Substring(i + 1, j - i - endMark);
                        }
                        else
                        {
                            result += s[i] + s.Substring(i + 1, j - i - endMark);
                        }
                    }
                    else
                    {
                        result += s[i];
                    }



                    i = j + 1;
                }
                Console.WriteLine($"Output: {result}");
            }
        }
    }
}
