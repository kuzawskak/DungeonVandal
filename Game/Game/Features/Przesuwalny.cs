using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
namespace Game.Features
{
    interface Przesuwalny
    {
        bool Przesun(Map.Map map,int x_vel);
    }
}
