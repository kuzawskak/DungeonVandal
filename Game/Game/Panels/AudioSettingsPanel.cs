using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using DungeonVandal;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace Game.Panels
{
    /// <summary>
    /// Panel z ustawieniami dźwięku
    /// </summary>
    public partial class AudioSettingsPanel : UserControl
    {
        /// <summary>
        /// Odtwarzacz muzyki w tle gry
        /// </summary>
        static MediaPlayer mp;
        /// <summary>
        /// Odtwarzacz pojedynczych dźwięków w grze
        /// </summary>
        static MediaPlayer sp;
        /// <summary>
        /// Wątek do odtwarzania muzyki w tle
        /// </summary>
        static  Thread mp_thread = new Thread(MusicThreadFunc);
        /// <summary>
        /// Wątek do odtwarzania pojedynczych dżwięków
        /// </summary>
         static Thread sp_thread = new Thread(SoundThreadFunc);

        /// <summary>
        /// Informacja czy zakonczyć odtwarzanie muzyki
        /// </summary>
        public static bool music_stop = false;
         /// <summary>
         /// Informacja czy zakonczyc odtwarzanie pojedynczych dzwiekow
         /// </summary>
        public static bool sound_stop = false;
        /// <summary>
        /// Informacja czy zmienic glosnosc muzyki
        /// </summary>
        public static bool music_changed = false;
        /// <summary>
        /// Informacja czy zmienic glosnosc pojedynczych dzwiekow
        /// </summary>
        public static bool sound_changed = false;
        public AudioSettingsPanel()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Funkcja wątku odtwarzania muzyki w tle
        /// </summary>
        public static void MusicThreadFunc()
        {
            try
            {
                mp = new MediaPlayer();
                mp.Open(new System.Uri(Path.GetFullPath(@"background_music.wav")));
                mp.Volume = (double)MusicVolumeTrackBar.Value / 10;
                mp.Play();
            }
            catch { }
            while (!music_stop)
            {
                if (music_changed)
                {
                    if (MuteCheckbox.Checked)
                    {
                        mp.Volume = 0;
                        music_changed = false;
                    }
                    else
                    {
                        mp.Volume = (double)MusicVolumeTrackBar.Value / 10;
                        music_changed = false;
                    }
                }
            }
            if(mp!=null)
            mp.Stop();
           music_stop = false;
            

        }
        /// <summary>
        /// Funkcja watku odtwarzania pojedynczych dzwiekow
        /// </summary>
        public static void SoundThreadFunc()
        {
            try
            {
           
                sp = new MediaPlayer();
                sp.Open(new System.Uri(Path.GetFullPath(@"found.wav")));
                sp.Volume = (double)musicVolTrackbar.Value / 10;
                sp.Play();
               
            }
            catch { }
            while (!sound_stop)
            {
                if (sound_changed)
                {
                    if (MuteCheckbox.Checked)
                    {
                        sp.Volume = 0;
                        sound_changed = false;
                    }
                    else
                    {
                        sp.Open(new System.Uri(Path.GetFullPath(@"found.wav")));
                        sp.Volume = (double)musicVolTrackbar.Value / 10;
                        sp.Play();
                        sound_changed = false;
                    }
                }
            }
            if (sp != null) 
            sp.Stop();
            sound_stop = false;
 
        }
        
        /// <summary>
        /// Funkcja rozpoczynajaca dzialanie watku z muzyka w tle
        /// </summary>
        public void playBackgroundMusic()
        {
            try
            {               
                mp_thread.Start();
            }
            catch { }    
        }

        /// <summary>
        /// Funkcja rozpoczynajaca dzialanie watku z pojedynczym dzwiekiem
        /// </summary>
        public void startSoundPlayer()
        {
            try
            {
                sp_thread.Start();
            }
            catch { } 
        }

        /// <summary>
        /// Zatrzymanie obu odtwarzaczy dzwieku
        /// </summary>
        public void stopPlayer()
        {
            sound_stop = true;
            music_stop = true;        
        }

  

        private void audioLabel_Click(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Obsluga zdarzenia zmiany checkboxa do wylaczania dzwieku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MuteCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            music_changed = true;
            sound_changed = true;

        }

        /// <summary>
        /// Obsluga zdarzenia zmian na scrollbarze do zmiany glosnosci dzwieku w tle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicVolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            music_changed = true;
        }

        /// <summary>
        /// Obsluga zdarzenia zmian na scrollbarze do zmiany glosnosci pojedynczego dzwieku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicVolTrackbar_Scroll(object sender, EventArgs e)
        {
            sound_changed = true;
        }


        /// <summary>
        /// Obluga zdarzenia wyjscia z manu suatwien dzwieku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            stopPlayer();
            mp_thread.Abort();
            sp_thread.Abort();
            mp_thread.Join();
            sp_thread.Join();
            this.Visible = false;
           
            ((MenuForm)Parent).player.AudioSettings = new Settings.AudioSettings((double)MusicVolumeTrackBar.Value / 10, (double)musicVolTrackbar.Value / 10, MuteCheckbox.Checked);
            ((MenuForm)Parent).settings_panel.Visible = true;
           
        }
    }
}
