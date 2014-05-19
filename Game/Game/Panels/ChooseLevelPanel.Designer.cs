namespace Game.Panels
{
    partial class ChooseLevelPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevelPanel));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ChooseLevelLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Scores5Button = new System.Windows.Forms.Button();
            this.Scores4Button = new System.Windows.Forms.Button();
            this.Scores3Button = new System.Windows.Forms.Button();
            this.Scores2Button = new System.Windows.Forms.Button();
            this.Level1Button = new System.Windows.Forms.Button();
            this.Level2Button = new System.Windows.Forms.Button();
            this.Level3button = new System.Windows.Forms.Button();
            this.Level4Button = new System.Windows.Forms.Button();
            this.Level5Button = new System.Windows.Forms.Button();
            this.Scores1Button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(39, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ChooseLevelLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(821, 619);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 0;
            // 
            // ChooseLevelLabel
            // 
            this.ChooseLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseLevelLabel.AutoSize = true;
            this.ChooseLevelLabel.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChooseLevelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseLevelLabel.Location = new System.Drawing.Point(267, 39);
            this.ChooseLevelLabel.Name = "ChooseLevelLabel";
            this.ChooseLevelLabel.Size = new System.Drawing.Size(301, 46);
            this.ChooseLevelLabel.TabIndex = 0;
            this.ChooseLevelLabel.Text = "Wybierz poziom";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.27488F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.72512F));
            this.tableLayoutPanel1.Controls.Add(this.Scores5Button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Scores4Button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Scores3Button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Scores2Button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Level1Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Level2Button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Level3button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Level4Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Level5Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Scores1Button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(145, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Scores5Button
            // 
            this.Scores5Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Scores5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scores5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scores5Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scores5Button.Location = new System.Drawing.Point(175, 357);
            this.Scores5Button.Name = "Scores5Button";
            this.Scores5Button.Size = new System.Drawing.Size(329, 63);
            this.Scores5Button.TabIndex = 9;
            this.Scores5Button.Text = "Najlepsze wyniki";
            this.Scores5Button.UseVisualStyleBackColor = true;
            this.Scores5Button.Click += new System.EventHandler(this.Scores5Button_Click);
            // 
            // Scores4Button
            // 
            this.Scores4Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Scores4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scores4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scores4Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scores4Button.Location = new System.Drawing.Point(175, 269);
            this.Scores4Button.Name = "Scores4Button";
            this.Scores4Button.Size = new System.Drawing.Size(329, 63);
            this.Scores4Button.TabIndex = 8;
            this.Scores4Button.Text = "Najlepsze wyniki";
            this.Scores4Button.UseVisualStyleBackColor = true;
            this.Scores4Button.Click += new System.EventHandler(this.Scores4Button_Click);
            // 
            // Scores3Button
            // 
            this.Scores3Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Scores3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scores3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scores3Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scores3Button.Location = new System.Drawing.Point(175, 183);
            this.Scores3Button.Name = "Scores3Button";
            this.Scores3Button.Size = new System.Drawing.Size(329, 63);
            this.Scores3Button.TabIndex = 7;
            this.Scores3Button.Text = "Najlepsze wyniki";
            this.Scores3Button.UseVisualStyleBackColor = true;
            this.Scores3Button.Click += new System.EventHandler(this.Scores3Button_Click);
            // 
            // Scores2Button
            // 
            this.Scores2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Scores2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scores2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scores2Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scores2Button.Location = new System.Drawing.Point(175, 97);
            this.Scores2Button.Name = "Scores2Button";
            this.Scores2Button.Size = new System.Drawing.Size(329, 63);
            this.Scores2Button.TabIndex = 6;
            this.Scores2Button.Text = "Najlepsze wyniki";
            this.Scores2Button.UseVisualStyleBackColor = true;
            this.Scores2Button.Click += new System.EventHandler(this.Scores2Button_Click);
            // 
            // Level1Button
            // 
            this.Level1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Level1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level1Button.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Level1Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Level1Button.Location = new System.Drawing.Point(26, 8);
            this.Level1Button.Name = "Level1Button";
            this.Level1Button.Size = new System.Drawing.Size(70, 70);
            this.Level1Button.TabIndex = 0;
            this.Level1Button.Text = "1.";
            this.Level1Button.UseVisualStyleBackColor = true;
            this.Level1Button.Click += new System.EventHandler(this.Level1Button_Click);
            // 
            // Level2Button
            // 
            this.Level2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Level2Button.Enabled = false;
            this.Level2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level2Button.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Level2Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Level2Button.Location = new System.Drawing.Point(26, 94);
            this.Level2Button.Name = "Level2Button";
            this.Level2Button.Size = new System.Drawing.Size(70, 70);
            this.Level2Button.TabIndex = 1;
            this.Level2Button.Text = "2.";
            this.Level2Button.UseVisualStyleBackColor = true;
            this.Level2Button.Click += new System.EventHandler(this.Level2Button_Click);
            // 
            // Level3button
            // 
            this.Level3button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Level3button.Enabled = false;
            this.Level3button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level3button.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Level3button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Level3button.Location = new System.Drawing.Point(26, 180);
            this.Level3button.Name = "Level3button";
            this.Level3button.Size = new System.Drawing.Size(70, 70);
            this.Level3button.TabIndex = 2;
            this.Level3button.Text = "3.";
            this.Level3button.UseVisualStyleBackColor = true;
            this.Level3button.Click += new System.EventHandler(this.Level3button_Click);
            // 
            // Level4Button
            // 
            this.Level4Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Level4Button.Enabled = false;
            this.Level4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level4Button.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Level4Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Level4Button.Location = new System.Drawing.Point(26, 266);
            this.Level4Button.Name = "Level4Button";
            this.Level4Button.Size = new System.Drawing.Size(70, 70);
            this.Level4Button.TabIndex = 3;
            this.Level4Button.Text = "4.";
            this.Level4Button.UseVisualStyleBackColor = true;
            this.Level4Button.Click += new System.EventHandler(this.Level4Button_Click);
            // 
            // Level5Button
            // 
            this.Level5Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Level5Button.Enabled = false;
            this.Level5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level5Button.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Level5Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Level5Button.Location = new System.Drawing.Point(26, 353);
            this.Level5Button.Name = "Level5Button";
            this.Level5Button.Size = new System.Drawing.Size(70, 70);
            this.Level5Button.TabIndex = 4;
            this.Level5Button.Text = "5.";
            this.Level5Button.UseVisualStyleBackColor = true;
            this.Level5Button.Click += new System.EventHandler(this.Level5Button_Click);
            // 
            // Scores1Button
            // 
            this.Scores1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Scores1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scores1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scores1Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scores1Button.Location = new System.Drawing.Point(175, 11);
            this.Scores1Button.Name = "Scores1Button";
            this.Scores1Button.Size = new System.Drawing.Size(329, 63);
            this.Scores1Button.TabIndex = 5;
            this.Scores1Button.Text = "Najlepsze wyniki";
            this.Scores1Button.UseVisualStyleBackColor = true;
            this.Scores1Button.Click += new System.EventHandler(this.Scores1Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(306, 442);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 49);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ChooseLevelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChooseLevelPanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ChooseLevelLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Scores5Button;
        private System.Windows.Forms.Button Scores4Button;
        private System.Windows.Forms.Button Scores3Button;
        private System.Windows.Forms.Button Scores2Button;
        private System.Windows.Forms.Button Level1Button;
        private System.Windows.Forms.Button Level2Button;
        private System.Windows.Forms.Button Level3button;
        private System.Windows.Forms.Button Level4Button;
        private System.Windows.Forms.Button Level5Button;
        private System.Windows.Forms.Button Scores1Button;
        private System.Windows.Forms.Button exitButton;
    }
}
