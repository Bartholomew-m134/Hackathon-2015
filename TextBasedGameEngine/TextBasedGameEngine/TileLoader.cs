using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Enemy;
using TextBasedGameEngine.Interfaces;
using TextBasedGameEngine.Tiles;
using TextBasedGameEngine.Utilities;
using TextBasedGameEngine.Utilities.Constants;

namespace TextBasedGameEngine
{
    public static class TileLoader
    {
        public static Dictionary<KeyValuePair<int,int>, ITile> Load(string filename)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "\\Content\\" + filename + ".csv";
            List<string[]> tileList = ParseFile(GetFileContents(directory));
            return CreateNewTiles(tileList);
        }

        private static List<string[]> ParseFile(List<string> fileContents)
        {
            List<string[]> parsedObjects = new List<string[]>();

            foreach (string line in fileContents)
                parsedObjects.Add(line.Split(','));

            return parsedObjects;
        }

        private static List<string> GetFileContents(string directory)
        {
            List<string> fileContents = new List<string>();
            StreamReader reader = new StreamReader(directory);

            try
            {
                do
                    fileContents.Add(reader.ReadLine());
                while (reader.Peek() != -1);
            }
            catch
            {
                Console.WriteLine("File Was Not Loaded\n");
            }
            finally
            {
                reader.Close();
            }

            return fileContents;
        }

        private static Dictionary<KeyValuePair<int,int>, ITile> CreateNewTiles(List<string[]> tileList)
        {
            Dictionary<KeyValuePair<int,int>, ITile> tiles = new Dictionary<KeyValuePair<int,int>,ITile>();

            for (int i = 0; i < tileList.Count - 1; i++ )
            {
                for (int j = 0; j < tileList[i].Length - 1; j++)
                {
                    string[] tileInfo = tileList[i][j].Split('-');
                    List<IEnemy> enemies = new List<IEnemy>();
                    List<IItem> storeItems = new List<IItem>();
                    ITile tile = null;

                    if(tileInfo.Length > 1)
                        enemies = CreateNewEnemies(tileInfo[1]);
                    if (tileInfo.Length > 2)
                        storeItems = CreateNewStoreItems(tileInfo[2]);

                    if (tileInfo[0].Equals("b"))
                    {
                        tile = new Tile(TileLookConstants.BEACH, enemies, storeItems);
                    }
                    else if (tileInfo[0].Equals("c"))
                    {
                        tile = new Tile(TileLookConstants.CLIFF, enemies, storeItems);
                    }
                    else if (tileInfo[0].Equals("g"))
                    {
                        tile = new Tile(TileLookConstants.GRASSLAND, enemies, storeItems);
                    }
                    else if (tileInfo[0].Equals("h"))
                    {
                        tile = new Tile(TileLookConstants.HILLS, enemies, storeItems);
                    }
                    else if (tileInfo[0].Equals("v"))
                    {
                        tile = new Tile(TileLookConstants.VOLCANO, enemies, storeItems);
                    }
                    else if (tileInfo[0].Equals("t"))
                    {
                        tile = new Tile(TileLookConstants.TOWN, enemies, storeItems);
                    }


                    if(tile != null)
                        tiles.Add(new KeyValuePair<int,int>(j+1,i+1), tile);
                }
            }

            return tiles;
        }

        private static List<IEnemy> CreateNewEnemies(string enemyString)
        {
            List<IEnemy> enemyList = new List<IEnemy>();
            string[] enemies = enemyString.Split(';');

            for (int i = 0; i < enemies.Length; i++)
            {
                if(enemies[i].Equals("G"))
                {
                    enemyList.Add(new Goblin());
                }
                else if (enemies[i].Equals("Ch"))
                {
                    enemyList.Add(new Chicken());
                }
                else if (enemies[i].Equals("Wy"))
                {
                    enemyList.Add(new Wyvern());
                }
                else if (enemies[i].Equals("Ce"))
                {
                    enemyList.Add(new Centaur());
                }
                else if (enemies[i].Equals("Tr"))
                {
                    enemyList.Add(new Troll());
                }
                else if (enemies[i].Equals("Gc"))
                {
                    enemyList.Add(new GiantCrab());
                }
                else if (enemies[i].Equals("Al"))
                {
                    enemyList.Add(new ArmoredLizard());
                }
                else if (enemies[i].Equals("Dr"))
                {
                    enemyList.Add(new Dragon());
                }
                else if (enemies[i].Equals("D"))
                {
                    enemyList.Add(new Demon());
                }
                else if (enemies[i].Equals("Aw"))
                {
                    enemyList.Add(new AngryWizard());
                }

            }

            return enemyList;
        }

        private static List<IItem> CreateNewStoreItems(string itemsString)
        {
            List<IItem> storeItemList = new List<IItem>();

            for (int i = 0; i < itemsString.Length; i++)
            {
                if (itemsString[i].Equals('G'))
                {
                    //storeItemList.Add(new Goblin());
                }
                else if (itemsString[i].Equals('C'))
                {
                   //storeItemList.Add(new Chicken());
                }
                else if (itemsString[i].Equals('W'))
                {
                    //storeItemList.Add(new Wyvern());
                }
            }

            return storeItemList;
        }
    }
}
