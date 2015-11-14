using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine
{
    public static class Reader
    {
        public static void ReadInput()
        {
            string input = Console.ReadLine();
            if (input != null && !input.Equals(""))
                InputParser.Parse(input);
        }
    }
}
