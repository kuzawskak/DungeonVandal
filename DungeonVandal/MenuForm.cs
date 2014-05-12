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
using DungeonVandal;


namespace DungeonVandal
{
    public partial class MenuForm : Form
    {
        Game.Game gameInstance;
        string playerName = null;
        Panel activePanel;

        public void setActivePanel(Panel panel)
        {
           activePanel.Visible= false;
            activePanel = panel;
            activePanel.Visible = true;
        }

        

        public IntPtr CanvasHandle
        {
            get { return GraphicsContainer.Handle; }
        }

        public Size ViewportSize
        {
            get { return GraphicsContainer.Size; }
        }

        public void setPlayerName(string player_name)
        {
            this.playerNameLabel.Text = player_name;

        }

        public void updateGameTime(int minutes, int seconds)
        {
            string minutes_str = minutes == 0 ? "00" : minutes.ToString();
            if (minutes_str.Length == 1) minutes_str = "0" + minutes_str;
            string seconds_str = seconds==0?"00":seconds.ToString();
            if (seconds_str.Length == 1) seconds_str = "0" + seconds_str;
            this.timeLabel.Text = minutes_str + ":" + seconds_str;
        }

        public void updatePoints(int points)
        {
            this.pointsLabel.Text = points.ToString();
        }

        public void updateDynamite(int dynamite)
        {
            this.dynamiteLabel.Text = "x"+dynamite.ToString();
        }

        public void updateRacket(int racket)
        {
            this.racketLabel.Text = "x"+racket.ToString();
        }

        public MenuForm()
        {
            InitializeComponent();
            activePanel = LoginPanel;
  
            activePanel.Visible = true;
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //TODO: 
            //validate(loginButton.Text);
            playerName =usernameTextBox.Text;
            setActivePanel(MenuPanel);

           
        }

          private void newGameButton_Click(object sender, EventArgs e)
            {
                XnaGamePanel.Visible = true;
                MenuPanel.Visible = false;
              //  gameInstance = new Game.Game(this,playerName);
             
              //  Thread thread = new Thread(new ThreadStart(gameInstance.Run));
              //  thread.Start();

              }

        void StartGame()
        {
          // setActivePanel(XnaGamePanel);
           // Game.Game game = new Game.Game(this,playerName);
           // Thread thread = new Thread(new ThreadStart(game.Run));
            //thread.Start();

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
