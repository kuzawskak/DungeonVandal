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
        Random rand = new Random();
        const string asset_name = "Textures\\chodzaca_bomba";
        public Game.direction Move(Map.Map map)
        {

            current_direction = (Game.direction)(rand.Next() % 4);

            return current_direction;

        }
        /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
        Map.MapObject collision_obj = null;

        public ChodzacaBomba(ContentManager content, Rectangle rectangle, int x, int y)
            : base(content, rectangle, x, y)
        {
            TypeTag = AIHelper.ElementType.CHODZACABOMBA;      
            texture = content.Load<Texture2D>(asset_name);       
            current_direction = Game.direction.down;
            this.velocity = 30;
        }


        public override void Update(GameTime gametime, Map.Map map)
        {
            if (gametime.TotalGameTime.Milliseconds % 10 == 0)
            {
                current_direction = Move(map);

                switch (current_direction)
                {
                    case Game.direction.down:
                       
                        {
                            collision_obj = map.getObject(x,y + 1);
                            if (collision_obj.GetType()==typeof(NonDestroyableObjects.Puste))
                            {
                                MoveInDirection(0, 1, map);
                            }
                             else if(collision_obj.GetType()!=typeof(DestroyableObjects.Ziemia))
                            {
                               FireBomb(map);
                            }
                        }

                        break;
                    case Game.direction.left:
                        if (rectangle.X > 0)
                        {
                            collision_obj = map.getObject(x-1,y);
                            if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste))
                            {
                                MoveInDirection(-1, 0, map);
                            }
                            else if(collision_obj.GetType()!=typeof(DestroyableObjects.Ziemia))
                            {
                               FireBomb(map);
                            }
                        }

                        break;
                    case Game.direction.right:
                 
                            collision_obj = map.getObject(x + 1, y);
                            if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste))
                            {
                                MoveInDirection(1, 0, map);
                            }
                             else if(collision_obj.GetType()!=typeof(DestroyableObjects.Ziemia))
                            {
                               FireBomb(map);
                            }
                        

                        break;
                    case Game.direction.up:
                        if (rectangle.Y > 0)
                        {
                            collision_obj = map.getObject(x , y-1);
                            if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste))
                            {
                                MoveInDirection(0, -1, map);
                            }
                             else if(collision_obj.GetType()!=typeof(DestroyableObjects.Ziemia))
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
            map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.Rectangle,x,y));

        }

        public void Move()
        {
        }
    }



}

