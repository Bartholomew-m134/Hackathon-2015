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
            Writer.WriteLine("Look/l - Observe the contents of a tile.");
            Writer.WriteLine("Battle/b - If enemy is on tile, enter battle mode.");
            Writer.WriteLine("Shop - If shop is on tile, enter shop mode.");
            Writer.WriteLine("Status - Report the status of the player character.");
            Writer.WriteLine("Move North/w - If possible, move north 1 tile location.");
            Writer.WriteLine("Move South/s - If possible, move south 1 tile location.");
            Writer.WriteLine("Move West/a - If possible, move west 1 tile location.");
            Writer.WriteLine("Move East/d - If possible, move east 1 tile location.");
            Writer.WriteLine("Help/h - Reprint this list of instructions.\n");
        }
    }
}
