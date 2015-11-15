using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Shops
{
    public class Shop
    {
        private List<IItem> storeItemList;
        int currentItem;

        public Shop(List<IItem> list)
        {
            storeItemList = list;
            currentItem = 0;
        }

        public void LookAtItem(){
            Writer.WriteLine("Item: " + storeItemList[currentItem].Name + " Value: " + storeItemList[currentItem].Value);
        }

        public void PurchaseItem(IPlayer player)
        {
            if (player.Gold - storeItemList[currentItem].Value > 0)
            {
                player.Gold -= storeItemList[currentItem].Value;

            }
        }

        public void NextItem()
        {
            currentItem++;
            if (currentItem >= storeItemList.Count)
                currentItem = 0;
        }
    }
}
