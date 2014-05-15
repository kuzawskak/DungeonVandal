namespace Game.Panels
{
    partial class XnaGamePanel
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.racketCounter = new System.Windows.Forms.Label();
            this.dynamiteCounter = new System.Windows.Forms.Label();
            this.racketPictureBox = new System.Windows.Forms.PictureBox();
            this.dynamitePictureBox = new System.Windows.Forms.PictureBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.GraphicsContainer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racketPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.racketCounter);
            this.splitContainer1.Panel1.Controls.Add(this.dynamiteCounter);
            this.splitContainer1.Panel1.Controls.Add(this.racketPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.dynamitePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.pointsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.timeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.playerName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GraphicsContainer);
            this.splitContainer1.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 0;
            // 
            // racketCounter
            // 
            this.racketCounter.AutoSize = true;
            this.racketCounter.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.racketCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.racketCounter.Location = new System.Drawing.Point(796, 22);
            this.racketCounter.Name = "racketCounter";
            this.racketCounter.Size = new System.Drawing.Size(42, 30);
            this.racketCounter.TabIndex = 6;
            this.racketCounter.Text = "x0";
            // 
            // dynamiteCounter
            // 
            this.dynamiteCounter.AutoSize = true;
            this.dynamiteCounter.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dynamiteCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dynamiteCounter.Location = new System.Drawing.Point(630, 22);
            this.dynamiteCounter.Name = "dynamiteCounter";
            this.dynamiteCounter.Size = new System.Drawing.Size(42, 30);
            this.dynamiteCounter.TabIndex = 5;
            this.dynamiteCounter.Text = "x0";
            // 
            // racketPictureBox
            // 
            this.racketPictureBox.BackgroundImage = global::Game.Resources.racket;
            this.racketPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.racketPictureBox.Location = new System.Drawing.Point(729, 13);
            this.racketPictureBox.Name = "racketPictureBox";
            this.racketPictureBox.Size = new System.Drawing.Size(50, 50);
            this.racketPictureBox.TabIndex = 4;
            this.racketPictureBox.TabStop = false;
            // 
            // dynamitePictureBox
            // 
            this.dynamitePictureBox.BackgroundImage = global::Game.Resources.dynamite;
            this.dynamitePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dynamitePictureBox.Location = new System.Drawing.Point(560, 13);
            this.dynamitePictureBox.Name = "dynamitePictureBox";
            this.dynamitePictureBox.Size = new System.Drawing.Size(50, 50);
            this.dynamitePictureBox.TabIndex = 3;
            this.dynamitePictureBox.TabStop = false;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointsLabel.Location = new System.Drawing.Point(411, 22);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(90, 30);
            this.pointsLabel.TabIndex = 2;
            this.pointsLabel.Text = "points";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(224, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(68, 30);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "time";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerName.Location = new System.Drawing.Point(26, 22);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(88, 30);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "Player";
            // 
            // GraphicsContainer
            // 
            this.GraphicsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsContainer.Location = new System.Drawing.Point(0, 3);
            this.GraphicsContainer.Name = "GraphicsContainer";
            this.GraphicsContainer.Size = new System.Drawing.Size(900, 600);
            this.GraphicsContainer.TabIndex = 0;
            this.GraphicsContainer.TabStop = false;
            // 
            // XnaGamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.splitContainer1);
            this.Name = "XnaGamePanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racketPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label playerName;
        public System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.PictureBox racketPictureBox;
        private System.Windows.Forms.PictureBox dynamitePictureBox;
        public System.Windows.Forms.Label racketCounter;
        public System.Windows.Forms.Label dynamiteCounter;
        public System.Windows.Forms.PictureBox GraphicsContainer;
    }
}
