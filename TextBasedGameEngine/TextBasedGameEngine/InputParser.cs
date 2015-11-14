﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine
{
    public static class InputParser
    {
        public static void Parse(string input) 
        {
            if (input.Equals(InputCommandList.ATTACK, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.Attack();
            }
            else if (input.Equals(InputCommandList.LOOK, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.Look();
            }
            else if (input.Equals(InputCommandList.SHOP, StringComparison.CurrentCultureIgnoreCase))
            {
                TileControler.Shop();
            }
            else if (input.Equals(InputCommandList.HELP, StringComparison.CurrentCultureIgnoreCase))
            {
                List<string> list = InputCommandList.CommandList();

                foreach (string command in list)
                    Writer.WriteLine(command);
            }
        }
    }
}
