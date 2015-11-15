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
            if (input.Equals(BattleCommandList.ATTACK, StringComparison.CurrentCultureIgnoreCase))
            {
                battle.Melee();
            }
            else if (input.Equals(BattleCommandList.MAGIC, StringComparison.CurrentCultureIgnoreCase))
            {
                battle.Magic();
            }
            else if (input.Equals(BattleCommandList.HEAL, StringComparison.CurrentCultureIgnoreCase))
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
