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
    public partial class AudioSettingsPanel : UserControl
    {
        static MediaPlayer mp;
        static MediaPlayer sp;
         Thread mp_thread = new Thread(MusicThreadFunc);
         Thread sp_thread = new Thread(SoundThreadFunc);

        public static bool music_stop = false;
        public static bool sound_stop = false;
        public static bool music_changed = false;
        public static bool sound_changed = false;
        public AudioSettingsPanel()
        {
            InitializeComponent();

        }

        public static void MusicThreadFunc()
        {
            try
            {
                mp = new MediaPlayer();
                mp.Open(new System.Uri(Path.GetFullPath(@"Audio\\background_music.wav")));
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
        
        public void playBackgroundMusic()
        {
            try
            {
                
                mp_thread.Start();
            }
            catch { }    
        }

        public void startSoundPlayer()
        {
            try
            {
                sp_thread.Start();
            }
            catch { } 
        }


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

        private void MuteCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            music_changed = true;
            sound_changed = true;

        }

        private void MusicVolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            music_changed = true;
        }

        private void musicVolTrackbar_Scroll(object sender, EventArgs e)
        {
            sound_changed = true;
        }


        //exit wand apply settings to a player
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
