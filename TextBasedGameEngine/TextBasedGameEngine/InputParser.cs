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
            if (input.Equals(InputCommandList.BATTLE, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.Battle();
            }
            else if (input.Equals(InputCommandList.LOOK, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.Look();
            }
            else if (input.Equals(InputCommandList.SHOP, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.Shop();
            }
            else if (input.Equals(InputCommandList.MOVE_NORTH, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.MoveNorth();
            }
            else if (input.Equals(InputCommandList.MOVE_EAST, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.MoveEast();
            }
            else if (input.Equals(InputCommandList.MOVE_WEST, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.MoveWest();
            }
            else if (input.Equals(InputCommandList.MOVE_SOUTH, StringComparison.CurrentCultureIgnoreCase))
            {
                TileController.MoveSouth();
            }
            else if (input.Equals(InputCommandList.HELP, StringComparison.CurrentCultureIgnoreCase))
            {
                Instructions.PrintControls();
            }
            else if (input.Equals(InputCommandList.MOVE_WEST, StringComparison.CurrentCultureIgnoreCase))
            {
                //TileController.Status();
            }
            else
            {
                Writer.OutputInvalidCommand();
            }
        }
    }
}
