﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Interfaces
{
    public interface IItem
    {
        string Name { get; }
        void UseItem(IPlayer player);
        int Value { get; }
    }
}
