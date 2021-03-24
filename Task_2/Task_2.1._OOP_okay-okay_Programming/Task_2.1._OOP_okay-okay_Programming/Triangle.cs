using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Triangle allows user to create a triangle with three pairs of coordinates (x1, y1); (x2, y2); (x3, y3);
    /// Overrided method counting length;
    /// Added method of counting area.
    /// </summary>
    public class Triangle : Line
    {
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3, string name) : base(x1, y1, x2, y2, name)
        {
            X3 = x3;
            Y3 = y3;
        }

        public double X3 { get; }
        public double Y3 { get; }

        public double sideA => Math.Sqrt((X2 - X) * (X2 - X) + (Y2 - Y) * (Y2 - Y));
        public double sideB => Math.Sqrt((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - Y2));
        public double sideC => Math.Sqrt((X - X3) * (X - X3) + (Y - Y3) * (Y - Y3));

        public override double Length => sideA + sideB + sideC;

        public double SemiPerimeter => Length / 2;

        public double Area => Math.Sqrt(SemiPerimeter * (SemiPerimeter - sideA) * (SemiPerimeter - sideB) * (SemiPerimeter - sideC));

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Pair of coordinates is: ({X3}, {Y3})");
            Console.WriteLine($"Side A is: {sideA}");
            Console.WriteLine($"Side B is: {sideB}");
            Console.WriteLine($"Side C is: {sideC}");
            Console.WriteLine($"Perimeter of the {Name} is: {Length}");
            Console.WriteLine($"Semiperimeter of the {Name} is: {SemiPerimeter}");
            Console.WriteLine($"Area of the {Name} is: {Area}");
        }
    }
}
