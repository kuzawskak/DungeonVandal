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
    /// Klasa przeciwnika , ktory porusza sie prosto
    /// jak napotka przeszkode skreca w lewo
    /// szybkosc poruszania taka sama jak gracza
    /// </summary>
    class Goblin : Enemy
    {

         //TODO; Dodac grafike go GameContent
        const string asset_name = "goblin";
        public Goblin(ContentManager content, Rectangle rectangle, int max_width, int max_height,int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.max_height = max_height;
            this.max_width = max_width;
            this.x = x;
            this.y = y;
            this.velocity = 5;
        }


        public void Move() { }

        public void Die() { 
            //upusc dynamit 
        }
    }
}
