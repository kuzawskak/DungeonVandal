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
    class Puste:Map.MapObject
    {
        const string asset_name = "puste";

        public Puste(ContentManager content, Rectangle rectangle)
        {
            this.texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            IsAccesible = true;

        }


   
    }
}
