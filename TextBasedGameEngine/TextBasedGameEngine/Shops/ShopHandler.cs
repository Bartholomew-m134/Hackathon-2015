using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Shops
{
    public class ShopHandler
    {
        private List<IItem> storeItemList;
        IPlayer player;
        int currentItem;
        bool exitShop;

        public ShopHandler(IPlayer player, List<IItem> list)
        {
            storeItemList = list;
            this.player = player;
            currentItem = 0;
            exitShop = false;
        }

        public void ManageShop()
        {

            while (!exitShop)
            {
                Writer.WriteLine("Options: Look Purchase Next Exit");
                string input = Console.ReadLine();
                while(!ShopParser.ParseShop(this, input))
                    input = Console.ReadLine();

            }
        }

        public void LookAtItem(){
            Writer.WriteLine("Item: " + storeItemList[currentItem].Name + " Value: " + storeItemList[currentItem].Value);
        }

        public void PurchaseItem()
        {
            if (player.Gold - storeItemList[currentItem].Value > 0)
            {
                player.Gold -= storeItemList[currentItem].Value;
                player.Inventory.AddItem(storeItemList[currentItem]);
            }
        }

        public void NextItem()
        {
            currentItem++;
            if (currentItem >= storeItemList.Count)
                currentItem = 0;
        }

        public void ExitShop()
        {
            exitShop = true;
        }
    }
}
