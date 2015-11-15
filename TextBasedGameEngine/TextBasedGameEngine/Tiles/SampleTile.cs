using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;

namespace TextBasedGameEngine.Tiles
{
    public class SampleTile : ITile
    {
        List<>

        public SampleTile()
        {
        }

        public void Battle(IPlayer player)


        public void Attack(IPlayer player)
        {
            Writer.OutputNotAvailableCommand();
        }

        public void Shop(IPlayer player)
        {
            Writer.OutputNotAvailableCommand();
        }

        public void Look(IPlayer player)
        {
            Writer.WriteLine("x: " + player.Position.X + " y: " + player.Position.Y);
        }
    }
}
