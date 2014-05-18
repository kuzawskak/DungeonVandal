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




namespace Game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game : Microsoft.Xna.Framework.Game
    {
        private readonly GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //time value not incremented when pause is on
        Song music;
        int totalMinutes = 0;
        int totalSeconds = 0;
        int lastUpdateMinutes = 0;
        int lastUpdateSeconds = 0;
        public int tile_size;
        public int map_width, map_height;
        bool move = false;
   
        public enum direction { left, up, right, down,none };

        private bool IsPaused;
        private Player player;
        private Map.Map map;
        private int LevelNumber;
        private int TargetCount;
        private TimeSpan CurrentTime;

        private System.Windows.Forms.Keys key_pressed = System.Windows.Forms.Keys.None;
        public MenuForm Form;

        //Game world
        private Characters.Vandal vandal;
        private Map.Map game_map;

        public void setMapDimension()
        {
            tile_size = 30;
            map_height = Form.ViewportSize.Height / tile_size;
            map_width = Form.ViewportSize.Width / tile_size;
            
        }


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


        void Game_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        void Game_Key(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            key_pressed = e.KeyCode;
            move = true;
        }

        void Game_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            key_pressed = System.Windows.Forms.Keys.None;
        }

        void MainGame_VisibleChanged(object sender, System.EventArgs e)
        {
            if (System.Windows.Forms.Control.FromHandle(Window.Handle).Visible)
                System.Windows.Forms.Control.FromHandle(Window.Handle).Visible = false;
        }

        void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = Form.CanvasHandle;
        }


        public void ContinueGame()
        {
            MediaPlayer.Resume();
            IsPaused = false;

        }

        private void PauseGame()
        {
            MediaPlayer.Pause();
            IsPaused = true;
            Form.Pause();
        }


        public Game(Game game)
        {
            //³adowanie z XML
            //przypisanie wszytkich pol
        }

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        void updateLabel(int minutes, int seconds)
        {
            
            totalMinutes += minutes;
            totalSeconds += seconds;
            Form.updateGameTime(totalMinutes, totalSeconds);
            Form.updatePoints(player.Points);
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
         
            vandal = new Characters.Vandal(this.Content, new Rectangle(1*tile_size, 1*tile_size, tile_size, tile_size), tile_size * map_width, tile_size * map_height);
            game_map = new Map.Map(tile_size, map_width, map_height, this.Content, player, vandal);
            music = Content.Load<Song>("background_music");
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
                    game_map.Update(vandal.Rectangle, gameTime);

                    if (key_pressed == System.Windows.Forms.Keys.None)
                    {
                        if (move)
                        {
                            // if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                            // vandal.SetFinalPosition(game_map);
                            move = false;
                            vandal.Move(direction.none);
                        }
                    }


                    else if (key_pressed == player.KeyboardSettings.Up)
                    {
                        if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                            vandal.Move(direction.up);
                    }
                    else if (key_pressed == player.KeyboardSettings.Down)
                    {
                        if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                            vandal.Move(direction.down);

                    }
                    else if (key_pressed == player.KeyboardSettings.Left)
                    {
                        if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                            vandal.Move(direction.left);
                    }
                    else if (key_pressed == player.KeyboardSettings.Right)
                    {
                        if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                            vandal.Move(direction.right);
                    }
                    else if (key_pressed == player.KeyboardSettings.Block)
                    {
                        if (gameTime.TotalGameTime.Milliseconds % 20 == 0)
                            vandal.changeDirectionToNext(game_map);
                    }
                    else if (key_pressed == player.KeyboardSettings.Dynamite)
                    {
                        if (player.Dynamite > 0)
                        {
                            vandal.LeftDynamite(game_map, gameTime);
                            key_pressed = System.Windows.Forms.Keys.None;
                        }
                        else
                        {
                            SoundEffect null_sound = Content.Load<SoundEffect>("null_sound");
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
                            vandal.AttackWithRacket(game_map);
                        else
                        {
                            SoundEffect.MasterVolume = (float)player.AudioSettings.SoundVolume;
                            SoundEffect null_sound = Content.Load<SoundEffect>("null_sound");
                            null_sound.Play();
                        }
                    }


                   
                    // vandal.LoadCurrentTexture(game_map);

                
            }
                base.Update(gameTime);
            
            lastUpdateMinutes = gameTime.TotalGameTime.Minutes;
            lastUpdateSeconds = gameTime.TotalGameTime.Seconds;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            if (!IsPaused)
            {
                GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);
                
                spriteBatch.Begin();
                
                game_map.Draw(spriteBatch);
                vandal.Draw(spriteBatch);

                spriteBatch.End();
                base.Draw(gameTime);
            }
        }
    }
}
