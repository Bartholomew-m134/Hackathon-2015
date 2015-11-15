using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Utilities;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Player
{
    public class PlayerCharacter : IPlayer
    {
        private Location playerLocation;
        private Inventory inventory;
        private int health;
        private int maxHealth;
        private int weaponPower;
        private int armor;
        private int magic;
        private int heal;
        private bool hasStatus;
        private int statusModifier;
        private int gold;

        public PlayerCharacter()
        {
            playerLocation = new Location(1, 1);
            inventory = new Inventory();
            health = 100;
            maxHealth = 100;
            weaponPower = 10;
            armor = 0;
            magic = (weaponPower*4)/5;
            heal = 20;
            hasStatus = false;
            statusModifier = 0;
            gold = 0;
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        public Location Position
        {
            get { return playerLocation; }
            set { playerLocation = value; }
        }


        public int WeaponPower
        {
            get { return weaponPower; }
            set { weaponPower = value; }
        }

        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }


        public int Magic
        {
            get { return magic; }
            set { magic = value; }
        }


        public bool HasStatusEffect
        {
            get { return hasStatus; }
            set { hasStatus = value; }
        }


        public int StatusEffectModifier
        {
            get { return statusModifier; }
            set { statusModifier = value; }
        }


        public void HandleStatusEffect()
        {
            health += statusModifier;
        }


        public int Heal
        {
            get { return heal; }
            set { heal = value; }
        }


        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        public Inventory Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
    }
}
