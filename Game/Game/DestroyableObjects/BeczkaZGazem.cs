using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;

namespace Game.DestroyableObjects
{
    class BeczkaZGazem : Map.MapObject,ReagujeNaGrawitacje,Eksplodujacy,Kruchy,Przesuwalny,Zniszczalny
    {

        void ReagujeNaGrawitacje.Spadaj()
        {
            throw new NotImplementedException();
        }

        void Eksplodujacy.Eksploduj()
        {
            throw new NotImplementedException();
        }

        void Kruchy.Kolizja()
        {
            throw new NotImplementedException();
        }

        bool Przesuwalny.Przesun(Map.Map map,int velocity)
        {
            return false;
        }

        void Update(GameTime gameTime) { }
        void Draw(GameTime gameTime) { }

        public void OnDestroy(Map.Map map)
        {
            
        }
    }
}
