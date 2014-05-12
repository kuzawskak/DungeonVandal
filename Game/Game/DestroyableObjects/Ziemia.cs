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
    class Ziemia : Map.MapObject,Slaby,Zniszczalny
    {



        const string asset_name = "ziemia";
        void Slaby.Znikaj()
        {
            throw new NotImplementedException();
        }

        public Ziemia(ContentManager content, Rectangle rectangle)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            IsAccesible = true;

        }
        public override void Update(GameTime gametime, Map.Map map)
        {
            int x = rectangle.X/rectangle.Width;
            int y = rectangle.Y/rectangle.Width;
            if (map.is_vandal_exact_on_rectangle(x,y))
                map.setObject(x, y,new NonDestroyableObjects.Puste(content, this.Rectangle));
        }
        void Draw(GameTime gameTime) { }


        public void OnDestroy(ref Map.MapObject[,] objects)
        {
            throw new NotImplementedException();
        }
    }
}
