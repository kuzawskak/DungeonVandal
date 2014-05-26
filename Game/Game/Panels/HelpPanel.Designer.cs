namespace Game.Panels
{

    partial class HelpPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.nextSlideButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Location = new System.Drawing.Point(44, 45);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HelpLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.nextSlideButton);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(816, 542);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 0;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(348, 26);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(135, 46);
            this.HelpLabel.TabIndex = 0;
            this.HelpLabel.Text = "Pomoc";
            // 
            // nextSlideButton
            // 
            this.nextSlideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextSlideButton.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextSlideButton.Location = new System.Drawing.Point(749, 176);
            this.nextSlideButton.Name = "nextSlideButton";
            this.nextSlideButton.Size = new System.Drawing.Size(64, 98);
            this.nextSlideButton.TabIndex = 2;
            this.nextSlideButton.Text = ">";
            this.nextSlideButton.UseVisualStyleBackColor = true;
            this.nextSlideButton.Click += new System.EventHandler(this.nextSlideButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(57, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 440);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(394, 593);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 49);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // HelpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HelpPanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button nextSlideButton;
    }
}
