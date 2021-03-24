using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    class Program
    {
        static void CustomString()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("You chose Task 2.1.1");
            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("Type '1' to compare two strings;");
                Console.WriteLine("Type '2' to concat two strings;");
                Console.WriteLine("Type '3' to search char or string;");
                Console.WriteLine("Type '4' to use to get element from char array by index;");
                Console.WriteLine("Type 'exit' to go back to main menu.");
                Console.Write("Choose option: ");
                string selection = Console.ReadLine();
                Console.WriteLine("------------------------------------------");

                switch (selection)
                {
                    case "1":
                        {
                            Console.WriteLine("Here you can compare 2 strings");
                            Console.Write("Input string 1: ");
                            CustomString str1 = new CustomString(Console.ReadLine());
                            Console.Write("Input string 2: ");
                            CustomString str2 = new CustomString(Console.ReadLine());
                            int temp = str1.CompareTo(str2);
                            Console.WriteLine(temp == 1 ? "String 1 is greater than string 2"
                                : temp == 0 ? "String 1 is equal to string 2"
                                : "String 1 is less than string 2");
                            Console.WriteLine("------------------------------------------");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Here you can concat 2 strings");
                            Console.Write("Input string 1: ");
                            CustomString str1 = new CustomString(Console.ReadLine());
                            Console.Write("Input string 2: ");
                            CustomString str2 = new CustomString(Console.ReadLine());
                            str1.Concat(str2);
                            Console.WriteLine($"Concated string is: " + Environment.NewLine + str1.ToString());
                            Console.WriteLine("------------------------------------------");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Here you can search substring in string");
                            Console.Write("Input string: ");
                            CustomString str1 = new CustomString(Console.ReadLine());
                            Console.Write("Input substring: ");
                            CustomString str2 = new CustomString(Console.ReadLine());
                            int index = str1.Search(str2.ToString());
                            Console.WriteLine(index == -1 ? "String doesnt contain substring"
                                : $"Start index of the substring is: {index}");
                            Console.WriteLine("------------------------------------------");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Here you can search char by index");
                            Console.Write("Input string: ");
                            CustomString str1 = new CustomString(Console.ReadLine());
                            int index;
                            Console.Write("Enter index value: ");
                            while (!int.TryParse(Console.ReadLine(), out index))
                            {
                                Console.Write("Enter index value:");
                            }
                            Console.WriteLine($"Char with given index is: {str1[index]}");
                            Console.WriteLine("------------------------------------------");
                            break;
                        }
                    case "exit":
                        Console.WriteLine("Returning to the main menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }
            }
        }
        static void CustomPaint()
        {
            Console.WriteLine("------------------------------------------");
            Session session = new Session();
            Console.WriteLine("You chose Task 2.1.2");
            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("Type '1' to add figure;");
                Console.WriteLine("Type '2' to show all of the figures;");
                Console.WriteLine("Type '3' to clear all figures.");
                Console.WriteLine("Type 'exit' to go back to main menu.");
                Console.Write("Choose option: ");
                string selection = Console.ReadLine();
                Console.WriteLine("------------------------------------------");

                switch (selection)
                {
                    case "1":
                        {
                            Console.WriteLine("Here you can add some figures.");
                            Console.WriteLine("Range of figures:");
                            Console.WriteLine("Type '1' to create Point;");
                            Console.WriteLine("Type '2' to create Line;");
                            Console.WriteLine("Type '3' to create Circle;");
                            Console.WriteLine("Type '4' to create Disc;");
                            Console.WriteLine("Type '5' to create Ring;");
                            Console.WriteLine("Type '6' to create Triangle;");
                            Console.WriteLine("Type '7' to create Quadrangle;");
                            Console.WriteLine("Type '8' to create Rectangle;");
                            Console.Write("Select type of the figure: ");
                            string choice = Console.ReadLine();
                            Console.WriteLine("------------------------------------------");

                            switch (choice)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Point.");
                                        Console.WriteLine("Set a pair of coordinates (x, y) and name for figure");
                                        double x, y;
                                        do
                                        {
                                            Console.Write("Enter x value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x));
                                        do
                                        {
                                            Console.Write("Enter y value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y));
                                        Console.Write("Call your Point: ");
                                        Point point = new Point(x, y, Console.ReadLine());
                                        Console.WriteLine("The Point successfully created.");
                                        point.Show();
                                        session.AddShape(point);
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Line.");
                                        Console.WriteLine("Set pair two of coordinates (x1, y1), (x2, y2) and name for figure");
                                        double x1, y1, x2, y2;
                                        do
                                        {
                                            Console.Write("Enter x1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x1));

                                        do
                                        {
                                            Console.Write("Enter x2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x2));
                                        do
                                        {
                                            Console.Write("Enter y1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y1));
                                        do
                                        {
                                            Console.Write("Enter y2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y2));

                                        Console.Write("Call your Line: ");
                                        Line line = new Line(x1, y1, x2, y2, Console.ReadLine());
                                        Console.WriteLine("The Line successfully created.");
                                        line.Show();
                                        session.AddShape(line);
                                        break;
                                    }
                                case "3":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Circle.");
                                        Console.WriteLine("Set a pair of coordinates (x, y), radius R and name for figure");
                                        double x, y, r;
                                        do
                                        {
                                            Console.Write("Enter x value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x));
                                        do
                                        {
                                            Console.Write("Enter y value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y));
                                        do
                                        {
                                            Console.Write("Enter r value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out r));
                                        Console.Write("Call your Circle: ");
                                        Circle circle = new Circle(x, y, r, Console.ReadLine());
                                        Console.WriteLine("The Circle successfully created.");
                                        circle.Show();
                                        session.AddShape(circle);
                                        break;
                                    }
                                case "4":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Disc.");
                                        Console.WriteLine("Set a pair of coordinates (x, y), radius R and name for figure");
                                        double x, y, r;
                                        do
                                        {
                                            Console.Write("Enter x value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x));
                                        do
                                        {
                                            Console.Write("Enter y value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y));
                                        do
                                        {
                                            Console.Write("Enter r value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out r));
                                        Console.Write("Call your Disc: ");
                                        Disc disc = new Disc(x, y, r, Console.ReadLine());
                                        Console.WriteLine("The Disc successfully created.");
                                        disc.Show();
                                        session.AddShape(disc);
                                        break;
                                    }
                                case "5":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Circle.");
                                        Console.WriteLine("Set a pair of coordinates (x, y), radiuses R1, R2 and name for figure");
                                        double x, y, r1, r2;
                                        do
                                        {
                                            Console.Write("Enter x value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x));
                                        do
                                        {
                                            Console.Write("Enter y value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y));
                                        do
                                        {
                                            Console.Write("Enter r1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out r1));
                                        do
                                        {
                                            Console.Write("Enter r2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out r2));
                                        Console.Write("Call your Ring: ");
                                        Ring ring = new Ring(x, y, r1, r2, Console.ReadLine());
                                        Console.WriteLine("The Ring successfully created.");
                                        ring.Show();
                                        session.AddShape(ring);
                                        break;
                                    }
                                case "6":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Triangle.");
                                        Console.WriteLine("Set three pairs of coordinates (x1, y1), (x2, y2), (x3, y3) and name for figure");
                                        double x1, y1, x2, y2, x3, y3;
                                        do
                                        {
                                            Console.Write("Enter x1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x1));

                                        do
                                        {
                                            Console.Write("Enter x2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x2));
                                        do
                                        {
                                            Console.Write("Enter x3 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x3));
                                        do
                                        {
                                            Console.Write("Enter y1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y1));
                                        do
                                        {
                                            Console.Write("Enter y2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y2));
                                        do
                                        {
                                            Console.Write("Enter y3 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y3));

                                        Console.Write("Call your Triangle: ");
                                        Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3, Console.ReadLine());
                                        Console.WriteLine("The Triangle successfully created.");
                                        triangle.Show();
                                        session.AddShape(triangle);
                                        break;
                                    }
                                case "7":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Quadrangle.");
                                        Console.WriteLine("Set four pairs of coordinates (x1, y1), (x2, y2), (x3, y3), (x4, y4) and name for figure");
                                        double x1, y1, x2, y2, x3, y3, x4, y4;
                                        Console.WriteLine();
                                        do
                                        {
                                            Console.Write("Enter x1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x1));

                                        do
                                        {
                                            Console.Write("Enter x2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x2));
                                        do
                                        {
                                            Console.Write("Enter x3 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x3));
                                        do
                                        {
                                            Console.Write("Enter x4 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x4));
                                        do
                                        {
                                            Console.Write("Enter y1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y1));
                                        do
                                        {
                                            Console.Write("Enter y2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y2));
                                        do
                                        {
                                            Console.Write("Enter y3 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y3));
                                        do
                                        {
                                            Console.Write("Enter y4 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y4));

                                        Console.Write("Call your Quadrangle: ");
                                        Quadrangle quadrangle = new Quadrangle(x1, y1, x2, y2, x3, y3, x4, y4, Console.ReadLine());
                                        Console.WriteLine("The Quadrangle successfully created.");
                                        quadrangle.Show();
                                        session.AddShape(quadrangle);
                                        break;
                                    }
                                case "8":
                                    {
                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("You chose figure type Rectangle.");
                                        Console.WriteLine("Set two pairs of coordinates min (x, y), max (x, y) and name for figure");
                                        double x1, y1, x2, y2;
                                        do
                                        {
                                            Console.Write("Enter x1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x1));

                                        do
                                        {
                                            Console.Write("Enter x2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out x2));
                                        do
                                        {
                                            Console.Write("Enter y1 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y1));
                                        do
                                        {
                                            Console.Write("Enter y2 value: ");
                                        } while (!double.TryParse(Console.ReadLine(), out y2));

                                        Console.Write("Call your Rectangle: ");
                                        Rectangle rectangle = new Rectangle(x1, y1, x2, y2, Console.ReadLine());
                                        Console.WriteLine("The Rectangle successfully created.");
                                        rectangle.Show();
                                        session.AddShape(rectangle);
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Invalid Command!");
                                    break;

                            }
                            Console.WriteLine("------------------------------------------");
                            break;
                        }
                    case "2":
                        {
                            session.OutputShapes();
                            Console.WriteLine("------------------------------------------");
                            break;
                        }
                    case "3":
                        {
                            session.ExcludeShapes();
                            Console.WriteLine("------------------------------------------");
                            break;
                        }
                    case "exit":
                        Console.WriteLine("Returning to the main menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("Navigation: type 'exit' if you want to stop the execution");
                Console.Write("Type from '1' to '2' to pick the task to execute: ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        CustomString();
                        break;
                    case "2":
                        CustomPaint();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }
            }
        }
    }
}
