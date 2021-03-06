﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.BattleHandling;
using TextBasedGameEngine.Interfaces;
using TextBasedGameEngine.Shops;

namespace TextBasedGameEngine.Tiles
{
    public class Tile : ITile
    {
        private List<IEnemy> enemyList;
        private List<IItem> storeItemList;
        private string lookText;


        public Tile(string lookText, List<IEnemy> enemies, List<IItem> storeItems)
        {
            enemyList = enemies;
            storeItemList = storeItems;
            this.lookText = lookText;
        }

        public void Battle(IPlayer player)
        {
            if (enemyList.Count > 0)
            {
                BattleHandler battle = new BattleHandler(player, enemyList.First());
                battle.HandleBattle();
                if (enemyList.First().Health <= 0)
                    enemyList.RemoveAt(0);
            }
        }

        public void Shop(IPlayer player)
        {
            if (storeItemList != null && storeItemList.Count > 0)
            {
                ShopHandler shop = new ShopHandler(player, storeItemList);
                shop.ManageShop();
            }
            else
            {
                Writer.OutputNotAvailableCommand();
            }
        }

        public void Look(IPlayer player)
        {
            Writer.WriteLine("x: " + player.Position.X + " y: " + player.Position.Y);
            Writer.WriteLine(lookText);

            foreach (IEnemy enemy in enemyList)
            {
                Writer.WriteLine("You see a " + enemy.Name);
            }
        }
    }
}
