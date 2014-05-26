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
    class PekDynamitow :  Weapon, Zniszczalny
    {
        private string asset_name = "Textures\\dynamites";
        public PekDynamitow(ContentManager content, Rectangle rectangle, int x, int y):base(content,rectangle,x,y)
        {
            this.TypeTag = AIHelper.ElementType.PEKDYNAMITOW;
            this.texture = content.Load<Texture2D>(asset_name);
        }

         public override void OnFound(Map.Map map)
        {
            found_soundEffect.Play();
            map.addPlayersDynamites(5);

        }

        public override void Update(GameTime gametime, Map.Map map)
        {

        }

    }
}
