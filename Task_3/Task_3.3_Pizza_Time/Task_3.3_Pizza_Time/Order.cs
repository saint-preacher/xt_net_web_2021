using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3_Pizza_Time
{
    class Order
    {
        public int Number { get; set; }
        public Pizza Pizza { get; set; }
        public Order(Pizza _pizza)
        {
            Pizza = _pizza;
        }
    }
}
