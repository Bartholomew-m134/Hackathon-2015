using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class Dragon : IEnemy
    {
        private const string NAME = "Dragon";
        private int power = 50;
        private int health = 200;
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
            player.HasStatusEffect = true;
            player.StatusEffectModifier = -5;
            Writer.WriteLine("Enemy damages player for " + damage + ", and applies a status for -5");
        }


        public void Loot(IPlayer player)
        {
            Writer.WriteLine("Player loots a Dragon Great Axe with a damage of " + power);
            Writer.WriteLine("Player loots a Dragon Plate Mail with a defense of " + 40);
            if (power > player.WeaponPower)
            {
                Writer.WriteLine("Player equips the Dragon Great Axe.");
                player.WeaponPower = power;
                player.Magic = (power * 4) / 5;
            }
            if (40 > player.Armor)
            {
                Writer.WriteLine("Player equips the Dragon Plate Mail.");
                player.Armor = 40;
            }
            Writer.WriteLine("\n");
        }
    }
}
