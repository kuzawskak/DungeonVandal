using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;

namespace Game.Weapon
{
    class PoleSilowe:Map.MapObject,Zniszczalny,Weapon
    {

        public void OnFound(Map.Map map)
        {
            throw new NotImplementedException();
        }

        public void OnDestroy(ref Map.MapObject[,] objects)
        {
            throw new NotImplementedException();
        }
    }
}
