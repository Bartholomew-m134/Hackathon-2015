using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class AngryWizard : IEnemy
    {
        private const string NAME = "Centaur";
        private int power = 30;
        private int health = 100;
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
            Writer.WriteLine("Enemy damages player for " + damage + ", and applies a status for -10");
        }


        public void Loot(IPlayer player)
        {
            Writer.WriteLine("Player loots a Magical Mail with a defense of 25.");
            if (25 > player.Armor)
            {
                Writer.WriteLine("Player equips the Magical Mail.");
                player.Armor = 25;
            }
            player.Gold += 7;
            Writer.WriteLine("\n");
        }
    }
}
