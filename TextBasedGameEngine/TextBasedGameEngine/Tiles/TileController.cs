using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;
using TextBasedGameEngine.Utilities;
using TextBasedGameEngine.Interfaces;

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

        public static void Battle()
        {
            tile.Battle(player);
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
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X, player.Position.Y - 1)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.Y - 1)];
                player.Position.Y--;
                Look();
            }
            else
                Writer.OutputNotAvailableCommand();
        }

        public static void MoveSouth()
        {
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X, player.Position.Y + 1)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X, player.Position.Y + 1)];
                player.Position.Y++;
                Look();
            }
            else
                Writer.OutputNotAvailableCommand();
        }

        public static void MoveWest()
        {
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X - 1, player.Position.Y)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X - 1, player.Position.Y)];
                player.Position.X--;
                Look();
            }
            else
                Writer.OutputNotAvailableCommand();
        }

        public static void MoveEast()
        {
            if (tileList.ContainsKey(new KeyValuePair<int, int>(player.Position.X + 1, player.Position.Y)))
            {
                tile = tileList[new KeyValuePair<int, int>(player.Position.X + 1, player.Position.Y)];
                player.Position.X++;
                Look();
            }
            else
                Writer.OutputNotAvailableCommand();
        }

        public static void Status()
        {
            Writer.WriteLine("\nHealth: " + player.Health + "/" + player.MaxHealth);
            Writer.WriteLine("Status Modifier: " + player.StatusEffectModifier);
            Writer.WriteLine("Armor: " + player.Armor);
            Writer.WriteLine("Weapon Power: " + player.WeaponPower);
            Writer.WriteLine("Magic Power: " + player.Magic + "\n");
            player.Inventory.PrintInventory();
        }
    }
}
