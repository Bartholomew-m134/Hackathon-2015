using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;

namespace TextBasedGameEngine.Tiles
{
    public static class TileController
    {
        private static IPlayer player = new PlayerCharacter();
        private static ITile tile = new SampleTile();

        public static void Attack()
        {
            tile.Attack(player);
        }

        public static void Shop()
        {
            tile.Shop(player);
        }

        public static  void Look()
        {
            tile.Look(player);
        }

        public static void MoveNorth()
        {
            //Fill in later.
        }

        public static void MoveSouth()
        {
            //Fill in later.
        }

        public static void MoveWest()
        {
            //Fill in later.
        }

        public static void MoveEast()
        {
            //Fill in later.
        }
    }
}
