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
        Random rand = new Random();
        const string asset_name = "goblin";
        Queue<Game.direction> move_queue = new Queue<Game.direction>();
        public Game.direction Move(Map.Map map)
        {
            if (rectangle.X % rectangle.Width == 0 && rectangle.Y % rectangle.Height == 0)
            {
                map.setObject((int)(rectangle.X / rectangle.Width), (int)(rectangle.Y / rectangle.Height), new NonDestroyableObjects.Puste(content, this.Rectangle));


                for (int i = 0; i < 4; i++)
                {
                    if(isPointAccesible(map,((int)current_direction+1)%4))
                    {
                        current_direction = (Game.direction)(((int)current_direction+i)%4);
                        break;
                    }
                }

            }
            return current_direction;

        }

        private bool isPointAccesible(Map.Map map, int dir)
        {
            switch ((Game.direction)dir)
            {
                case Game.direction.down:
                    {
                        if (map.getObject(rectangle.X / rectangle.Width, (rectangle.Y + velocity) / rectangle.Height + 1).IsAccesible)
                            return true;
                    }break;
                    
                case Game.direction.left:
                    if (rectangle.X > 0)
                    {
                      if(map.getObject((rectangle.X - velocity) / rectangle.Width, rectangle.Y / rectangle.Height).IsAccesible)
                        return true;
                    }

                    break;
                case Game.direction.right:
                    if (rectangle.X + velocity < max_width - rectangle.Width)
                    {
                        if(map.getObject((rectangle.X + velocity) / rectangle.Width + 1, rectangle.Y / rectangle.Height).IsAccesible) 
                            return true;                       
                    }

                    break;
                case Game.direction.up:
                    if (rectangle.Y > 0)
                    {
                        if (map.getObject(rectangle.X / rectangle.Width, (rectangle.Y - velocity) / rectangle.Height).IsAccesible)

                            return true;
                    }break;
                        

            }
            return false;
        }

        /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
        Map.MapObject collision_obj = null;

        public Goblin(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.max_height = max_height;
            this.max_width = max_width;
            this.x = x;
            this.y = y;
            current_direction = Game.direction.down;
            //same as vandals' velocity
            this.velocity = 1;
        }
        

        public override void Update(GameTime gametime, Map.Map map)
        {
          

            current_direction = Move(map);

            switch (current_direction)
            {
                case Game.direction.down:
                    if (rectangle.Y + velocity < max_height - rectangle.Height)
                    {
                        collision_obj = map.getObject(rectangle.X / rectangle.Width, (rectangle.Y + velocity) / rectangle.Height + 1);
                        if (collision_obj.IsAccesible)
                        {
                            rectangle.Y += velocity;
                        }
                    }

                    break;
                case Game.direction.left:
                    if (rectangle.X > 0)
                    {
                        collision_obj = map.getObject((rectangle.X - velocity) / rectangle.Width, rectangle.Y / rectangle.Height);
                        if (collision_obj.IsAccesible)
                        {
                            rectangle.X -= velocity;
                        }
                    }

                    break;
                case Game.direction.right:
                    if (rectangle.X + velocity < max_width - rectangle.Width)
                    {
                        collision_obj = map.getObject((rectangle.X + velocity) / rectangle.Width + 1, rectangle.Y / rectangle.Height);
                        if (collision_obj.IsAccesible)
                        {
                            rectangle.X += velocity;
                        }
                    }

                    break;
                case Game.direction.up:
                    if (rectangle.Y > 0)
                    {
                        collision_obj = map.getObject(rectangle.X / rectangle.Width, (rectangle.Y - velocity) / rectangle.Height);
                        if (collision_obj.IsAccesible)
                        {
                            rectangle.Y -= velocity;
                        }
                    }

                    break;
                default:
                    break;

            }


        }


        void Draw(GameTime gameTime) { }
        public void Die()
        {
            //TODO: fire animation
            //remove object from map(insert Puste in its place)
        }
    }
}
