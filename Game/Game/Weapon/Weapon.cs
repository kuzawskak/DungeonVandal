using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace Game.Weapon
{
    class Weapon: Map.MapObject
    {
        protected bool is_fired ;

        /// <summary>
        /// Efekt dzwiekowy na znalezienie dynamitu
        /// </summary>
        protected SoundEffect found_soundEffect;

        public Weapon(ContentManager content, Rectangle rectangle, int x, int y):base(content,rectangle,x,y)
        {
            this.found_soundEffect = content.Load<SoundEffect>("Audio\\found");
            this.IsAccesible = true;
        }


        public virtual void OnFound(Map.Map map)
        {

        }

        public void OnDestroy(Map.Map map)
        {
            map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.Rectangle,x,y));
        }
    }
}
