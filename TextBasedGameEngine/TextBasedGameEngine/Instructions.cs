using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine
{
    public static class Instructions
    {
        public static void PrintControls()
        {
            Writer.WriteLine("Look - Observe the contents of a tile.");
            Writer.WriteLine("Battle - If enemy is on tile, enter battle mode.");
            Writer.WriteLine("Shop - If shop is on tile, enter shop mode.");
            Writer.WriteLine("Status - Report the status of the player character.");
            Writer.WriteLine("Move North - If possible, move north 1 tile location.");
            Writer.WriteLine("Move South - If possible, move south 1 tile location.");
            Writer.WriteLine("Move West - If possible, move west 1 tile location.");
            Writer.WriteLine("Move East - If possible, move east 1 tile location.");
            Writer.WriteLine("Help - Reprint this list of instructions.\n");
        }
    }
}
