using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using System.Threading;
using DungeonVandal;
using Game.Panels;

namespace Game.Panels
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Włącz lub wyłącz obsługe przycisku ładowania gry w zależności od 
        /// tego czy gracz ma zapisane stany gry
        /// </summary>
        /// <param name="enable"></param>
        public void EnableLoadButton(bool enable)
        {
            LoadGameButton.Enabled = enable;
        }


        /// <summary>
        /// Wyświetl menu ładowania zapisanej gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            XnaGamePanel game_panel = ((MenuForm)Parent).game_panel;
            MenuForm form = (MenuForm)Parent;
            game_panel.Visible = true;           
            form.gameInstance = new Game(form, form.player);
            Thread thread = new Thread(new ThreadStart(form.gameInstance.Run));
            thread.Start();
            game_panel.GraphicsContainer.Focus();
        }


        /// <summary>
        /// Wyświetl menu wyboru poziomu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseLevelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).GamePause = false;
            ((MenuForm)Parent).choose_level_panel.Visible = true;
            ((MenuForm)Parent).choose_level_panel.Focus();
        }


        /// <summary>
        /// Wyświetl menu ustawień
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ((MenuForm)Parent).GamePause = false;
            ((MenuForm)Parent).settings_panel.Visible = true;
            ((MenuForm)Parent).settings_panel.Focus();

        }

        /// <summary>
        /// Wyświetl pomoc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpPanel help_panel = ((MenuForm)Parent).help_panel;
            this.Visible = false;
            help_panel.Visible = true;
        }

        /// <summary>
        /// Wyłącz całkowicie aplikację
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Wątek w ktorym uruchamiana jest gra
        /// </summary>
        Thread thread;

        /// <summary>
        /// Rozpocznij nową grę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameButton_Click_1(object sender, EventArgs e)
        {
            
            MenuForm form = (MenuForm)Parent;
            ((MenuForm)Parent).game_panel.Visible = true;
            this.Visible = false;
            //kliknięcie nowej gry w trakcie pauzy kończy dotychczasowa grę i uruchamia nową instancję
            if (((MenuForm)Parent).GamePause)
            {
                form.gameInstance.Exit();
                ((MenuForm)Parent).GamePause = false;
            }

            form.player = new Player(form.player.Name);
            form.gameInstance = new Game(form, form.player);
            thread = new Thread(new ThreadStart(form.gameInstance.Run));
            thread.Start();
            ((MenuForm)Parent).game_panel.GraphicsContainer.Focus();
        }
    }
}
