using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Weapon;
using Game.Characters;

namespace Game
{
    /// <summary>
    /// Klasa gracza
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Nazwa gracza
        /// </summary>
        public string Name {get; private set;}

        /// <summary>
        /// Liczab rakiet
        /// </summary>
        public int Rackets  {get; set;}

        /// <summary>
        /// Liczab dynamitów
        /// </summary>
        public int Dynamite { get; set; }

        /// <summary>
        /// Liczba punktów
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Poziom inteligencji
        /// </summary>
        public int IntelligenceLevel { get;  set; }

        /// <summary>
        /// Konstruktor z przypisaniem wszytkich pól na 0 (oprócz nazwy)
        /// </summary>
        /// <param name="name">Nazwa gracza</param>
        public Player(string name)
        {
            KeyboardSettings = new Settings.KeySettings();
            AudioSettings = new Settings.AudioSettings();
            this.Name = name;
            this.Points = 0;
            this.Rackets = 0;
            this.Dynamite = 0;
            this.IntelligenceLevel = 1;
        }

        /// <summary>
        /// Ustawienia klawiatury
        /// </summary>
        public Settings.KeySettings KeyboardSettings { get; set; }
        /// <summary>
        /// Ustawienia audio
        /// </summary>
        public Settings.AudioSettings AudioSettings { get; set; }

        /// <summary>
        /// Konstruktor bezparametrowy
        /// </summary>
        public Player()
        {
            KeyboardSettings = new Settings.KeySettings();
            AudioSettings = new Settings.AudioSettings();
            IntelligenceLevel = 1;
            //inicializacja wszytkich pol na 0   
        }

    }
}
