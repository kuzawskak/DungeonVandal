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
    /// po smierci upuszcza dynamit
    /// </summary>
    class Goblin : Enemy
    {
        /// <summary>
        /// Conbtent dla rysowania tekstury
        /// </summary>
        const string asset_name = "Textures\\goblin";
        /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
        Map.MapObject collision_obj = null;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="content"></param>
        /// <param name="rectangle"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Goblin(ContentManager content, Rectangle rectangle, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            current_direction = Game.direction.down;
            this.velocity = 30;
        }

        /// <summary>
        /// Wybierz kierunek ruchu
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public Game.direction Move(Map.Map map)
        {
            current_direction = Game.direction.none;
           // map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.Rectangle));
            for (int i = 0; i < 4; i++)
            {
                if (isPointAccesible(map, ((int)current_direction + 1) % 4))
                {
                    current_direction = (Game.direction)(((int)current_direction + i) % 4);
                    break;
                }
            }
            return current_direction;
        }

        private bool isPointAccesible(Map.Map map, int dir)
        {
            switch ((Game.direction)dir)
            {
                case Game.direction.down:
                    if (y + 1 < map.getHeight() - 1)
                    {
                        if (map.getObject(x, y + 1).GetType() == typeof(NonDestroyableObjects.Puste))
                            return true;
                    } break;

                case Game.direction.left:
                    if (x > 0)
                    {
                        if (map.getObject(x - 1, y).GetType() == typeof(NonDestroyableObjects.Puste))
                            return true;
                    }

                    break;
                case Game.direction.right:
                    if (x + 1 < map.getWidth() - 1)
                    {
                        if (map.getObject(x + 1, y).GetType() == typeof(NonDestroyableObjects.Puste))
                            return true;
                    }

                    break;
                case Game.direction.up:
                    if (y > 0)
                    {
                        if (map.getObject(x, y - 1).GetType() == typeof(NonDestroyableObjects.Puste))

                            return true;
                    } break;


            }
            return false;
        }

        /// <summary>
        /// Aktualizacja pozycji na mapie
        /// </summary>
        /// <param name="gametime"></param>
        /// <param name="map"></param>
        public override void Update(GameTime gametime, Map.Map map)
        {

            if (gametime.TotalGameTime.Milliseconds % 20 == 0)
            {
                current_direction = Move(map);

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
        /// Reakcja na eksplozje, po smmierci upuszcza dynamit
        /// </summary>
        public void Die()
        {
            //TODO: fire animation
            //remove object from map(insert Puste in its place)
        }
    }
}
