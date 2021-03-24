using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Quadrangle allows user to create a quadreangle with four pairs of coordinates (x1, y1); (x2, y2); (x3, y3); (x4, y4).
    /// Overrided method of counting perimeter;
    /// Overrided display method.
    /// </summary>
    public class Quadrangle : Line
    {
        public Quadrangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, string name) : base(x1, y1, x2, y2, name)
        {
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }
        public double X3 { get; }
        public double Y3 { get; }
        public double X4 { get; }
        public double Y4 { get; }

        public double sideAB => Math.Sqrt((X2 - X) * (X2 - X) + (Y2 - Y) * (Y2 - Y));

        public double sideBC => Math.Sqrt((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - Y2));

        public double sideCD => Math.Sqrt((X4 - X3) * (X4 - X3) + (Y4 - Y3) * (Y4 - Y3));

        public double sideDA => Math.Sqrt((X - X4) * (X - X4) + (Y - Y4) * (Y - Y4));

        public override double Length => sideAB + sideBC + sideCD + sideDA;

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
        }
    }
}
