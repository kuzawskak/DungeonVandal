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
    /// Klasa przcienika, ktory po zauwazeniu Vandala goni go
    /// w przeciwnym przypadku porusza sie losowo
    /// potrafi drazyc w ziemi
    /// Szybkosc rowna szybkosci gracza
    /// </summary>
    class GigantycznySzczur : Enemy
    {
        //TODO; Dodac grafike go GameContent
        const string asset_name = "gigantyczny_szczur";
        public GigantycznySzczur(ContentManager content, Rectangle rectangle, int max_width, int max_height,int x, int y)
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

        bool LookForVandal() { return false; }

        void Chase() { }
    }
}
