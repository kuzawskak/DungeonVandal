namespace DungeonVandal
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


       // public void StartGame() { }
        public void ChooseLevel() { }
        public void Login(string player_name) { }
        public void SetActivePanel(System.Windows.Forms.Panel panel) { }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LevelsPanel = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SettingsMenuPanel = new System.Windows.Forms.Panel();
            this.ScoresPanel = new System.Windows.Forms.Panel();
            this.AudioSettingsPanel = new System.Windows.Forms.Panel();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.menuTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newGameButton = new System.Windows.Forms.Button();
            this.chooseLevelButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.GraphicsSettingsPanel = new System.Windows.Forms.Panel();
            this.KeySettingsPanel = new System.Windows.Forms.Panel();
            this.PausePanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.XnaGamePanel = new System.Windows.Forms.Panel();
            this.racketLabel = new System.Windows.Forms.Label();
            this.racketPictureBox = new System.Windows.Forms.PictureBox();
            this.dynamiteLabel = new System.Windows.Forms.Label();
            this.dynamitePictureBox = new System.Windows.Forms.PictureBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.GraphicsContainer = new System.Windows.Forms.PictureBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.menuTableLayoutPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.XnaGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racketPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsContainer)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelsPanel
            // 
            this.LevelsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelsPanel.Location = new System.Drawing.Point(0, 0);
            this.LevelsPanel.Name = "LevelsPanel";
            this.LevelsPanel.Size = new System.Drawing.Size(780, 560);
            this.LevelsPanel.TabIndex = 7;
            this.LevelsPanel.Visible = false;
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(780, 560);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Visible = false;
            // 
            // SettingsMenuPanel
            // 
            this.SettingsMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsMenuPanel.Name = "SettingsMenuPanel";
            this.SettingsMenuPanel.Size = new System.Drawing.Size(796, 598);
            this.SettingsMenuPanel.TabIndex = 2;
            this.SettingsMenuPanel.Visible = false;
            // 
            // ScoresPanel
            // 
            this.ScoresPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoresPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScoresPanel.Location = new System.Drawing.Point(0, 0);
            this.ScoresPanel.Name = "ScoresPanel";
            this.ScoresPanel.Size = new System.Drawing.Size(812, 636);
            this.ScoresPanel.TabIndex = 8;
            this.ScoresPanel.Visible = false;
            // 
            // AudioSettingsPanel
            // 
            this.AudioSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioSettingsPanel.AutoSize = true;
            this.AudioSettingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AudioSettingsPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AudioSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.AudioSettingsPanel.Name = "AudioSettingsPanel";
            this.AudioSettingsPanel.Size = new System.Drawing.Size(780, 560);
            this.AudioSettingsPanel.TabIndex = 3;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainMenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(780, 560);
            this.MainMenuPanel.TabIndex = 1;
            this.MainMenuPanel.Visible = false;
            // 
            // menuTableLayoutPanel
            // 
            this.menuTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuTableLayoutPanel.ColumnCount = 1;
            this.menuTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuTableLayoutPanel.Controls.Add(this.newGameButton, 0, 1);
            this.menuTableLayoutPanel.Controls.Add(this.chooseLevelButton, 0, 3);
            this.menuTableLayoutPanel.Controls.Add(this.settingsButton, 0, 4);
            this.menuTableLayoutPanel.Controls.Add(this.helpButton, 0, 5);
            this.menuTableLayoutPanel.Controls.Add(this.exitButton, 0, 6);
            this.menuTableLayoutPanel.Controls.Add(this.loadGameButton, 0, 2);
            this.menuTableLayoutPanel.Location = new System.Drawing.Point(3, 12);
            this.menuTableLayoutPanel.Name = "menuTableLayoutPanel";
            this.menuTableLayoutPanel.RowCount = 7;
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.menuTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.menuTableLayoutPanel.Size = new System.Drawing.Size(777, 445);
            this.menuTableLayoutPanel.TabIndex = 2;
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newGameButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newGameButton.Location = new System.Drawing.Point(288, 52);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(200, 50);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "Rozpocznij grę od początku";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // chooseLevelButton
            // 
            this.chooseLevelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseLevelButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chooseLevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseLevelButton.Location = new System.Drawing.Point(288, 184);
            this.chooseLevelButton.Name = "chooseLevelButton";
            this.chooseLevelButton.Size = new System.Drawing.Size(200, 50);
            this.chooseLevelButton.TabIndex = 2;
            this.chooseLevelButton.Text = "Wybór poziomu";
            this.chooseLevelButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.Location = new System.Drawing.Point(288, 250);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 50);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpButton.Location = new System.Drawing.Point(288, 316);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(200, 50);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.Location = new System.Drawing.Point(288, 384);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loadGameButton
            // 
            this.loadGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadGameButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.loadGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadGameButton.Location = new System.Drawing.Point(288, 118);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(200, 50);
            this.loadGameButton.TabIndex = 1;
            this.loadGameButton.Text = "Wczytaj grę";
            this.loadGameButton.UseVisualStyleBackColor = false;
            // 
            // GraphicsSettingsPanel
            // 
            this.GraphicsSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsSettingsPanel.AutoSize = true;
            this.GraphicsSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.GraphicsSettingsPanel.Name = "GraphicsSettingsPanel";
            this.GraphicsSettingsPanel.Size = new System.Drawing.Size(780, 560);
            this.GraphicsSettingsPanel.TabIndex = 4;
            this.GraphicsSettingsPanel.Visible = false;
            // 
            // KeySettingsPanel
            // 
            this.KeySettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeySettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.KeySettingsPanel.Name = "KeySettingsPanel";
            this.KeySettingsPanel.Size = new System.Drawing.Size(780, 560);
            this.KeySettingsPanel.TabIndex = 5;
            this.KeySettingsPanel.Visible = false;
            // 
            // PausePanel
            // 
            this.PausePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PausePanel.Location = new System.Drawing.Point(0, 0);
            this.PausePanel.Name = "PausePanel";
            this.PausePanel.Size = new System.Drawing.Size(780, 560);
            this.PausePanel.TabIndex = 6;
            this.PausePanel.Visible = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuPanel.Controls.Add(this.menuTableLayoutPanel);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(780, 560);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.Visible = false;
            // 
            // XnaGamePanel
            // 
            this.XnaGamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XnaGamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.XnaGamePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.XnaGamePanel.Controls.Add(this.racketLabel);
            this.XnaGamePanel.Controls.Add(this.racketPictureBox);
            this.XnaGamePanel.Controls.Add(this.dynamiteLabel);
            this.XnaGamePanel.Controls.Add(this.dynamitePictureBox);
            this.XnaGamePanel.Controls.Add(this.pointsLabel);
            this.XnaGamePanel.Controls.Add(this.timeLabel);
            this.XnaGamePanel.Controls.Add(this.playerNameLabel);
            this.XnaGamePanel.Controls.Add(this.GraphicsContainer);
            this.XnaGamePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.XnaGamePanel.Location = new System.Drawing.Point(0, 0);
            this.XnaGamePanel.Name = "XnaGamePanel";
            this.XnaGamePanel.Size = new System.Drawing.Size(780, 560);
            this.XnaGamePanel.TabIndex = 2;
            this.XnaGamePanel.Visible = false;
            // 
            // racketLabel
            // 
            this.racketLabel.AutoSize = true;
            this.racketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.racketLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.racketLabel.Location = new System.Drawing.Point(652, 13);
            this.racketLabel.Name = "racketLabel";
            this.racketLabel.Size = new System.Drawing.Size(32, 24);
            this.racketLabel.TabIndex = 7;
            this.racketLabel.Text = "x0";
            // 
            // racketPictureBox
            // 
            this.racketPictureBox.Image = global::DungeonVandal.Properties.Resources.racket;
            this.racketPictureBox.Location = new System.Drawing.Point(591, 13);
            this.racketPictureBox.Name = "racketPictureBox";
            this.racketPictureBox.Size = new System.Drawing.Size(44, 31);
            this.racketPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racketPictureBox.TabIndex = 6;
            this.racketPictureBox.TabStop = false;
            // 
            // dynamiteLabel
            // 
            this.dynamiteLabel.AutoSize = true;
            this.dynamiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dynamiteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dynamiteLabel.Location = new System.Drawing.Point(508, 13);
            this.dynamiteLabel.Name = "dynamiteLabel";
            this.dynamiteLabel.Size = new System.Drawing.Size(32, 24);
            this.dynamiteLabel.TabIndex = 5;
            this.dynamiteLabel.Text = "x0";
            // 
            // dynamitePictureBox
            // 
            this.dynamitePictureBox.Image = global::DungeonVandal.Properties.Resources.dynamite;
            this.dynamitePictureBox.Location = new System.Drawing.Point(461, 12);
            this.dynamitePictureBox.Name = "dynamitePictureBox";
            this.dynamitePictureBox.Size = new System.Drawing.Size(41, 32);
            this.dynamitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dynamitePictureBox.TabIndex = 4;
            this.dynamitePictureBox.TabStop = false;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointsLabel.Location = new System.Drawing.Point(309, 13);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(66, 24);
            this.pointsLabel.TabIndex = 3;
            this.pointsLabel.Text = "points";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(176, 13);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(51, 26);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "time";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerNameLabel.Location = new System.Drawing.Point(13, 13);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(68, 24);
            this.playerNameLabel.TabIndex = 1;
            this.playerNameLabel.Text = "Player";
            // 
            // GraphicsContainer
            // 
            this.GraphicsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsContainer.Location = new System.Drawing.Point(3, 50);
            this.GraphicsContainer.Name = "GraphicsContainer";
            this.GraphicsContainer.Size = new System.Drawing.Size(780, 510);
            this.GraphicsContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GraphicsContainer.TabIndex = 0;
            this.GraphicsContainer.TabStop = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginPanel.BackgroundImage = global::DungeonVandal.Properties.Resources.title;
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPanel.Controls.Add(this.tableLayoutPanel);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(780, 560);
            this.LoginPanel.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.BackgroundImage = global::DungeonVandal.Properties.Resources.title;
            this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.usernameTextBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.loginButton, 0, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(780, 560);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTextBox.Location = new System.Drawing.Point(153, 260);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(474, 38);
            this.usernameTextBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(340, 441);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 50);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Wejdź do gry";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.XnaGamePanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuTableLayoutPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.XnaGamePanel.ResumeLayout(false);
            this.XnaGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racketPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsContainer)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel SettingsMenuPanel;
        private System.Windows.Forms.Panel AudioSettingsPanel;
        private System.Windows.Forms.Panel GraphicsSettingsPanel;
        private System.Windows.Forms.Panel KeySettingsPanel;
        private System.Windows.Forms.Panel PausePanel;
        private System.Windows.Forms.Panel LevelsPanel;
        private System.Windows.Forms.Panel ScoresPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox GraphicsContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TableLayoutPanel menuTableLayoutPanel;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Button chooseLevelButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel XnaGamePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.PictureBox racketPictureBox;
        private System.Windows.Forms.Label dynamiteLabel;
        private System.Windows.Forms.PictureBox dynamitePictureBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label racketLabel;
    }


}

