using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game.NonDestroyableObjects
{
    /// <summary>
    /// Obiekt niezniszczalny bez specjalnych wlasciwosci
    /// </summary>
    class CiezkiMur:Map.MapObject
    {
        /// <summary>
        /// Content dla tekstury
        /// </summary>
        private string asset_name = "Textures\\ciezki_mur";

        public CiezkiMur(ContentManager content, Rectangle rectangle, int x, int y)
        {
            TypeTag = AIHelper.ElementType.CIEZKIMUR;
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;

        }
    }
}
