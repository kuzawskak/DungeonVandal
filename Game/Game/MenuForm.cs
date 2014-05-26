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
using XMLManager.XMLObjects;
using Microsoft.Xna.Framework.Storage;


namespace DungeonVandal
{

    /// <summary>
    /// Główne okno aplikacji
    /// </summary>
    public partial class MenuForm : Form
    {
        public bool GamePause = false;
        public int ChoosenLevel = 1;
        /// <summary>
        /// Wszytkie panele aplikacji
        /// ( w zaleznosci od wyboru menu odpowiedni jest ustwiany na aktywny
        /// </summary>
        public MainPanel main_panel = new MainPanel();
        public PausePanel pause_panel = new PausePanel();
        public SettingsPanel settings_panel = new SettingsPanel();
        public AudioSettingsPanel audio_settings_panel = new AudioSettingsPanel();
        public KeyboardSettingsPanel keyboard_settings_panel = new KeyboardSettingsPanel();
        public PredefinedSettingsPanel predefined_settings_panel = new PredefinedSettingsPanel();
        public HelpPanel help_panel = new HelpPanel();
        public LoadGamePanel load_game_panel = new LoadGamePanel();  
        public BestScoresPanel best_scores_panel = new BestScoresPanel();
        public ChooseLevelPanel choose_level_panel = new ChooseLevelPanel();
        public XnaGamePanel game_panel = new XnaGamePanel();
        public GameOver game_over_panel = new GameOver();
        public Win win_panel = new Win();

        public Game.Game gameInstance;
        public Game.Player player = null;
        private Panel activePanel = null;

        /// <summary>
        /// Konstruktor głównego Form dla całej gry
        /// Na starcie ustawia panel logowania jako aktywny i tworzy instancję gracza
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
            InitializePanels();
          
            activePanel = LoginPanel;
            activePanel.Visible = true;
            player = new Game.Player();
        }

        /// <summary>
        /// Wyświetlenie okna z informacją o przegranej
        /// </summary>
        public void GameOver()
        {          
            game_panel.Visible = false;
            game_over_panel.setScoreLabel(player.Points);
            game_over_panel.Visible = true;
        }

        /// <summary>
        /// Wyświetlenie okna z informacją o wygranej
        /// </summary>
        public void Win()
        {
            game_panel.Visible = false;
            win_panel.setScoreLabel(player.Points);
            win_panel.Visible = true;
        }

        /// <summary>
        /// Inicjalizacja paneli WindowsForms (do obsługi menu)
        /// </summary>
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

            game_over_panel.Dock = DockStyle.Fill;
            this.Controls.Add(game_over_panel);
            game_over_panel.Visible = false;

            win_panel.Dock = DockStyle.Fill;
            this.Controls.Add(win_panel);
            win_panel.Visible = false;

            main_panel.Dock = DockStyle.Fill;
            this.Controls.Add(main_panel);
            main_panel.Visible = true;
  
        }

        /// <summary>
        /// Ustawienie aktualnie wyświetlanego panelu
        /// </summary>
        /// <param name="panel">nowy aktywny panel</param>
        public void setActivePanel(Panel panel)
        {
            activePanel.Visible = false;
            activePanel = panel;
            activePanel.Visible = true;
            GamePause = true;
        }


        /// <summary>
        /// Wskażnik na kontrolkę z oknem gry
        /// </summary>
        public IntPtr CanvasHandle
        {
            get { return game_panel.GraphicsContainer.Handle; }
        }

        /// <summary>
        /// Rozmiar okna gry
        /// </summary>
        public Size ViewportSize
        {
            get { return game_panel.GraphicsContainer.Size; }
        }


        /************PANEL STANU GRY******************/

        /// <summary>
        /// Aktualizacja nazwy gracza na panelu stanu gry
        /// </summary>
        /// <param name="player_name">nazwa gracza</param>
        public void setPlayerName(string player_name)
        {
            this.game_panel.playerName.Text = player_name;

        }

        /// <summary>
        /// Aktualizacja czasu gry na panelu stanu gry
        /// </summary>
        /// <param name="minutes">liczba minut</param>
        /// <param name="seconds">liczba sekund</param>
        public void updateGameTime(int minutes, int seconds)
        {
            string minutes_str = minutes == 0 ? "00" : minutes.ToString();
            if (minutes_str.Length == 1) minutes_str = "0" + minutes_str;
            string seconds_str = seconds == 0 ? "00" : seconds.ToString();
            if (seconds_str.Length == 1) seconds_str = "0" + seconds_str;
            this.game_panel.timeLabel.Text = minutes_str + ":" + seconds_str;
        }

        /// <summary>
        /// Aktualizacja liczby punktów na panelu stanu gry
        /// </summary>
        /// <param name="points">liczba zdobytych punktów</param>
        public void updatePoints(int points)
        {
            this.game_panel.pointsLabel.Text = points.ToString();
        }

        /// <summary>
        /// Aktualizacja licznika dynamitu na panelu stanu gry
        /// </summary>
        /// <param name="dynamite">ilość zdobytych dynamitów</param>
        public void updateDynamite(int dynamite)
        {
            this.game_panel.dynamiteCounter.Text = "x" + dynamite.ToString();
        }


        /// <summary>
        /// Aktualizacja licznika zdobytych rakiet na Panelu stanu gry 
        /// </summary>
        /// <param name="racket">ilość zdobytych rakiet</param>
        public void updateRacket(int racket)
        {
            this.game_panel.racketCounter.Text = "x" + racket.ToString();
        }

     
        /// <summary>
        /// Obsługa zamknięcia aplikacji
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit();
        }

        /// <summary>
        /// Obsługa pauzy z poziomu WindowsForms
        /// Ustawienie fokusu i widoczności dla panelu z Menu na czas Pauzy
        /// </summary>
        public void Pause()
        {

            GamePause = true;
            game_panel.Visible = false;
            pause_panel.Visible = true;

        }


        /***************** LOGIN PANEL **********************/

        /// <summary>
        /// Obsługa kliknięcia przycisku logowania
        /// automatycznie player jest rejestrowany
        /// (co oznacza ze przy pierwszym logowaniu tworzone są pliki ustawień dla danego gracza)
        /// </summary>
        /// <param name="sender">przycisk wysyłający sygnał logowania</param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        { 
            player = new Game.Player(usernameTextBox.Text);
            activePanel.Visible = false;
            main_panel.Visible = true;

            //jesli gracz ma zapisane jakies stany gry to odblokuj przycisk ładowania na głownym menu
            IAsyncResult result = StorageDevice.BeginShowSelector(PlayerIndex.One, null, null);
            GameState.GameStateData saved_data = GameState.LoadGameState(result, player.Name);
            if (saved_data.Count == 0)
            {
                //Pierwsze uruchomienie gry ( brak listy najlepszych wynikow dla danego poziomu)
                main_panel.EnableLoadButton(false);
            }
            else
            {
                main_panel.EnableLoadButton(true);
                load_game_panel.InitializeGameStatesList(saved_data);
            }

        }

        /// <summary>
        /// Walidacja logowania - przechodzą niezerowe ciągi znaków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).BackColor = System.Drawing.Color.Tomato;
                ((TextBox)sender).Refresh();
                Thread.Sleep(1000);
                ((TextBox)sender).BackColor = System.Drawing.Color.White;
                e.Cancel = true;
            }
          
        }


    }
}
