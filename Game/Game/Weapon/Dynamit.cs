using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Game.Weapon
{
    class Dynamit : Map.MapObject, Zniszczalny, Weapon
    {
        /// <summary>
        /// Efekt dzwiekowy na znalezienie dynamitu
        /// </summary>
        SoundEffect found_soundEffect;
        /// <summary>
        /// Efekt dzwiekowy na wybuch dynamitu
        /// </summary>
        SoundEffect fired_soundEffect;
        /// <summary>
        /// Czas po ktorym wybuchnie w przypadku odpalonego dynamitu
        /// </summary>
        private int sleep_time = 3000;
        private string asset_name = "dynamite";
        /// <summary>
        /// Czy dynamit jest odpalony
        /// </summary>
        private bool is_fired;
        /// <summary>
        /// indeksy na mapie
        /// </summary>
        private int i, j;
        private GameTime start_time;

        /// <summary>
        /// Konstruktor dla nieodpalonego dynamitu
        /// </summary>
        /// <param name="content"></param>
        /// <param name="rectangle"></param>
        /// <param name="max_width"></param>
        /// <param name="max_height"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Dynamit(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.i =x / rectangle.Width;
            this.j = y / rectangle.Height;
            this.is_fired = false;
            this.IsAccesible = true;
            found_soundEffect = content.Load<SoundEffect>("found");
            fired_soundEffect = content.Load<SoundEffect>("explosion_sound");


        }

        /// <summary>
        /// Konstruktor dla odpalonego dynamitu
        /// </summary>
        /// <param name="content"></param>
        /// <param name="rectangle"></param>
        /// <param name="max_width"></param>
        /// <param name="max_height"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="gametime"></param>
        public Dynamit(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y, GameTime gametime)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.i = x / rectangle.Width;
            this.j = y / rectangle.Height;
            this.is_fired = true;
            IsAccesible = true;
            found_soundEffect = content.Load<SoundEffect>("found");
            fired_soundEffect = content.Load<SoundEffect>("explosion_sound");
            this.start_time = gametime;

        }

        /// <summary>
        /// Akcja w przypadku znalezienia dynamitu przez Vandala
        /// </summary>
        /// <param name="map"></param>
        public void OnFound( Map.Map map)
        {
            if (!is_fired)
            {
                found_soundEffect.Play();
                map.addPlayersDynamites(1);
                map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, new NonDestroyableObjects.Puste(content, this.Rectangle));
            }
           // zabij Vandala
            //else map.getVandal().onDestroy();
          
        }


        public override void Update(GameTime gametime, Map.Map map)
        {
            if (rectangle.Intersects(map.getVandalRectangle()))
                this.OnFound(map);
         
            if (is_fired &&(gametime.TotalGameTime- start_time.TotalGameTime).Milliseconds>=3000)
                {
                    //TODO: sprawdzic czemu metoda nie startuje
                    this.OnDestroy(map);                   
                }
            
        }


        public void OnDestroy(Map.Map map)
        {
            //oznacz odpowiednie pole jak puste
            fired_soundEffect.Play();
            map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, new NonDestroyableObjects.Puste(content, this.Rectangle));
        }


        /// <summary>
        /// implementacja interfejsu Zniszczalny
        /// </summary>
        /// <param name="objects"></param>
        public void OnDestroy(ref Map.MapObject[,] objects)
        {
            throw new NotImplementedException();
        }
    }
}
