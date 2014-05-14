using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game.Panels
{
    public partial class SettingsPanel : UserControl
    {

        public SettingsPanel()
        {
            InitializeComponent();
        }

        private void audioButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AudioSettingsPanel audio_settings_panel = new AudioSettingsPanel();
            this.Parent.Controls.Add(audio_settings_panel);
            audio_settings_panel.Dock = DockStyle.Fill;
            //audio_settings_panel.Show();

        }

        private void graphicsButton_Click(object sender, EventArgs e)
        {
           // GraphicSettingsPanel graphic_settings_panel = new GraphicSettingsPanel(player);

        }

        private void keyboardButton_Click(object sender, EventArgs e)
        {

        }

        private void defaultSettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Parent.Visible = true;
            this.Parent.Controls.Remove(this);
           
        }
    }
}
