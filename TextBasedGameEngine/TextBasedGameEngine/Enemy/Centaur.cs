using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class Centaur : IEnemy
    {
        private const string NAME = "Centaur";
        private int power = 35;
        private int health = 80;
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
            if (damage > 0)
                player.Health -= damage;
            Writer.WriteLine("Enemy damages player for " + damage);
        }


        public void Loot(IPlayer player)
        {
            Writer.WriteLine("Player loots a Centaur Mail with a defense of 15.");
            if (15 > player.Armor)
            {
                Writer.WriteLine("Player equips the Scale Mail.");
                player.Armor = 15;
            }
            player.Gold += 5;
            Writer.WriteLine("\n");
        }
    }
}
