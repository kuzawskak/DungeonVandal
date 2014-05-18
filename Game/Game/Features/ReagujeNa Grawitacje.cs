using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Features
{
    /// <summary>
    /// Obiekt taki bedzie spadał na dół az napotka inny obiekt (kazda NIEPUSTA komórka na której moze sie zatrzymac)
    /// </summary>
    interface ReagujeNaGrawitacje
    {
        void Spadaj();
    }
}
