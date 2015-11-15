using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;
using TextBasedGameEngine.Utilities;
using TextBasedGameEngine.Interfaces;
using TextBasedGameEngine.Inventory;
using TextBasedGameEngine.Utilities.Constants;

namespace TextBasedGameEngine.Tiles
{
    public static class TileController
    {
        private static IPlayer player;
        private static ITile tile;
        private static Dictionary<KeyValuePair<int,int>, ITile> tileList;
        private static List<KeyValuePair<int, int>> prevVisitedTiles;


        public static void Load()
        {
            prevVisitedTiles = new List<KeyValuePair<int, int>>();
            tileList = TileLoader.Load("Tiles");
            player = new PlayerCharacter();
            tile = tileList[new KeyValuePair<int,int>(1,1)];
        }

        public static void Battle()
        {
            tile.Battle(player);
            tile.Look(player);
        }

        public static void Shop()
        {
            tile.Shop(player);
            tile.Look(player);
        }

        public static  void Look()
        {
            tile.Look(player);
        }

        public static void MoveNorth()
        {
            KeyValuePair<int,int> newLocation = new KeyValuePair<int,int>(player.Position.X, player.Position.Y - 1);

            if (tileList.ContainsKey(newLocation))
            {
                if(!prevVisitedTiles.Contains(player.Position.ConvertToPair()))
                    prevVisitedTiles.Add(player.Position.ConvertToPair());

                tile = tileList[newLocation];
                player.Position.Y--;
                Look();
            }
            else
                Writer.OutputNotAvailableCommand();
        }

        public static void MoveSouth()
        {
            KeyValuePair<int, int> newLocation = new KeyValuePair<int, int>(player.Position.X, player.Position.Y + 1);

            if (tileList.ContainsKey(newLocation))
            {
                if (!prevVisitedTiles.Contains(player.Position.ConvertToPair()))
                    prevVisitedTiles.Add(player.Position.ConvertToPair());

                tile = tileList[newLocation];
                player.Position.Y++;
                Look();
            }
            else
                Writer.OutputNotAvailableCommand();
        }

        public static void MoveWest()
        {
            KeyValuePair<int, int> newLocation = new KeyValuePair<int, int>(player.Position.X - 1, player.Position.Y);

            if (tileList.ContainsKey(newLocation))
            {
                if (!prevVisitedTiles.Contains(player.Position.ConvertToPair()))
                    prevVisitedTiles.Add(player.Position.ConvertToPair());

                tile = tileList[newLocation];
                player.Position.X--;
                Look();
            }
            else
                Writer.OutputNotAvailableCommand();
        }

        public static void MoveEast()
        {
            KeyValuePair<int, int> newLocation = new KeyValuePair<int, int>(player.Position.X + 1, player.Position.Y);

            if (tileList.ContainsKey(newLocation))
            {
                if (!prevVisitedTiles.Contains(player.Position.ConvertToPair()))
                    prevVisitedTiles.Add(player.Position.ConvertToPair());

                tile = tileList[newLocation];
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
            Writer.WriteLine("Magic Power: " + player.Magic);
            player.Inventory.PrintInventory();
            Writer.WriteLine("Gold: " + player.Gold + "\n");
        }

        public static void Inventory()
        {
            player.Inventory.HandleInventory();
            tile.Look(player);
        }

        public static void Map()
        {
            for (int i = 0; i < WorldConstants.WORLD_HEIGHT; i++)
            {
                for (int j = 0; j < WorldConstants.WORLD_WIDTH; j++)
                {
                    if (player.Position.X == j && player.Position.Y == i)
                        Writer.Write("P");
                    else if (prevVisitedTiles.Contains(new KeyValuePair<int, int>(j, i)))
                        Writer.Write("O");
                    else
                        Writer.Write(" ");
                }
                Writer.WriteLine("");
            }
        }
    }
}
