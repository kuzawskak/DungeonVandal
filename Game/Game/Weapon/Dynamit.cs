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
    /// <summary>
    /// Klasa dynamitu - w zależności od konstruktora jest to broń odpalona lub do zebrania
    /// </summary>
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

        /// <summary>
        /// Ścieżka do tekstury
        /// </summary>
        private string asset_name = "Textures\\dynamite";

        /// <summary>
        /// Czas startowy odpalenia lontu
        /// </summary>
        private GameTime start_time;

        /// <summary>
        /// Timer liczący czas na wybuch dynamitu od momentu odpalenia
        /// </summary>
        private Timer timer;

        /// <summary>
        /// Konstruktor dla nieodpalonego dynamitu
        /// </summary>
        /// <param name="content">XNA Content</param>
        /// <param name="rectangle">Prostokat reprezentujacy obiekt na mapie</param>
        /// <param name="x">indeks x na mapie obiektów</param>
        /// <param name="y">indeks y na mapie obiektów</param>
        public Dynamit(ContentManager content, Rectangle rectangle, int x, int y)
            :base(content,rectangle,x,y)
        {
            this.TypeTag = AIHelper.ElementType.DYNAMIT;
            this.texture = content.Load<Texture2D>(asset_name);
            this.IsAccesible = true;
            this.is_fired = false;
            this.fired_soundEffect = content.Load<SoundEffect>("Audio\\explosion_sound");
        }

         
     
        /// <summary>
        /// Konstruktor dla odpalonego dynamitu
        /// </summary>
        /// <param name="content">XNA Content</param>
        /// <param name="rectangle">Prostokat reprezentujacy obiekt na mapie</param>
        /// <param name="x">indeks x na mapie obiektów</param>
        /// <param name="y">indeks y na mapie obiektów</param>
        /// <param name="gametime">Czas gry</param>
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

        /// <summary>
        /// Reakcja na upływ czasu potrzebnego na wybuch odpalonego dynamitu
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            is_fired = true;        
        }

        /// <summary>
        /// Aktualizacja stanu dynamitu
        /// </summary>
        /// <param name="gametime">czas gry</param>
        /// <param name="map">mapa obiektów</param>
        public override void Update(GameTime gametime, Map.Map map)
        {

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



        /// <summary>
        /// Reakcja na znalezienie przez Vandala
        /// </summary>
        /// <param name="map">mapa obiektów</param>
         public override void OnFound(Map.Map map)
        {
            found_soundEffect.Play();
            map.addPlayersDynamites(1);

        }


        
    }
}
