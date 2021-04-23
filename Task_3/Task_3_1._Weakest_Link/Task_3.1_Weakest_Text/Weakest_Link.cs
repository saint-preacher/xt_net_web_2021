using System;
using System.Collections.Generic;


namespace Task_3._1_Weakest_Text
{
    public class Weakest_Link
    {
        public static void WeakestLink()
        {
            int n;
            int num;
            Console.Write("Enter count of people in circle: ");
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0))
            {
                Console.Write("Enter count of people in circle: ");
            }
            Console.WriteLine();

            Console.Write("Enter number of person to delete: ");
            while (!int.TryParse(Console.ReadLine(), out num) || (num > n) || (num <= 0))
            {
                if (num > n)
                {
                    Console.WriteLine("Number of person can`t be more that count of people in circle!");
                    Console.WriteLine("Try again!");
                }

                Console.Write("Enter number of person to delete: ");
            }
            Console.WriteLine();
            static void DisplayList<T>(List<T> list)
            {
                foreach (var item in list)
                {
                    Console.Write($"{item}; ");
                }
                Console.WriteLine();
            }
            List<int> people = new List<int>(n);
            for (int i = 1; i <= n; i++)
            {
                people.Add(i);
            }
            int count = people.Count;

            Console.WriteLine($"Generated circle consisted of {count} people.");
            Console.WriteLine($"In each round a person with number {num} is about to be deleted.");
            Console.WriteLine();
            int round = 1;
            int check = 1;

            while (people.Count > num - 1)
            {
                for (int i = 0; i < count; i++)
                {
                    if (check % num == 0)
                    {
                        people.RemoveAt(i);
                        count--;
                        i--;
                        Console.WriteLine($"Round {round++}. A person deleted. People remain: {people.Count}");
                        DisplayList(people);
                        Console.WriteLine();
                    }
                    check++;
                }
                
            }
            Console.WriteLine("Game over. Unable to delete more people.");
            return;
            //Console.ReadLine();
        }
    }
}
