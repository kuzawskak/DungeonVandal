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
    public partial class SettingsPanel : UserControl
    {
        public bool GamePause = false;
        
        public SettingsPanel()
        {
            InitializeComponent();
        }

        private void audioButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).audio_settings_panel.Visible = true;
            ((MenuForm)Parent).audio_settings_panel.playBackgroundMusic();
            ((MenuForm)Parent).audio_settings_panel.startSoundPlayer();
          // ((MenuForm)Parent).audio_settings_panel.Focus();           

        }

        private void graphicsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).graphic_settings_panel.Visible = true;
            ((MenuForm)Parent).graphic_settings_panel.Focus();
        }

        private void keyboardButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).keyboard_settings_panel.Visible = true;
            ((MenuForm)Parent).keyboard_settings_panel.Focus();
        }

        private void defaultSettingsButton_Click(object sender, EventArgs e)
        {
            //przywroc ustawienia domyslne
            //TODO
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (GamePause) ((MenuForm)Parent).pause_panel.Visible = true;
            else ((MenuForm)Parent).main_panel.Visible = true;
                  
        }
    }
}
