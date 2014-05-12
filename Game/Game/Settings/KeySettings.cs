using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Settings
{
   
    public class KeySettings
    {
        
        private ConsoleKey up;
        private ConsoleKey down;
        private ConsoleKey left;
        private ConsoleKey right;
        private ConsoleKey block;
        private ConsoleKey dynamite;
        private ConsoleKey racket;
        public KeySettings(List<ConsoleKey> keys)
        {
        }
        public KeySettings(int number)
        {
        }

        public KeySettings()
        {
        }
    }
}
