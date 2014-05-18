using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Features
{

    /// <summary>
    /// Kiedy spadnie na niego inny obiekt - ten znika
    /// </summary>
    interface Kruchy
    {
        void Kolizja();
    }
}
