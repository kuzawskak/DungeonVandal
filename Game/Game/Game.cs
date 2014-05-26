using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Windows.Forms;
using DungeonVandal;
using XMLManager.XMLObjects;
using Microsoft.Xna.Framework.Storage;


namespace Game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game : Microsoft.Xna.Framework.Game
    {
        private readonly GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Song music;
        /// <summary>
        /// Sumaryczna liczba minut gry ( nie naliczany w trakcie pauzy)
        /// </summary>
        int totalMinutes = 0;
        /// <summary>
        /// Sumaryczna liczba sekund gry ( nie naliczana w trakcie pauzy)
        /// </summary>
        int totalSeconds = 0;
        int lastUpdateMinutes = 0;
        int lastUpdateSeconds = 0;
        /// <summary>
        /// rozmiar komórki mapy
        /// </summary>
        public int tile_size;
        /// <summary>
        /// Szerokosc i wysokosc mapy
        /// </summary>
        public int map_width, map_height;

        /// <summary>
        /// czy obiekt na mapie porusza sie
        /// </summary>
        bool move = false;

        /// <summary>
        /// Kierunek poruszania
        /// </summary>
        public enum direction { left, up, right, down, none };

        /// <summary>
        /// Stan gry (czy pauza w³¹czona)
        /// </summary>
        private bool IsPaused;
        /// <summary>
        /// Instancja gracza
        /// </summary>
        private Player player;

        /// <summary>
        /// Dane gry do za³adowania w przypadku wyboru zapisanej gry
        /// </summary>
        GameState.GameStateData data_to_load = new GameState.GameStateData(0);
        /// <summary>
        /// Indeks wybranej gry do za³adowania
        /// </summary>
        int data_index;
        /// <summary>
        /// Stan klawiatury
        /// </summary>
        private System.Windows.Forms.Keys key_pressed = System.Windows.Forms.Keys.None;
        /// <summary>
        /// Wka¿nik na g³ówne okno aplikacji
        /// </summary>
        public MenuForm Form;

        /// <summary>
        /// Mapa gry
        /// </summary>
        private Map.Map game_map;

        /// <summary>
        /// Ustawienie wymiarów mapy
        /// </summary>
        public void setMapDimension()
        {
            tile_size = 30;
            map_height = Form.ViewportSize.Height / tile_size;
            map_width = Form.ViewportSize.Width / tile_size;

        }

        /// <summary>
        /// Konstruktor dla nowej gry
        /// </summary>
        /// <param name="form">WskaŸnik do okna aplikacji</param>
        /// <param name="player">Instancja gracza</param>
        public Game(DungeonVandal.MenuForm form, Player player)
        {
            Form = form;
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = Form.ViewportSize.Width,
                PreferredBackBufferHeight = Form.ViewportSize.Height
            };

            this.player = player;
            Form.setPlayerName(player.Name);
            graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
            System.Windows.Forms.Control.FromHandle(Window.Handle).VisibleChanged += MainGame_VisibleChanged;
            System.Windows.Forms.Control.FromHandle(Form.Handle).KeyUp += new System.Windows.Forms.KeyEventHandler(Game_KeyUp);
            System.Windows.Forms.Control.FromHandle(Form.Handle).KeyPress += new System.Windows.Forms.KeyPressEventHandler(Game_KeyPress);
            System.Windows.Forms.Control.FromHandle(Form.Handle).KeyDown += new System.Windows.Forms.KeyEventHandler(Game_Key);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        public void clearGameState()
        {
            player.Points = 0;
            player.Dynamite = 0;
            player.Rackets = 0;
            totalMinutes = 0;
            totalSeconds = 0;

        }



        /// <summary>
        /// Konstruktor ³aduj¹cy zapisan¹ grê
        /// </summary>
        /// <param name="form"> WskaŸnik do okna gry</param>
        /// <param name="player">Instancja gracza</param>
        /// <param name="game_state_data_to_load">Dane stany gry do ³adowania</param>
        /// <param name="data_index">Indeks danych w tablicy stanów gry</param>
        public Game(DungeonVandal.MenuForm form, Player player, GameState.GameStateData game_state_data_to_load, int data_index)
        {
            Form = form;
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = Form.ViewportSize.Width,
                PreferredBackBufferHeight = Form.ViewportSize.Height
            };

            data_to_load = game_state_data_to_load;
            this.data_index = data_index;
            this.player = player;
            this.player.Dynamite = data_to_load.Dynamites[data_index];
            this.player.Points = data_to_load.Points[data_index];
            this.player.Rackets = data_to_load.Rackets[data_index];
            totalMinutes = data_to_load.TotalMinutes[data_index];
            totalSeconds = data_to_load.TotalSeconds[data_index];
            Form.setPlayerName(player.Name);
            graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
            System.Windows.Forms.Control.FromHandle(Window.Handle).VisibleChanged += MainGame_VisibleChanged;
            System.Windows.Forms.Control.FromHandle(Form.Handle).KeyUp += new System.Windows.Forms.KeyEventHandler(Game_KeyUp);
            System.Windows.Forms.Control.FromHandle(Form.Handle).KeyPress += new System.Windows.Forms.KeyPressEventHandler(Game_KeyPress);
            System.Windows.Forms.Control.FromHandle(Form.Handle).KeyDown += new System.Windows.Forms.KeyEventHandler(Game_Key);
            System.Windows.Forms.Control.FromHandle(Form.Handle).PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(Game_PreviewKeyDown);
             
            Content.RootDirectory = "Content";

            IsMouseVisible = true;
        }


        void Game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            key_pressed = e.KeyCode;
            move = true;
        }
        void Game_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        /// <summary>
        /// Obs³uga wciœniêcia klawisza klawiatury
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Game_Key(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            key_pressed = e.KeyCode;
            move = true;
        }

        /// <summary>
        /// Obs³uga zwolnienia klawisza klawiatury
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Game_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            key_pressed = System.Windows.Forms.Keys.None;
        }

        /// <summary>
        /// Obs³uga zmiany widzialnoœci panelu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainGame_VisibleChanged(object sender, System.EventArgs e)
        {
            if (System.Windows.Forms.Control.FromHandle(Window.Handle).Visible)
                System.Windows.Forms.Control.FromHandle(Window.Handle).Visible = false;
        }

        /// <summary>
        /// Przygotowanie ustawieñ grafiki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = Form.CanvasHandle;
        }

        /// <summary>
        /// Kontynuowanie gry
        /// </summary>
        public void ContinueGame()
        {
            MediaPlayer.Resume();
            IsPaused = false;
        }

        /// <summary>
        /// Zatrzymanie gry na czas pauzy
        /// </summary>
        private void PauseGame()
        {
            MediaPlayer.Pause();
            IsPaused = true;
            Form.Pause();
        }

        /// <summary>
        /// Zakonczenie gry w przypadku przegranej
        /// </summary>
        private void GameOver()
        {
            MediaPlayer.Pause();
            IsPaused = true;
            Form.GameOver();
        }

        /// <summary>
        /// Zatrzymanie gry w przypadku wygranej
        /// </summary>
        private void Win()
        {
            MediaPlayer.Pause();
            IsPaused = true;
            Form.Win();
        }


        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Aktualizacja paska stanu gry
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        void updateLabel(int minutes, int seconds)
        {
            totalMinutes += minutes;
            totalSeconds += seconds;
            Form.updateGameTime(totalMinutes, totalSeconds);
            Form.updatePoints(0);
            Form.updateRacket(player.Rackets);
            Form.updateDynamite(player.Dynamite);
            Form.setPlayerName(player.Name);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            //inicjalizacja wszytkich pol prywatnych 
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            setMapDimension();
            if (data_to_load.Count != 0)
            {

                game_map = new Map.Map(tile_size, map_width, map_height, data_to_load.GameMaps[data_index], this.Content, player);
            }
            else
            {
                game_map = new Map.Map(tile_size, map_width, map_height, this.Content, player);
            }
            music = Content.Load<Song>("Audio\\background_music");
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(music);
            MediaPlayer.Volume = (float)player.AudioSettings.MusicVolume;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {


            // Allows the game to exit
            if (!IsPaused)
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                    this.Exit();


                updateLabel(gameTime.TotalGameTime.Minutes - lastUpdateMinutes, gameTime.TotalGameTime.Seconds - lastUpdateSeconds);

                game_map.Update(gameTime);


                if (key_pressed == System.Windows.Forms.Keys.None)
                {
                    if (move)
                    {
                        // if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                        // vandal.SetFinalPosition(game_map);
                        move = false;
                        game_map.MoveVandal(direction.none);
                    }
                }


                else if (key_pressed == player.KeyboardSettings.Up)
                {
                    if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                        game_map.MoveVandal(direction.up);
                }
                else if (key_pressed == player.KeyboardSettings.Down)
                {
                     
                   if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                        game_map.MoveVandal(direction.down);

                }
                else if (key_pressed == player.KeyboardSettings.Left)
                {

                    if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                    {
                        game_map.MoveVandal(direction.left);
                    }
                }
                else if (key_pressed == player.KeyboardSettings.Right)
                {
                    if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                        game_map.MoveVandal(direction.right);
                }
                else if (key_pressed == player.KeyboardSettings.Block)
                {
                    if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                        game_map.GetVandal().changeDirectionToNext(game_map);
                }
                else if (key_pressed == player.KeyboardSettings.Dynamite)
                {
                    if (player.Dynamite > 0)
                    {
                        game_map.GetVandal().LeftDynamite(game_map, gameTime);
                        key_pressed = System.Windows.Forms.Keys.None;
                    }
                    else
                    {
                        SoundEffect null_sound = Content.Load<SoundEffect>("Audio\\null_sound");
                        SoundEffect.MasterVolume = (float)player.AudioSettings.SoundVolume;
                        null_sound.Play();


                    }
                }
                else if (key_pressed == player.KeyboardSettings.Pause)
                {

                    PauseGame();
                }
                else if (key_pressed == player.KeyboardSettings.Racket)
                {
                    if (player.Rackets > 0)
                        game_map.GetVandal().AttackWithRacket(game_map);
                    else
                    {
                        SoundEffect.MasterVolume = (float)player.AudioSettings.SoundVolume;
                        SoundEffect null_sound = Content.Load<SoundEffect>("Audio\\null_sound");
                        null_sound.Play();
                    }
                }



                // vandal.LoadCurrentTexture(game_map);

                if (game_map.GetVandal().level_up)
                {
                    int current_level = game_map.gameLevel;
                    if (current_level < 5)
                    {                      
                        game_map = new Map.Map(tile_size, map_width, map_height, this.Content, player,current_level + 1);
                    }
                    else
                    {
                        SaveHighScore();

                        Win();
                    }
                }
            }
            if (!game_map.GetVandal().is_alive)
            {
                SaveHighScore();
                GameOver();
            }

            else
            {
                base.Update(gameTime);

                lastUpdateMinutes = gameTime.TotalGameTime.Minutes;
                lastUpdateSeconds = gameTime.TotalGameTime.Seconds;
            }
        }

        /// <summary>
        /// Funkcja XNA wywyo³ywana do odrysowania obiektów
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            if (!IsPaused)
            {
                GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);

                spriteBatch.Begin();
                game_map.Draw(spriteBatch);
                spriteBatch.End();
                base.Draw(gameTime);
            }
        }

        /// <summary>
        /// Zapis stanu gry do pliku zwi¹zanego z aktualnym graczem
        /// </summary>
        public void SaveGameState()
        {
            // Create the data to save
            IAsyncResult result = StorageDevice.BeginShowSelector(PlayerIndex.One, null, null);
            //za³adowanie pliku z wynikami dla odpowiedniego poziomu
            GameState.GameStateData saved_data = GameState.LoadGameState(result, player.Name);
            GameState.GameStateData new_saved_data = new GameState.GameStateData(saved_data.Count + 1, game_map.getWidth(), game_map.getHeight());
            for (int i = 0; i < saved_data.Count; i++)
            {
                new_saved_data.Date[i] = saved_data.Date[i];
                new_saved_data.Dynamites[i] = saved_data.Dynamites[i];
                new_saved_data.Rackets[i] = saved_data.Rackets[i];
                new_saved_data.Points[i] = saved_data.Points[i];
                new_saved_data.Levels[i] = saved_data.Levels[i];
                new_saved_data.TotalMinutes[i] = saved_data.TotalMinutes[i];
                new_saved_data.TotalSeconds[i] = saved_data.TotalSeconds[i];
                new_saved_data.Intelligence[i] = saved_data.Intelligence[i];
                new_saved_data.GameMaps[i] = saved_data.GameMaps[i];
            }

            new_saved_data.Date[new_saved_data.Count - 1] = System.DateTime.Now.ToString();
            new_saved_data.Dynamites[new_saved_data.Count - 1] = player.Dynamite;
            new_saved_data.Rackets[new_saved_data.Count - 1] = player.Rackets;
            new_saved_data.Points[new_saved_data.Count - 1] = player.Points;
            new_saved_data.Levels[new_saved_data.Count - 1] = game_map.gameLevel;
            new_saved_data.TotalMinutes[new_saved_data.Count - 1] = totalMinutes;
            new_saved_data.TotalSeconds[new_saved_data.Count - 1] = totalSeconds;
            new_saved_data.Intelligence[new_saved_data.Count - 1] = player.IntelligenceLevel;
            new_saved_data.GameMaps[new_saved_data.Count - 1] = game_map.getIntMap();

            GameState.gameStateToSave = new_saved_data;
            GameState.SaveToDevice(result, player.Name);
            Form.load_game_panel.updateListItems(new_saved_data.Date[new_saved_data.Count - 1]);


        }

        /// <summary>
        /// Zapis wyniku obecnego gracza do listy najlepszych (pod warunkiem , ¿e mieœci siê w 5 najlepeszych z danego poziomu)
        /// </summary>
        private void SaveHighScore()
        {
            // Create the data to save
            IAsyncResult result = StorageDevice.BeginShowSelector(PlayerIndex.One, null, null);
            //za³adowanie pliku z wynikami dla odpowiedniego poziomu
            HighScores.HighScoreData saved_data = HighScores.LoadHighScores(result, game_map.gameLevel);
            HighScores.HighScoreData new_highscores;
            if (saved_data.Count < 5)
            {
                //Pierwsze uruchomienie gry ( brak listy najlepszych wynikow dla danego poziomu)
                new_highscores = new HighScores.HighScoreData(saved_data.Count + 1);
                if (saved_data.Count != 0)
                {
                    for (int i = 0; i < saved_data.Count; i++)
                    {
                        new_highscores.PlayerName[i] = saved_data.PlayerName[i];
                        new_highscores.Score[i] = saved_data.Score[i];
                        new_highscores.Time[i] = saved_data.Time[i];
                    }
                }

            }
            else new_highscores = saved_data;

            int scoreIndex = -1;
            for (int i = 0; i < new_highscores.Count; i++)
            {
                if (player.Points > new_highscores.Score[i])
                {
                    scoreIndex = i;
                    break;
                }
            }

            if (scoreIndex > -1)
            {
                //Nowy high score znaleziony  (przeskakiwanie wynikow)
                for (int i = new_highscores.Count - 1; i > scoreIndex; i--)
                {
                    new_highscores.PlayerName[i] = new_highscores.PlayerName[i - 1];
                    new_highscores.Score[i] = new_highscores.Score[i - 1];
                }
                new_highscores.PlayerName[scoreIndex] = player.Name;
                new_highscores.Score[scoreIndex] = player.Points;
                string minutes_str = totalMinutes == 0 ? "00" : totalMinutes.ToString();
                if (minutes_str.Length == 1) minutes_str = "0" + minutes_str;
                string seconds_str = totalSeconds == 0 ? "00" : totalSeconds.ToString();
                if (seconds_str.Length == 1) seconds_str = "0" + seconds_str;
                new_highscores.Time[scoreIndex] = minutes_str + ":" + seconds_str;
            }
            HighScores.highScoreToSave = new_highscores;
            HighScores.SaveToDevice(result, game_map.gameLevel);
        }
    }


}
