using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Items
{
    public class HealthPotion : IItem
    {
        private const string NAME = "HealthPotion";
        private int itemValue = 5;

        public string Name
        {
            get { return NAME; }
        }

        public void UseItem(IPlayer player)
        {
            player.Health = player.MaxHealth;
        }

        public int Value
        {
            get { return itemValue; }
        }
    }
}
