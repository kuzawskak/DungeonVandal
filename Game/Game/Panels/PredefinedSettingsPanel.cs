using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game.Panels
{
    public partial class PredefinedSettingsPanel : UserControl
    {
        public PredefinedSettingsPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Zaladuj ustawienie predefiniowane #1 i wroc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings1Button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Zaladuj ustawienie predefiniowane #2 i wroc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings2Button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Zaladuj ustawienie predefiniowane #3 i wroc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings3Button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Wroc do menu ustawien klawiatury bez zmian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
