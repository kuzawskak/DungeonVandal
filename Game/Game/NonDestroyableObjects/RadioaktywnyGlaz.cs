using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;

namespace Game.NonDestroyableObjects
{
    /// <summary>
    /// Obiekt reagujacy na gawitację, niezniszczalny, skażony i ciężki
    /// </summary>
    class RadioaktywnyGlaz : Map.MapObject, ReagujeNaGrawitacje, Skazony, Ciezki
    {
        /// <summary>
        /// Content dla tekstury
        /// </summary>
        private string asset_name = "Textures\\skazony";
        /// <summary>
        /// Stan (czy spada czy nie)
        /// </summary>
        private bool is_falling;
        /// <summary>
        /// /Predkosc spadania
        /// </summary>
        private int velocity = 5;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="content">Content odpowiedzilany za ladowanie tekstury</param>
        /// <param name="rectangle">Prostokat okreslajacy pozycje na ekranie gry</param>
        /// <param name="x"> Indeks x na mapie obiektow</param>
        /// <param name="y"> Indeks y na mapie obiektow</param>
        public RadioaktywnyGlaz(ContentManager content, Rectangle rectangle, int x, int y)
        {
            TypeTag = AIHelper.ElementType.RADIOAKTYWNYGLAZ;
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            IsAccesible = false;
            is_falling = false;
        }

        /// <summary>
        /// Aktualizacja stanu w zależności od otoczenia
        /// </summary>
        /// <param name="gametime"></param>
        /// <param name="map"></param>
        public override void Update(GameTime gametime, Map.Map map)
        {
            int x_index = rectangle.X / rectangle.Width;
            int y_index = rectangle.Y / rectangle.Height;

            //sprawdzenie wszytkich dookola pol
            if (map.is_vandal_on_rectangle(x_index - 1, y_index) ||
                map.is_vandal_on_rectangle(x_index + 1, y_index) ||
                map.is_vandal_on_rectangle(x_index, y_index - 1) ||
                map.is_vandal_on_rectangle(x_index, y_index + 1) ||
                map.is_vandal_on_rectangle(x_index - 1, y_index - 1) ||
                map.is_vandal_on_rectangle(x_index - 1, y_index + 1) ||
                map.is_vandal_on_rectangle(x_index + 1, y_index + 1) ||
                map.is_vandal_on_rectangle(x_index + 1, y_index - 1))
            {
                Zabij(map);
                return;
            }

            if (y_index == map.getHeight() - 1)
            {
                if (is_falling)
                {

                    map.setObject(x_index, y_index, this);
                    map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle, x_index, y_index - 1));
                    is_falling = false;
                    return;
                }
                else
                    return;
            }
            if (is_falling)
            {

                //nie spadl calkowice jeszcze na odpowiedni prosokat
                if (rectangle.Y % rectangle.Height != 0)
                {
                    Spadaj();
                }
                else
                {
                    map.setObject(x_index, y_index, this);
                    map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle,x_index, y_index - 1));
                    //pozniej zmienic na nondestroyable zamista puste
                    if (y_index < map.getHeight() - 1 && map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste))
                    {
                        Spadaj();
                        // break;
                    }
                    else is_falling = false;
                }
            }
            else if (map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste) && !map.is_vandal_on_rectangle(x_index, y_index + 1))
            {//rozpoczecie spadania
                is_falling = true;
                Spadaj();
            }
        }

        public void Spadaj()
        {
            rectangle.Y += velocity;
        }

        public void Zabij(Map.Map map)
        {
            map.vandal.is_alive = false;
        }

        public void Zgniec()
        {
            
        }
    }
}
