using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Enemy
{
    public class Wyvern : IEnemy
    {
        private const string NAME = "Wyvern";
        private int power = 40;
        private int health = 120;
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
            if(damage > 0)
                player.Health -= damage;
            player.HasStatusEffect = true;
            player.StatusEffectModifier = -5;
            Writer.WriteLine("Enemy damages player for " + damage + ", and applies a status for -5");
        }
    }
}
