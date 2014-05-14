namespace Game.Panels
{
    partial class MainPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ChooseLevelButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.BackgroundImage")));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ExitGameButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.HelpButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SettingsButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ChooseLevelButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoadGameButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NewGameButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 533);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitGameButton.AutoSize = true;
            this.ExitGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitGameButton.Location = new System.Drawing.Point(3, 443);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(894, 87);
            this.ExitGameButton.TabIndex = 5;
            this.ExitGameButton.Text = "Wyjdź";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpButton.AutoSize = true;
            this.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelpButton.Location = new System.Drawing.Point(3, 355);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(894, 82);
            this.HelpButton.TabIndex = 4;
            this.HelpButton.Text = "Pomoc";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.AutoSize = true;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsButton.Location = new System.Drawing.Point(3, 267);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(894, 82);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Ustawienia";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ChooseLevelButton
            // 
            this.ChooseLevelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseLevelButton.AutoSize = true;
            this.ChooseLevelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChooseLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseLevelButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseLevelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseLevelButton.Location = new System.Drawing.Point(3, 179);
            this.ChooseLevelButton.Name = "ChooseLevelButton";
            this.ChooseLevelButton.Size = new System.Drawing.Size(894, 82);
            this.ChooseLevelButton.TabIndex = 2;
            this.ChooseLevelButton.Text = "Wybór poziomu";
            this.ChooseLevelButton.UseVisualStyleBackColor = true;
            this.ChooseLevelButton.Click += new System.EventHandler(this.ChooseLevelButton_Click);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadGameButton.AutoSize = true;
            this.LoadGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadGameButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadGameButton.Location = new System.Drawing.Point(3, 91);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(894, 82);
            this.LoadGameButton.TabIndex = 0;
            this.LoadGameButton.Text = "Wczytaj grę";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewGameButton.AutoSize = true;
            this.NewGameButton.BackColor = System.Drawing.Color.Transparent;
            this.NewGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewGameButton.Location = new System.Drawing.Point(3, 3);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(894, 82);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "Rozpocznij grę od początku";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click_1);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ChooseLevelButton;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.Button NewGameButton;

    }
}
