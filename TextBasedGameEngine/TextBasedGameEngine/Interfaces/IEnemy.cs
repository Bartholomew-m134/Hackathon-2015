using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine.Interfaces
{
    public interface IEnemy
    {
        void Attack(IPlayer player);

        int AttackPower
        {
            get;
        }

        int Health
        {
            get;
            set;
        }

        bool HitWithMagic
        {
            get;
            set;
        }

        void HandleMagicBurn();
    }
}
