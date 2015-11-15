using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class ArmoredLizard : IEnemy
    {
        private const string NAME = "Armored Lizard";
        private int power = 20;
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
            if (isHitWithMagic)
            {
                health -= 3;
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
            Writer.WriteLine("Player loots a Scale Mail with a defense of 10.");
            if (10 > player.Armor)
            {
                Writer.WriteLine("Player equips the Scale Mail.");
                player.Armor = 10;
            }
            Writer.WriteLine("\n");
        }
    }
}
