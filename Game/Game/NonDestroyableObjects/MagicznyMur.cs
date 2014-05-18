using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Timers;
using System.Windows.Forms;

namespace Game.NonDestroyableObjects
{
    /// <summary>
    /// Obiekt niezniszczalny, co pewnie losowy czas staje sie eteryczny (Vandal moze przez niego przejsc)
    /// a nastepnie znowy normalny
    /// Gdy Vandal pozostanie na tym miejscu w czasie gdy zmieni sie na nieeteryczny - ginie
    /// </summary>
    class MagicznyMur:Map.MapObject,Eteryczny
    {
        Random rand = new Random();
        /// <summary>
        /// Czas bycia eterycznym (liczba losowa z przedzialu od 2 do 7) w sekundach
        /// </summary>
        private int eteryczny_time;

        /// <summary>
        /// Content dla tekstury (na czas bycia nieeterycznym)
        /// </summary>
        private string asset_name = "Textures\\magiczny_mur";
        /// <summary>
        /// Cintent dla tekstury (na czas bycia eterycznym)
        /// </summary>
        private string eteryczny_asset_name = "Textures\\eteryczny_mur";
        /// <summary>
        /// Wartosc okraslajaca czy jest w danym momencie eteryczny
        /// </summary>
        private bool is_eteryczny = false;
        /// <summary>
        /// Timer do wyzanczenia czy jest eteryczny czy nie
        /// </summary>
        private System.Timers.Timer timer;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="content">Content odpowiedzilany za ladowanie tekstury</param>
        /// <param name="rectangle">Prostokat okreslajacy pozycje na ekranie gry</param>
        /// <param name="x"> Indeks x na mapie obiektow</param>
        /// <param name="y"> Indeks y na mapie obiektow</param>
        public MagicznyMur(ContentManager content, Rectangle rectangle, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            eteryczny_time = rand.Next(2, 7);
            timer = new System.Timers.Timer(eteryczny_time*1000);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            IsAccesible = false;
            timer.Start();
           
        }

        /// <summary>
        /// Aktualizacja stanu obiektu
        /// </summary>
        /// <param name="gametime">czas gry</param>
        /// <param name="map">mapa obiektów</param>
        public override void Update(GameTime gametime, Map.Map map)
        {
            if (!is_eteryczny&&map.is_vandal_on_rectangle(rectangle.X/rectangle.Width,rectangle.Y/rectangle.Height))
            {
                //ZniszczBohatera
                ZniszczBohatera(map);
            }
        
        }

        /// <summary>
        /// Zmiana na eteryczny/nieeteryczny w zaleznosci od aktualnego stanu
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //zmien na eteryczny
            texture = content.Load<Texture2D>(is_eteryczny ? asset_name : eteryczny_asset_name);            
            is_eteryczny = !is_eteryczny;
            IsAccesible = is_eteryczny;
            timer.Start();
        }

        /// <summary>
        /// Impelemntacja interfejsu eteryczny, zabicie bohatera
        /// </summary>
        public void ZniszczBohatera(Map.Map map)
        {
            map.vandal.is_alive = false;
        }
    }
}
