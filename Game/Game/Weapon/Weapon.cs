using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;

namespace Game.Weapon
{
    interface Weapon
    {
        


        void OnFound(Map.Map map);
    }
}
