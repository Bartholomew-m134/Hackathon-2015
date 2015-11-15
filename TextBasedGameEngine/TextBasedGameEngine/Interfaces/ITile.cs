using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Player;

namespace TextBasedGameEngine.Interfaces
{
    public interface ITile
    {
        void Battle(IPlayer player);
        void Shop(IPlayer player);
        void Look(IPlayer player);
    }
}
