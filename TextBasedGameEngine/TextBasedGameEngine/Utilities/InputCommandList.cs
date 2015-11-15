using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Utilities
{
    public static class InputCommandList
    {
        public const string BATTLE = "Battle";
        public const string LOOK = "Look";
        public const string SHOP = "Shop";
        public const string HELP = "Help";
        public const string MOVE_NORTH = "Move North";
        public const string MOVE_EAST = "Move East";
        public const string MOVE_WEST = "Move West";
        public const string MOVE_SOUTH = "Move South";
        public const string STATUS = "Status";


        public static List<string> CommandList()
        {
            List<string> list = new List<string>();

            list.Add(BATTLE);
            list.Add(LOOK);
            list.Add(SHOP);
            list.Add(STATUS);

            list.Add(MOVE_NORTH);
            list.Add(MOVE_SOUTH);
            list.Add(MOVE_WEST);
            list.Add(MOVE_EAST);

            list.Add(HELP);

            return list;
        }
    }
}
