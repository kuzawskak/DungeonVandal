using System;
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
    class MarmurowyKamien:StaticObject,ReagujeNaGrawitacje,Ciezki
    {

        const int fall_velocity = 1;
        bool is_falling = false;
        private string asset_name = "marmur";
       

         public MarmurowyKamien(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            IsAccesible = false;
            is_falling = false;
            

        }

        //sprawdzanie kolizji



         public override void Update(GameTime gametime,Map.Map map)
         {

             int x_index = rectangle.X / rectangle.Width;
             int y_index = rectangle.Y / rectangle.Height;
             if (y_index == map.getHeight() - 1)
             {
                 if (is_falling)
                 {
                     MessageBox.Show(x_index.ToString() + "  " + y_index.ToString());
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
             else if (map.getObject(x_index, y_index + 1).GetType() == typeof(NonDestroyableObjects.Puste)&& !map.is_vandal_on_rectangle(x_index, y_index + 1))
             {//rozpoczecie spadania
                 is_falling = true;
                 Spadaj();
             }
            // else is_falling = false;
          
         }

        public void Spadaj()
        {
            rectangle.Y += fall_velocity;
        }

        /// <summary>
        /// Metoda wywolywana w OnCollisionDetected dla tego obiektu
        /// </summary>
        public void Zgniec()
        {
            //kill the vandal
            //play the sound
            throw new NotImplementedException();
        }
    }
}
