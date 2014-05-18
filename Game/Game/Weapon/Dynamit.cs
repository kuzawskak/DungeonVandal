using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.Timers;

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
        const int sleep_time = 3000;

        private string asset_name = "Textures\\dynamite";
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
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Dynamit(ContentManager content, Rectangle rectangle, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.is_fired = false;
            this.IsAccesible = true;
            found_soundEffect = content.Load<SoundEffect>("Audio\\found");
            fired_soundEffect = content.Load<SoundEffect>("Audio\\explosion_sound");


        }

        private Timer timer;
        /// <summary>
        /// Konstruktor dla odpalonego dynamitu
        /// </summary>
        /// <param name="content"></param>
        /// <param name="rectangle"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="gametime"></param>
        public Dynamit(ContentManager content, Rectangle rectangle,int x, int y, GameTime gametime)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.is_fired = false;
            IsAccesible = true;
            found_soundEffect = content.Load<SoundEffect>("Audio\\found");
            fired_soundEffect = content.Load<SoundEffect>("Audio\\explosion_sound");
            this.start_time = gametime;
            timer = new Timer(sleep_time);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Start();
            

        }


        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            is_fired = true;        
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
         
            if (is_fired)
                {
                    Map.MapObject obj;
                    //TODO: sprawdzic czemu metoda nie startuje
                    this.OnDestroy(map);
                    obj = map.getObject(x - 1, y-1);
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                    
                    obj = map.getObject(x - 1, y+1);
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                    obj = map.getObject(x - 1, y );
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                    obj = map.getObject(x , y-1);
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                    obj = map.getObject(x , y+1);
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                    obj = map.getObject(x + 1, y);
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                    obj = map.getObject(x + 1, y-1);
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                    obj = map.getObject(x + 1, y + 1);
                    if (obj is Zniszczalny) (obj as Zniszczalny).OnDestroy(map);
                    else if (obj.GetType() == typeof(Characters.Enemy))
                        (obj as Characters.Enemy).Die(map);
                }
            
        }


        public void OnDestroy(Map.Map map)
        {
            if(is_fired)
            //oznacz odpowiednie pole jak puste
            fired_soundEffect.Play();

            else map.addPlayersDynamites(1);

            map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, new NonDestroyableObjects.Puste(content, this.Rectangle));
        }


        
    }
}
