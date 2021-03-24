using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._Game_Development
{
    class Tiger : IEnemy
    {
        public int hp; //Health Points
        public int attack; //Damage
        public int vision; // Radius of vision
        public void Move()
        {
            Console.WriteLine("Tiger is moving from 1 to 2 cells on diagonal " +
                              "if it`s not on the edge of the desk" +
                              "Tiger has 1 hp. If dies drop skin which gives +1 to armor");
        }

    }
}
