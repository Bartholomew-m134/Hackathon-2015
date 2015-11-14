using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Utilities
{
    public class Location
    {
        private int xLocation;
        private int yLocation;

        public Location(int x, int y)
        {
            xLocation = x;
            yLocation = y;
        }

        public int X
        {
            get { return xLocation; }
            set { xLocation = value; }
        }

        public int Y
        {
            get { return yLocation; }
            set { yLocation = value; }
        }
    }
}
