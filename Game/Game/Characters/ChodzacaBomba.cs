using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game.Characters
{
    /// <summary>
    /// Klasa przeciwnika poruszajacego sie 2 razy szybciej niz Vandal, 
    /// gdy trafi na jakis obiekt wybucha
    /// </summary>
    class ChodzacaBomba : Enemy
    {
        //TODO: Dodac grafike do GameContent
        const string asset_name = "chodzaca_bomba";

        public ChodzacaBomba(ContentManager content, Rectangle rectangle, int max_width, int max_height,int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.max_height = max_height;
            this.max_width = max_width;
            this.x = x;
            this.y = y;
            //2 razy szybszy niz gracz
            this.velocity = 10;
        }

        public void FireBomb()
        {
        }
        public void Die()
        {
        }
        public void Move()
        {
        }
       
    }
}
