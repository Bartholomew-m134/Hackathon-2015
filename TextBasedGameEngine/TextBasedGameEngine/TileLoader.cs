using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;
using TextBasedGameEngine.Tiles;

namespace TextBasedGameEngine
{
    public static class TileLoader
    {
        public static ITile MoveNorth(IPlayer player, ITile tile)
        {
            int nextYPosition = player.Position.Y - 1;
            ITile nextTile = tile;
            return nextTile;
        }

        public static ITile MoveSouth(IPlayer player, ITile tile)
        {
            int nextYPosition = player.Position.Y + 1;
            ITile nextTile = tile;
            return nextTile;
        }

        public static ITile MoveWest(IPlayer player, ITile tile)
        {
            int nextXPosition = player.Position.X - 1;
            ITile nextTile = tile;
            return nextTile;
        }

        public static ITile MoveEast(IPlayer player, ITile tile)
        {
            int nextXPosition = player.Position.X + 1;
            ITile nextTile = tile;
            return nextTile;
        }
    }
}
