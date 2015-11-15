using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine.Inventory
{
    public class InventoryHandler
    {
        private List<IItem> itemList;
        private const int MAX_COUNT = 5;
        private IPlayer player;

        public InventoryHandler(IPlayer player)
        {
            itemList = new List<IItem>();
            this.player = player;
        }

        public void HandleInventory()
        {
            PrintInventory();
            Writer.WriteLine("Enter an items index number, or exit with 5");
            int input = -1;
            
            while (input != 5)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input\n");
                }
                if (input < itemList.Count && input >= 0)
                {
                    UseItem(input);
                }

            }
        }

        public void AddItem(IItem item)
        {
            if (itemList.Count < MAX_COUNT)
            {
                itemList.Add(item);
            }
            else
            {
                Writer.WriteLine("Inventory Full");
            }
        }

        public void UseItem(int index)
        {
            if (index< itemList.Count)
            {
                Writer.WriteLine("Used " + itemList[index].Name);
                itemList[index].UseItem(player);
                itemList.RemoveAt(index);
            }
            else
            {
                Writer.WriteLine("Invalid Index");
            }
        }

        public void PrintInventory()
        {
            Writer.WriteLine("Inventory");

            for (int i = 0; i < itemList.Count; i++)
            {
                Writer.WriteLine(i + ": " + itemList[i].Name);
            }
        }
    }
}
