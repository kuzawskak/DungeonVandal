﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Game.Weapon;
using AIHelper;
using System.Windows.Forms;


namespace Game.Map
{
    public class Map
    {
        public RandomOperator random_operator;

        public int gameLevel { get; set; }
        Player player;
        public Characters.Vandal vandal;
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

        private List<Characters.Enemy> enemies = new List<Characters.Enemy>();

        ContentManager content;
        public Map(int tile_size, int width, int height, ContentManager content, Player player, Characters.Vandal vandal, int gameLevel = 1)
        {
            this.gameLevel = gameLevel;
            this.vandal = vandal;
            this.content = content;
            this.width = width;
            this.height = height;
            this.player = player;
            this.tile_size = tile_size;
            objects = new MapObject[width, height];
            random_operator = new RandomOperator(width, height);
            random_operator.GenerateRandomMap(width, height, gameLevel);
            CovertIntToObjects(ref objects, random_operator.Map);


        }

        public void setObject(int x, int y, MapObject obj)
        {
            obj.rectangle.X = x * tile_size;
            obj.rectangle.Y = y * tile_size;
            objects[x, y] = obj;

        }
        int last_update = 0;


        public void setVandalImmortal()
        {
            vandal.setImmortal();
            vandal.LoadCurrentTexture(this);
        }

        private void CovertIntToObjects(ref MapObject[,] map_obj, ElementType[,] objects)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    switch (objects[x, y])
                    {
                        case ElementType.AMEBA:
                            map_obj[x, y] = new DestroyableObjects.Ameba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.BECZKAZGAZEM:
                            break;
                        case ElementType.BLOB:
                            map_obj[x, y] = new Characters.Blob(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.CHODZACABOMBA:
                            map_obj[x, y] = new Characters.ChodzacaBomba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.CIEZKIMUR:
                            map_obj[x, y] = new NonDestroyableObjects.CiezkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.DYNAMIT:
                            map_obj[x, y] = new Weapon.Dynamit(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.GIGANTYCZNYSZCZUR:
                            break;
                        case ElementType.GOBLIN:
                            map_obj[x, y] = new Characters.Goblin(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.KAMIEN:
                            map_obj[x, y] = new DestroyableObjects.Kamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.LEKKIMUR:
                            map_obj[x, y] = new DestroyableObjects.LekkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.MAGICZNYMUR:
                            map_obj[x, y] = new NonDestroyableObjects.MagicznyMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.MARMUROWYKAMIEN:
                            map_obj[x, y] = new NonDestroyableObjects.MarmurowyKamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.NIESTABILNABECZKA:
                            break;
                        case ElementType.PEKDYNAMITOW:
                            map_obj[x, y] = new Weapon.PekDynamitow(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.POLESILOWE:
                            map_obj[x, y] = new Weapon.PoleSilowe(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.PUSTE:
                            map_obj[x, y] = new NonDestroyableObjects.Puste(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size));
                            break;
                        case ElementType.RACKET:
                            map_obj[x, y] = new Weapon.Racket(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.RADIOAKTYWNYGLAZ:
                            map_obj[x, y] = new NonDestroyableObjects.RadioaktywnyGlaz(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.VANDAL:
                            map_obj[x, y] = vandal;
                            break;
                        case ElementType.ZIEMIA:
                            map_obj[x, y] = new DestroyableObjects.Ziemia(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, player.IntelligenceLevel);
                            break;
                        case ElementType.CELMISJI:
                            map_obj[x, y] = new DestroyableObjects.CelMisji(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, gameLevel, player.IntelligenceLevel);
                            break;



                    }
                }
        }

        private void ConvertObjectsToInt(ref int[] int_obj, MapObject[,] objects)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    if (objects[x, y].GetType() == typeof(DestroyableObjects.Ameba))
                        int_obj[x*height+ y] = (int)ElementType.AMEBA;
                    else if (objects[x, y].GetType() == typeof(DestroyableObjects.BeczkaZGazem))
                        int_obj[x * height + y] = (int)ElementType.BECZKAZGAZEM;
                    else if (objects[x, y].GetType() == typeof(Characters.Blob))
                        int_obj[x * height + y] = (int)ElementType.BLOB;
                    else if (objects[x, y].GetType() == typeof(Characters.ChodzacaBomba))
                        int_obj[x * height + y] = (int)ElementType.CHODZACABOMBA;
                    else if (objects[x, y].GetType() == typeof(NonDestroyableObjects.CiezkiMur))
                        int_obj[x * height + y] = (int)ElementType.CIEZKIMUR;
                    else if (objects[x, y].GetType() == typeof(Weapon.Dynamit))
                        int_obj[x * height + y] = (int)ElementType.DYNAMIT;
                    else if (objects[x, y].GetType() == typeof(Characters.Goblin))
                        int_obj[x * height + y] = (int)ElementType.GOBLIN;
                    else if (objects[x, y].GetType() == typeof(Characters.GigantycznySzczur))
                        int_obj[x * height + y] = (int)ElementType.GIGANTYCZNYSZCZUR;
                    else if (objects[x, y].GetType() == typeof(DestroyableObjects.Kamien))
                        int_obj[x * height + y] = (int)ElementType.KAMIEN;
                    else if (objects[x, y].GetType() == typeof(DestroyableObjects.LekkiMur))
                        int_obj[x * height + y] = (int)ElementType.LEKKIMUR;
                    else if (objects[x, y].GetType() == typeof(NonDestroyableObjects.MagicznyMur))
                        int_obj[x * height + y] = (int)ElementType.MAGICZNYMUR;
                    else if (objects[x, y].GetType() == typeof(NonDestroyableObjects.MarmurowyKamien))
                        int_obj[x * height + y] = (int)ElementType.MARMUROWYKAMIEN;
                    else if (objects[x, y].GetType() == typeof(DestroyableObjects.NiestabilnaBeczka))
                        int_obj[x * height + y] = (int)ElementType.NIESTABILNABECZKA;
                    else if (objects[x, y].GetType() == typeof(Weapon.PekDynamitow))
                        int_obj[x * height + y] = (int)ElementType.PEKDYNAMITOW;
                    else if (objects[x, y].GetType() == typeof(Weapon.PoleSilowe))
                        int_obj[x * height + y] = (int)ElementType.POLESILOWE;
                    else if (objects[x, y].GetType() == typeof(NonDestroyableObjects.Puste))
                        int_obj[x * height + y] = (int)ElementType.PUSTE;
                    else if (objects[x, y].GetType() == typeof(Weapon.Racket))
                        int_obj[x * height + y] = (int)ElementType.RACKET;
                    else if (objects[x, y].GetType() == typeof(NonDestroyableObjects.RadioaktywnyGlaz))
                        int_obj[x * height + y] = (int)ElementType.RADIOAKTYWNYGLAZ;
                    else if (objects[x, y].GetType() == typeof(Characters.Vandal))
                        int_obj[x * height + y] = (int)ElementType.VANDAL;
                    else if (objects[x, y].GetType() == typeof(DestroyableObjects.CelMisji))
                        int_obj[x * height + y] = (int)ElementType.CELMISJI;
                    else if (objects[x, y].GetType() == typeof(DestroyableObjects.Ziemia))
                        int_obj[x * height + y] = (int)ElementType.ZIEMIA;



                }

        }

        public int[] getIntMap()
        {
            int[] int_map = new int[width* height];

            ConvertObjectsToInt(ref int_map, objects);

            return int_map;
        }
        public void UpgradePlayersLevel()
        {
            if (gameLevel < 5)
            {
                //  vandal.rectangle = new Rectangle(tile_size, tile_size, tile_size, tile_size);
                // vandal.x = 1;
                //  vandal.y = 1;
                //  vandal = new Characters.Vandal(content, new Rectangle(tile_size, tile_size, tile_size, tile_size), tile_size * width, tile_size * height);
                //  this.vandal_rectangle = vandal.rectangle;

                // setObject(1, 1, vandal);
                ++gameLevel;
                objects = new MapObject[width, height];
                random_operator.GenerateRandomMap(width, height, gameLevel);
                CovertIntToObjects(ref objects, random_operator.Map);




            }
        }
        public void RemoveCharacter(Characters.Enemy enemy)
        {
            try
            {
                enemies.Remove(enemy);
            }
            catch { }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    try
                    {
                        spritebatch.Draw(objects[i, j].Texture, objects[i, j].rectangle, Color.White);
                    }
                    catch { }
                }

        }

        public bool is_vandal_on_rectangle(int x, int y)
        {
            if (x >= 0 && x < this.width && y >= 0 && y < this.height)
                return (vandal_rectangle.X / vandal_rectangle.Width == x || (vandal_rectangle.X + vandal_rectangle.Width - 1) / vandal_rectangle.Width == x) && vandal_rectangle.Y / vandal_rectangle.Height == y;
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
            player.Dynamite += points;
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
            this.vandal_rectangle = vandal.rectangle;// _rectangle;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    objects[i, j].Update(gametime, this);
                }

            /* foreach (Characters.Enemy e in enemies)
             {
                 e.Update(gametime, this);
             }*/
        }


        public Game.direction GetVandalDirection()
        {
            return vandal.current_direction;
        }

        public void AddPlayersPoints(int points)
        {
            player.Points += points;
        }
    }

}

