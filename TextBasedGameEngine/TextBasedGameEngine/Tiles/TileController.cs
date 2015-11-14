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
        private static IPlayer player;
        private static ITile tile;
        private static Dictionary<KeyValuePair<int,int>, ITile> tileList;


        public static void Load()
        {
            tileList = TileLoader.Load("Tiles");
            player = new PlayerCharacter();
            tile = tileList[new KeyValuePair<int,int>(1,1)];
        }

        public static void MoveNorth(IPlayer player)
        {
            if (tileList.ContainsKey(player.Position.ConvertToPair()))
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.Y - 1)];
        }

        public static void MoveSouth(IPlayer player)
        {
            if (tileList.ContainsKey(player.Position.ConvertToPair()))
                tile = tileList[new KeyValuePair<int,int>(player.Position.X, player.Position.Y + 1)];
        }

        public static void MoveWest(IPlayer player)
        {
             if (tileList.ContainsKey(player.Position.ConvertToPair()))
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.X - 1)];
        }

        public static void MoveEast(IPlayer player)
        {
            if (tileList.ContainsKey(player.Position.ConvertToPair()))
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.X + 1)];
        }

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
