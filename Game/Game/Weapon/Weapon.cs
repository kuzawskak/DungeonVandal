using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace Game.Weapon
{
    /// <summary>
    /// Klasa broni  - bazowa dla wszytkich typów broni
    /// </summary>
    class Weapon: Map.MapObject
    {
        /// <summary>
        /// Stan broni - czy odpalona , czy do zebrania (false)
        /// </summary>
        protected bool is_fired ;

        /// <summary>
        /// Efekt dzwiekowy na znalezienie broni
        /// </summary>
        protected SoundEffect found_soundEffect;

        /// <summary>
        /// Konstruktor dla nieodpalonej broni
        /// </summary>
        /// <param name="content"></param>
        /// <param name="rectangle"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Weapon(ContentManager content, Rectangle rectangle, int x, int y):base(content,rectangle,x,y)
        {
            this.found_soundEffect = content.Load<SoundEffect>("Audio\\found");
            this.IsAccesible = true;
        }

        /// <summary>
        /// Reakcja na znalezienie broni (zwiekszenie ilosci odpowiedniego typu broni)
        /// </summary>
        /// <param name="map">Mapa obiektów</param>
        public virtual void OnFound(Map.Map map)
        {

        }

        /// <summary>
        /// Reakcja na zniszczenie obiektu (zastąpienie pustym polem)
        /// </summary>
        /// <param name="map">Mapa obiektów</param>
        public void OnDestroy(Map.Map map)
        {
            map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.Rectangle,x,y));
        }
    }
}
