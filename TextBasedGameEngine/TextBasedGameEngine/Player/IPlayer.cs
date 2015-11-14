﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine.Player
{
    public interface IPlayer
    {
        int Health
        {
            get;
            set;
        }

        Location Position
        {
            get;
            set;
        }
    }
}