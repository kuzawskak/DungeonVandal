using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Features
{
    /// <summary>
    /// Po losowym czasie obiekt znika 
    /// </summary>
    interface Niestabilny
    {
        void Znikaj(Map.Map map);
    }
}
