using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;
using TextBasedGameEngine.Enemy;

namespace TextBasedGameEngine.BattleHandling
{
    public class BattleHandler
    {
        IPlayer player;
        IEnemy enemy;

        public BattleHandler(IPlayer player, IEnemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        public void HandleBattle()
        {
            int enemyHealth = enemy.Health;
            while (player.Health > 0 && enemy.Health > 0)
            {
                Writer.WriteLine("Player: " + player.Health + "/" + player.MaxHealth + " Enemy: " + enemy.Health + "/" + enemyHealth);
                Writer.WriteLine("Options: Attack Magic Heal");
                HandlePlayerAction();
                HandleEnemyAction();
            }
            if (player.Health == 0)
            {
                Writer.WriteLine("Player has been defeated.");
            }
            else
            {
                Writer.WriteLine("Enemy has been defeated.");
            }
        }

        private void HandlePlayerAction()
        {
            string input = Console.ReadLine();
            while (!BattleParser.ParseBattle(this, input))
                input = Console.ReadLine();
        }

        private void HandleEnemyAction()
        {
            if (enemy.Hostile && enemy.Health > 0)
                player.Health -= enemy.AttackPower;
            enemy.HandleMagicBurn();
        }

        public void Attack()
        {
            enemy.Health -= player.Power;
        }

        public void Magic(){
            enemy.Health -= player.Magic;
            enemy.HitWithMagic = true;
        }

        public void Heal()
        {
            player.Health += 20;
            if (player.Health >= 100)
            {
                player.Health = 100;
            }
        }
    }
}
