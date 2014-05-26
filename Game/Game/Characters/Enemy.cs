using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Game.Characters
{
    /// <summary>
    /// Klasa bazowa przeciwnika 
    /// Kazdy przeciwnik porusza się z nadana mu predkoscia
    /// </summary>
    public class Enemy:Map.MapObject
    {
        /// <summary>
        /// Czestotliwość aktualizowania pozycji na mapie ( determinuje prędkość wroga)
        /// </summary>
        protected int move_frequency;
        
        /// <summary>
        /// AKtualny kierunek ruchu
        /// </summary>
        protected Game.direction current_direction;
        //ograniczenia mapy - okreslaja granice po ktorych przeciwnik moze sie poruszac
        protected int max_height, max_width;

        /// <summary>
        /// Konstruktor 
        /// </summary>
        /// <param name="content">XNA Content</param>
        /// <param name="rectangle">Prostokąt określający pozycję na mapie</param>
        /// <param name="x">indeks w tablicy obiektów</param>
        /// <param name="y">indeks w tablicy obiektów</param>
        public Enemy(ContentManager content, Rectangle rectangle, int x, int y)
            : base(content, rectangle, x, y)
        {
        }



        /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
       protected Map.MapObject collision_obj = null;

        /// <summary>
        /// Poruszanie w określonym kierunku
        /// </summary>
        /// <param name="add_x">Zmiana indeksu x na tablicy obiektów</param>
        /// <param name="add_y">Zmiana indeksu y na tablicy obiektów </param>
        /// <param name="map">Mapa obiektów</param>
        public void MoveInDirection(int add_x, int add_y, Map.Map map)
        {
            int new_x = x + add_x;
            int new_y = y + add_y;
            collision_obj = map.getObject(new_x, new_y);
            if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste) || collision_obj.GetType() == typeof(DestroyableObjects.Ziemia))
            {
                map.setObject(new_x, new_y, this);
                map.setObject(x, y, new NonDestroyableObjects.Puste(content, new Rectangle(x * this.rectangle.Width, y * this.rectangle.Height, this.rectangle.Width, this.rectangle.Height),x,y));
                x = new_x;
                y = new_y;
            }
        }


        /// <summary>
        /// Reakcja na zabicie
        /// </summary>
        /// <param name="map"></param>
        public void Die(Map.Map map)
        {
        }


        

    }
}
