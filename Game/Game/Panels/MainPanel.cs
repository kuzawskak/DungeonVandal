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
    /// <summary>
    /// Główne menu gry 9pojawia się bezpośrednio po zalogowaniu użytkownika)
    /// </summary>
    public partial class MainPanel : UserControl
    {
        /// <summary>
        /// Konstruktor domyślny generowany przez WindowsForms
        /// </summary>
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
            ((MenuForm)Parent).load_game_panel.Visible = true;   
            
         
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

        }

        /// <summary>
        /// Wyświetl pomoc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpButton_Click(object sender, EventArgs e)
        {
            ((MenuForm)Parent).GamePause = false;
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
               
                form.gameInstance.clearGameState();

            }
            else
            {
                form.gameInstance = new Game(form, form.player);
                thread = new Thread(new ThreadStart(form.gameInstance.Run));
                thread.Start();
            }
            ((MenuForm)Parent).game_panel.GraphicsContainer.Focus();
        }
    }
}
