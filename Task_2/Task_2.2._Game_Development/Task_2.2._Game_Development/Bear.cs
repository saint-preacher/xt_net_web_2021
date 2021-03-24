using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._Game_Development
{
    class Bear : IEnemy
    {
        public int hp; //Health Points
        public int attack; //Damage
        public int vision; // Radius of vision
        public void Move()
        {
            Console.WriteLine("Bear is moving on 1 cell only on right" +
                              "or left if it`s not on the edge of the desk" +
                              "Bear has 3 hp. If dies drop skin which gives +3 to armor");
        }
    }
}
