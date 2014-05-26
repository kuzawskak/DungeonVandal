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
    class PoleSilowe :  Weapon, Zniszczalny
    {

        private string asset_name = "Textures\\pole_silowe";
        private const int speed = 5;

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
            : base(content, rectangle, x, y)
        {
            this.TypeTag = AIHelper.ElementType.POLESILOWE;
            this.texture = content.Load<Texture2D>(asset_name);
        }

        public override void OnFound(Map.Map map)
        {
            found_soundEffect.Play();
            map.setVandalImmortal();
        }


        public override void Update(GameTime gametime, Map.Map map)
        {

        }


    }

}
