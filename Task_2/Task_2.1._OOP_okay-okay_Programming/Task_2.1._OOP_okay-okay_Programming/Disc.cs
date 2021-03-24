using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Disc allows user to create a Disc with a pair of coordinates (x, y) and radius r;
    /// Added method of counting area of the disk.
    /// </summary>
    public class Disc : Circle
    {
        public Disc(double x, double y, double radius, string name) : base(x, y, radius, name)
        {
        }

        public double Area => Math.PI * Radius * Radius;

        public override void Show()
        {
            Console.WriteLine($"Figure is: {Name}");
            Console.WriteLine($"Center of the {Name} is in: ({X},{Y})");
            Console.WriteLine($"Radius of the {Name} is: {Radius}");
            Console.WriteLine($"Length of the {Name} is: {Length}");
            Console.WriteLine($"Area of the {Name} is: {Area}");
        }
    }
}
