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
    class Enemy:Map.MapObject
    {
        protected int velocity;
        
        private Game.direction current_direction;
        //ograniczenia mapy - okreslaja granice po ktorych przeciwnik moze sie poruszac
        protected int max_height, max_width;

        public void Move(Game.direction direction) {
            current_direction = direction;

            switch (direction)
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

        

    }
}
