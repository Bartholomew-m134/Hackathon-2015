using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.BattleHandling;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Tiles
{
    public class GrasslandTile : ITile
    {
        List<IEnemy> enemyList;

        public GrasslandTile(List<IEnemy> enemies)
        {
            enemyList = enemies;
        }

        public void Battle(IPlayer player)
        {
            if (enemyList.Count > 0)
            {
                BattleHandler battle = new BattleHandler(player, enemyList.First());
                battle.HandleBattle();
            }
        }

        public void Shop(IPlayer player)
        {
            
        }

        public void Look(IPlayer player)
        {
            Writer.WriteLine("x: " + player.Position.X + " y: " + player.Position.Y);
            Writer.WriteLine("You are in a Grassland.");

            foreach (IEnemy enemy in enemyList)
            {
                Writer.WriteLine("You see a " + enemy.Name);
            }
        }
    }
}
