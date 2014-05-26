using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using AIHelper;

namespace Game.Map
{
    public class MapObject
    {
        protected Texture2D texture;
        public Rectangle rectangle;
        protected ContentManager content;

        public bool IsAccesible
        {
            get;
            protected set;
        }

        //wspolrzedne na mapie
        public int x { get;  set; }
        public int y { get; set; }

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }
        public Rectangle Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }
        public MapObject() { }



        public ElementType TypeTag { get; protected set; }


        public MapObject(ContentManager content, Rectangle rectangle, int x, int y)
        {
            this.content = content;
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;

        }

        public void Draw(SpriteBatch spritebatch)
        {

            spritebatch.Draw(texture, rectangle, Color.White);
        }

        public virtual void onCollisionDetected(Map map, MapObject map_object)
        {

        }

        public virtual void Update(GameTime gametime, Map map)
        {
        }

        void onExplosion()
        {
            //default do nothing
        }
        void Die()
        {
            //change itself to empty firld
            //get map and 
        }
    }
}
