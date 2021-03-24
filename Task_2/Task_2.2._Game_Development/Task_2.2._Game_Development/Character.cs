using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._2._Game_Development
{
    class Character
    {
        public Character()
        {
            hp = 10;
            attack = 1;
            vision = 2;
        }

        public int hp; //Health Points
        public int attack; //Damage
        public int vision; // Radius of vision

        public void BonusUp(Bonus bonus)
        {
            if (bonus.Name == "Apple")
            {
                hp += bonus.Restore;
            }
            else if (bonus.Name == "Cherry")
            {
                vision += bonus.Vision;
            }
            else
            {
                attack += bonus.Attack;
            }
        }

        public void Show()
        {
            Console.WriteLine("Character has damage, vision, armor");
            Console.WriteLine("Character can move on 1 cell on the right or on the left" +
                              "if it`s not on the edge of the desk");
        }
    }
}
