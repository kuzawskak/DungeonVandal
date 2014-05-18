using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
namespace Game.Features
{
    /// <summary>
    /// Bog=hater moze przesunac taki obiekt
    /// Jezeli obiekt reaguje na grawitacje, mozna przesuwac go tylko w kierunku prostopadlym do wektora grawitacji
    /// </summary>
    interface Przesuwalny
    {
        bool Przesun(Map.Map map,int x_vel);
    }
}
