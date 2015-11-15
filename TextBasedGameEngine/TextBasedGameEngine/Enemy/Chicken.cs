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
        private const string NAME = "Chicken";
        private int power = 2;
        private int health = 6;
        private bool isHitWithMagic = false;

        public int AttackPower
        {
            get { return power; }
        }

        public string Name
        {
            get { return NAME; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public bool HitWithMagic
        {
            get { return isHitWithMagic; }
            set { isHitWithMagic = value; }
        }


        public void HandleMagicBurn()
        {
        }

        public void Attack(IPlayer player)
        {
            int damage = power - player.Armor;
            if(damage > 0)
                player.Health -= power;
            Writer.WriteLine("Enemy damages player for " + damage);
        }
    }
}
