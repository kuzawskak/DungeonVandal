using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Features
{
    /// <summary>
    /// Obiekty które bohater moze przechodzic, gdy przestaje byc eteryczzn, bohater ginie
    /// (pod warunkiem ze stoi na tym polu)
    /// </summary>
    interface Eteryczny
    {
        void ZniszczBohatera(Map.Map map);
    }
}
