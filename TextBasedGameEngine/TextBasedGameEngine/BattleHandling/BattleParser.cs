using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine.BattleHandling
{
    public static class BattleParser
    {
        public static bool ParseBattle(BattleHandler battle, string input)
        {
            bool validCommand = true;
            if (input.Equals(BattleCommandList.MELEE, StringComparison.CurrentCultureIgnoreCase) || input.Equals("a"))
            {
                battle.Melee();
            }
            else if (input.Equals(BattleCommandList.MAGIC, StringComparison.CurrentCultureIgnoreCase) || input.Equals("s"))
            {
                battle.Magic();
            }
            else if (input.Equals(BattleCommandList.HEAL, StringComparison.CurrentCultureIgnoreCase) || input.Equals("d"))
            {
                battle.Heal();
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
