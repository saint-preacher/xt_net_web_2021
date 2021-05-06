using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3._3_Pizza_Time
{
    class Restaurant
    {
        public Action<Client, Pizza> Creation;

        public Order OrderMaking (Client client, Pizza pizza)
        {
            var order = new Order(pizza);

            Creation(client, pizza);

            return order;
        }

    }
}
