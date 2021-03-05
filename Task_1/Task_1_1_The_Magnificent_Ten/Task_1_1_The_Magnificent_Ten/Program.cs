using System;
using System.Numerics;
using System.Runtime.Serialization.Formatters;

namespace Task_1_1_The_Magnificent_Ten
{
    class Program
    {

        [Flags]
        public enum TypesOfTextAdjustment //Enum with flags in order to combine adjustments
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }

        public enum Commands //Enum to select the adjustment or exit
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 3,
            Exit = 4
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Navigation: type 'exit' if you want to stop the execution");
                Console.Write("Type from '1' to '10' to pick the task to execute: ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Rectangle();
                        break;
                    case "2":
                        Triangle();
                        break;
                    case "3":
                        Another_Triangle();
                        break;
                    case "4":
                        Xmas_Tree();
                        break;
                    case "5":
                        Sum_of_Numbers();
                        break;
                    case "6":
                        Font_Adjustment();
                        break;
                    case "7":
                        Array_Processing();
                        break;
                    case "8":
                        No_Positive();
                        break;
                    case "9":
                        Non_Negative_Sum();
                        break;
                    case "10":
                        Double_Dimension_Arr();
                        break;
                    case "exit":
                        return;
                    default:                                    //Default case: if input doesn`t belong to command list,
                        Console.WriteLine("Invalid Command!");  //user will be needed to enter correct number of command 
                        break;
                }
            }
        }

        static void Rectangle()
        {
            Console.WriteLine("You chose task 1.1.1 \"Rectangle\"");
            int a, b;

            Console.Write("Enter a value: ");

            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)  //value check for side a
            {
                Console.Write("Enter a value: ");
            }

            Console.Write("Enter b value: ");

            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0) //value check for side b
            {
                Console.Write("Enter b value: ");
            }

            Console.WriteLine($"Square = {a * b}");
        }

        static void Triangle()
        {
            Console.WriteLine("You chose task 1.1.2 \"Trinagle\"");
            int N;
            string star = "*";
            Console.Write("Enter N value: ");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0) //value check for N
            {
                Console.Write("Enter correct value: ");
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }

        }
        static void Another_Triangle()
        {
            Console.WriteLine("You chose task 1.1.3 \"Another_Triangle\"");
            int N;
            Console.Write("Enter N value: ");

            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0) //value check for N
            {
                Console.Write("Enter correct N value: ");
            }

            //Display Result
            for (int i = 1; i <= N; i++)
            {
                string spaces = new String(' ', N - i);
                string stars = new String('*', i * 2 - 1);
                Console.WriteLine($"{spaces}{stars}");
            }
        }

        static void Xmas_Tree()
        {
            Console.WriteLine("You chose task 1.1.4 \"Xmas_Tree\"");
            int N;
            //Value Check
            Console.WriteLine("Enter N: ");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)  //value check for N
            {
                Console.WriteLine("Enter correct N value: ");
            }

            //Display Result
            for (int j = 1; j <= N; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    string spaces = new String(' ', N - i);
                    string stars = new String('*', i * 2 - 1);
                    Console.WriteLine($"{spaces}{stars}");
                }
            }
        }

        static void Sum_of_Numbers()
        {
            Console.WriteLine("You chose task 1.1.5 \"Sum_of_Numbers\"");
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 15 != 0) && ((i % 3 == 0) || (i % 5 == 0)))
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of Numbers = {sum}");
        }

        static void Font_Adjustment()
        {
            Console.WriteLine("You chose task 1.1.6 \"Font_Adjusment\"");
            TypesOfTextAdjustment type = TypesOfTextAdjustment.None; //Variable to set the adjustment (default is None) 
            Commands command; //Variable to set the command from console
            Console.WriteLine("Types of adjustment:" + Environment.NewLine +
                        "None = '0'" + Environment.NewLine +
                        "Bold = '1'" + Environment.NewLine +
                        "Italic = '2'" + Environment.NewLine +
                        "Underline = '3'" + Environment.NewLine +
                        "Input '4' to exit from Program");
            while (true)
            {
                Console.WriteLine($"Current type is: {type}");
                Console.Write("Choose adjustment: ");
                command = (Commands)Enum.Parse(typeof(Commands), Console.ReadLine()); //Parsing command from console
                Console.WriteLine();
                switch (command)
                {
                    case Commands.None:                                 //Input 0 to cancel all adjustments
                        type &= TypesOfTextAdjustment.None;
                        break;

                    case Commands.Bold:                                 //Input 1 to select or unselect Bold adjustment
                        type ^= TypesOfTextAdjustment.Bold;
                        break;

                    case Commands.Italic:                               //Input 2 to select or unselect Italic adjustment
                        type ^= TypesOfTextAdjustment.Italic;
                        break;

                    case Commands.Underline:                            //Input 3 to select or unselect Underline adjustment
                        type ^= TypesOfTextAdjustment.Underline;
                        break;

                    case Commands.Exit:                                 //Input 4 to exit from program
                        return;

                    default:                                            //Default case: if input doesn`t belong to command list, 
                        Console.WriteLine("Invalid Command!");          //user will be needed to enter correct number of command
                        break;
                }
            }
        }
        static void Array_Processing()
        {
            Console.WriteLine("You chose task 1.1.7 \"Array_Processing\"");
            int t;
            int[] array = new int[15];
            Random r = new Random();
            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-30, 30);             //array fills with random values in range from -30: 30
                Console.Write($"{array[i]}  ");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])                //array sorts with temporary variable
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1} element: {array[i]}  ");
            }

        }

        static void No_Positive()
        {
            Console.WriteLine("You chose task 1.1.8 \"No_Positive\"");
            int[,,] array = new int[8, 8, 8];  // initializing 3D array with 8 elements in each dimension
            Random r = new Random();
            Console.WriteLine("Array: ");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        array[i, j, k] = r.Next(-20, 20); //array fills with random values in range from -20: 20

                        if (array[i, j, k] > 0) //if element of array is positive,
                            array[i, j, k] = 0; //then it turns to 0

                        Console.WriteLine($"{i + 1} element: {array[i, j, k]}");
                    }
                }
            }

        }

        static void Non_Negative_Sum()
        {
            Console.WriteLine("You chose task 1.1.9 \"Non_Negative_Sum\"");
            int[] array = new int[10];
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-20, 20); //array fills with random values in range from -20: 20

                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Sum of non-negative elements = {sum}");
        }

        static void Double_Dimension_Arr()
        {
            Console.WriteLine("You chose task 1.1.10 \"Double_Dimnesion_Arr\"");
            int[,] array = new int[3, 2];
            Random r = new Random();
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = r.Next(-20, 20); //array fills with random values in range from -20: 20
                    Console.WriteLine($"[{i}], [{j}] element: {array[i, j]}");
                    if ((i + j) % 2 == 0) //if the sum of coordinates of the element is even, such element stands on even position
                    {
                        Console.WriteLine($"[{i}], [{j}] element: {array[i, j]} is on even position");
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum of elements on even positions is: {sum}");
        }
    }
}
