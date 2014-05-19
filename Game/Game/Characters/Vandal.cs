using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Audio;
using Game.Features;
using System.Timers;

namespace Game.Characters
{
    /// <summary>
    /// Postac któej ruchem i zachowaniem steruje gracz
    /// </summary>
    public class Vandal :  Map.MapObject
    {

        public bool is_alive { get; set; }
        public bool level_up { get; set; }
        /// <summary>
        /// Czas pozostaly przez ktory Vandal jest niesmiertelny
        /// </summary>
        bool is_immortal;
        /// <summary>
        /// Predkosc poruszania
        /// </summary>
        const int velocity = 30;
        /// <summary>
        /// Kierunek ruchu
        /// </summary>
        public Game.direction current_direction { get; private set; }
        int max_height, max_width;
        /// <summary>
        /// Obiekt na mapie , z ktorym nastapila kolizja
        /// </summary>
        Map.MapObject collision_obj = null;

        private System.Timers.Timer immortal_timer;


        public Vandal(ContentManager content, Rectangle rectangle, int max_width, int max_height)
        {
            this.content = content;
            texture = content.Load<Texture2D>("Textures\\vandal_right");
            this.rectangle = rectangle;
            x = (int)(rectangle.X / rectangle.Width);
            y = (int)(rectangle.Y / rectangle.Height);
            this.max_height = max_height;
            this.max_width = max_width;
            this.is_alive = true;
            this.level_up = false;
            current_direction = Game.direction.none;

        }


        /// <summary>
        /// Ustawienie niesmertelnosci po podniesieniu Pola Silowego
        /// </summary>
        public void setImmortal()
        {
            is_immortal = true;
            immortal_timer = new System.Timers.Timer(5000);
            immortal_timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            immortal_timer.Start();
        }

        /// <summary>
        /// Utrata niesmiertelnosci po czasie 5 sekund
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            is_immortal = false;
            LoadCurrentTexture(null);
        }


        /// <summary>
        /// Upusc dynamit
        /// </summary>
        /// <param name="game_map"></param>
        /// <param name="gametime"></param>
        public void LeftDynamite(Map.Map game_map, GameTime gametime)
        {

            current_direction = Game.direction.right;
            int new_x = x + 1;
            int new_y = y + 0;
            collision_obj = game_map.getObject(new_x, new_y);
            //  if (collision_obj.IsAccesible)
            {
                if (collision_obj is Zniszczalny)
                    (collision_obj as Zniszczalny).OnDestroy(game_map);

                game_map.setObject(new_x, new_y, this);
                game_map.setObject(x, y, new Weapon.Dynamit(content, new Rectangle(x * this.rectangle.Width, y * this.rectangle.Height, this.rectangle.Width, this.rectangle.Height), x, y, gametime));

                x = new_x;
                y = new_y;
            }
            game_map.addPlayersDynamites(-1);

        }

        /// <summary>
        /// Wystrzel rakiete
        /// </summary>
        /// <param name="game_map"></param>
        public void AttackWithRacket(Map.Map game_map)
        {
            Map.MapObject racket = new Weapon.Racket(content, this.Rectangle,rectangle.X, rectangle.Y, current_direction);
            game_map.setObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height, racket);
            game_map.addPlayersRacket(-1);
            SoundEffect fire_racket_effect = content.Load<SoundEffect>("Audio\\fire_racket");
            fire_racket_effect.Play();
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
            //collision_obj = game_map.getObject(rectangle.X / rectangle.Width, rectangle.Y / rectangle.Height);
            string asset_name = null;
            switch (current_direction)
            {
                case Game.direction.left:
                    asset_name = "Textures\\vandal_left";
                    break;
                case Game.direction.right:
                    asset_name = "Textures\\vandal_right";
                    break;
                case Game.direction.up:
                    asset_name = "Textures\\vandal_left";
                    break;
                case Game.direction.down:
                    asset_name = "Textures\\vandal_right";
                    break;
                default: break;

            }
            // if (collision_obj != null && collision_obj.GetType().BaseType == typeof(NonDestroyableObjects.StaticObject))
            //    asset_name += "_inv";
            if (is_immortal)
                asset_name += "_immortal";
            this.texture = content.Load<Texture2D>(asset_name);
        }

        void Draw(GameTime gameTime) { }

        public void MoveInDirection(int add_x, int add_y, Map.Map map)
        {
            int new_x = x + add_x;
            int new_y = y + add_y;
            collision_obj = map.getObject(new_x, new_y);
            if (collision_obj.IsAccesible)
            {
                if (collision_obj is Zniszczalny)
                    (collision_obj as Zniszczalny).OnDestroy(map);

                map.setObject(new_x, new_y, this);
                if (!(collision_obj is Eteryczny))
                    map.setObject(x, y, new NonDestroyableObjects.Puste(content, new Rectangle(x * this.rectangle.Width, y * this.rectangle.Height, this.rectangle.Width, this.rectangle.Height)));

                x = new_x;
                y = new_y;
            }      
        }


        /// <summary>
        /// Poruszanie - ustalenie aktualnego kierunku poruszania
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="map"></param>
        public void Move(Game.direction direction)
        {
            current_direction = direction;
        }


        public override void Update(GameTime gametime, Map.Map map)
        {
            if (!is_immortal)
            {
                //sprawdzenie czy styka sie z wrogiem 
                if (map.getObject(x , y).GetType() == typeof(Characters.Enemy) || map.getObject(x , y) is Skazony)
                { is_alive = false; return; }
             /*   if (map.getObject(x + 1, y).GetType() == typeof(Characters.Enemy) || map.getObject(x + 1, y) is Skazony)
                { is_alive = false; return; }
                if (map.getObject(x, y - 1).GetType() == typeof(Characters.Enemy) || map.getObject(x, y - 1) is Skazony)
                { is_alive = false; return; }
                if (map.getObject(x, y + 1).GetType() == typeof(Characters.Enemy) || map.getObject(x, y + 1) is Skazony)
                { is_alive = false; return; }
                //lub skazonym polem po skosie
                if (map.getObject(x - 1, y - 1) is Skazony)
                { is_alive = false; return; }
                if (map.getObject(x + 1, y - 1) is Skazony)
                { is_alive = false; return; }
                if (map.getObject(x - 1, y + 1) is Skazony)
                { is_alive = false; return; }
                if (map.getObject(x + 1, y + 1) is Skazony)
                { is_alive = false; return; }*/
            }



            if (gametime.TotalGameTime.Milliseconds % 20 == 0)
            {
                switch (current_direction)
                {
                    case Game.direction.down:
                        if (rectangle.Y + velocity < max_height - rectangle.Height)
                            MoveInDirection(0, 1, map);
                        current_direction = Game.direction.none;
                        break;
                    case Game.direction.left:
                        if (rectangle.X > 0)
                            MoveInDirection(-1, 0, map);
                        current_direction = Game.direction.none;
                        break;
                    case Game.direction.right:
                        if (rectangle.X + velocity < max_width - rectangle.Width)
                            MoveInDirection(1, 0, map);
                        current_direction = Game.direction.none;
                        break;
                    case Game.direction.up:
                        if (rectangle.Y > 0)
                            MoveInDirection(0, -1, map);
                        current_direction = Game.direction.none;
                        break;
                    default:
                        MoveInDirection(0, 0, map);
                        current_direction = Game.direction.none;
                        break;

                }
            }
        }

    }

}

