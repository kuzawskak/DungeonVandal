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
    public partial class Win : UserControl
    {
        public Win()
        {
            InitializeComponent();
        }
        public void setScoreLabel(int points)
        {
            this.scoreLabel.Text = "Twoj wynik to: " + points.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //start new game
            this.Visible = false;
            ((MenuForm)Parent).gameInstance = new Game((MenuForm)Parent, ((MenuForm)Parent).player);
            ((MenuForm)Parent).game_panel.Visible = true;
        }
    }
}
