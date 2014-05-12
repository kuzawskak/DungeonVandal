using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Audio;

namespace Game.Characters
{
    /// <summary>
    /// Postac któej ruchem i zachowaniem steruje gracz
    /// </summary>
    public class Vandal : Map.MapObject
    {
        /// <summary>
        /// Czas pozostaly przez ktory Vandal jest niesmiertelny
        /// </summary>
        TimeSpan immortal_time_left;
        const int velocity = 5;
        /// <summary>
        /// Kierunek ruchu
        /// </summary>
        Game.direction current_direction;
        int max_height, max_width;
        /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
        Map.MapObject collision_obj = null;

        public Vandal(ContentManager content, Rectangle rectangle, int max_width, int max_height)
        {
            this.content = content;
            texture = content.Load<Texture2D>("vandal_right");
            this.rectangle = rectangle;
            this.max_height = max_height;
            this.max_width = max_width;
 
        }

        /// <summary>
        /// Upusc dynamit
        /// </summary>
        /// <param name="game_map"></param>
        /// <param name="gametime"></param>
        public void LeftDynamite(Map.Map game_map, GameTime gametime)
        {
            Map.MapObject dynamite = new Weapon.Dynamit(content, this.Rectangle, max_width, max_height, rectangle.X, rectangle.Y,gametime);
            game_map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, dynamite);
            game_map.addPlayersDynamites(-1);

        }

        /// <summary>
        /// Wystrzel rakiete
        /// </summary>
        /// <param name="game_map"></param>
        public void AttackWithRacket(Map.Map game_map)
        {
            Map.MapObject racket = new Weapon.Racket(content, this.Rectangle, max_width, max_height, rectangle.X, rectangle.Y, current_direction);
            game_map.setObject(rectangle.X/rectangle.Width, rectangle.Y/rectangle.Height, racket);
            game_map.addPlayersRacket(-1);
            SoundEffect fire_racket_effect = content.Load<SoundEffect>("fire_racket");
            
            fire_racket_effect.Play();
            //TODO
        }

        /// <summary>
        /// Zmien kierunek poruszania/patrzenia
        /// </summary>
        /// <param name="game_map"></param>
        public void changeDirectionToNext(Map.Map game_map)
        {
            current_direction = (Game.direction)(((int)current_direction + 1) % 3 + 1);
            LoadCurrentTexture(game_map);

        }

        /// <summary>
        /// Ładownaie odpowiedniej textury w zaleznosci od ustawienia bohatera na mapie i kierunku patrzenia
        /// </summary>
        /// <param name="game_map"></param>
        public void LoadCurrentTexture(Map.Map game_map)
        {
            collision_obj = game_map.getObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height);
            string asset_name = null;
            switch (current_direction)
            {
                case Game.direction.left:
                    asset_name = "vandal_left";
                    break;
                case Game.direction.right:
                    asset_name = "vandal_right";
                    break;
                case Game.direction.up:
                    asset_name = "vandal_left";
                    break;
                case Game.direction.down:
                    asset_name = "vandal_right";
                    break;
                default: break;

            }
            if (collision_obj != null && collision_obj.GetType().BaseType == typeof(NonDestroyableObjects.StaticObject))
                asset_name += "_inv";
            this.texture = content.Load<Texture2D>(asset_name);
        }

        /// <summary>
        /// Ustaw finalna pozycje (tak aby po zatrzymaniu Vandal nie był na miejscy posrednim miedy kratkami mapy)
        /// </summary>
        /// <param name="game_map"></param>
        public void SetFinalPosition(Map.Map game_map)
        {
            int x_rest = rectangle.X % rectangle.Width;
            int y_rest = rectangle.Y % rectangle.Height;
            int i = (int)(rectangle.X / rectangle.Width);
            int j = (int)(rectangle.Y / rectangle.Height);
            rectangle.X = x_rest < rectangle.Width / 2 ? i * rectangle.Width :(i+1) * rectangle.Width;
            rectangle.Y = y_rest < rectangle.Height / 2 ? j * rectangle.Height : (j + 1) * rectangle.Height;
          
        }

        /// <summary>
        /// Poruszanie
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="map"></param>
        public void Move(Game.direction direction,Map.Map map)
        {
            current_direction = direction;
            switch (direction)
            {
                case Game.direction.down:
                    if (rectangle.Y + velocity< max_height - rectangle.Height)
                    { 
                        collision_obj = map.getObject(rectangle.X/rectangle.Width,(rectangle.Y+velocity)/rectangle.Height +1);
                        if (collision_obj.IsAccesible)
                        {
                            rectangle.Y += velocity;
                        }
                    }

                    break;
                case Game.direction.left:
                    if (rectangle.X > 0)
                    { 
                        collision_obj = map.getObject((rectangle.X-velocity)/rectangle.Width ,rectangle.Y/rectangle.Height);
                        if (collision_obj.IsAccesible)
                        {
                            rectangle.X -= velocity;
                        }
                    }
                        
                    break;
                case Game.direction.right:
                    if (rectangle.X + velocity< max_width - rectangle.Width)
                    {
                        collision_obj = map.getObject((rectangle.X+velocity) / rectangle.Width + 1, rectangle.Y / rectangle.Height);
                        if (collision_obj.IsAccesible)
                        {
                            rectangle.X += velocity;
                        }
                    }
                       
                    break;
                case Game.direction.up:
                    if (rectangle.Y > 0)
                        {
                        collision_obj = map.getObject(rectangle.X / rectangle.Width ,( rectangle.Y - velocity)/ rectangle.Height);
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

    }

}

