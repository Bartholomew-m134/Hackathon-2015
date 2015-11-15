using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Utilities
{
    public static class ShopCommandList
    {
        public const string LOOK = "Look";
        public const string PURCHASE = "Purchase";
        public const string NEXT = "Next";
        public const string EXIT = "Exit";

        public static List<string> CommandList()
        {
            List<string> list = new List<string>();

            list.Add(LOOK);
            list.Add(PURCHASE);
            list.Add(NEXT);
            list.Add(EXIT);

            return list;
        }
    }
}
