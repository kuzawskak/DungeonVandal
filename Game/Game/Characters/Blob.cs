using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Game.Characters
{
    class Blob : Enemy
    {
        Random rand = new Random();
        const string asset_name = "Blob";
        Queue<Game.direction> move_queue = new Queue<Game.direction>(); 
        public void Move()
        {
            //random move
        }
        
        public Blob(ContentManager content, Rectangle rectangle, int max_width, int max_height,int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.max_height = max_height;
            this.max_width = max_width;
            this.x = x;
            this.y = y;
            //same as vandals' velocity
            this.velocity = 5;
        }
        public Blob() { }

        public override void Update(GameTime gametime,Map.Map map)
        {
            Game.direction dir = (Game.direction)(rand.Next() % 4);
           
            switch (dir)
            {
                case Game.direction.down:
                    if(rectangle.Y<max_height-rectangle.Height)
                    rectangle.Y += velocity;
                    
                    break;
                case Game.direction.left:
                    if(rectangle.X>0)
                    rectangle.X -= velocity;
                    break;
                case Game.direction.right:
                    if(rectangle.X<max_width-rectangle.Width)
                    rectangle.X += velocity;
                    break;
                case Game.direction.up:
                    if(rectangle.Y>0)
                    rectangle.Y -= velocity;
                    break;
                default:
                    break;
                
            }
        }

        public void Die()
        {
            //TODO: fire animation
            //remove object from map(insert Puste in its place)
        }
    }
}
