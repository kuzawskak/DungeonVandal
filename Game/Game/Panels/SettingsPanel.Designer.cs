namespace Game.Panels
{
    partial class SettingsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.defaultSettingsButton = new System.Windows.Forms.Button();
            this.keyboardButton = new System.Windows.Forms.Button();
            this.audioButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.audioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.keyboardButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.defaultSettingsButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 613);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(331, 513);
            this.exitButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 74);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // defaultSettingsButton
            // 
            this.defaultSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.defaultSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultSettingsButton.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultSettingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.defaultSettingsButton.Location = new System.Drawing.Point(423, 269);
            this.defaultSettingsButton.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.defaultSettingsButton.Name = "defaultSettingsButton";
            this.defaultSettingsButton.Size = new System.Drawing.Size(345, 72);
            this.defaultSettingsButton.TabIndex = 7;
            this.defaultSettingsButton.Text = "Przywróć domyślne";
            this.defaultSettingsButton.UseVisualStyleBackColor = true;
            this.defaultSettingsButton.Click += new System.EventHandler(this.defaultSettingsButton_Click);
            // 
            // keyboardButton
            // 
            this.keyboardButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keyboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyboardButton.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keyboardButton.Location = new System.Drawing.Point(50, 144);
            this.keyboardButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.keyboardButton.Name = "keyboardButton";
            this.keyboardButton.Size = new System.Drawing.Size(376, 78);
            this.keyboardButton.TabIndex = 6;
            this.keyboardButton.Text = "Ustawienia sterowania";
            this.keyboardButton.UseVisualStyleBackColor = true;
            this.keyboardButton.Click += new System.EventHandler(this.keyboardButton_Click);
            // 
            // audioButton
            // 
            this.audioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.audioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioButton.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.audioButton.Location = new System.Drawing.Point(50, 25);
            this.audioButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(376, 72);
            this.audioButton.TabIndex = 0;
            this.audioButton.Text = "Ustawienia audio";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(900, 700);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button defaultSettingsButton;
        private System.Windows.Forms.Button keyboardButton;
        private System.Windows.Forms.Button audioButton;
    }
}
