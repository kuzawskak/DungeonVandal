﻿namespace Game.Panels
{
    partial class GraphicSettingsPanel
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
            this.graphicsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.monochromaticCheckbox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brightnessTrackbar = new System.Windows.Forms.TrackBar();
            this.contrastTrackbar = new System.Windows.Forms.TrackBar();
            this.contrastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.graphicsLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(897, 694);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.TabIndex = 0;
            // 
            // graphicsLabel
            // 
            this.graphicsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphicsLabel.AutoSize = true;
            this.graphicsLabel.BackColor = System.Drawing.Color.Transparent;
            this.graphicsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.graphicsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.graphicsLabel.Location = new System.Drawing.Point(344, 38);
            this.graphicsLabel.Name = "graphicsLabel";
            this.graphicsLabel.Size = new System.Drawing.Size(283, 37);
            this.graphicsLabel.TabIndex = 0;
            this.graphicsLabel.Text = "Ustawienia grafiki";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.monochromaticCheckbox, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 572);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.brightnessLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.brightnessTrackbar);
            this.splitContainer2.Size = new System.Drawing.Size(894, 137);
            this.splitContainer2.SplitterDistance = 65;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 146);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.contrastLabel);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.contrastTrackbar);
            this.splitContainer3.Size = new System.Drawing.Size(894, 137);
            this.splitContainer3.SplitterDistance = 71;
            this.splitContainer3.TabIndex = 1;
            // 
            // monochromaticCheckbox
            // 
            this.monochromaticCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monochromaticCheckbox.AutoSize = true;
            this.monochromaticCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.monochromaticCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monochromaticCheckbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monochromaticCheckbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monochromaticCheckbox.Location = new System.Drawing.Point(283, 340);
            this.monochromaticCheckbox.Name = "monochromaticCheckbox";
            this.monochromaticCheckbox.Size = new System.Drawing.Size(333, 34);
            this.monochromaticCheckbox.TabIndex = 2;
            this.monochromaticCheckbox.Text = "Tryb monochromatyczny";
            this.monochromaticCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monochromaticCheckbox.UseVisualStyleBackColor = false;
            this.monochromaticCheckbox.CheckedChanged += new System.EventHandler(this.monochromaticCheckbox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(377, 469);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 63);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.brightnessLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brightnessLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brightnessLabel.Location = new System.Drawing.Point(413, 25);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(106, 30);
            this.brightnessLabel.TabIndex = 0;
            this.brightnessLabel.Text = "Jasność";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // brightnessTrackbar
            // 
            this.brightnessTrackbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brightnessTrackbar.Location = new System.Drawing.Point(214, 3);
            this.brightnessTrackbar.Maximum = 100;
            this.brightnessTrackbar.Name = "brightnessTrackbar";
            this.brightnessTrackbar.Size = new System.Drawing.Size(506, 45);
            this.brightnessTrackbar.TabIndex = 0;
            this.brightnessTrackbar.Value = 50;
            this.brightnessTrackbar.Scroll += new System.EventHandler(this.brightnessTrackbar_Scroll);
            // 
            // contrastTrackbar
            // 
            this.contrastTrackbar.Location = new System.Drawing.Point(214, 17);
            this.contrastTrackbar.Maximum = 100;
            this.contrastTrackbar.Name = "contrastTrackbar";
            this.contrastTrackbar.Size = new System.Drawing.Size(506, 45);
            this.contrastTrackbar.TabIndex = 0;
            this.contrastTrackbar.Value = 50;
            this.contrastTrackbar.Scroll += new System.EventHandler(this.contrastTrackbar_Scroll);
            // 
            // contrastLabel
            // 
            this.contrastLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.BackColor = System.Drawing.Color.Transparent;
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contrastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contrastLabel.Location = new System.Drawing.Point(401, 27);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(118, 30);
            this.contrastLabel.TabIndex = 1;
            this.contrastLabel.Text = "Kontrast";
            // 
            // GraphicSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GraphicSettingsPanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label graphicsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.TrackBar brightnessTrackbar;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar contrastTrackbar;
        private System.Windows.Forms.CheckBox monochromaticCheckbox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label contrastLabel;
    }
}