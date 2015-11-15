using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGameEngine
{
    public static class Writer
    {
        private const string INVALID_COMMAND_TEXT = "Invalid Command";
        private const string NOT_ABAILABLE_COMMAND_TEXT = "Not possible here";

        public static void Write(string text)
        {
            Console.Write(text);
        }

        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void OutputInvalidCommand()
        {
            Console.WriteLine(INVALID_COMMAND_TEXT);
        }

        public static void OutputNotAvailableCommand()
        {
            Console.WriteLine(NOT_ABAILABLE_COMMAND_TEXT);
        }
    }
}
