using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace Game.Weapon
{
    class PoleSilowe : Map.MapObject, Zniszczalny, Weapon
    {

        SoundEffect soundEffect;
        private string asset_name = "Textures\\pole_silowe";
        private bool is_fired = false;
        private const int speed = 5;
        Game.direction direction;

        private int i, j;
        /// <summary>
        /// Costructor for static racket (getting this racket gives racket_points)
        /// </summary>
        /// <param name="content"> XNA Content </param>
        /// <param name="rectangle"> XNA Rectangle </param>
        /// <param name="max_width"> width of the whole map</param>
        /// <param name="max_height">height of the whole map</param>
        /// <param name="x"> the initial rectangle x value</param>
        /// <param name="y"> the initail rectangle y value</param>
        public PoleSilowe(ContentManager content, Rectangle rectangle, int x, int y)
        {
            soundEffect = content.Load<SoundEffect>("Audio\\found");
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            IsAccesible = true;

        }

        public void OnFound(Map.Map map)
        {
            soundEffect.Play();
            map.setVandalImmortal();
            map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.Rectangle));

        }


        public override void Update(GameTime gametime, Map.Map map)
        {
            if (rectangle.Intersects(map.getVandalRectangle()))
                this.OnFound(map);
        }
        public void OnDestroy(Map.Map map)
        {
            OnFound(map);
        }

    }

}
