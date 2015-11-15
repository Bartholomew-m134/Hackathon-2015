using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

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
                Writer.WriteLine("\nPlayer: " + player.Health + "/" + player.MaxHealth + " Enemy: " + enemy.Health + "/" + enemyHealth);
                Writer.WriteLine("Options: Melee Magic Heal");
                HandlePlayerAction();
                HandleEnemyAction();
                HandleStatusEffect();
            }
            if (player.Health == 0)
            {
                Writer.WriteLine("Player has been defeated.");
            }
            else
            {
                Writer.WriteLine("Enemy has been defeated.");
                enemy.Loot(player);
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
            if(enemy.Health > 0)
                enemy.Attack(player);
        }

        private void HandleStatusEffect()
        {
            enemy.HandleMagicBurn();
            player.HandleStatusEffect();
        }

        public void Melee()
        {
            Writer.WriteLine("Player hits enemy for " + player.WeaponPower);
            enemy.Health -= player.WeaponPower;
        }

        public void Magic(){
            Writer.WriteLine("Player strikes enemy for " + player.Magic + ", and applies a burn");
            enemy.Health -= player.Magic;
            enemy.HitWithMagic = true;
        }

        public void Heal()
        {
            player.Health += player.Heal;
            player.HasStatusEffect = false;
            player.StatusEffectModifier = 0;
            Writer.WriteLine("Player heals for " + player.Heal + ", and removes status ailment.");
            if (player.Health >= player.MaxHealth)
            {
                player.Health = player.MaxHealth;
            }
        }
    }
}
