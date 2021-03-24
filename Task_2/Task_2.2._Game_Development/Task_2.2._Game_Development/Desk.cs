using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._Game_Development
{
    class Desk
    {
        private List<IEnemy> Enemy;
        private List<IObstacle> Obstacle;

        public int height = 30;
        public int width = 40;

        public Desk()
        {
            //Area of the desk is 30x40. Obstacles and bonuses randomly spawn on the desk.
            //There is 1 enemy of each type.
            //Character and enemies spawn in the corners of the desk.
        }

        public void Move()
        {
            //Character goes first. Then enemies go. If the enemy is in the filed of vision of the Character,
            //Character can attack enemy, but then he can`t move.
            //If enemy is attacked by Character, it can not attack him.
            //After each step there is check if the Character is still alive.
        }

    }
}
