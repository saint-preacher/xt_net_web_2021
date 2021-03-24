using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Line allows user to create a line with two pairs of coordinates (x1, y1); (x2, y2);
    /// Added method to count length of the line.
    /// </summary>
    public class Line : Point
    {
        public Line(double x1, double y1, double x2, double y2, string name) : base(x1, y1, name)
        {
            X2 = x2;
            Y2 = y2;
        }

        public double X2 { get; }
        public double Y2 { get; }

        public virtual double Length => Math.Sqrt((X2 - X) * (X2 - X) + (Y2 - Y) * (Y2 - Y));

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Pair of coordinates is: ({X2}, {Y2})");
            Console.WriteLine($"Length of the {Name} is: {Length}");
        }
    }
}
