using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class Goblin : IEnemy
    {
        private int power = 10;
        private int health = 40;
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
                health -= 2;
            }
        }

        public void Attack(IPlayer player)
        {
            player.Health -= power;
        }
    }
}
