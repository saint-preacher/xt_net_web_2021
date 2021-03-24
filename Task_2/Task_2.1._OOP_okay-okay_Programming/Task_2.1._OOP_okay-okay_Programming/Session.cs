using System;
using System.Collections.Generic;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Session is created to manage all functionality required by the task
    /// </summary>
    public class Session
    {
        public List<Shape> Shapes { get; private set; }

        public Session()
        {
            Shapes = new List<Shape>();
        }

        //Adds chosen figure
        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        //Clears all created figures
        public void ExcludeShapes()
        {
            Shapes.Clear();
        }

        //Displays info about all of the created figures
        public void OutputShapes()
        {
            if (Shapes.Count == 0)
            {
                Console.WriteLine("---------");
                Console.WriteLine("No figures to show.");
                Console.WriteLine("---------");
                return;

            }
            foreach (var shape in Shapes)
            {
                Console.WriteLine("---------");
                shape.Show();
                Console.WriteLine("---------");
            }
        }
    }
}
