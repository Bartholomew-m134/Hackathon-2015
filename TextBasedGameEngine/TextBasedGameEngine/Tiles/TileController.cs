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
        private IPlayer player = new PlayerCharacter();
        private ITile tile = new SampleTile();
        public void Attack()
        {
            tile.Attack(player);
        }

        public void Shop()
        {
            tile.Shop(player);
        }

        public void Look()
        {
            tile.Look(player);
        }

        public void MoveNorth()
        {
            //Fill in later.
        }

        public void MoveSouth()
        {
            //Fill in later.
        }

        public void MoveWest()
        {
            //Fill in later.
        }

        public void MoveEast()
        {
            //Fill in later.
        }
    }
}
