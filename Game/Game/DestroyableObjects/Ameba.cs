using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;

namespace Game.DestroyableObjects
{
    class Ameba : Map.MapObject, Kruchy, Skazony,Niestabilny,Zniszczalny
    {

        private TimeSpan random_new_ameba_time;



        void Kruchy.Kolizja()
        {
            throw new NotImplementedException();
        }

        void Skazony.Zabij()
        {
            throw new NotImplementedException();
        }

        void Niestabilny.Znikaj()
        {
            throw new NotImplementedException();
        }


        void CreateNewAmeba(ref Map.Map map)
        {
            //losuj dostepne puste miejsce
            //
        }
        void OnExplosion()
        {

        }
        void Update(GameTime gameTime) { 
            //
        }
        void Draw(GameTime gameTime) { }


        public void OnDestroy(ref Map.MapObject[,] objects)
        {

            throw new NotImplementedException();
        }
    }
}
