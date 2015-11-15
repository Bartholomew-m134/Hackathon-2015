using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Enemy
{
    public class Wyvern : IEnemy
    {
        private int power = 40;
        private int health = 120;
        private bool isHitWithMagic = false;
        private bool isHostile = true;

        public int AttackPower
        {
            get { return power; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }


        public bool Hostile
        {
            get { return isHostile; }
        }

        public bool HitWithMagic
        {
            get { return isHitWithMagic; }
            set { isHitWithMagic = value; }
        }


        public void HandleMagicBurn()
        {
            if (isHitWithMagic)
            {
                health -= 5;
            }
        }
    }
}
