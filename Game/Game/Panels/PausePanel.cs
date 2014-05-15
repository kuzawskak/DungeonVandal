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
    public partial class PausePanel : UserControl
    {
        public PausePanel()
        {
            InitializeComponent();
        }

        private void backToGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).game_panel.Visible = true;
            ((MenuForm)Parent).game_panel.GraphicsContainer.Focus();
            ((MenuForm)Parent).gameInstance.ContinueGame();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).settings_panel.GamePause = true;
            ((MenuForm)Parent).settings_panel.Visible = true;
            ((MenuForm)Parent).settings_panel.Focus();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).help_panel.Visible = true;

        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {
            //TODO: save game state
        }

        private void backtoMenuPanel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).main_panel.Visible = true;
        }
    }
}
