using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;

namespace Game.Weapon
{
    class PekDynamitow : Map.MapObject, Zniszczalny, Weapon
    {
        SoundEffect soundEffect;

        private string asset_name = "dynamites";
        private int i, j;
        public PekDynamitow(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            soundEffect = content.Load<SoundEffect>("found");
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.i = x / rectangle.Width;
            this.j = y / rectangle.Height;
            IsAccesible = true;

        }

        public void OnFound(Map.Map map)
        {
            soundEffect.Play();
            map.addPlayersDynamites(5);
            map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, new NonDestroyableObjects.Puste(content, this.Rectangle));

        }

        public override void Update(GameTime gametime, Map.Map map)
        {
            if (rectangle.Intersects(map.getVandalRectangle()))
                this.OnFound(map);
        }
        public void OnDestroy(ref Map.MapObject[,] objects)
        {
            //oznacz odpowiednie pole jak puste
            objects[i, j] = new NonDestroyableObjects.Puste(content, objects[i, j].Rectangle);
        }

    }
}
