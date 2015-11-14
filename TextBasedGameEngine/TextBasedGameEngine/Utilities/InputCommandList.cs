using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Utilities
{
    public static class InputCommandList
    {
        public const string ATTACK = "Attack";
        public const string LOOK = "Look";
        public const string SHOP = "Shop";
        public const string HELP = "Help";

        public static List<string> CommandList()
        {
            List<string> list = new List<string>();

            list.Add(ATTACK);
            list.Add(LOOK);
            list.Add(SHOP);
            list.Add(HELP);

            return list;
        }
    }
}
