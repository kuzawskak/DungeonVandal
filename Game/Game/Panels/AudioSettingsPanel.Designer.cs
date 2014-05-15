namespace Game.Panels
{
    partial class AudioSettingsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioSettingsPanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.audioLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.musicBarContainer = new System.Windows.Forms.SplitContainer();
            this.musicColumeLabel = new System.Windows.Forms.Label();
            MusicVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.soundVolumeContainer = new System.Windows.Forms.SplitContainer();
            this.soundVolumeLabel = new System.Windows.Forms.Label();
            musicVolTrackbar = new System.Windows.Forms.TrackBar();
            MuteCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBarContainer)).BeginInit();
            this.musicBarContainer.Panel1.SuspendLayout();
            this.musicBarContainer.Panel2.SuspendLayout();
            this.musicBarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(MusicVolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundVolumeContainer)).BeginInit();
            this.soundVolumeContainer.Panel1.SuspendLayout();
            this.soundVolumeContainer.Panel2.SuspendLayout();
            this.soundVolumeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(musicVolTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(45, 41);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.audioLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(809, 615);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 0;
            // 
            // audioLabel
            // 
            this.audioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioLabel.AutoSize = true;
            this.audioLabel.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.audioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.audioLabel.Location = new System.Drawing.Point(225, 32);
            this.audioLabel.Name = "audioLabel";
            this.audioLabel.Size = new System.Drawing.Size(365, 46);
            this.audioLabel.TabIndex = 0;
            this.audioLabel.Text = "Ustawienia dźwięku";
            this.audioLabel.Click += new System.EventHandler(this.audioLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.musicBarContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.soundVolumeContainer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(MuteCheckbox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // musicBarContainer
            // 
            this.musicBarContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicBarContainer.Location = new System.Drawing.Point(3, 3);
            this.musicBarContainer.Name = "musicBarContainer";
            this.musicBarContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // musicBarContainer.Panel1
            // 
            this.musicBarContainer.Panel1.Controls.Add(this.musicColumeLabel);
            // 
            // musicBarContainer.Panel2
            // 
            this.musicBarContainer.Panel2.Controls.Add(MusicVolumeTrackBar);
            this.musicBarContainer.Size = new System.Drawing.Size(800, 118);
            this.musicBarContainer.SplitterDistance = 58;
            this.musicBarContainer.TabIndex = 1;
            // 
            // musicColumeLabel
            // 
            this.musicColumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicColumeLabel.AutoSize = true;
            this.musicColumeLabel.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicColumeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicColumeLabel.Location = new System.Drawing.Point(289, 9);
            this.musicColumeLabel.Name = "musicColumeLabel";
            this.musicColumeLabel.Size = new System.Drawing.Size(239, 37);
            this.musicColumeLabel.TabIndex = 1;
            this.musicColumeLabel.Text = "Głośność muzyki";
            // 
            // MusicVolumeTrackBar
            // 
            MusicVolumeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            MusicVolumeTrackBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            MusicVolumeTrackBar.Location = new System.Drawing.Point(46, 3);
            MusicVolumeTrackBar.Name = "MusicVolumeTrackBar";
            MusicVolumeTrackBar.Size = new System.Drawing.Size(715, 45);
            MusicVolumeTrackBar.TabIndex = 0;
            MusicVolumeTrackBar.Value = 5;
            MusicVolumeTrackBar.Scroll += new System.EventHandler(this.MusicVolumeTrackBar_Scroll);
            // 
            // soundVolumeContainer
            // 
            this.soundVolumeContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundVolumeContainer.Location = new System.Drawing.Point(3, 127);
            this.soundVolumeContainer.Name = "soundVolumeContainer";
            this.soundVolumeContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // soundVolumeContainer.Panel1
            // 
            this.soundVolumeContainer.Panel1.Controls.Add(this.soundVolumeLabel);
            // 
            // soundVolumeContainer.Panel2
            // 
            this.soundVolumeContainer.Panel2.Controls.Add(musicVolTrackbar);
            this.soundVolumeContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.soundVolumeContainer.Size = new System.Drawing.Size(800, 118);
            this.soundVolumeContainer.SplitterDistance = 58;
            this.soundVolumeContainer.TabIndex = 2;
            // 
            // soundVolumeLabel
            // 
            this.soundVolumeLabel.AutoSize = true;
            this.soundVolumeLabel.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundVolumeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soundVolumeLabel.Location = new System.Drawing.Point(267, 10);
            this.soundVolumeLabel.Name = "soundVolumeLabel";
            this.soundVolumeLabel.Size = new System.Drawing.Size(278, 37);
            this.soundVolumeLabel.TabIndex = 0;
            this.soundVolumeLabel.Text = "Głośność dżwięków";
            this.soundVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // musicVolTrackbar
            // 
            musicVolTrackbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            musicVolTrackbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            musicVolTrackbar.Location = new System.Drawing.Point(46, 3);
            musicVolTrackbar.Name = "musicVolTrackbar";
            musicVolTrackbar.Size = new System.Drawing.Size(715, 45);
            musicVolTrackbar.TabIndex = 1;
            musicVolTrackbar.Value = 5;
            musicVolTrackbar.Scroll += new System.EventHandler(this.musicVolTrackbar_Scroll);
            // 
            // MuteCheckbox
            // 
            MuteCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            MuteCheckbox.AutoSize = true;
            MuteCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            MuteCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MuteCheckbox.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            MuteCheckbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            MuteCheckbox.Location = new System.Drawing.Point(275, 289);
            MuteCheckbox.Name = "MuteCheckbox";
            MuteCheckbox.Size = new System.Drawing.Size(255, 41);
            MuteCheckbox.TabIndex = 3;
            MuteCheckbox.Text = "Wycisz wszystko";
            MuteCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            MuteCheckbox.UseVisualStyleBackColor = true;
            MuteCheckbox.CheckedChanged += new System.EventHandler(this.MuteCheckbox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(299, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wyjdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AudioSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.splitContainer1);
            this.Name = "AudioSettingsPanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.musicBarContainer.Panel1.ResumeLayout(false);
            this.musicBarContainer.Panel1.PerformLayout();
            this.musicBarContainer.Panel2.ResumeLayout(false);
            this.musicBarContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBarContainer)).EndInit();
            this.musicBarContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(MusicVolumeTrackBar)).EndInit();
            this.soundVolumeContainer.Panel1.ResumeLayout(false);
            this.soundVolumeContainer.Panel1.PerformLayout();
            this.soundVolumeContainer.Panel2.ResumeLayout(false);
            this.soundVolumeContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundVolumeContainer)).EndInit();
            this.soundVolumeContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(musicVolTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public  static System.Windows.Forms.TrackBar MusicVolumeTrackBar;
        private System.Windows.Forms.SplitContainer musicBarContainer;
        private System.Windows.Forms.Label musicColumeLabel;
        private System.Windows.Forms.SplitContainer soundVolumeContainer;
        private System.Windows.Forms.Label soundVolumeLabel;
        public static System.Windows.Forms.TrackBar musicVolTrackbar;
        public static System.Windows.Forms.CheckBox MuteCheckbox;
        private System.Windows.Forms.Button button1;
    }
}
