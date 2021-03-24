using System;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Shape is a base class. Other figures inherits it.
    /// </summary>
    public class Shape
    {
        private double _x;
        private double _y;
        private string _name;

        public Shape(double x, double y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public double X { get => _x; }
        public double Y { get => _y; }
        public string Name { get => _name; }

        //Virtual method to show the info about the figure.
        //Can be redefined for concrete figure.
        public virtual void Show()
        {
            Console.WriteLine($"Figure is: {Name};");
            Console.WriteLine($"Pair of coordinates: ({ X}, { Y})");
        }
    }
}
