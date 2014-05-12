using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Game.Weapon;

namespace Game.Map
{
    public class Map
    {
        Player player;
        Rectangle vandal_rectangle;
        public Random rand = new Random();
        private int tile_size;
        private int height;
        private int width;
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }
        private MapObject[,] objects;
        public MapObject getObject(int x, int y)
        {
            return objects[x, y];
        }
        private Characters.Blob[] blobs;
        ContentManager content;
        public Map(int tile_size,int width, int height, ContentManager content, Player player)
        {
            this.content = content;
            this.width = width;
            this.height = height;
            this.player = player;
            this.tile_size = tile_size;
            objects = GenerateRandomMap(0, width, height);
        }

        public void setObject(int x, int y,MapObject obj)
        {
            objects[x,y] = obj;
        }
        private List<Weapon.Dynamit> dynamites = new List<Weapon.Dynamit>();
        int last_update = 0;

        public MapObject[,] GenerateRandomMap(int intelligence_level, int width, int height)
        {
            MapObject[,] objects = new MapObject[width, height];
            for (int i = 0; i < width ; i++)
                for (int j = 0; j < height; j++)
                {
                    {
                        MapObject obj = new DestroyableObjects.Ziemia(content, new Rectangle(i * tile_size, j * tile_size, tile_size, tile_size));
                        objects[i, j] = obj;
                    }
                }


            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next() % (width);
                int y = rand.Next() % (height);
                MapObject d = new NonDestroyableObjects.MagicznyMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                objects[x, y] = d;
                x = rand.Next() % (width);
                y = rand.Next() % (height);
                MapObject mm = new DestroyableObjects.Kamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                objects[x, y] = mm;
               

            }


            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next() % (width);
                int y = rand.Next() % (height);
                MapObject d = new Weapon.Dynamit(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width*tile_size, height*tile_size, x, y);
                objects[x, y] = d;
                dynamites.Add((Weapon.Dynamit)d);
            }
            blobs = new Characters.Blob[10];
            //generate blobs in 10 random places
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next() % (width);
                int y = rand.Next() % (height);
               // MapObject b = new Characters.Blob(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
               // objects[x, y] = b;
               // blobs[i] = (Characters.Blob)b;
            }

            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next() % (width);
                int y = rand.Next() % (height);
                MapObject marmur = new NonDestroyableObjects.MarmurowyKamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                objects[x, y] = marmur;
               
            }
            for (int i = 0; i < 5; i++)
            {
                int x = rand.Next() % (width);
                int y = rand.Next() % (height);
                MapObject racket = new Weapon.Racket(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                objects[x, y] = racket;

            }
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next() % (width);
                int y = rand.Next() % (height);
                MapObject rg = new NonDestroyableObjects.RadioaktywnyGlaz(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                objects[x, y] = rg;

            }
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next() % (width);
                int y = rand.Next() % (height);
                MapObject c = new NonDestroyableObjects.CiezkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                objects[x, y] = c;
               
            }
            return objects;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    try
                    {
                        spritebatch.Draw(objects[i, j].Texture, objects[i, j].Rectangle, Color.White);
                    }
                    catch { }
                }
        }

        public bool is_vandal_on_rectangle(int x, int y)
        {if(x>=0&&x<this.width&&y>=0&&y<this.height)
            return (vandal_rectangle.X / vandal_rectangle.Width == x ||( vandal_rectangle.X + vandal_rectangle.Width-1)/ vandal_rectangle.Width == x)&& vandal_rectangle.Y / vandal_rectangle.Height == y;
        else return false;
        }

        public bool is_vandal_exact_on_rectangle(int x, int y)
        {
            if (x >= 0 && x < this.width && y >= 0 && y < this.height)
                return (vandal_rectangle.X / vandal_rectangle.Width == x && vandal_rectangle.Y / vandal_rectangle.Height == y);
            else return false;
        }


        public void addPlayersDynamites(int points)
        {
            player.Dynamite+=points;
        }

        public void addPlayersRacket(int points)
        {
            player.Rackets += points;
        }

        public Rectangle getVandalRectangle()
        {
            return vandal_rectangle;
        }

        public void Update(Rectangle vandal_rectangle, GameTime gametime)
        {
            this.vandal_rectangle = vandal_rectangle;
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                     objects[i,j].Update(gametime,this);
                }
        }
    }

}

