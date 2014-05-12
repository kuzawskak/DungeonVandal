using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Settings;
using Microsoft.Xna.Framework.Storage;


namespace XMLManager
{
    public class FileManager
    {
        const string GameStateFile = "game_state.dat";
        const string HighScoresFile = "high_scores.dat";
        const string SettingsFile = "settings.dat";
        

        public List<Game.Score> GetScores(int level) { return null;}
        public Game.Game GetGameState(String PlayerName)
        { return null; }

        public AudioSettings GetAudioSettings(String PlayerName) { return null; }
        public GraphicsSettings GetGraphicsSettings(String PlayerName) { return null; }
        public KeySettings GetKeySettings(String PlayerName) { return null; }

        public bool SaveScore(Game.Score score) { return false; }
        public bool SaveGameState(Game.Game game) { return false;  }

        public bool SaveSettings(AudioSettings audio, GraphicsSettings graphics, KeySettings keys, Game.Player player) { 
        return false;
         }

    }
}
