using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Rectangle allows user to create a rectangle. It needs only two pairs of coordinates: min (x, y) and max (x,y).
    /// Other pairs of coordinates created by the class functionality.
    /// Overrided method of counting perimeter;
    /// Overrided display method.
    /// </summary>
    public class Rectangle : Line
    {
        public Rectangle(double x1, double y1, double x2, double y2, string name) : base(x1, y1, x2, y2, name)
        {
            Xmin = x1;
            Xmax = x2;

            Ymin = y1;
            Ymax = y2;
        }

        public double Xmin { get; }
        public double Xmax { get; }
        public double Ymin { get; }
        public double Ymax { get; }

        public double X3 => Xmax;
        public double X4 => Xmin;

        public double Y3 => Ymin;
        public double Y4 => Ymax;

        public double sideAB => Math.Sqrt((Y2 - Y) * (Y2 - Y));
        public double sideBC => Math.Sqrt((X2 - X) * (X2 - X));
        public double sideCD => sideAB;
        public double sideDA => sideBC;

        public override double Length => 2 * (Math.Sqrt((Y2 - Y) * (Y2 - Y)) + Math.Sqrt((X2 - X) * (X2 - X)));
        public double Area => (Y2 - Y) * (X2 - X);

        public override void Show()
        {
            Console.WriteLine($"Figure is: {Name}");
            Console.WriteLine($"Pair of coordinates is: ({X}, {Y})");
            Console.WriteLine($"Pair of coordinates is: ({X2}, {Y2})");
            Console.WriteLine($"Pair of coordinates is: ({X3}, {Y3})");
            Console.WriteLine($"Pair of coordinates is: ({X4}, {Y4})");
            Console.WriteLine($"Length of the side AB is: {sideAB}");
            Console.WriteLine($"Length of the side BC is: {sideBC}");
            Console.WriteLine($"Length of the side CD is: {sideCD}");
            Console.WriteLine($"Length of the side DA is: {sideDA}");
            Console.WriteLine($"Perimeter of the {Name} is: {Length}");
            Console.WriteLine($"Area of the {Name} is: {Area}");
        }
    }
}
