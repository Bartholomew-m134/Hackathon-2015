using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Tiles
{
    public interface ITile
    {
        void Attack();
        void Shop();
        void Look();
    }
}
