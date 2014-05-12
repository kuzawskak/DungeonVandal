using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Features
{
    public interface Zniszczalny
    {
        void OnDestroy(ref Map.MapObject[,] objects);
    }


}
