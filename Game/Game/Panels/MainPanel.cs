﻿using System;
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

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            XnaGamePanel game_panel = ((MenuForm)Parent).game_panel;
            MenuForm form = (MenuForm)Parent;
            game_panel.Visible = true;           
            Game gameInstance = new Game(form, form.player.Name);
            Thread thread = new Thread(new ThreadStart(gameInstance.Run));
            thread.Start();
            game_panel.GraphicsContainer.Focus();
        }

        private void ChooseLevelButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SettingsPanel settings_panel = new SettingsPanel();
            settings_panel.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(settings_panel);


        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpPanel help_panel = ((MenuForm)Parent).help_panel;
            this.Visible = false;
            help_panel.Visible = true;
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGameButton_Click_1(object sender, EventArgs e)
        {
            XnaGamePanel game_panel = ((MenuForm)Parent).game_panel;
            MenuForm form = (MenuForm)Parent;
            game_panel.Visible = true;
            this.Visible = false;
            Game gameInstance = new Game(form, form.player.Name);
            Thread thread = new Thread(new ThreadStart(gameInstance.Run));
            thread.Start();
            game_panel.GraphicsContainer.Focus();
        }
    }
}
