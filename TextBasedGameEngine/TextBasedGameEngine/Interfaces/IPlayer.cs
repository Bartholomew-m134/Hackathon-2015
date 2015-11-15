using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;

namespace TextBasedGameEngine.Interfaces
{
    public interface IPlayer
    {
        int Health
        {
            get;
            set;
        }

        int MaxHealth
        {
            get;
            set;
        }

        Location Position
        {
            get;
            set;
        }

        int Power
        {
            get;
        }

        int Magic
        {
            get;
        }

        bool StatusEffect
        {
            get;
            set;
        }
    }
}
