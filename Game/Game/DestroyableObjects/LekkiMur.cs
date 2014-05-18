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
    /// Obiekt zniszczalny bez specjalnych wlasciwosci
    /// </summary>
    class LekkiMur : Map.MapObject,Zniszczalny
    {


        private string asset_name = "Textures\\lekki_mur";

        public LekkiMur(ContentManager content, Rectangle rectangle, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.IsAccesible = false;

        }
        void Draw(GameTime gameTime) { }

        public void OnDestroy(Map.Map map)
        {

        }
    }
}
