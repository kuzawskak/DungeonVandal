using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Windows.Forms;
using System.Threading;
using Game.Panels;


namespace DungeonVandal
{
    public partial class MenuForm : Form
    {

        /// <summary>
        /// Wszytkie panele aplikacji
        /// ( w zaleznosci od wyboru menu odpowiedni jest ustwiany na aktywny
        /// </summary>
        public MainPanel main_panel = new MainPanel();
        public PausePanel pause_panel = new PausePanel();
        public SettingsPanel settings_panel = new SettingsPanel();
        public AudioSettingsPanel audio_settings_panel = new AudioSettingsPanel();
        public GraphicSettingsPanel graphic_settings_panel = new GraphicSettingsPanel();
        public KeyboardSettingsPanel keyboard_settings_panel = new KeyboardSettingsPanel();
        public PredefinedSettingsPanel predefined_settings_panel = new PredefinedSettingsPanel();
        public HelpPanel help_panel = new HelpPanel();
        public LoadGamePanel load_game_panel = new LoadGamePanel();  
        public BestScoresPanel best_scores_panel = new BestScoresPanel();
        public ChooseLevelPanel choose_level_panel = new ChooseLevelPanel();
        public XnaGamePanel game_panel = new XnaGamePanel();


        public Game.Game gameInstance;
        public Game.Player player = null;
        private Panel activePanel = null;

        public MenuForm()
        {
            InitializeComponent();
            InitializePanels();
          
            activePanel = LoginPanel;
            activePanel.Visible = true;
            player = new Game.Player();
        }

        public void InitializePanels()
        {
            pause_panel.Dock = DockStyle.Fill;
            this.Controls.Add(pause_panel);
            pause_panel.Visible = false;

            settings_panel.Dock = DockStyle.Fill;
            this.Controls.Add(settings_panel);
            settings_panel.Visible = false;

            keyboard_settings_panel.Dock = DockStyle.Fill;
            this.Controls.Add(keyboard_settings_panel);
            keyboard_settings_panel.Visible = false;

            audio_settings_panel.Dock = DockStyle.Fill;
            this.Controls.Add(audio_settings_panel);
            audio_settings_panel.Visible = false;

            graphic_settings_panel.Dock = DockStyle.Fill;
            this.Controls.Add(graphic_settings_panel);
            graphic_settings_panel.Visible = false;

            predefined_settings_panel.Dock = DockStyle.Fill;
            this.Controls.Add(predefined_settings_panel);
            predefined_settings_panel.Visible = false;

            help_panel.Dock = DockStyle.Fill;
            this.Controls.Add(help_panel);
            help_panel.Visible = false;

            load_game_panel.Dock = DockStyle.Fill;
            this.Controls.Add(load_game_panel);
            load_game_panel.Visible = false;

            best_scores_panel.Dock = DockStyle.Fill;
            this.Controls.Add(best_scores_panel);
            best_scores_panel.Visible = false;

            choose_level_panel.Dock = DockStyle.Fill;
            this.Controls.Add(choose_level_panel);
            choose_level_panel.Visible = false;

            game_panel.Dock = DockStyle.Fill;
            this.Controls.Add(game_panel);
            game_panel.Visible = false;

            main_panel.Dock = DockStyle.Fill;
            this.Controls.Add(main_panel);
            main_panel.Visible = true;

  
        }

        public void setActivePanel(Panel panel)
        {
            activePanel.Visible = false;
            activePanel = panel;
            activePanel.Visible = true;
        }



        public IntPtr CanvasHandle
        {
            get { return game_panel.GraphicsContainer.Handle; }
        }

        public Size ViewportSize
        {
            get { return game_panel.GraphicsContainer.Size; }
        }

        public void setPlayerName(string player_name)
        {
            this.game_panel.playerName.Text = player_name;

        }

        public void updateGameTime(int minutes, int seconds)
        {
            string minutes_str = minutes == 0 ? "00" : minutes.ToString();
            if (minutes_str.Length == 1) minutes_str = "0" + minutes_str;
            string seconds_str = seconds == 0 ? "00" : seconds.ToString();
            if (seconds_str.Length == 1) seconds_str = "0" + seconds_str;
            this.game_panel.timeLabel.Text = minutes_str + ":" + seconds_str;
        }

        public void updatePoints(int points)
        {
            this.game_panel.pointsLabel.Text = points.ToString();
        }

        public void updateDynamite(int dynamite)
        {
            this.game_panel.dynamiteCounter.Text = "x" + dynamite.ToString();
        }

        public void updateRacket(int racket)
        {
            this.game_panel.racketCounter.Text = "x" + racket.ToString();
        }

     

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit();
        }

        public void Pause()
        {
            game_panel.Visible = false;
            pause_panel.Visible = true;
            pause_panel.Focus();

        }

       /*
        * BUTTON CLICK HANDLERS
        */

        /***************** LOGIN PANEL **********************/
        private void loginButton_Click(object sender, EventArgs e)
        {
            //TODO: 
            //validate(loginButton.Text)
            player.Name =  usernameTextBox.Text;          
            activePanel.Visible = false;
            main_panel.Visible = true;
        }


        /*************** PAUSE MENU PANEL **********************/
        private void continueGameButton_Click(object sender, EventArgs e)
        {
            //TODO: go back to game
          //  PausePanel.Visible = false;
           game_panel.Visible = true;
            game_panel.GraphicsContainer.Focus();
            gameInstance.ContinueGame();
        }

        private void settingsPauseButton_Click(object sender, EventArgs e)
        {
            //TODO:show settings menu
        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {
            //TODO:save game state in xml
        }

        private void backMainMenuButton_Click(object sender, EventArgs e)
        {
            //TODO: go to main menu - save instance game for player in XML file firstly
            //PausePanel.Visible = false;
            //MenuPanel.Visible = true;
            //MenuPanel.Focus();
        }




    }
}
