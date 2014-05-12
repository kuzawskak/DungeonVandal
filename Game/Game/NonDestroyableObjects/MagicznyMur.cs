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

namespace Game.NonDestroyableObjects
{
    class MagicznyMur:StaticObject,Eteryczny
    {
        Random rand = new Random();
        private int eteryczny_time;

        private string asset_name = "magiczny_mur";
        private string eteryczny_asset_name = "eteryczny_mur";
        private bool is_eteryczny = false;

        private System.Timers.Timer timer;
        public MagicznyMur(ContentManager content, Rectangle rectangle, int max_width, int max_height, int x, int y)
        {
            this.content = content;
            texture = content.Load<Texture2D>(asset_name);
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            eteryczny_time = rand.Next()%7;
            timer = new System.Timers.Timer(eteryczny_time*1000);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            IsAccesible = false;
            timer.Start();
            

        }


        public override void Update(GameTime gametime, Map.Map map)
        {


            if (!is_eteryczny&&map.is_vandal_on_rectangle(rectangle.X/rectangle.Width,rectangle.Y/rectangle.Height))
            {
                //ZniszczBohatera
                MessageBox.Show("KILL!");
            }
        
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //zmien na eteryczny
            texture = content.Load<Texture2D>(is_eteryczny ? asset_name : eteryczny_asset_name);            
            is_eteryczny = !is_eteryczny;
            IsAccesible = is_eteryczny;
            timer.Start();
        }

        public void ZniszczBohatera()
        {
            throw new NotImplementedException();
        }
    }
}
