using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Player
{
    public class PlayerCharacter : IPlayer
    {
        private Location playerLocation;
        private int health;
        private int maxHealth;
        private int power;
        private int magic;
        private int heal;
        private bool statusEffect;
        private int statusModifier;

        public PlayerCharacter()
        {
            playerLocation = new Location(1, 1);
            health = 100;
            maxHealth = 100;
            power = 20;
            magic = 16;
            heal = 20;
            statusEffect = false;
            statusModifier = 0;
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        public Location Position
        {
            get { return playerLocation; }
            set { playerLocation = value; }
        }


        public int Power
        {
            get { return power; }
        }


        public int Magic
        {
            get { return magic; }
        }


        public bool StatusEffect
        {
            get { return statusEffect; }
            set { statusEffect = value; }
        }


        public int StatusModifier
        {
            set { statusModifier = value; }
        }


        public void HandleStatusEffect()
        {
            health += statusModifier;
        }


        public int Heal
        {
            get { return heal; }
            set { heal = value; }
        }
    }
}
