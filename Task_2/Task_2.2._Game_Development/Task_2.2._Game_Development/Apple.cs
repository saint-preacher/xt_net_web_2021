using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._Game_Development
{
    class Apple : Bonus
    {
        // set the category buff
        public override string Name { get; } = "Apple";

        public override int Restore { get; } = 1;
    }
}
