using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Enemy
{
    public interface IEnemy
    {
        int AttackPower
        {
            get;
        }

        int Health
        {
            get;
            set;
        }

        bool Hostile
        {
            get;
        }

        bool HitWithMagic
        {
            get;
            set;
        }

        void HandleMagicBurn();
    }
}
