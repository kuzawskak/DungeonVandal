using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game.Settings
{
    public enum State { NONE, UP, DOWN, LEFT, RIGHT, BLOCK, DYNAMITE, RACKET };
   
    public class KeySettings
    {

        public Keys Up { get; private set; }
        public Keys Down { get; private set; }
        public Keys Left { get; private set; }
        public Keys Right { get; private set; }
        public Keys Block { get; private set; }
        public Keys Dynamite { get; private set; }
        public Keys Racket { get; private set; }
        public Keys Pause { get; private set; }
       

        public KeySettings(Dictionary<State, Keys> keys)
        {
       
            Pause = System.Windows.Forms.Keys.Escape;
            
        }

       /// <summary>
       /// Apply changes made in KeySettingsPanel
       /// </summary>
       /// <param name="key_changes"></param>
        public void ApplyChanges(Dictionary<State, Keys> key_changes)
        {
            Pause = System.Windows.Forms.Keys.Escape;
            foreach (State s in key_changes.Keys)
            {
                switch (s)
                {
                    case State.UP:
                        Up = key_changes[s];
                        break;
                    case State.DOWN:
                        Down = key_changes[s];
                        break;
                    case State.RIGHT:
                        Right = key_changes[s];
                        break;
                    case State.LEFT:
                        Left = key_changes[s];
                        break;
                    case State.DYNAMITE:
                        Dynamite = key_changes[s];
                        break;
                    case State.RACKET:
                        Racket = key_changes[s];
                        break;
                    case State.BLOCK:
                        Block = key_changes[s];
                        break;
                    default: break;
                }
            }
        }

        /// <summary>
        /// W przypadku kilku predefiniowanych ustawien - konstruktor z numerem ustawien
        /// </summary>
        /// <param name="number"></param>
        public KeySettings(int number)
        {
            Pause = System.Windows.Forms.Keys.Escape;
            switch (number)
            {
                case 1:
                    Up = Keys.W;
                    Down = Keys.S;
                    Left = Keys.A;
                    Right = Keys.D;
                    Block = Keys.Alt;
                    Dynamite = Keys.Space;
                    Racket = Keys.Return;
                    Pause = Keys.Escape;
                    break;
                case 2:
                    Up = Keys.Up;
                    Down = Keys.Down;
                    Left = Keys.Left;
                    Right = Keys.Right;
                    Block = Keys.Alt;
                    Dynamite = Keys.Space;
                    Racket = Keys.Return;
                    Pause = Keys.Escape;
                    break;
                case 3:
                    Up = Keys.NumPad8;
                    Down = Keys.NumPad2;
                    Left = Keys.NumPad4;
                    Right = Keys.NumPad6;
                    Block = Keys.Alt;
                    Dynamite = Keys.Space;
                    Racket = Keys.Return;
                    Pause = Keys.Escape;
                    break;
            }
        }

        /// <summary>
        /// Domyslne ustawienia
        /// </summary>
        public KeySettings()
        {
            Up = Keys.W;
            Down = Keys.S;
            Left = Keys.A;
            Right = Keys.D;
            Block = Keys.Alt;
            Dynamite = Keys.Space;
            Racket = Keys.Return;
            Pause = Keys.Escape;
        }
    }
}
