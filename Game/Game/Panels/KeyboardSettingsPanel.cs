using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Game.Settings;

namespace Game.Panels
{
    
    public partial class KeyboardSettingsPanel : UserControl
    {
        Dictionary<State, Keys> keyboard_changes = new Dictionary<State, Keys>();
        State current_state = State.NONE;
        public KeyboardSettingsPanel()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            current_state = State.UP;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current_state = State.DOWN;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            current_state = State.RIGHT;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            current_state = State.LEFT;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current_state = State.BLOCK;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current_state = State.DYNAMITE;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            current_state = State.RACKET;
        }

        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (current_state != State.NONE)
                keyboard_changes.Add(current_state, e.KeyData);
        }

        private void KeyboardSettingsPanel_Load(object sender, EventArgs e)
        {

        }


    }
}
