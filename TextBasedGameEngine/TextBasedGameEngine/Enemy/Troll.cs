using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class Troll : IEnemy
    {
        private const string NAME = "Troll";
        private int power = 25;
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
                health -= 5;
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
            Writer.WriteLine("Player loots a Stone Club with a damage of " + power);
            if (power > player.WeaponPower)
            {
                Writer.WriteLine("Player equips the Stone Club.");
                player.WeaponPower = power;
                player.Magic = (power * 4) / 5;
            }
            player.Gold += 4;
            Writer.WriteLine("\n");
        }
    }
}
