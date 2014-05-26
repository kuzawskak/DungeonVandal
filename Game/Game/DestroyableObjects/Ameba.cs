using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Timers;
using System.Windows.Forms;

namespace Game.DestroyableObjects
{
    /// <summary>
    /// Obiekt zniszczalny , co losowy czas tworzy kolejne ameby dookola siebie na SŁABYCH polach
    /// </summary>
    class Ameba : Map.MapObject, Kruchy, Skazony, Niestabilny, Zniszczalny
    {
        Random rand = new Random();
        List<Map.MapObject> available_tiles;
        private int random_new_ameba_time;
        private int points;
        private string asset_name = "Textures\\ameba";
        private bool create_ameba = false;
        private System.Timers.Timer timer;
        public Ameba(ContentManager content, Rectangle rectangle, int x, int y):base(content,rectangle,x,y)
        {
            TypeTag = AIHelper.ElementType.AMEBA;   
            texture = content.Load<Texture2D>(asset_name);
            this.IsAccesible = false;
            this.points = 2;
            random_new_ameba_time = rand.Next(6, 10);
            timer = new System.Timers.Timer(random_new_ameba_time * 1000);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Start();

        }

        public override void Update(GameTime gametime, Map.Map map)
        {
            if (create_ameba)
            {
                available_tiles = new List<Map.MapObject>();

                if (x > 0 && y > 0 && map.getObject(x - 1, y - 1) is Features.Slaby)
                    available_tiles.Add(map.getObject(x - 1, y - 1));
                if (x > 0 && map.getObject(x - 1, y) is Features.Slaby)
                    available_tiles.Add(map.getObject(x - 1, y));
                if (x > 0 && y < map.getHeight() - 1 && map.getObject(x - 1, y + 1) is Features.Slaby)
                    available_tiles.Add(map.getObject(x - 1, y + 1));
                if (y > 0 && map.getObject(x, y - 1) is Features.Slaby)
                    available_tiles.Add(map.getObject(x, y - 1));
                if (y < map.getHeight() - 1 && map.getObject(x, y + 1) is Features.Slaby)
                    available_tiles.Add(map.getObject(x, y + 1));
                if (x < map.getWidth() - 1 && y > 0 && map.getObject(x + 1, y - 1) is Features.Slaby)
                    available_tiles.Add(map.getObject(x + 1, y - 1));
                if (x<map.getWidth()-1&&map.getObject(x + 1, y) is Features.Slaby)
                    available_tiles.Add(map.getObject(x + 1, y));
                if (x<map.getWidth()-1&&y<map.getHeight()-1&&map.getObject(x + 1, y + 1) is Features.Slaby)
                    available_tiles.Add(map.getObject(x + 1, y + 1));
                CreateNewAmeba(map);
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

        void Skazony.Zabij(Map.Map map)
        {
            throw new NotImplementedException();
        }

        void Niestabilny.Znikaj(Map.Map map)
        {
            throw new NotImplementedException();
        }


        void CreateNewAmeba(Map.Map map)
        {
            //losuj dostepne puste miejsce
            if (available_tiles.Capacity > 0)
            {
                int random_pos = rand.Next(0, available_tiles.Capacity - 1);
                map.setObject(available_tiles[random_pos].x, available_tiles[random_pos].y, new DestroyableObjects.Ameba(content, new Rectangle(available_tiles[random_pos].x * rectangle.Width, available_tiles[random_pos].y * rectangle.Height, rectangle.Width, rectangle.Height), available_tiles[random_pos].x, available_tiles[random_pos].y));
            }
        }
        void OnExplosion()
        {

        }
        void Update(GameTime gameTime)
        {
            //
        }


        public void OnDestroy(Map.Map map)
        {
            map.AddPlayersPoints(points);
            map.setObject(x,y, new NonDestroyableObjects.Puste(content, this.Rectangle,x, y));
         
        }
    }
}
