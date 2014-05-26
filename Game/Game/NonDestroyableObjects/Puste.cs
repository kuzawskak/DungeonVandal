using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.NonDestroyableObjects;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Game.NonDestroyableObjects
{
    /// <summary>
    /// Niezniszczalne pole, po którym moga się swobodnie poruszac bohater i przeciwnicy
    /// oraz moga spadac na tej sciezce obiekty reagujace na grawitacje
    /// </summary>
    class Puste:Map.MapObject
    {
        /// <summary>
        /// Content dla tekstury
        /// </summary>
        const string asset_name = "Textures\\puste";

        public Puste(ContentManager content, Rectangle rectangle,int x, int y):base(content,rectangle,x,y)
        {
            TypeTag = AIHelper.ElementType.PUSTE;
            this.texture = content.Load<Texture2D>(asset_name);
            IsAccesible = true;

        }


   
    }
}
