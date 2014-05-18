using System;
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
        public Map(int tile_size,int width, int height, ContentManager content, Player player,Characters.Vandal vandal)
        {
            this.vandal = vandal;
            this.content = content;
            this.width = width;
            this.height = height;
            this.player = player;
            this.tile_size = tile_size;
            objects = new MapObject[width, height];
            random_operator = new RandomOperator(width, height);
            random_operator.GenerateRandomMap( width, height);
            CovertIntToObjects(ref objects, random_operator.Map);
            vandal_rectangle = vandal.rectangle;
           
        }

        public void setObject(int x, int y,MapObject obj)
        {
            obj.rectangle.X = x * tile_size;
            obj.rectangle.Y = y * tile_size;
            objects[x,y] = obj;

        }
        int last_update = 0;

    


        private void CovertIntToObjects(ref MapObject[,] map_obj,ElementType[,] objects)
        {
            for(int x=0;x<width;x++)
                for (int y = 0; y < height; y++)
                {
                    switch(objects[x,y])
                    {
                        case ElementType.AMEBA:
                            map_obj[x, y] = new DestroyableObjects.Ameba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                            break;
                        case ElementType.BECZKAZGAZEM:
                            break;
                        case ElementType.BLOB:
                           map_obj[x,y] =  new Characters.Blob(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                            break;
                        case ElementType.CHODZACABOMBA:                         
                            map_obj[x,y] =  new Characters.ChodzacaBomba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                            break;
                        case ElementType.CIEZKIMUR:
                            map_obj[x,y] = new NonDestroyableObjects.CiezkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x,y);
                            break;
                        case ElementType.DYNAMIT:
                             map_obj[x,y] = new Weapon.Dynamit(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size,x,y);
                             break;
                        case ElementType.GIGANTYCZNYSZCZUR:
                             break;
                        case ElementType.GOBLIN:
                           // map_obj[x, y] = new NonDestroyableObjects.Puste(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size));
                           map_obj[x,y] =  new Characters.Goblin(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                            break;
                           
                        case ElementType.KAMIEN:
                             map_obj[x,y] = new DestroyableObjects.Kamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                             break;
                        case ElementType.LEKKIMUR:
                              map_obj[x,y] = new DestroyableObjects.LekkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                             break;
                        case ElementType.MAGICZNYMUR:
                             map_obj[x,y] = new NonDestroyableObjects.MagicznyMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                             break;
                        case ElementType.MARMUROWYKAMIEN:
                            map_obj[x,y] = new NonDestroyableObjects.MarmurowyKamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                             break;
                        case ElementType.NIESTABILNABECZKA:
                            break;
                        case ElementType.PEKDYNAMITOW:
                             map_obj[x,y] = new Weapon.PekDynamitow(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size,x,y);
                             break;
                        case ElementType.POLESILOWE:
                            break;
                        case ElementType.PUSTE:
                            map_obj[x,y] = new NonDestroyableObjects.Puste(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size));
                            break;
                        case ElementType.RACKET:
                            map_obj[x,y] =  new Weapon.Racket(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                            break;
                        case ElementType.RADIOAKTYWNYGLAZ:
                            map_obj[x, y] = new NonDestroyableObjects.RadioaktywnyGlaz(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), width * tile_size, height * tile_size, x, y);
                            break;
                        case ElementType.VANDAL:

                            map_obj[x, y] = vandal;
                           // MessageBox.Show(vandal.rectangle.X + "  " + vandal.rectangle.Y);

                            break;
                        case ElementType.ZIEMIA:
                            map_obj[x,y] = new DestroyableObjects.Ziemia(content, new Rectangle(x* tile_size, y * tile_size, tile_size, tile_size),player.IntelligenceLevel);
                            break;



                    }
                }
        }

        private void ConvertObjectsToInt(ref int[,] int_obj, MapObject[,] objects)
        {
            
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
           /* foreach (Characters.Enemy e in enemies)
            {
                try
                {
                    spritebatch.Draw(e.Texture, e.Rectangle, Color.White);
                }
                catch { }
            }*/
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
            this.vandal_rectangle = vandal.rectangle;// _rectangle;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                     objects[i,j].Update(gametime,this);
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

