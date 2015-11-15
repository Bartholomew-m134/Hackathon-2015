using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Tiles;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine
{
    public static class InputParser
    {
        public static void Parse(string input) 
        {
            if (input.Equals(InputCommandList.BATTLE, StringComparison.CurrentCultureIgnoreCase) || input.Equals("b"))
            {
                TileController.Battle();
            }
            else if (input.Equals(InputCommandList.LOOK, StringComparison.CurrentCultureIgnoreCase) || input.Equals("l"))
            {
                TileController.Look();
            }
            else if (input.Equals(InputCommandList.SHOP, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.Shop();
            }
            else if (input.Equals(InputCommandList.MOVE_NORTH, StringComparison.CurrentCultureIgnoreCase) || input.Equals("w"))
            {
                TileController.MoveNorth();
            }
            else if (input.Equals(InputCommandList.MOVE_EAST, StringComparison.CurrentCultureIgnoreCase) || input.Equals("d"))
            {
                TileController.MoveEast();
            }
            else if (input.Equals(InputCommandList.MOVE_WEST, StringComparison.CurrentCultureIgnoreCase) || input.Equals("a"))
            {
                TileController.MoveWest();
            }
            else if (input.Equals(InputCommandList.MOVE_SOUTH, StringComparison.CurrentCultureIgnoreCase) || input.Equals("s"))
            {
                TileController.MoveSouth();
            }
            else if (input.Equals(InputCommandList.HELP, StringComparison.CurrentCultureIgnoreCase) || input.Equals("h"))
            {
                Instructions.PrintControls();
            }
            else if (input.Equals(InputCommandList.STATUS, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.Status();
            }
            else if (input.Equals(InputCommandList.INVENTORY, StringComparison.CurrentCultureIgnoreCase) || input.Equals("i"))
            {
                TileController.Inventory();
            }
            else
            {
                Writer.OutputInvalidCommand();
            }
        }
    }
}
