using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Timers;

namespace Game.DestroyableObjects
{
    class Ameba : Map.MapObject, Kruchy, Skazony,Niestabilny,Zniszczalny
    {
        Random rand = new Random();
        private int random_new_ameba_time;
        
        private string asset_name = "ameba";
        private bool create_ameba = false;
        private System.Timers.Timer timer;
        public Ameba(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.IsAccesible = false;
            random_new_ameba_time = rand.Next(6, 10);
            timer = new System.Timers.Timer(random_new_ameba_time * 1000);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Start();

        }

        public override void Update(GameTime gametime, Map.Map map)
        {
           int x = this.rectangle.X/this.Rectangle.Width;
           int y = this.rectangle.Y/this.Rectangle.Height;

            if (create_ameba)
            {
                List<Point> accessible_places = new List<Point>();
                if (map.getObject(x - 1, y-1).IsAccesible)
                    map.setObject(x - 1, y - 1, new DestroyableObjects.Ameba(content, new Rectangle((x - 1) * rectangle.Width, (y - 1) * rectangle.Height, rectangle.Width, rectangle.Height), x - 1, y - 1, x - 1, y - 1));
                if (map.getObject(x - 1, y).IsAccesible)
                    map.setObject(x - 1, y, new DestroyableObjects.Ameba(content, new Rectangle((x - 1) * rectangle.Width, y * rectangle.Height, rectangle.Width, rectangle.Height), x - 1, y, x - 1, y));
                if (map.getObject(x - 1, y+1).IsAccesible)
                    map.setObject(x - 1, y + 1, new DestroyableObjects.Ameba(content, new Rectangle((x - 1) * rectangle.Width, (y + 1) * rectangle.Height, rectangle.Width, rectangle.Height), x - 1, y + 1, x - 1, y + 1));
                if (map.getObject(x , y-1).IsAccesible)
                    map.setObject(x, y - 1, new DestroyableObjects.Ameba(content, new Rectangle(x * rectangle.Width, (y - 1) * rectangle.Height, rectangle.Width, rectangle.Height), x, y - 1, x, y - 1));
                if (map.getObject(x , y+1).IsAccesible)
                    map.setObject(x, y + 1, new DestroyableObjects.Ameba(content, new Rectangle(x * rectangle.Width, (y + 1) * rectangle.Height, rectangle.Width, rectangle.Height), x, y + 1, x, y + 1));
                if (map.getObject(x + 1, y-1).IsAccesible)
                    map.setObject(x + 1, y - 1, new DestroyableObjects.Ameba(content, new Rectangle((x + 1) * rectangle.Width, (y - 1) * rectangle.Height, rectangle.Width, rectangle.Height), x + 1, y - 1, x + 1, y - 1));
                if (map.getObject(x + 1, y).IsAccesible)
                    map.setObject(x + 1, y, new DestroyableObjects.Ameba(content, new Rectangle((x + 1) * rectangle.Width, y * rectangle.Height, rectangle.Width, rectangle.Height), x + 1, y, x + 1, y));
                if (map.getObject(x + 1, y+1).IsAccesible)
                    map.setObject(x + 1, y + 1, new DestroyableObjects.Ameba(content, new Rectangle((x + 1) * rectangle.Width, (y + 1) * rectangle.Height, rectangle.Width, rectangle.Height), x + 1, y + 1, x + 1, y + 1));
                create_ameba = false;
            }
            

        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            create_ameba = true;
       
            timer.Start();
    
        }



        void Kruchy.Kolizja()
        {
            throw new NotImplementedException();
        }

        void Skazony.Zabij()
        {
            throw new NotImplementedException();
        }

        void Niestabilny.Znikaj()
        {
            throw new NotImplementedException();
        }


        void CreateNewAmeba(ref Map.Map map)
        {
            //losuj dostepne puste miejsce
            //
        }
        void OnExplosion()
        {

        }
        void Update(GameTime gameTime) { 
            //
        }
        void Draw(GameTime gameTime) { }


        public void OnDestroy(ref Map.MapObject[,] objects)
        {

            throw new NotImplementedException();
        }
    }
}
