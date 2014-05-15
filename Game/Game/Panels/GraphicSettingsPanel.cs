using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DungeonVandal;

namespace Game.Panels
{
    public partial class GraphicSettingsPanel : UserControl
    {

        public GraphicSettingsPanel()
        {
            InitializeComponent();
        }

        private void monochromaticCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void contrastTrackbar_Scroll(object sender, EventArgs e)
        {

        }

        private void brightnessTrackbar_Scroll(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).player.GraphicsSettings = new Settings.GraphicsSettings((double)brightnessTrackbar.Value / 10, (double)contrastTrackbar.Value / 10, monochromaticCheckbox.Checked);
            this.Visible = false;
            ((MenuForm)Parent).settings_panel.Visible = true;
        }
    }
}
