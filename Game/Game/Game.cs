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
       /*   const Settings.KeySettings[] Predefined = new Settings.KeySettings[3]{new Settings.KeySettings(),
            new Settings.KeySettings(),
            new Settings.KeySettings()};
        */
        public enum direction { left, up, right, down };
        private bool IsPaused;
        private Player player;
        private Map.Map map;
        private int LevelNumber;
        private int TargetCount;
        private TimeSpan CurrentTime;
        private Settings.KeySettings CurKeySettings;
        private Settings.AudioSettings CurAudioSettings;
        private Settings.GraphicsSettings CurGraphicsSettings;
        private System.Windows.Forms.Keys key_pressed = System.Windows.Forms.Keys.None;
        public MenuForm Form;
        
        //Game world
        private Characters.Vandal vandal;      
        private Map.Map game_map;


        public void setMapDimension()
        {
            tile_size = 50;
            map_height   =  Form.ViewportSize.Height/tile_size;
            map_width = Form.ViewportSize.Width/tile_size;

        }


       public Game(DungeonVandal.MenuForm form,string player_name)
        {
            Form = form;
           
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = Form.ViewportSize.Width,
                PreferredBackBufferHeight = Form.ViewportSize.Height
            };

            player = new Player(player_name);
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
           //   MessageBox.Show(e.KeyCode.ToString());
         //  key_pressed = (System.Windows.Forms.Keys)e.KeyChar;
          // move = true;
       }

        void Game_Key(object sender, System.Windows.Forms.KeyEventArgs e)
        {
         //   MessageBox.Show(e.KeyCode.ToString());
           // MessageBox.Show(e.KeyCode.ToString());
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
            IsPaused = false;
        }

        private void PauseGame()
        {
            IsPaused = true;
            Form.Pause();
        }


        public Game(Game game)
        {
            //�adowanie z XML
            //przypisanie wszytkich pol
        }

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        void updateLabel(int minutes, int seconds)
        {
            totalMinutes+=minutes;
            totalSeconds+=seconds;
            Form.updateGameTime(totalMinutes,totalSeconds);
            Form.updatePoints(player.Points);
            Form.updateRacket(player.Rackets);
            Form.updateDynamite(player.Dynamite);
            
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
            game_map = new Map.Map(tile_size,map_width, map_height,this.Content,player);
            vandal = new Characters.Vandal(this.Content, new Rectangle(0, 0, tile_size, tile_size),tile_size*map_width,tile_size*map_height);
            music = Content.Load<Song>("background_music");
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(music);
           
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


                switch (key_pressed)
                {

                    case (System.Windows.Forms.Keys.None):
                        if (move)
                        {
                            vandal.SetFinalPosition(game_map);
                            move = false;
                        }
                        break;
                    case (System.Windows.Forms.Keys.W):

                        vandal.Move(direction.up,game_map);
                        break;


                    case (System.Windows.Forms.Keys.S):

                        vandal.Move(direction.down,game_map);
                        break;

                    case (System.Windows.Forms.Keys.A):

                        vandal.Move(direction.left,game_map);
                        break;

                    case (System.Windows.Forms.Keys.D):

                        vandal.Move(direction.right,game_map);
                        break;
                    case (System.Windows.Forms.Keys.Menu):
                      //  Form.setPlayerName("alt");
                        vandal.changeDirectionToNext(game_map);
                        break;
                    case (System.Windows.Forms.Keys.Return):
                        if (player.Dynamite > 0)
                            vandal.LeftDynamite(game_map,gameTime);
                        else
                        {
                            SoundEffect null_sound = Content.Load<SoundEffect>("null_sound");
                            null_sound.Play();
                        }
                        break;
                    case (System.Windows.Forms.Keys.Escape):
                        //go back to main menu
                        PauseGame();

                        break;
                    case (System.Windows.Forms.Keys.ShiftKey):
                        if(player.Rackets>0)
                        vandal.AttackWithRacket(game_map);
                        else 
                        {
                            SoundEffect null_sound = Content.Load<SoundEffect>("null_sound");
                            null_sound.Play();
                        }
                        break;

                    default:
                        break;
                }
                vandal.LoadCurrentTexture(game_map);
                /*  for(int i = 0;i<dynamites.Capacity;)
                  {
                      if(dynamites[i].Rectangle.Intersects(vandal.Rectangle))
                      { 
                         // dynamites.Remove(dynamites[i]);
                          player.Dynamite++;
                      }
                      //else
                      i++;

                     // d.Update();
                  }*/

                // TODO: Add your update logic here

                base.Update(gameTime);
            }
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
