using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace Game.DestroyableObjects
{
    class Kamien : Map.MapObject,ReagujeNaGrawitacje,Przesuwalny,Ciezki,Zniszczalny
    {
        int velocity = 1;

        private string asset_name = "kamien";
        private bool is_falling;
        public Kamien(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.is_falling = false;
            IsAccesible = true;
        }

        public override void Update(GameTime gametime, Map.Map map)
        {
            int x_index = rectangle.X / rectangle.Width;
            int y_index = rectangle.Y / rectangle.Height;
            if (y_index == map.getHeight() - 1)
            {
                if (is_falling)
                {
                  //  MessageBox.Show(x_index.ToString() + "  " + y_index.ToString());
                    map.setObject(x_index, y_index, this);
                    map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle));
                    is_falling = false;
                    return;
                }
                else
                {


                    if(map.getVandalRectangle().Intersects(rectangle))
                    {
                        
                        rectangle.X += ( map.getVandalRectangle().X + map.getVandalRectangle().Width - rectangle.X);

                    }
                    return;
                    }
            }
            if (is_falling)
            {

                //nie spadl calkowice jeszcze na odpowiedni prosokat
                if (rectangle.Y % rectangle.Height != 0)
                {
                    //   MessageBox.Show(x_index.ToString() + "  " + y_index.ToString());
                    Spadaj();
                }
                else
                {
                    // MessageBox.Show(x_index.ToString() + "  " + y_index.ToString());
                    map.setObject(x_index, y_index, this);
                    map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle));
                    //pozniej zmienic na nondestroyable zamista puste
                    if (y_index < map.getHeight() - 1 && map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste))
                    {
                        Spadaj();
                        // break;
                    }
                    else is_falling = false;

                    // Spadaj();
                    //  is_falling = false;            
                }
            }
            else if (map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste) && !map.is_vandal_on_rectangle(x_index, y_index + 1))
            {//rozpoczecie spadania
                is_falling = true;
                Spadaj();
            }
            else
            {
                //TODO: change it!

                if (map.getVandalRectangle().Intersects(rectangle))
                {
                    rectangle.X += (-map.getVandalRectangle().X -rectangle.Width+ rectangle.X);

                }
                return;
            }
            // else is_falling = false;
        }

        public void Spadaj()
        {
            rectangle.Y += velocity;
        }

        void Przesuwalny.Przesun()
        {
            throw new NotImplementedException();
        }




        public void Zgniec()
        {
            throw new NotImplementedException();
        }

        public void OnDestroy(ref Map.MapObject[,] objects)
        {
            throw new NotImplementedException();
        }
    }
}
