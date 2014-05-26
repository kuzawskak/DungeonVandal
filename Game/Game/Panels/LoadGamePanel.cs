using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XMLManager.XMLObjects;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework;
using DungeonVandal;
using System.Threading;

namespace Game.Panels
{
    /// <summary>
    /// Panel ładowania zapisanej gry
    /// </summary>
    public partial class LoadGamePanel : UserControl
    {
        public LoadGamePanel()
        {
            InitializeComponent();
        
        }

        /// <summary>
        /// Wypelnienie ListBox-a ze stanami gry do wyboru
        /// </summary>
        /// <param name="player_data">Dane pobrane z pliku XML z zapisanymi stanami gry</param>
        public void InitializeGameStatesList(GameState.GameStateData player_data)
        {
            for (int i = 0; i < player_data.Count; i++)
            {
                gameStatesList.Items.Add(player_data.Date[i]);
            }
        }
    
        /// <summary>
        /// Dodanie nowego stanu gry do listy zapisanych
        /// </summary>
        /// <param name="game_state"></param>
        public void updateListItems(string game_state)
        {
            gameStatesList.Items.Add(game_state);
            ((MenuForm)Parent).main_panel.EnableLoadButton(true);
        }

        /// <summary>
        /// Wybór jednej z zapisanych gier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameStatesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            //load game
     
            int index_in_xml = gameStatesList.SelectedIndex;
            MessageBox.Show(index_in_xml.ToString());
            // Create the data to save
            IAsyncResult result = StorageDevice.BeginShowSelector(PlayerIndex.One, null, null);
            //załadowanie pliku z wynikami dla odpowiedniego poziomu
            GameState.GameStateData saved_data = GameState.LoadGameState(result,( (MenuForm)Parent).player.Name);
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
            form.gameInstance = new Game(form, form.player,saved_data,index_in_xml);
            Thread thread = new Thread(new ThreadStart(form.gameInstance.Run));
            thread.Start();
            ((MenuForm)Parent).game_panel.GraphicsContainer.Focus();

           
        }
    }
}
