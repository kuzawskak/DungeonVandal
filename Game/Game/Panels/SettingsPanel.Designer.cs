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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.audioButton = new System.Windows.Forms.Button();
            this.graphicsButton = new System.Windows.Forms.Button();
            this.keyboardButton = new System.Windows.Forms.Button();
            this.defaultSettingsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.defaultSettingsButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.keyboardButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.graphicsButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.audioButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // audioButton
            // 
            this.audioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.audioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.audioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.audioButton.Location = new System.Drawing.Point(50, 35);
            this.audioButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(348, 72);
            this.audioButton.TabIndex = 0;
            this.audioButton.Text = "Ustawienia audio";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
            // 
            // graphicsButton
            // 
            this.graphicsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.graphicsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.graphicsButton.Location = new System.Drawing.Point(50, 182);
            this.graphicsButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.graphicsButton.Name = "graphicsButton";
            this.graphicsButton.Size = new System.Drawing.Size(348, 65);
            this.graphicsButton.TabIndex = 5;
            this.graphicsButton.Text = "Ustawienia grafiki";
            this.graphicsButton.UseVisualStyleBackColor = true;
            this.graphicsButton.Click += new System.EventHandler(this.graphicsButton_Click);
            // 
            // keyboardButton
            // 
            this.keyboardButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keyboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyboardButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keyboardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keyboardButton.Location = new System.Drawing.Point(50, 323);
            this.keyboardButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.keyboardButton.Name = "keyboardButton";
            this.keyboardButton.Size = new System.Drawing.Size(348, 68);
            this.keyboardButton.TabIndex = 6;
            this.keyboardButton.Text = "Ustawienia sterowania";
            this.keyboardButton.UseVisualStyleBackColor = true;
            this.keyboardButton.Click += new System.EventHandler(this.keyboardButton_Click);
            // 
            // defaultSettingsButton
            // 
            this.defaultSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.defaultSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultSettingsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defaultSettingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.defaultSettingsButton.Location = new System.Drawing.Point(502, 464);
            this.defaultSettingsButton.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.defaultSettingsButton.Name = "defaultSettingsButton";
            this.defaultSettingsButton.Size = new System.Drawing.Size(345, 72);
            this.defaultSettingsButton.TabIndex = 7;
            this.defaultSettingsButton.Text = "Przywróć domyślne";
            this.defaultSettingsButton.UseVisualStyleBackColor = true;
            this.defaultSettingsButton.Click += new System.EventHandler(this.defaultSettingsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(370, 607);
            this.exitButton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 74);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
        private System.Windows.Forms.Button graphicsButton;
        private System.Windows.Forms.Button audioButton;
    }
}
