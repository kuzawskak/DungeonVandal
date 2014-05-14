﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;

namespace Game.NonDestroyableObjects
{
    class RadioaktywnyGlaz:StaticObject,ReagujeNaGrawitacje,Skazony,Ciezki
    {
        private string asset_name = "skazony";
        private bool is_falling;
        private int velocity = 1;
         public RadioaktywnyGlaz(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            IsAccesible = false;
            is_falling = false;
            

        }




         public override void Update(GameTime gametime, Map.Map map)
         {

             int x_index = rectangle.X / rectangle.Width;
             int y_index = rectangle.Y / rectangle.Height;

             //sprawdzenie wszytkich dookola pol
             if (map.is_vandal_exact_on_rectangle(x_index - 1, y_index) ||
                 map.is_vandal_exact_on_rectangle(x_index + 1, y_index) ||
                 map.is_vandal_exact_on_rectangle(x_index, y_index - 1) ||
                 map.is_vandal_exact_on_rectangle(x_index, y_index + 1) ||
                 map.is_vandal_exact_on_rectangle(x_index - 1, y_index - 1) ||
                 map.is_vandal_exact_on_rectangle(x_index - 1, y_index + 1) ||
                 map.is_vandal_exact_on_rectangle(x_index + 1, y_index + 1) ||
                 map.is_vandal_exact_on_rectangle(x_index + 1, y_index - 1))
             {
                 Zabij();
                 return;
             }



             if (y_index == map.getHeight() - 1)
             {
                 if (is_falling)
                 {
                    
                     map.setObject(x_index, y_index, this);
                     map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle));
                     is_falling = false;
                     return;
                 }
                 else
                     return;
             }
             if (is_falling)
             {

                 //nie spadl calkowice jeszcze na odpowiedni prosokat
                 if (rectangle.Y % rectangle.Height != 0)
                 {
                     Spadaj();
                 }
                 else
                 {
                     map.setObject(x_index, y_index, this);
                     map.setObject(x_index, y_index - 1, new NonDestroyableObjects.Puste(content, rectangle));
                     //pozniej zmienic na nondestroyable zamista puste
                     if (y_index < map.getHeight() - 1 && map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste))
                     {
                         Spadaj();
                         // break;
                     }
                     else is_falling = false;        
                 }
             }
             else if (map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste) && !map.is_vandal_on_rectangle(x_index, y_index + 1))
             {//rozpoczecie spadania
                 is_falling = true;
                 Spadaj();
             }

         }

        public void Spadaj()
        {
            rectangle.Y += velocity;
        }

        public void Zabij()
        {
           // MessageBox.Show("Zabij!");

            //throw new NotImplementedException();
        }

        public void Zgniec()
        {
            throw new NotImplementedException();
        }
    }
}