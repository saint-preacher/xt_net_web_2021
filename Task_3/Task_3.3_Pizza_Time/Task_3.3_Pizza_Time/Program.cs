using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_3._3_Pizza_Time
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Type '1' to choose Task 3.3.1 \"Super Array\";");
                Console.WriteLine("Type '2' to choose Task 3.3.2 \"Super String\";");
                Console.WriteLine("Type '3' to choose Task 3.3.3 \"Pizza Time\";");
                Console.WriteLine("Type 'exit' to go back to main menu.");
                Console.Write("Choose option: ");
                string selection = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                switch (selection)
                {
                    case "1":
                        {
                            Console.WriteLine("You chose Task 3.3.1 \"Super Array\"");
                            int[] numbers = { 1, 5, 8, 9, 52, 34, 34, 34, 34 };

                            double[] numbers1 = { 5.45, 7.62, 9.19, 12.7, 5.56, 5.56, 5.56, 5.56 };


                            Func<int, int> delegate1 = new Func<int, int>(SuperArray.SquareInt);

                            Func<double, double> delegate2 = new Func<double, double>(SuperArray.SquareDouble);

                            Console.WriteLine("Unmodified int array:");
                            foreach (var i in numbers)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine(Environment.NewLine);
                            Console.WriteLine("Unmodified double array:");
                            foreach (double d in numbers1)
                            {
                                Console.Write(d + " ");
                            }
                            Console.WriteLine(Environment.NewLine);
                            Console.WriteLine("--------------------");

                            Console.WriteLine("Calling \"Sum\" method for int and double arrays:" + Environment.NewLine);

                            Console.WriteLine($"Sum of elements of int array is: {SuperArray.Sum(numbers)}" + Environment.NewLine);
                            Console.WriteLine($"Sum of elements of double array is:{SuperArray.Sum(numbers1)}" + Environment.NewLine);

                            Console.WriteLine("--------------------");
                            Console.WriteLine("Calling \"Average\" method for int and double arrays " + Environment.NewLine
                                + "to find average value of the array: " + Environment.NewLine);

                            Console.WriteLine($"The average value of int array is: {SuperArray.Average(numbers)}" + Environment.NewLine);
                            Console.WriteLine($"The average value of double arrau is: {SuperArray.Average(numbers1)}" + Environment.NewLine);

                            Console.WriteLine("--------------------");

                            Console.WriteLine("Calling \"Count\" method for int and double arrays " + Environment.NewLine
                                + "to find the most frequently used element:" + Environment.NewLine);

                            Console.WriteLine($"The most frequently used element of int array is: {SuperArray.Count(numbers)}" + Environment.NewLine);
                            Console.WriteLine($"The most frequently used element of double array is: {SuperArray.Count(numbers1)}" + Environment.NewLine);

                            Console.WriteLine("--------------------");

                            //Updating int and double arrays, where each element multiplies by itself using delegate
                            SuperArray.UpdateArray(numbers, delegate1);

                            SuperArray.UpdateArray(numbers1, delegate2);

                            Console.WriteLine($"Int elements powered by 2");
                            foreach (var i in numbers)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("--------------------");
                            Console.WriteLine("Double elements powered by 2");
                            foreach (var i in numbers1)
                            {
                                Console.WriteLine(i);
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You chose task 3.3.2 \"Super String\"" + Environment.NewLine);
                            SuperString.StringDisplay();
                            break;
                        }
                    case "3":
                        {
                            Console.Write("You chose task 3.3.3 \"Pizza Time\"" + Environment.NewLine);
                            Console.WriteLine("Input your name, pizza and its size:");
                            Console.Write("Name: ");
                            var name = Console.ReadLine();
                            Console.Write("Name of pizza: ");
                            var pizzaType = Console.ReadLine();
                            Console.Write("Size: ");
                            var size = Console.ReadLine();
                            //Get clients` name for order notification
                            var client = new Client { Name = name };
                            //Setting input parameters for the order
                            var pizza = new Pizza { Name = pizzaType, Price = pizzaType.Length * size.Length * 10 };

                            var restoraunt = new Restaurant();

                            restoraunt.Creation += (client, pizza) => Console.WriteLine($"{pizza.Name} for {pizza.Price} is ready. {client.Name}, please, take your order.");

                            restoraunt.OrderMaking(client, pizza);

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
