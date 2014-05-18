using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Game.Characters
{
    /// <summary>
    /// Klasa bazowa przeciwnika 
    /// kazdy przeciwnik uzywa AIHelper-a
    /// Kazdy przeciwnik porusza się z nadana mu predkoscia
    /// </summary>
    public class Enemy:Map.MapObject
    {
        protected int velocity;
        
        protected Game.direction current_direction;
        //ograniczenia mapy - okreslaja granice po ktorych przeciwnik moze sie poruszac
        protected int max_height, max_width;

        public void Move(Game.direction direction) {
            current_direction = direction;

            switch (direction)
            {
                case Game.direction.down:
                    if(rectangle.Y<max_height-rectangle.Height)
                    this.rectangle.Y += velocity;                  
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

        /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
        Map.MapObject collision_obj = null;


        public void MoveInDirection(int add_x, int add_y, Map.Map map)
        {
            int new_x = x + add_x;
            int new_y = y + add_y;
            collision_obj = map.getObject(new_x, new_y);
            if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste))
            {
                map.setObject(new_x, new_y, this);
                map.setObject(x, y, new NonDestroyableObjects.Puste(content, new Rectangle(x * this.rectangle.Width, y * this.rectangle.Height, this.rectangle.Width, this.rectangle.Height)));
                x = new_x;
                y = new_y;
            }
        }

        public void Die(Map.Map map)
        {
        }


        

    }
}
