using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    ITile tile = null;

                    if (tileList[i][j].Equals("SampleTile"))
                    {
                        tile = new SampleTile();
                    }
                    else if (tileList[i][j].Equals("GrasslandGoblinTile"))
                    {
                        tile = new GrasslandGoblinTile();
                    }
                    if(tile != null)
                        tiles.Add(new KeyValuePair<int,int>(j+1,i+1), tile);

                }
            }

            return tiles;
        }
    }
}
