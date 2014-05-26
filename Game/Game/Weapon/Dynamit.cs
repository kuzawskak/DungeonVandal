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
    class Dynamit : Weapon, Zniszczalny
    {

        /// <summary>
        /// Efekt dzwiekowy na wybuch dynamitu
        /// </summary>
        SoundEffect fired_soundEffect;
        /// <summary>
        /// Czas po ktorym wybuchnie w przypadku odpalonego dynamitu
        /// </summary>
        const int sleep_time = 3000;

        private string asset_name = "Textures\\dynamite";

        private GameTime start_time;

        /// <summary>
        /// Konstruktor dla nieodpalonego dynamitu
        /// </summary>
        /// <param name="content"></param>
        /// <param name="rectangle"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Dynamit(ContentManager content, Rectangle rectangle, int x, int y)
            :base(content,rectangle,x,y)
        {
            this.TypeTag = AIHelper.ElementType.DYNAMIT;
            this.texture = content.Load<Texture2D>(asset_name);
            this.IsAccesible = true;
            this.is_fired = false;
            this.fired_soundEffect = content.Load<SoundEffect>("Audio\\explosion_sound");
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
            : base(content, rectangle, x, y)
        {
            this.TypeTag = AIHelper.ElementType.DYNAMIT;
            this.texture = content.Load<Texture2D>(asset_name);
            this.is_fired = false;
            this.IsAccesible = true;
            this.fired_soundEffect = content.Load<SoundEffect>("Audio\\explosion_sound");
            this.start_time = gametime;
            this.timer = new Timer(sleep_time);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Start();
            

        }


        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            is_fired = true;        
        }


        public override void Update(GameTime gametime, Map.Map map)
        {
            //if (rectangle.Intersects(map.getVandalRectangle()))
           //     this.OnFound(map);
         
            if (is_fired)
                {
                    Map.MapObject obj;
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




         public override void OnFound(Map.Map map)
        {

            found_soundEffect.Play();
            map.addPlayersDynamites(1);

        }


        
    }
}
