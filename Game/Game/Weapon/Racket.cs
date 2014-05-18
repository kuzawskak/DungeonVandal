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
    class Racket:Map.MapObject,Zniszczalny,Weapon
    {
       
        SoundEffect soundEffect;
        private string asset_name = "Textures\\racket";
        private bool is_fired = false;
        private const int speed = 5;
        Game.direction direction;

        private int i, j;
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
        {           
            soundEffect = content.Load<SoundEffect>("Audio\\found"); 
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            IsAccesible = true;

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
        public Racket(ContentManager content, Rectangle rectangle, int x, int y,Game.direction direction)
        {
            is_fired = true;
            this.direction = direction;
            soundEffect = content.Load<SoundEffect>("Audio\\found");
            this.content = content;
            switch (direction)
            {
                case Game.direction.down:
                    texture = content.Load<Texture2D>("vandal_down_inv");
                    break;
                case Game.direction.up:
                    texture = content.Load<Texture2D>("vandal_up_inv");
                    break;
                case Game.direction.left:
                    texture = content.Load<Texture2D>("vandal_left_inv");
                    break;
                case Game.direction.right:
                    texture = content.Load<Texture2D>("vandal_right_inv");
                    break;

            }
            
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            IsAccesible = true;

        }



        public void OnFound( Map.Map map)
        {
            soundEffect.Play();
            map.addPlayersRacket(1);
            map.setObject(x, y,new NonDestroyableObjects.Puste(content, this.Rectangle));
          
        }




        public override void Update(GameTime gametime, Map.Map map)
        {
            if (is_fired)
            {

                int x_index = x;
                int y_index = y;
                if (map.getObject(x_index, y_index).GetType() != typeof(NonDestroyableObjects.Puste) && map.getObject(x_index, y_index)!=this)
                {
                    //explosion
                    SoundEffect explosion_sound = content.Load<SoundEffect>("Audio\\explosion_sound");
                    explosion_sound.Play();
                    //TODO: dodac sprawdzanie czy nie wykraczamy indeksow w mapie i czy obiekt nie jest niezniszczalny
                    //tak naprawde powinno sie to zmienic na wywolanie onDestroy dla kazdego z tych obiektow!!!!!!!!!!
                    
                    map.setObject(x_index - 1, y_index, new NonDestroyableObjects.Puste(content, new Rectangle((x_index - 1) * rectangle.Width, y_index * rectangle.Height, rectangle.Width, rectangle.Height)));
                    map.setObject(x_index - 1, y_index + 1, new NonDestroyableObjects.Puste(content, new Rectangle((x_index - 1) * rectangle.Width, (y_index + 1) * rectangle.Height, rectangle.Width, rectangle.Height)));
                    map.setObject(x_index - 1, y_index - 1, new NonDestroyableObjects.Puste(content, new Rectangle((x_index - 1) * rectangle.Width, (y_index - 1) * rectangle.Height, rectangle.Width, rectangle.Height)));
                   
                    map.setObject(x_index, y_index-1, new NonDestroyableObjects.Puste(content, new Rectangle((x_index) * rectangle.Width, (y_index-1) * rectangle.Height, rectangle.Width, rectangle.Height)));
                    map.setObject(x_index, y_index+1, new NonDestroyableObjects.Puste(content, new Rectangle((x_index) * rectangle.Width, (y_index +1)* rectangle.Height, rectangle.Width, rectangle.Height)));
                    map.setObject(x_index, y_index, new NonDestroyableObjects.Puste(content, new Rectangle((x_index) * rectangle.Width, y_index * rectangle.Height, rectangle.Width, rectangle.Height)));
                    
                    map.setObject(x_index + 1, y_index, new NonDestroyableObjects.Puste(content, new Rectangle((x_index + 1) * rectangle.Width, y_index * rectangle.Height, rectangle.Width, rectangle.Height)));
                    map.setObject(x_index + 1, y_index + 1, new NonDestroyableObjects.Puste(content, new Rectangle((x_index + 1) * rectangle.Width, (y_index + 1) * rectangle.Height, rectangle.Width, rectangle.Height)));
                    map.setObject(x_index + 1, y_index - 1, new NonDestroyableObjects.Puste(content, new Rectangle((x_index + 1) * rectangle.Width, (y_index + 1) * rectangle.Height, rectangle.Width, rectangle.Height)));
                   
                   
                    map.setObject(this.x / Rectangle.Width, this.y / Rectangle.Height, new NonDestroyableObjects.Puste(content, new Rectangle((this.x / Rectangle.Width)*rectangle.Width, (this.y / Rectangle.Height)*rectangle.Height, rectangle.Width, rectangle.Height)));
                }


                switch (direction)
                {
                    case Game.direction.down:
                        texture = content.Load<Texture2D>("vandal_down_inv");
                        rectangle.Y += speed;                     
                        break;
                    case Game.direction.up:
                        texture = content.Load<Texture2D>("vandal_up_inv");
                        rectangle.Y -= speed;
                        break;
                    case Game.direction.left:
                        texture = content.Load<Texture2D>("vandal_left_inv");
                        rectangle.X -= speed;
                        break;
                    case Game.direction.right:
                        texture = content.Load<Texture2D>("vandal_right_inv");
                        rectangle.X += speed;
                        break;

                }
            }
            else 
            {
                if (rectangle.Intersects(map.getVandalRectangle()))
                    this.OnFound(map);
            }

        }
        public void OnDestroy(Map.Map map)
        {
            //oznacz odpowiednie pole jak puste
            map.setObject(x, y, new NonDestroyableObjects.Puste(content, this.Rectangle));
        
        }

        


    }
}
