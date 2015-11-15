using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedGameEngine.Tiles;

namespace TextBasedGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            TileController.Load();

            Console.Title = "Hackathon 2015 Text Based Game Engine";

            while(true)
                Reader.ReadInput(); 
        }
    }
}
