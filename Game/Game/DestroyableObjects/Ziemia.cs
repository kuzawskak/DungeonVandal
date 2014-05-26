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
    /// Klasa obiektu Ziemia (zajmuje większość mapy)
    /// 
    /// </summary>
    class Ziemia : Map.MapObject,Slaby,Zniszczalny
    {
        /// <summary>
        /// Punkty naliczane za zniszczenie obiektu
        /// </summary>
        int points;
        /// <summary>
        /// Nazwa assetu dla XNA Content
        /// </summary>
        const string asset_name = "Textures\\ziemia";

        /// <summary>
        /// Znikanie obiektu po przejściu Vandala
        /// </summary>
        /// <param name="map"></param>
        public void Znikaj(Map.Map map)
        {       
            int x_ind = (int)(this.rectangle.X / this.Rectangle.Width);
            int y_ind = (int)(this.rectangle.Y / this.Rectangle.Height);
            map.setObject(x_ind, y_ind, new NonDestroyableObjects.Puste(content, new Rectangle((x_ind) * this.rectangle.Width, y_ind * this.Rectangle.Height, this.rectangle.Width, this.rectangle.Width),x_ind,y_ind));
        }

        public Ziemia(ContentManager content, Rectangle rectangle,int x, int y,int intelligence_level)
        {
            TypeTag = AIHelper.ElementType.ZIEMIA;
            switch (intelligence_level)
            {
                case 0:
                    this.points = 3;
                    break;
                case 1:
                    this.points = 2;
                    break;
                case 2:
                    this.points = 1;
                    break;
            }
            this.x = x;
            this.y = y;
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            IsAccesible = true;

        }

        /// <summary>
        /// Aktualizacja stanu obiektu w zależności od tego czy Vandal po nim chodzi
        /// </summary>
        /// <param name="gametime"></param>
        /// <param name="map"></param>
        public override void Update(GameTime gametime, Map.Map map)
        {
            int x = rectangle.X/rectangle.Width;
            int y = rectangle.Y/rectangle.Width;
            if (map.is_vandal_on_rectangle(x, y))
            {
                
                this.Znikaj(map);
            }
        }
        void Draw(GameTime gameTime) { }

        /// <summary>
        /// Obsługa zniszczenia obiektu
        /// </summary>
        /// <param name="map"></param>
        public void OnDestroy(Map.Map map)
        {
            map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, new NonDestroyableObjects.Puste(content, this.Rectangle, rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height));
            map.AddPlayersPoints(points);
            
        }
    }
}
