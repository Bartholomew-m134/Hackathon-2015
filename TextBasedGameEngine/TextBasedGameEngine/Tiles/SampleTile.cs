﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Tiles
{
    public class SampleTile : ITile
    {
        public SampleTile()
        {

        }

        public void Attack()
        {
            Writer.Write();
        }

        public void Shop()
        {
            Writer.Write();
        }
    }
}
