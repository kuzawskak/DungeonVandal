using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Map;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;


namespace AIHelper
{
    public class RandomOperator
    {
        Random rand = new Random();
        //ContentManager content;
        private int tile_size = 50;
        public List<int> RandomMove(int x, int y, Game.Map.Map map) { return null ; }

        public MapObject[,] GenerateRandomMap(int intelligence_level,int width, int height)
        {
            MapObject[,] objects = new MapObject[width / 50 + 1, height / 50 + 1];
            for (int i = 0; i < width /tile_size + 1; i++)
                for (int j = 0; j < height / tile_size + 1; j++)
                {
                    // if (!(i == 0 && j == 0))
                    {
                   //     MapObject obj = new MapObject(content, new Rectangle(i * tile_size, j * tile_size, tile_size, tile_size), "ziemia");
                     //   objects[i, j] = obj;
                    }
                }
            return objects;
        }
    }
}
