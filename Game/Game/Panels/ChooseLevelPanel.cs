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
    public partial class ChooseLevelPanel : UserControl
    {
        /// <summary>
        /// Wybrany przez gracza poziom ( spośród dostępnych)
        /// </summary>
        private int choosenLevel = 1;

        public ChooseLevelPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wyświetlenie panelu z najlepszymi wynikami dla poziomu 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scores1Button_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).best_scores_panel.UpdateForLevel(1);
            this.Visible = false;
            ((MenuForm)Parent).best_scores_panel.Visible = true;
        }

        /// <summary>
        /// Wyświetlenie panelu z najlepszymi wynikami dla poziomu 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scores2Button_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).best_scores_panel.UpdateForLevel(2);
            this.Visible = false;
            ((MenuForm)Parent).best_scores_panel.Visible = true;
        }

        /// <summary>
        /// Wyświetlenie panelu z najlepszymi wynikami dla poziomu 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scores3Button_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).best_scores_panel.UpdateForLevel(3);
            this.Visible = false;
            ((MenuForm)Parent).best_scores_panel.Visible = true;
        }

        /// <summary>
        /// Wyświetlenie panelu z najlepszymi wynikami dla poziomu 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scores4Button_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).best_scores_panel.UpdateForLevel(4);
            this.Visible = false;
            ((MenuForm)Parent).best_scores_panel.Visible = true;
        }

        /// <summary>
        /// Wyświetlenie panelu z najlepszymi wynikami dla poziomu 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scores5Button_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).best_scores_panel.UpdateForLevel(5);
            this.Visible = false;
            ((MenuForm)Parent).best_scores_panel.Visible = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Wyjscie do menu poprzedzającego (menu główne)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).ChoosenLevel = this.choosenLevel;
            this.Visible = false;
            ((MenuForm)Parent).main_panel.Visible = true;
            ((MenuForm)Parent).main_panel.Focus();
        }

        /// <summary>
        /// Wybór poziomu 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level1Button_Click(object sender, EventArgs e)
        {
            this.choosenLevel = 1;
        }

        /// <summary>
        /// Wybór poziomu 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level2Button_Click(object sender, EventArgs e)
        {
            this.choosenLevel = 2;
        }

        /// <summary>
        /// Wybór poziomu 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level3button_Click(object sender, EventArgs e)
        {
            this.choosenLevel = 3;
        }

        /// <summary>
        /// Wybór poziomu 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level4Button_Click(object sender, EventArgs e)
        {
            this.choosenLevel = 4;
        }

        /// <summary>
        /// Wybór poziomu 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level5Button_Click(object sender, EventArgs e)
        {
            this.choosenLevel = 5;
        }




    }
}
