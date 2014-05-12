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
        KeyboardState oldState;

       /*   const Settings.KeySettings[] Predefined = new Settings.KeySettings[3]{new Settings.KeySettings(),
            new Settings.KeySettings(),
            new Settings.KeySettings()};
        */
        public enum direction { left, up, right, down };
        bool move = false;
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
        public DungeonVandal.MenuForm Form;
        
        //Game world
        private Characters.Vandal vandal;
      
        private Map.Map game_map;

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
            System.Windows.Forms.Control.FromHandle(Form.Handle).KeyDown += new System.Windows.Forms.KeyEventHandler(Game_Key);
           // System.Windows.Forms.Control.FromHandle(Form.Handle).KeyPress += new System.Windows.Forms.KeyPressEventHandler(Game_KeyPress);
           Content.RootDirectory = "Content";
   
            IsMouseVisible = true;
        }

       void Game_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
       {
           //key_pressed = (System.Windows.Forms.Keys)e.KeyChar;
       }

        void Game_Key(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if(e.KeyCode==System.Windows.Forms.Keys.Enter)

            if (e.KeyCode == System.Windows.Forms.Keys.Space)
               // Application.ExitThread();
            key_pressed = e.KeyCode;
           // move = true;
        }

        void Game_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            key_pressed = System.Windows.Forms.Keys.None;
            move = true;
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


        public void RestartGame()
        {
            IsPaused = false;
        }

        public void PauseGame()
        {
            IsPaused = true;
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


        void updateLabel(GameTime gameTime)
        {
            Form.updateGameTime(gameTime.TotalGameTime.Minutes, gameTime.TotalGameTime.Seconds);
            Form.updatePoints(player.Points);
            Form.updateRacket(player.Rackets);
            Form.updateDynamite(player.Dynamite);
            
        }

        private void UpdateInput()
        {
            KeyboardState newState = Keyboard.GetState();

            // Is the SPACE key down?
            if (newState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Enter))
            {

                Form.setPlayerName("enter");
                // If not down last update, key has just been pressed.
                if (!oldState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Enter))
                {
                    Form.setPlayerName("enter");
                    // 
                    //backColor =
                    //  new Color(backColor.R, backColor.G, (byte)~backColor.B);
                }
            }
            else if (oldState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Enter))
            {
                // Key was down last update, but not down now, so
                // it has just been released.
            }

            // Update saved state.
            oldState = newState;
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
           // oldState = Keyboard.GetState();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            game_map = new Map.Map(Form.ViewportSize.Width, Form.ViewportSize.Height,this.Content,player);
            vandal = new Characters.Vandal(this.Content, new Rectangle(0, 0, 50, 50),Form.ViewportSize.Width,Form.ViewportSize.Height);
      
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
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                this.Exit();
            updateLabel(gameTime);
            game_map.Update(vandal.Rectangle, gameTime);


           // UpdateInput();
            switch(key_pressed)
            {
                //case (System.Windows.Forms.Keys.None):
                //    if (move)
                //    {
                //        vandal.SetFinalPosition(game_map);
                //        move = false;
                //    }
                //    break;
                case (System.Windows.Forms.Keys.W):
            
                vandal.Move(direction.up);
                    break;

                case (System.Windows.Forms.Keys.S):

                    vandal.Move(direction.down);
                    break;

                case (System.Windows.Forms.Keys.A):

                    vandal.Move(direction.left);
                    break;

                case (System.Windows.Forms.Keys.D):

                    vandal.Move(direction.right);
                    break;
                case (System.Windows.Forms.Keys.Alt):

                    vandal.changeDirectionToNext();
                    break;
                case (System.Windows.Forms.Keys.Enter):
                    Form.setPlayerName("enter");
                    vandal.LeftDynamite();
                    break;
                case (System.Windows.Forms.Keys.Escape):
                    Application.Exit();
                    break;
                case (System.Windows.Forms.Keys.LShiftKey):

                    vandal.AttackWithRacket();
                    break;

                default:
                    break;
            }
            vandal.LoadCurrentTexture();
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

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);
            // TODO: Add your drawing code here
            spriteBatch.Begin();
          
            game_map.Draw(spriteBatch);
            vandal.Draw(spriteBatch);
       
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
