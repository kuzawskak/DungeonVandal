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
        Random rand = new Random();
        //TODO; Dodac grafike go GameContent
        const string asset_name = "gigantyczny_szczur";
                    /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
        Map.MapObject collision_obj = null;
     public GigantycznySzczur(ContentManager content, Rectangle rectangle, int max_width, int max_height,int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.max_height = max_height;
            this.max_width = max_width;
            this.x = x;
            this.y = y;
            current_direction = Game.direction.down;
            this.velocity = 30;
        }
               public Game.direction Move(Map.Map map)
        {
            if (rectangle.X % rectangle.Width == 0 && rectangle.Y % rectangle.Height == 0)
            {
                map.setObject((int)(rectangle.X / rectangle.Width), (int)(rectangle.Y / rectangle.Height), new NonDestroyableObjects.Puste(content, this.Rectangle));
                current_direction =  (Game.direction)(rand.Next() % 4);
            }
            return current_direction;
           
        }


          public override void Update(GameTime gametime,Map.Map map)
        {
            if (gametime.TotalGameTime.Milliseconds % 20 == 0)
            {
                current_direction = Move(map);

                switch (current_direction)
                {
                    case Game.direction.down:
                        if (rectangle.Y + velocity < max_height - rectangle.Height)
                        {
                            collision_obj = map.getObject(rectangle.X / rectangle.Width, (rectangle.Y) / rectangle.Height + 1);
                            if (collision_obj.IsAccesible)
                            {
                                rectangle.Y += velocity;
                            }
                            else
                            {
                                FireBomb(map);
                            }
                        }

                        break;
                    case Game.direction.left:
                        if (rectangle.X > 0)
                        {
                            collision_obj = map.getObject((rectangle.X) / rectangle.Width, rectangle.Y / rectangle.Height);
                            if (collision_obj.IsAccesible)
                            {
                                rectangle.X -= velocity;
                            }
                            else
                            {
                                FireBomb(map);
                            }
                        }

                        break;
                    case Game.direction.right:
                        if (rectangle.X + velocity < max_width - rectangle.Width)
                        {
                            collision_obj = map.getObject((rectangle.X) / rectangle.Width + 1, rectangle.Y / rectangle.Height);
                            if (collision_obj.IsAccesible)
                            {
                                rectangle.X += velocity;
                            }
                            else
                            {
                                FireBomb(map);
                            }
                        }

                        break;
                    case Game.direction.up:
                        if (rectangle.Y > 0)
                        {
                            collision_obj = map.getObject(rectangle.X / rectangle.Width, (rectangle.Y) / rectangle.Height);
                            if (collision_obj.IsAccesible)
                            {
                                rectangle.Y -= velocity;
                            }
                            else
                            {
                                FireBomb(map);
                            }
                        }

                        break;
                    default:
                        break;

                }
            }
        
        }


        public void Die()
        {
            //TODO: fire animation
            //remove object from map(insert Puste in its place)
        }

      public void FireBomb(Map.Map map)
        {
            map.setObject((int)(rectangle.X / rectangle.Width), (int)(rectangle.Y / rectangle.Height), new NonDestroyableObjects.Puste(content, this.Rectangle));
           // map.RemoveCharacter(this);

        }
 
        public void Move()
        {
        }
    

        bool LookForVandal() { return false; }

        void Chase() { }
    }
}
