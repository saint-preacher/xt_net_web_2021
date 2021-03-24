using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Circle allows iser to create a circle with a pair of coordinates (x, y) and radius r; 
    /// Overrided method of counting length.
    /// </summary>
    public class Circle : Shape
    {
        public Circle(double x, double y, double radius, string name) : base(x, y, name)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public double Length => 2 * Math.PI * Radius;

        public override void Show()
        {
            Console.WriteLine($"Figure is: {Name}");
            Console.WriteLine($"Center of the {Name} is in: ({X},{Y})");
            Console.WriteLine($"Radius of the {Name} is: {Radius}");
            Console.WriteLine($"Length of the {Name} is: {Length}");
        }
    }
}
