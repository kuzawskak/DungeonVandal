namespace Game.Panels
{
    partial class LoadGamePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadGamePanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loadGameLabel = new System.Windows.Forms.Label();
            this.gameStatesList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loadGameLabel);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gameStatesList);
            this.splitContainer1.Size = new System.Drawing.Size(897, 694);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // loadGameLabel
            // 
            this.loadGameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadGameLabel.AutoSize = true;
            this.loadGameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadGameLabel.Location = new System.Drawing.Point(182, 70);
            this.loadGameLabel.Name = "loadGameLabel";
            this.loadGameLabel.Size = new System.Drawing.Size(495, 61);
            this.loadGameLabel.TabIndex = 0;
            this.loadGameLabel.Text = "Wybierz rozgrywkę";
            // 
            // gameStatesList
            // 
            this.gameStatesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameStatesList.BackColor = System.Drawing.Color.Black;
            this.gameStatesList.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameStatesList.ForeColor = System.Drawing.SystemColors.Window;
            this.gameStatesList.FormattingEnabled = true;
            this.gameStatesList.IntegralHeight = false;
            this.gameStatesList.ItemHeight = 35;
            this.gameStatesList.Location = new System.Drawing.Point(193, 16);
            this.gameStatesList.Name = "gameStatesList";
            this.gameStatesList.Size = new System.Drawing.Size(484, 433);
            this.gameStatesList.TabIndex = 0;
            this.gameStatesList.SelectedIndexChanged += new System.EventHandler(this.gameStatesList_SelectedIndexChanged);
            // 
            // LoadGamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoadGamePanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label loadGameLabel;
        private System.Windows.Forms.ListBox gameStatesList;
    }
}
