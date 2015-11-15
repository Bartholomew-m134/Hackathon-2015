using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Interfaces;

namespace TextBasedGameEngine
{
    public class Inventory
    {
        private List<IItem> itemList;
        private const int MAX_COUNT = 5;

        public Inventory() 
        {
            itemList = new List<IItem>();
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
            if (index - 1 < itemList.Count)
            {
                Writer.WriteLine("Used " + itemList[index].Name);
                itemList.RemoveAt(index - 1);
            }
            else
            {
                Writer.WriteLine("Invalid Index");
            }
        }

        public void PrintInventory()
        {
            Writer.WriteLine("Inventory");

            for(int i = 0; i < itemList.Count; i++)
            {
                Writer.WriteLine(i + ": " + itemList[i].Name);
            }
    }
}
