using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Weapon;
using Game.Characters;

namespace Game
{
    public class Player
    {
        public string Name {get; private set;}

        public int Rackets  {get; set;}

        public int Dynamite { get; set; }

        public int Points { get; set; }

        public int IntelligenceLevel { get; private set; }

        public Player(string name)
        {
            KeyboardSettings = new Settings.KeySettings();
            GraphicsSettings = new Settings.GraphicsSettings();
            AudioSettings = new Settings.AudioSettings();
            this.Name = name;
            this.Points = 0;
            this.Rackets = 0;
            this.Dynamite = 0;
            this.IntelligenceLevel = 1;

        }


        void UpGrade() { }


        public Settings.KeySettings KeyboardSettings { get; set; }
        public Settings.GraphicsSettings GraphicsSettings { get; set; }
        public Settings.AudioSettings AudioSettings { get; set; }

        public Player()
        {
            KeyboardSettings = new Settings.KeySettings();
            GraphicsSettings = new Settings.GraphicsSettings();
            AudioSettings = new Settings.AudioSettings();
            IntelligenceLevel = 1;
            //inicializacja wszytkich pol na 0   
        }

    }
}
