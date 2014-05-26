using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace Game.DestroyableObjects
{
    /// <summary>
    /// Obiekt zniszczalny za pomoca eksplozji
    /// Można go przesuwać jeśli jest za nim puste pole
    /// Spada gdy ma pod sobą puste pole
    /// </summary>
    class Kamien : Map.MapObject, ReagujeNaGrawitacje, Przesuwalny, Ciezki, Zniszczalny
    {
        
        /// <summary>
        /// Predkosc spadania
        /// </summary>
        int velocity = 1;

        /// <summary>
        /// Tekstura dla Content XNA
        /// </summary>
        private string asset_name = "Textures\\kamien";

        /// <summary>
        /// Punkty naliczane za zgniecenie przedmiotu
        /// </summary>
        private int points = 5;
        /// <summary>
        /// Aktualny stan (czy spada czy nie)
        /// </summary>
        private bool is_falling;

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        /// <param name="content">XNA content</param>
        /// <param name="rectangle">Prostokąt określający na mapie</param>
        /// <param name="x">Współrzedna x na tablicy obiektów</param>
        /// <param name="y">Współrzędna y na tablicy obiektów</param>
        public Kamien(ContentManager content, Rectangle rectangle, int x, int y)
        {
            TypeTag = AIHelper.ElementType.KAMIEN;
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;

            this.is_falling = false;
            IsAccesible = false;
        }

        /// <summary>
        /// Aktualizacja stanu na mapie z uwzględnieniem spadania
        /// </summary>
        /// <param name="gametime"></param>
        /// <param name="map"></param>
        public override void Update(GameTime gametime, Map.Map map)
        {
            int x_index = rectangle.X / rectangle.Width;
            int y_index = rectangle.Y / rectangle.Height;
            if (y_index == map.getHeight() - 1)
            {
                if (is_falling)
                {
                    map.setObject(x_index, y_index, this);
                    map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle, x_index, y_index - 1));
                    is_falling = false;
                    return;
                }
                else return;
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
                    map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle, x_index, y_index - 1));
                    if (y_index < map.getHeight() - 1 && map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste))
                    {
                        Spadaj();
                    }
                    else is_falling = false;
                }
            }
            else if (map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste) && !map.is_vandal_on_rectangle(x_index, y_index + 1))
            {//rozpoczecie spadania
                is_falling = true;
                Spadaj();
            }
            else return;
        }

        public void Spadaj()
        {
            rectangle.Y += velocity;
        }


        /// <summary>
        /// Przesuwanie 
        /// </summary>
        /// <param name="map"> Aktualna mapa obiektów</param>
        /// <param name="x_vel">Predkość w poziomie</param>
        /// <returns></returns>
        public bool Przesun(Map.Map map, int x_vel)
        {
            if (map.vandal != null)
            {
                if (map.GetVandalDirection() == Game.direction.left && map.getObject((int)(x_vel / this.Rectangle.Width) - 1, (int)(map.getVandalRectangle().Y / map.getVandalRectangle().Height)).GetType() == typeof(NonDestroyableObjects.Puste))
                {
                    if ((x_vel) % this.rectangle.Width == 0)
                    {
                        int x_ind = (int)(x_vel / this.Rectangle.Width);
                        int y_ind = (int)(this.Rectangle.Y / this.Rectangle.Height);
                        map.setObject(x_ind, y_ind, this);
                        map.setObject(x_ind + 1, y_ind, new NonDestroyableObjects.Puste(content, new Rectangle((x_ind + 1) * this.rectangle.Width, y_ind * this.Rectangle.Height, this.rectangle.Width, this.rectangle.Width), x_ind + 1, y_ind));

                    }

                    rectangle.X = x_vel;
                    return true;

                }
                if (map.GetVandalDirection() == Game.direction.right && map.getObject((int)(x_vel / this.Rectangle.Width), (int)(map.getVandalRectangle().Y / map.getVandalRectangle().Height)).GetType() == typeof(NonDestroyableObjects.Puste))
                {
                    if ((x_vel) % this.rectangle.Width == 0)
                    {
                        int x_ind = (int)(x_vel / this.Rectangle.Width);
                        int y_ind = (int)(this.Rectangle.Y / this.Rectangle.Height);
                        map.setObject(x_ind - 1, y_ind, this);
                        map.setObject(x_ind, y_ind, new NonDestroyableObjects.Puste(content, new Rectangle((x_ind - 1) * this.rectangle.Width, y_ind * this.Rectangle.Height, this.rectangle.Width, this.rectangle.Width), x_ind, y_ind));
                    }
                    rectangle.X = x_vel;
                    return true;
                }
            }
            return false;
        }


        public void Zgniec()
        {
           
        }

        public void OnDestroy(Map.Map map)
        {
            map.AddPlayersPoints(points);
        }

    }
}
