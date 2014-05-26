using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace Game.Weapon
{
    class Racket : Weapon, Zniszczalny
    {

        private string asset_name = "Textures\\racket";
        private const int speed = 5;
        Game.direction direction;
        /// <summary>
        /// Costructor for static racket (getting this racket gives racket_points)
        /// </summary>
        /// <param name="content"> XNA Content </param>
        /// <param name="rectangle"> XNA Rectangle </param>
        /// <param name="max_width"> width of the whole map</param>
        /// <param name="max_height">height of the whole map</param>
        /// <param name="x"> the initial rectangle x value</param>
        /// <param name="y"> the initail rectangle y value</param>
        public Racket(ContentManager content, Rectangle rectangle, int x, int y)
            : base(content, rectangle, x, y)
        {
            this.is_fired = false;
            this.TypeTag = AIHelper.ElementType.RACKET;
            this.texture = content.Load<Texture2D>(asset_name);
        }

        /// <summary>
        /// Costructor for fired racket (getting this racket gives racket_points)
        /// </summary>
        /// <param name="content"> XNA Content </param>
        /// <param name="rectangle"> XNA Rectangle </param>
        /// <param name="max_width"> width of the whole map</param>
        /// <param name="max_height">height of the whole map</param>
        /// <param name="x"> the initial rectangle x value</param>
        /// <param name="y"> the initail rectangle y value</param>
        /// <param name="direction">direction of the move</param>
        public Racket(ContentManager content, Rectangle rectangle, int x, int y, Game.direction direction)
            : base(content, rectangle, x, y)
        {
            this.is_fired = true;
            this.direction = direction;
            this.TypeTag = AIHelper.ElementType.RACKET;


            switch (direction)
            {
                case Game.direction.down:
                    texture = content.Load<Texture2D>("Textures\\racket_down");
                    break;
                case Game.direction.up:
                    texture = content.Load<Texture2D>("Textures\\racket_up");
                    break;
                case Game.direction.left:
                    texture = content.Load<Texture2D>("Textures\\racket_left");
                    break;
                case Game.direction.right:
                    texture = content.Load<Texture2D>("Textures\\racket_right");
                    break;

            }
        }

        public override void OnFound(Map.Map map)
        {
            this.found_soundEffect.Play();
            map.addPlayersRacket(1);
        }



        public override void Update(GameTime gametime, Map.Map map)
        {
            if (gametime.TotalGameTime.Milliseconds % 20 == 0 && is_fired)
            {

                int collision_x = x;
                int collision_y = y;
                switch (direction)
                {
                    case Game.direction.down:
                        texture = content.Load<Texture2D>("Textures\\racket_down");
                        collision_x = x;
                        collision_y = y + 1;
                        break;
                    case Game.direction.up:
                        texture = content.Load<Texture2D>("Textures\\racket_up");
                        collision_x = x;
                        collision_y = y - 1;
                        break;
                    case Game.direction.left:
                        texture = content.Load<Texture2D>("Textures\\racket_left");
                        collision_x = x - 1;
                        collision_y = y;
                        break;
                    case Game.direction.right:
                        texture = content.Load<Texture2D>("Textures\\racket_right");
                        collision_x = x + 1;
                        collision_y = y;
                        break;
                }

                if (map.getObject(collision_x, collision_y).GetType() != typeof(NonDestroyableObjects.Puste) && map.getObject(collision_x, collision_y) != this)
                {
                    //explosion
                     SoundEffect explosion_sound = content.Load<SoundEffect>("Audio\\explosion_sound");
                     explosion_sound.Play();
                     int vandal_x = map.GetVandal().x;
                     int vandal_y = map.GetVandal().y;
                    //TODO: dodac sprawdzanie czy nie wykraczamy indeksow w mapie i czy obiekt nie jest niezniszczalny
                    //tak naprawde powinno sie to zmienic na wywolanie onDestroy dla kazdego z tych obiektow!!!!!!!!!!
                    if(x-1!=vandal_x&&y!=vandal_y&&map.getObject(x-1,y) is Zniszczalny)
                    map.setObject(x - 1, y, new NonDestroyableObjects.Puste(content, new Rectangle((x - 1) * rectangle.Width, y * rectangle.Height, rectangle.Width, rectangle.Height), x - 1, y));
                    if (x - 1 != vandal_x && y+1 != vandal_y && map.getObject(x - 1, y+1) is Zniszczalny)
                    map.setObject(x - 1, y + 1, new NonDestroyableObjects.Puste(content, new Rectangle((x - 1) * rectangle.Width, (y + 1) * rectangle.Height, rectangle.Width, rectangle.Height), x - 1, y + 1));
                    if (x - 1 != vandal_x && y-1 != vandal_y && map.getObject(x - 1, y-1) is Zniszczalny)
                    map.setObject(x - 1, y - 1, new NonDestroyableObjects.Puste(content, new Rectangle((x - 1) * rectangle.Width, (y - 1) * rectangle.Height, rectangle.Width, rectangle.Height), x - 1, y - 1));

                    if (x  != vandal_x && y-1 != vandal_y && map.getObject(x , y-1) is Zniszczalny)
                    map.setObject(x, y - 1, new NonDestroyableObjects.Puste(content, new Rectangle((x) * rectangle.Width, (y - 1) * rectangle.Height, rectangle.Width, rectangle.Height), x, y - 1));
                    if (x  != vandal_x && y+1 != vandal_y && map.getObject(x , y+1) is Zniszczalny)
                    map.setObject(x, y + 1, new NonDestroyableObjects.Puste(content, new Rectangle((x) * rectangle.Width, (y + 1) * rectangle.Height, rectangle.Width, rectangle.Height), x, y + 1));
                    if (x  != vandal_x && y != vandal_y && map.getObject(x , y) is Zniszczalny)
                    map.setObject(x, y, new NonDestroyableObjects.Puste(content, new Rectangle((x) * rectangle.Width, y * rectangle.Height, rectangle.Width, rectangle.Height), x, y));

                    if (x + 1 != vandal_x && y != vandal_y && map.getObject(x + 1, y) is Zniszczalny)
                    map.setObject(x + 1, y, new NonDestroyableObjects.Puste(content, new Rectangle((x + 1) * rectangle.Width, y * rectangle.Height, rectangle.Width, rectangle.Height), x + 1, y));
                    if (x + 1 != vandal_x && y+1 != vandal_y && map.getObject(x + 1, y+1) is Zniszczalny)
                    map.setObject(x + 1, y + 1, new NonDestroyableObjects.Puste(content, new Rectangle((x + 1) * rectangle.Width, (y + 1) * rectangle.Height, rectangle.Width, rectangle.Height), x + 1, y + 1));
                    if (x + 1 != vandal_x && y -1!= vandal_y && map.getObject(x + 1, y-1) is Zniszczalny)
                    map.setObject(x + 1, y - 1, new NonDestroyableObjects.Puste(content, new Rectangle((x + 1) * rectangle.Width, (y + 1) * rectangle.Height, rectangle.Width, rectangle.Height), x + 1, y - 1));

                   // if (x != vandal_x && y  != vandal_y && map.getObject(x , y ) is Zniszczalny)
                    map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.rectangle, x, y));
                }
                else
                {
                    map.setObject(collision_x, collision_y, this);
                    map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.rectangle, x, y));
                    this.x = collision_x;
                    this.y = collision_y;

                }
            }
        }


    }
}
