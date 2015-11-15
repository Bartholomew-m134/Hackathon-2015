using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Enemy;
using TextBasedGameEngine.Player;
using TextBasedGameEngine.BattleHandling;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Tiles
{
    public class GrasslandGoblinTile : ITile
    {
        IEnemy enemy;
        public GrasslandGoblinTile()
        {
            enemy = new Goblin();
        }

        public void Battle(IPlayer player)
        {
            if (enemy.Health > 0)
            {
                BattleHandler battle = new BattleHandler(player, enemy);
                battle.HandleBattle();
            }
        }

        public void Shop(IPlayer player)
        {
            Writer.OutputNotAvailableCommand();
        }

        public void Look(IPlayer player)
        {
            Writer.WriteLine("You are in a Grassland, and come across a Goblin.\n");
            Writer.WriteLine("x: " + player.Position.X + " y: " + player.Position.Y);
        }
    }
}
