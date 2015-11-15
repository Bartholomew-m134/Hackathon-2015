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

        int WeaponPower
        {
            set;
            get;
        }

        int Magic
        {
            get;
        }

        int Heal
        {
            get;
            set;
        }

        int Armor
        {
            get;
            set;
        }

        bool HasStatusEffect
        {
            get;
            set;
        }

        int StatusEffectModifier
        {
            set;
        }

        void HandleStatusEffect();
    }
}
