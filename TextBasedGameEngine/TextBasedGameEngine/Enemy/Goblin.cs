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
        private const string NAME = "Goblin";
        private int power = 10;
        private int health = 40;
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
            if (isHitWithMagic)
            {
                health -= 2;
            }
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
            Writer.WriteLine("Player loots a Goblin Mail with a defense of 4.");
            if (4 > player.Armor)
            {
                Writer.WriteLine("Player equips the Goblin Mail.");
                player.Armor = 4;
            }
            Writer.WriteLine("\n");
        }
    }
}
