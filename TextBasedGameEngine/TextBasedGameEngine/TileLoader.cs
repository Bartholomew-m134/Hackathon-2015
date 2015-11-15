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
                    List<IEnemy> enemies = CreateNewEnemies(tileInfo[tileInfo.Length - 1]);
                    ITile tile = null;

                    if (tileInfo[0].Equals("SampleTile"))
                    {
                        tile = new SampleTile();
                    }
                    else if (tileInfo[0].Equals("GrasslandGoblinTile"))
                    {
                        tile = new GrasslandGoblinTile();
                    }
                    else if (tileInfo[0].Equals("g"))
                    {
                        tile = new GrasslandTile(enemies);
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

            for (int i = 0; i < enemyString.Length; i++)
            {
                if(enemyString[i].Equals('G'))
                {
                    enemyList.Add(new Goblin());
                }
                else if (enemyString[i].Equals('C'))
                {
                    enemyList.Add(new Chicken());
                }
                else if (enemyString[i].Equals('W'))
                {
                    enemyList.Add(new Wyvern());
                }
            }

            return enemyList;
        }
    }
}
