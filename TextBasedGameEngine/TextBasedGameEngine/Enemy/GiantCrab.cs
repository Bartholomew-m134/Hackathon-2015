using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class GiantCrab : IEnemy
    {
        private const string NAME = "Giant Crab";
        private int power = 15;
        private int health = 30;
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
            player.HasStatusEffect = true;
            player.StatusEffectModifier = -1;
            Writer.WriteLine("Enemy damages player for " + damage + ", and applies a status for -1");
        }


        public void Loot(IPlayer player)
        {
            Writer.WriteLine("Player loots a Crab Claw with a damage of " + power);
            if (power > player.WeaponPower)
            {
                Writer.WriteLine("Player equips the Crab Claw.");
                player.WeaponPower = power;
                player.Magic = (power * 4) / 5;
            }
            player.Gold += 2;
            Writer.WriteLine("\n");
        }
    }
}
