using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine.Player
{
    public class PlayerCharacter : IPlayer
    {
        private Location playerLocation;
        private int health;
        private int maxHealth;
        private int power;
        private int magic;

        public PlayerCharacter()
        {
            playerLocation = new Location(1, 1);
            health = 100;
            maxHealth = 100;
            power = 20;
            magic = 16;
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
    }
}
