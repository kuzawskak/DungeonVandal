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
    /// <summary>
    /// Panel pauzy
    /// </summary>
    public partial class PausePanel : UserControl
    {
        /// <summary>
        /// Konstruktor domyślny z WindowsForms
        /// </summary>
        public PausePanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Powrót do gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).game_panel.Visible = true;
            ((MenuForm)Parent).game_panel.GraphicsContainer.Focus();
            ((MenuForm)Parent).gameInstance.ContinueGame();
        }

        /// <summary>
        /// Wejście do menu ustawień
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).GamePause = true;
            ((MenuForm)Parent).settings_panel.Visible = true;
        }

        /// <summary>
        /// Wejscie do menu pomocy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).GamePause = true;
            ((MenuForm)Parent).help_panel.Visible = true;

        }

        /// <summary>
        /// Zapis stanu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveGameButton_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).gameInstance.SaveGameState();
            MessageBox.Show("Zapisano stan gry");
        }

        /// <summary>
        /// Powrót do menu głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backtoMenuPanel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).GamePause = true;
            ((MenuForm)Parent).main_panel.Visible = true;
        }
    }
}
