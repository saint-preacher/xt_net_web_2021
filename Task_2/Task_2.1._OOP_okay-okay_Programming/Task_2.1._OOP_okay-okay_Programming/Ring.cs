using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Ring allows user to create a ring woth a pair of coordinates (x,y); outer radius R1 and inner radius R2;
    /// Added one more radius variable and changed method of counting area;
    /// Overrided Show method.
    /// </summary>
    public class Ring : Circle
    {
        public Ring(double x, double y, double radius, double radius2, string name) : base(x, y, radius, name)
        {
            Radius2 = radius2;
        }

        public double Radius2 { get; }

        public double Area => Math.Abs(Math.PI * Radius * Radius - Math.PI * Radius2 * Radius2);

        public override void Show()
        {
            Console.WriteLine($"Figure is: {Name}");
            Console.WriteLine($"Center of the {Name} is in: ({X},{Y})");
            Console.WriteLine($"Radius of the {Name} is: {Radius}");
            Console.WriteLine($"Another radius of the {Name} is: {Radius2}");
            Console.WriteLine($"Area of the {Name} is: {Area}");
        }
    }
}
