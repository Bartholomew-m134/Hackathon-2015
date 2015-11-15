using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Items
{
    public class HealingBooster : IItem
    {
        private const string NAME = "Healing Booster";
        private int itemValue = 8;

        public string Name
        {
            get { return NAME; }
        }


        public void UseItem(IPlayer player)
        {
            player.Heal += 10;
        }


        public int Value
        {
            get { return itemValue; }
        }
    }
}
