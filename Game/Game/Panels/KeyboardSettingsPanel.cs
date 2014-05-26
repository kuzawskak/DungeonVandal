using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Game.Settings;
using DungeonVandal;

namespace Game.Panels
{
    
    public partial class KeyboardSettingsPanel : UserControl
    {
        Dictionary<State, Keys> keyboard_changes = new Dictionary<State, Keys>();
        State current_state = State.NONE;
        public KeyboardSettingsPanel()
        {
            InitializeComponent();
          
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownHandler);
        }

        public void LoaderPlayerSettings()
        {
            Settings.KeySettings current_settings = ((MenuForm)Parent).player.KeyboardSettings;
            button1.Text = current_settings.Up.ToString();
            button2.Text = current_settings.Down.ToString();
            button3.Text = current_settings.Right.ToString();
            button4.Text = current_settings.Left.ToString();
            button5.Text = current_settings.Block.ToString();
            button6.Text = current_settings.Dynamite.ToString();
            button7.Text = current_settings.Racket.ToString();


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
            {
                switch (current_state)
                {
                    case State.UP:
                        button1.Text = e.KeyCode.ToString();
                   
                        break;
                    case State.DOWN:
                        button2.Text = e.KeyCode.ToString();
                        break;
                    case State.LEFT:
                        button4.Text = e.KeyCode.ToString();
                        MessageBox.Show(e.KeyValue.ToString());
                        break;
                    case State.RIGHT:
                        button3.Text = e.KeyCode.ToString();
                        break;
                    case State.DYNAMITE:
                        button6.Text = e.KeyCode.ToString();
                        break;
                    case State.RACKET:
                        button7.Text = e.KeyCode.ToString();
                        break;
                    case State.BLOCK:
                        button5.Text = e.KeyCode.ToString();
                        break;
                    
                }
                keyboard_changes.Add(current_state, e.KeyData);
            }
        }

        private void KeyboardSettingsPanel_Load(object sender, EventArgs e)
        {

        }



        private void KeyboardSettingsPanel_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void KeyboardSettingsPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

 

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button1.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button2.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button3.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
            }
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button4.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
            }
        }

        private void button4_KeyUp(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button5.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
            }
        }

        private void button5_KeyUp(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button6.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
            }
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button7.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
            }
        }

        private void button7_KeyUp(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            //apply_settings

            ((MenuForm)Parent).player.KeyboardSettings.ApplyChanges(keyboard_changes);
            this.Visible = false;
            ((MenuForm)Parent).settings_panel.Visible = true;
       
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //predefiniowane ustawienia - pokaz panel
            this.Visible = false;
            ((MenuForm)Parent).predefined_settings_panel.Visible = true;
           

        }

        private void button6_KeyUp(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            current_state = State.NONE;
        }

        private void button2_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                keyboard_changes = ((MenuForm)Parent).player.KeyboardSettings.ToMap();
                ClearSettingsChanges();
                LoaderPlayerSettings();
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button1.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
                current_state = State.NONE;
            }
        }


        private void button3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button3.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
                current_state = State.NONE;
            }

        }

        private void button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button2.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
                current_state = State.NONE;
            }
        }

        private void button4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button4.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
                current_state = State.NONE;
            }
        }

        private void button5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button5.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
                current_state = State.NONE;
            }
        }

        private void button6_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!keyboard_changes.ContainsValue(e.KeyData))
            {
                button6.Text = e.KeyCode.ToString();
                TryAddNewSetting(current_state, e.KeyData);
                current_state = State.NONE;
            }
        }

        private void button7_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            button7.Text = e.KeyCode.ToString();
            TryAddNewSetting(current_state, e.KeyData);
            current_state = State.NONE;
        }

        private void ClearSettingsChanges()
        {
            keyboard_changes.Clear();
        }

        private void TryAddNewSetting(State state, Keys keydata)
        {
            if(keyboard_changes.ContainsKey(state))
            keyboard_changes.Remove(state);
            keyboard_changes.Add(state, keydata);
        }


    }
}
