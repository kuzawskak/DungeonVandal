using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Settings
{
    public class AudioSettings
    {
        const int DEFAULT_MUSIC_VOLUME = 50;
        const int DEFAULT_SOUND_VOLUME = 50;
        const bool DEFAULT_IS_MUTED = false;

        private int music_volume;
        private int sound_volume;
        private bool is_muted;

        public AudioSettings()
        {

        }

        public AudioSettings(int music_volume, int sound_volume, bool is_muted)
        {
        }
    }
}
