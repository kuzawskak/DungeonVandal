using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Features
{
    /// <summary>
    /// Bohater moze przez taki obiekt przechodzic ( Nisczony kiedy bohater na niego wejdzie)
    /// </summary>
    interface Slaby
    {
        void Znikaj(Map.Map map);

       
    }
}
