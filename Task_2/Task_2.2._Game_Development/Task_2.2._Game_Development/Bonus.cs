using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._Game_Development
{
    public abstract class Bonus
    {
        public virtual string Name { get; }
        public virtual int Restore { get; }
        public virtual int Attack { get; }
        public virtual int Vision { get; }

    }
}
