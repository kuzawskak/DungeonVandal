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

        private string asset_name = "Textures\\kamien";
        private bool is_falling;
        public Kamien(ContentManager content, Rectangle rectangle, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;

            this.is_falling = false;
            IsAccesible = false;
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
                        
                       // rectangle.X = ( map.getVandalRectangle().X + map.getVandalRectangle().Width);// - rectangle.X);
                    //  Przesun(map);

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
                   // rectangle.X += (-map.getVandalRectangle().X -rectangle.Width+ rectangle.X);
                    //rectangle.X = (map.getVandalRectangle().X + map.getVandalRectangle().Width);
                 //  Przesun(map);
                 
                }
                return;
            }
            // else is_falling = false;
        }

        public void Spadaj()
        {
            rectangle.Y += velocity;
        }



        public bool Przesun(Map.Map map,int x_vel)
        {
            if (map.vandal != null)
            {


                if (map.GetVandalDirection() == Game.direction.left && map.getObject((int)(x_vel / this.Rectangle.Width) - 1, (int)(map.getVandalRectangle().Y / map.getVandalRectangle().Height)).GetType() == typeof(NonDestroyableObjects.Puste))
                {
                    if (( x_vel) % this.rectangle.Width == 0)
                    {
                        int x_ind =(int)( x_vel / this.Rectangle.Width) ;
                        int y_ind = (int)(this.Rectangle.Y / this.Rectangle.Height);
                        map.setObject(x_ind, y_ind,this);
                        map.setObject(x_ind+1, y_ind, new NonDestroyableObjects.Puste(content, new Rectangle((x_ind +1)* this.rectangle.Width, y_ind * this.Rectangle.Height, this.rectangle.Width, this.rectangle.Width)));
                   
                    }
                    
                    rectangle.X = x_vel;
                    return true;

                }
                if (map.GetVandalDirection() == Game.direction.right && map.getObject((int)(x_vel / this.Rectangle.Width) , (int)(map.getVandalRectangle().Y / map.getVandalRectangle().Height)).GetType() == typeof(NonDestroyableObjects.Puste))
                {
                    if (( x_vel) % this.rectangle.Width == 0)
                    {
                        int x_ind = (int)(x_vel / this.Rectangle.Width) ;
                        int y_ind = (int)(this.Rectangle.Y / this.Rectangle.Height);
                        map.setObject(x_ind-1, y_ind, this);
                        map.setObject(x_ind,y_ind, new NonDestroyableObjects.Puste(content, new Rectangle((x_ind-1) * this.rectangle.Width, y_ind * this.Rectangle.Height, this.rectangle.Width, this.rectangle.Width)));
                    }
                    rectangle.X = x_vel;
                    return true;
                }
            }
            return false;

        }


        public void Zgniec()
        {
            throw new NotImplementedException();
        }

        public void OnDestroy(Map.Map map)
        {
            //throw new NotImplementedException();
        }

   
    }
}
