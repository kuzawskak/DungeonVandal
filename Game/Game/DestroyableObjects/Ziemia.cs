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
        int points;
        const string asset_name = "ziemia";
        public void Znikaj(Map.Map map)
        {
        
            int x_ind = (int)(this.rectangle.X / this.Rectangle.Width);
            int y_ind = (int)(this.rectangle.Y / this.Rectangle.Height);
            map.setObject(x_ind, y_ind, new NonDestroyableObjects.Puste(content, new Rectangle((x_ind) * this.rectangle.Width, y_ind * this.Rectangle.Height, this.rectangle.Width, this.rectangle.Width)));
        }

        public Ziemia(ContentManager content, Rectangle rectangle,int intelligence_level)
        {
            switch (intelligence_level)
            {
                case 0:
                    this.points = 3;
                    break;
                case 1:
                    this.points = 2;
                    break;
                case 2:
                    this.points = 1;
                    break;
            }
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            IsAccesible = true;

        }
        public override void Update(GameTime gametime, Map.Map map)
        {
            int x = rectangle.X/rectangle.Width;
            int y = rectangle.Y/rectangle.Width;
            if (map.is_vandal_exact_on_rectangle(x, y))
            {
                
                this.Znikaj(map);
            }
        }
        void Draw(GameTime gameTime) { }


        public void OnDestroy(Map.Map map)
        {
            map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, new NonDestroyableObjects.Puste(content, this.Rectangle));
            map.AddPlayersPoints(points);
            
        }
    }
}
