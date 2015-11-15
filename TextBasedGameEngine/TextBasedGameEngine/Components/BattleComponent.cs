using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.BattleHandling;
using TextBasedGameEngine.Enemy;
using TextBasedGameEngine.Player;

namespace TextBasedGameEngine.Components
{
    public class BattleComponent : IComponent
    {
        private IEnemy enemy;

        public BattleComponent(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void Execute(IPlayer player)
        {
            if (enemy.Health > 0)
            {
                BattleHandler battle = new BattleHandler(player, enemy);
                battle.HandleBattle();
            }
        }
    }
}
