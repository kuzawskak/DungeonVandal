using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;

namespace Game.DestroyableObjects
{
    class NiestabilnaBeczka : Map.MapObject,ReagujeNaGrawitacje,Eksplodujacy,Skazony,Niestabilny,Kruchy,Zniszczalny
    {


        void ReagujeNaGrawitacje.Spadaj()
        {
            throw new NotImplementedException();
        }

        void Eksplodujacy.Eksploduj()
        {
            throw new NotImplementedException();
        }

        void Skazony.Zabij(Map.Map map)
        {
            throw new NotImplementedException();
        }

        void Niestabilny.Znikaj(Map.Map map)
        {
            throw new NotImplementedException();
        }

        void Kruchy.Kolizja()
        {
            throw new NotImplementedException();
        }


        void Update(GameTime gameTime) { }
        void Draw(GameTime gameTime) { }



        public void OnDestroy(Map.Map map)
        {
           
        }
    }
}
