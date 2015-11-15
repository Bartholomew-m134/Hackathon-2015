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

        string Name
        {
            get;
        }

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

        void Loot(IPlayer player);
    }
}
