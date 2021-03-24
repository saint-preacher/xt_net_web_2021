using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._Game_Development
{
    class Wolf : IEnemy
    {
        public int hp; //Health Points
        public int attack; //Damage
        public int vision; // Radius of vision
        public void Move()
        {
            Console.WriteLine("Wolf is moving on 2 cells on the right or on the left" +
                              "if it`s not on the edge of the desk" +
                              "Wolf has 2 hp. If dies drop skin which gives +2 to armor");
        }
    }
}
