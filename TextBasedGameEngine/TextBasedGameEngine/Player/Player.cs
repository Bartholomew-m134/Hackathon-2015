using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine.Player
{
    public class Player : IPlayer
    {
        private Location playerLocation;
        private int health;

        public Player()
        {
            playerLocation.X = 0;
            playerLocation.Y = 0;
            health = 3;
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Location Position
        {
            get { return playerLocation; }
            set { playerLocation = value; }
        }
    }
}
