using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
using Game.Features;

namespace Game.Characters
{

    /// <summary>
    /// Klasa przcienika, ktory po zauwazeniu Vandala goni go
    /// w przeciwnym przypadku porusza sie losowo
    /// potrafi drazyc w ziemi
    /// Bardzo wolny - 2 razy wolniejszy niz gracz
    /// </summary>
    class GigantycznySzczur : Enemy
    {
        int updateFrequency;
        Random rand = new Random();
        //TODO; Dodac grafike go GameContent
        const string asset_name = "Textures\\gigantyczny_szczur";

        public GigantycznySzczur(ContentManager content, Rectangle rectangle, int x, int y)
            : base(content, rectangle, x, y)
        {
            updateFrequency = 800;
            this.current_direction = Game.direction.down;
            TypeTag = AIHelper.ElementType.GIGANTYCZNYSZCZUR;
            texture = content.Load<Texture2D>(asset_name);
        }

        /// <summary>
        /// Funkcja dla AI szczura (sprawdza czy Vandal jest w zasiegu wzroku szczura - jesli tak - to wyznacza kierunk ruc)
        /// </summary>
        /// <param name="map">Mapa obiektów</param>
        /// <returns>Punkt reprezentujacy kierunek poruszania Gigantycznego Szczura</returns>
        public Point isVandalInSight(Map.Map map)
        {
         
            int x_move = 0;
            int y_move = 0;
            int vandal_x = map.GetVandal().x;
            int vandal_y = map.GetVandal().y;
            if (vandal_x == this.x)
            {
                int lower_ind = vandal_y<this.y?vandal_y:this.y;
                int higher_ind = vandal_y<this.y?this.y:vandal_y;
                for (int i = lower_ind + 1; i < higher_ind; i++)
                {
                    if (map.getObject(this.x, i).GetType() != typeof(NonDestroyableObjects.Puste))
                    {
                        y_move = 0;
                        break;
                    }
                //    else y_move = lower_ind == this.y ? 1 : -1;
                }

             
            }
            if (vandal_y == this.y)
            {
                int lower_ind = vandal_x < this.x ? vandal_x : this.x;
                int higher_ind = vandal_x < this.x ? this.x : vandal_x;
                for (int i = lower_ind + 1; i < higher_ind; i++)
                {
                    if (map.getObject(i, this.y).GetType() != typeof(NonDestroyableObjects.Puste))
                    {
                        x_move = 0;
                        break;
                    }
                 //   else x_move = lower_ind == this.x ? 1 : -1;
                }
              
            }
            return new Point(x_move, y_move);

        }



    /*    public Point Move(Map.Map map)
        {
            Point is_in_sight = isVandalInSight(map);
            if (is_in_sight.X == 0 && is_in_sight.Y == 0)
            {//nie ma w zasiegu wzroku Vandala - moze poruszac sie losowo, bardzo wolno
                updateFrequency = 800;
                List<Point> available_points = new List<Point>();
                Map.MapObject collision_obj;
                collision_obj = map.getObject(this.x+1,this.y);
                if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste) || collision_obj.GetType() == typeof(DestroyableObjects.Ziemia))
                    available_points.Add(new Point(1, 0));
                collision_obj = map.getObject(this.x - 1, this.y);
                if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste) || collision_obj.GetType() == typeof(DestroyableObjects.Ziemia))
                    available_points.Add(new Point( - 1, 0));
                collision_obj = map.getObject(this.x , this.y+1);
                if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste) || collision_obj.GetType() == typeof(DestroyableObjects.Ziemia))
                    available_points.Add(new Point(0 , 1));
                collision_obj = map.getObject(this.x, this.y-1);
                if (collision_obj.GetType() == typeof(NonDestroyableObjects.Puste) || collision_obj.GetType() == typeof(DestroyableObjects.Ziemia))
                    available_points.Add(new Point(0, -1));


                if (available_points.Capacity != 0)
                {
                    return available_points[rand.Next(0, available_points.Capacity - 1)];
                }
            }
            else
            {
                //goni  - porusza sie szybciej
                updateFrequency = 800;
               return(new Point(0,0));

            }

            return is_in_sight;



        }*/
       public void Move(Map.Map map)
        {
            List<Game.direction> available_dir = new List<Game.direction>();
            if (x > 1 && (map.getObject(x - 1, y).GetType() == typeof(NonDestroyableObjects.Puste) || map.getObject(x - 1, y).GetType() == typeof(DestroyableObjects.Ziemia)))
                available_dir.Add(Game.direction.left);
            if (x < map.getWidth() - 1 && (map.getObject(x + 1, y).GetType() == typeof(NonDestroyableObjects.Puste) ||  map.getObject(x + 1, y).TypeTag ==AIHelper.ElementType.ZIEMIA))
                available_dir.Add(Game.direction.right);
            if (y > 1 &&( map.getObject(x, y - 1).GetType() == typeof(NonDestroyableObjects.Puste)|| map.getObject(x, y - 1).GetType() == typeof(DestroyableObjects.Ziemia)))
                available_dir.Add(Game.direction.up);
            if (x < map.getHeight() - 1 &&( map.getObject(x, y + 1).GetType() == typeof(NonDestroyableObjects.Puste)||map.getObject(x, y + 1).GetType()== typeof(DestroyableObjects.Ziemia)))
                available_dir.Add(Game.direction.down);
            if (available_dir.Capacity > 0)
            {

                int rand_dir = rand.Next(0, available_dir.Capacity - 1);
                current_direction = (Game.direction)(rand_dir);
          
            }
            else
            {
                MessageBox.Show(map.getObject(x - 1, y).GetType().ToString());
                current_direction = Game.direction.none;
            }


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

        public void Die()
        {
            //TODO: fire animation
            //remove object from map(insert Puste in its place)
        }

        public void FireBomb(Map.Map map)
        {
            map.setObject((int)(rectangle.X / rectangle.Width), (int)(rectangle.Y / rectangle.Height), new NonDestroyableObjects.Puste(content, this.Rectangle, (int)(rectangle.X / rectangle.Width), (int)(rectangle.Y / rectangle.Height)));
            // map.RemoveCharacter(this);

        }


    }
}
