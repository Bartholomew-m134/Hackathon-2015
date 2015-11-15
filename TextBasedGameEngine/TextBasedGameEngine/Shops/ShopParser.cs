using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine.Shops
{
    public static class ShopParser
    {
        public static bool ParseShop(ShopHandler shop, string input)
        {
            bool validCommand = true;
            if (input.Equals(ShopCommandList.LOOK, StringComparison.CurrentCultureIgnoreCase))
            {
                shop.LookAtItem();
            }
            else if (input.Equals(ShopCommandList.NEXT, StringComparison.CurrentCultureIgnoreCase))
            {
                shop.NextItem();
            }
            else if (input.Equals(ShopCommandList.PURCHASE, StringComparison.CurrentCultureIgnoreCase))
            {
                shop.PurchaseItem();
            }
            else if (input.Equals(ShopCommandList.EXIT, StringComparison.CurrentCultureIgnoreCase))
            {
                shop.ExitShop();
            }
            else
            {
                validCommand = false;
                Writer.OutputInvalidCommand();
            }

            return validCommand;
        }
    }
}
