﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Utilities
{
    public static class BattleCommandList
    {
        public const string MELEE = "Melee";
        public const string MAGIC = "Magic";
        public const string HEAL = "Heal";

        public static List<string> CommandList()
        {
            List<string> list = new List<string>();

            list.Add(MELEE);
            list.Add(MAGIC);
            list.Add(HEAL);

            return list;
        }
    }
}
