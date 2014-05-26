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
    /// Panel wyświetlany na zakończenie gry w przypadku przegranej
    /// </summary>
    public partial class GameOver : UserControl
    {
        /// <summary>
        /// Konstruktor domyślny, generowany przez WindowsForms
        /// </summary>
        public GameOver()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Ustawienie wyświetlanej liczby punktów
        /// </summary>
        /// <param name="points"></param>
        public void setScoreLabel(int points)
        {
            this.ScoreLabel.Text = "Twoj wynik to: "+ points.ToString();
        }

        /// <summary>
        /// Obsługa zamknięcia panelu (wyście z aplikacji)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Application.Exit();
        }

        /// <summary>
        /// Obsługa włączenia nowej gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameButton_Click(object sender, EventArgs e)
        {
            //start new game
            this.Visible = false;
            ((MenuForm)Parent).gameInstance = new Game((MenuForm)Parent, ((MenuForm)Parent).player);
            ((MenuForm)Parent).game_panel.Visible = true;

        }
    }
}
