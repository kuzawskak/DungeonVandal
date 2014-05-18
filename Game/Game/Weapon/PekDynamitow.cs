﻿using System;
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

        private string asset_name = "Textures\\dynamites";
        private int i, j;
        public PekDynamitow(ContentManager content, Rectangle rectangle, int x, int y)
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
            map.addPlayersDynamites(5);
            map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, new NonDestroyableObjects.Puste(content, this.Rectangle));

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
