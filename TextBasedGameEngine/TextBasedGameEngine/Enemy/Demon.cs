using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class Demon : IEnemy
    {
        private const string NAME = "Demon";
        private int power = 90;
        private int health = 500;
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
            player.HasStatusEffect = true;
            player.StatusEffectModifier = -10;
            Writer.WriteLine("Enemy damages player for " + damage + ", and applies a status for -5");
        }


        public void Loot(IPlayer player)
        {
            Writer.WriteLine("Player loots a Hellfire Rapier with a damage of " + power);
            Writer.WriteLine("Player loots a Hellfire Garb with a defense of " + 80);
            if (power > player.WeaponPower)
            {
                Writer.WriteLine("Player equips the Hellfire Rapier.");
                player.WeaponPower = power;
                player.Magic = (power * 4) / 5;
            }
            if (80 > player.Armor)
            {
                Writer.WriteLine("Player equips the Hellfire Garb.");
                player.Armor = 80;
            }
            player.Gold += 25;
            Writer.WriteLine("\n");
        }
    }
}
