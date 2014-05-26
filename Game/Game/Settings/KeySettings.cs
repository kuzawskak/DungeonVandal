using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game.Settings
{
    /// <summary>
    /// Aktualny stan wyboru ustawień ( determinuje który klawisz jest zmieniany)
    /// </summary>
    public enum State { NONE, UP, DOWN, LEFT, RIGHT, BLOCK, DYNAMITE, RACKET };
   
    /// <summary>
    /// Klasa ustawien sterowania
    /// </summary>
    public class KeySettings
    {
        /// <summary>
        /// Klawisz poruszania w górę
        /// </summary>
        public Keys Up { get; private set; }
        /// <summary>
        /// Klawicz poruszania w dół
        /// </summary>
        public Keys Down { get; private set; }
        /// <summary>
        /// Klawisz poruszania w lewo
        /// </summary>
        public Keys Left { get; private set; }
        /// <summary>
        /// Klawisz poruszania w prawo
        /// </summary>
        public Keys Right { get; private set; }
        /// <summary>
        /// Klawisz blokowania ruchu (zmiana kierunku poruszania w miejscu)
        /// </summary>
        public Keys Block { get; private set; }
        /// <summary>
        /// Klawisz odpalenia dynamitu
        /// </summary>
        public Keys Dynamite { get; private set; }
        /// <summary>
        /// Klawisz odpalenia rakiety
        /// </summary>
        public Keys Racket { get; private set; }
        /// <summary>
        /// Klawisz pauzy
        /// </summary>
        public Keys Pause { get; private set; }
       



       /// <summary>
       /// Zastosuj zmiany uwzglednione w Dictionary ze zmianami
       /// </summary>
       /// <param name="key_changes">Zmiany do zastosowania</param>
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
        /// Konwersja ustawien sterowania na słownik indeksowany STanem klawiszy
        /// </summary>
        /// <returns>Słownik z aktualnymi ustawieniami sterowania</returns>
        public Dictionary<State, Keys> ToMap()
        {
            Dictionary<State, Keys> dict = new Dictionary<State, Keys>();
            dict.Add(State.UP, Up);
            dict.Add(State.DOWN, Down);
            dict.Add(State.LEFT, Left);
            dict.Add(State.RIGHT, Right);
            dict.Add(State.DYNAMITE, Dynamite);
            dict.Add(State.BLOCK,Block);
            dict.Add(State.RACKET, Racket);
            return dict;

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
        /// Domyslne ustawienia (poruszanie strzałkami)
        /// </summary>
        public KeySettings()
        {
            Up = Keys.Up;
            Down = Keys.Down;
            Left = Keys.Left;
            Right = Keys.Right;
            Block = Keys.Alt;
            Dynamite = Keys.Space;
            Racket = Keys.Return;
            Pause = Keys.Escape;
        }
    }
}
