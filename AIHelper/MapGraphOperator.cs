using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AIHelper
{
    public class MapGraphOperator
    {


        /// <summary>
        /// mapa reprezentowana jako tablica integerów
        /// </summary>
        public ElementType[,] Map { get; private set; }
        
        public MapGraphOperator(ElementType[,] map)
        {
            Map = map;

        }





      //  List<int> FindShortestPath(int x1, int y1, int x2, int y2,Game.Map.Map map) { return null; }
    }

}
