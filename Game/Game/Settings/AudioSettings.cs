using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Settings
{
    public class AudioSettings
    {
        const double DEFAULT_MUSIC_VOLUME = 0.5;
        const double DEFAULT_SOUND_VOLUME = 0.5;
        const bool DEFAULT_IS_MUTED = false;

        public double MusicVolume {get; private set;}
        public double SoundVolume { get; private set; }
        public bool IsMuted { get; private set; }

        /// <summary>
        /// Domyslne ustawienia
        /// </summary>
        public AudioSettings()
        {
            MusicVolume = DEFAULT_MUSIC_VOLUME;
            SoundVolume = DEFAULT_SOUND_VOLUME;
            IsMuted = DEFAULT_IS_MUTED;

        }

        /// <summary>
        /// Konstruktor z paramterami
        /// </summary>
        /// <param name="music_volume"></param>
        /// <param name="sound_volume"></param>
        /// <param name="is_muted"></param>
        public AudioSettings(double music_volume, double sound_volume, bool is_muted)
        {
            MusicVolume = music_volume;
            SoundVolume = sound_volume;
            IsMuted = is_muted;
        }
    }
}
