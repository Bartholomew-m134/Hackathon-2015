using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class Chicken : IEnemy
    {
        private int power = 2;
        private int health = 6;
        private bool isHitWithMagic = false;
        private bool isHostile = false;

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
