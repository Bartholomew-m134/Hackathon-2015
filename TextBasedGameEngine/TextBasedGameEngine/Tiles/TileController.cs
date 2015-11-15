using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine.Tiles
{
    public static class TileController
    {
        private static IPlayer storedPlayer;
        private static ITile tile;
        private static Dictionary<KeyValuePair<int,int>, ITile> tileList;


        public static void Load()
        {
            tileList = TileLoader.Load("Tiles");
            storedPlayer = new PlayerCharacter();
            tile = tileList[new KeyValuePair<int,int>(1,1)];
        }

        public static void MoveNorth(IPlayer player)
        {
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X, player.Position.Y - 1)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.Y - 1)];
                player.Position.Y--;
                storedPlayer = player;
            }
        }

        public static void MoveSouth(IPlayer player)
        {
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X, player.Position.Y + 1)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.Y + 1)];
                player.Position.Y++;
                storedPlayer = player;
            }
        }

        public static void MoveWest(IPlayer player)
        {
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X, player.Position.X - 1)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.X - 1)];
                player.Position.X--;
                storedPlayer = player;
            }
        }

        public static void MoveEast(IPlayer player)
        {
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X, player.Position.X + 1)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.X + 1)];
                player.Position.X += 1;
                storedPlayer = player;
            }
        }

        public static void Attack()
        {
            tile.Attack(storedPlayer);
        }

        public static void Shop()
        {
            tile.Shop(storedPlayer);
        }

        public static  void Look()
        {
            tile.Look(storedPlayer);
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
