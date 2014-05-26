using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Game;
using DungeonVandal;

namespace Game.Panels
{
    /// <summary>
    /// Panel z wyborem ustawień
    /// </summary>
    public partial class SettingsPanel : UserControl
    {
        /// <summary>
        /// Konstruktor domyślny generowany przez WindowsForms
        /// </summary>
       
        public SettingsPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wejście do ustawień audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void audioButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).audio_settings_panel.Visible = true;
            ((MenuForm)Parent).audio_settings_panel.playBackgroundMusic();
            ((MenuForm)Parent).audio_settings_panel.startSoundPlayer();
      
        }



        /// <summary>
        /// Wejście do ustawień sterowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyboardButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).keyboard_settings_panel.Visible = true;
            //MenuForm)Parent).keyboard_settings_panel.Focus();
        }

        /// <summary>
        ///Przywrócenie usawień domyślnych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultSettingsButton_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).player.AudioSettings = new Settings.AudioSettings();
            ((MenuForm)Parent).player.KeyboardSettings = new Settings.KeySettings();

        }

        /// <summary>
        /// Wyjście z menu ustawień
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (((MenuForm)Parent).GamePause) ((MenuForm)Parent).pause_panel.Visible = true;
            else ((MenuForm)Parent).main_panel.Visible = true;
           
                  
        }
    }
}
