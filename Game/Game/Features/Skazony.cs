using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Features
{
    /// <summary>
    /// Taki obiekt zabija bohatera jesli ten sie do niego zblizy na odlwglosc jednaj kratki (dookoła)
    /// </summary>
    interface Skazony
    {
        void Zabij(Map.Map map);
    }
}
