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
    /// Przeciwnik poruszajacy sie losowo
    /// po smierci zostawia pole ameby
    /// </summary>
    class Blob : Enemy
    {
        /// <summary>
        /// Czynnik losowy przy wyborze ruchu
        /// </summary>
        Random rand = new Random();
        const string asset_name = "Textures\\blob";


        public Blob(ContentManager content, Rectangle rectangle, int x, int y):base(content,rectangle,x,y)
        {
            TypeTag = AIHelper.ElementType.BLOB;
            texture = content.Load<Texture2D>(asset_name);
            current_direction = Game.direction.down;
        }

        public void Move(Map.Map map)
        {
            List<Game.direction> available_dir = new List<Game.direction>();
            if (x > 1 && map.getObject(x - 1, y).GetType() == typeof(NonDestroyableObjects.Puste))
                available_dir.Add(Game.direction.left);
            if (x < map.getWidth() - 1 && map.getObject(x + 1, y).GetType() == typeof(NonDestroyableObjects.Puste))
                available_dir.Add(Game.direction.right);
            if (y > 1 && map.getObject(x, y - 1).GetType() == typeof(NonDestroyableObjects.Puste))
                available_dir.Add(Game.direction.up);
            if (x < map.getHeight() - 1 && map.getObject(x, y + 1).GetType() == typeof(NonDestroyableObjects.Puste))
                available_dir.Add(Game.direction.down);
            if (available_dir.Capacity > 0)
            {
                int rand_dir = rand.Next(0, available_dir.Capacity - 1);
                current_direction = (Game.direction)(rand_dir);
            }
            else current_direction = Game.direction.none;

        }


        public override void Update(GameTime gametime, Map.Map map)
        {
            if (gametime.TotalGameTime.Milliseconds % 20 == 0)
            {
                Move(map);
                switch (current_direction)
                {
                    case Game.direction.down:
                        MoveInDirection(0, 1, map);
                        break;
                    case Game.direction.left:
                        MoveInDirection(-1, 0, map);
                        break;
                    case Game.direction.right:
                        MoveInDirection(1, 0, map);
                        break;
                    case Game.direction.up:
                        MoveInDirection(0, -1, map);
                        break;
                    default:
                        break;
                }

            }

        }

        /// <summary>
        /// Zostawia na swoim miejscu pole ameby
        /// </summary>
        /// <param name="map"></param>
         public void Die(Map.Map map)
        {
            map.setObject(x,y,new DestroyableObjects.Ameba(content, new Rectangle(x * this.rectangle.Width, y * this.rectangle.Height, this.rectangle.Width, this.rectangle.Height), x, y));
       
        }
    }
}
