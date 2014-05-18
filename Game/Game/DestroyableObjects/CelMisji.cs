using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Features;

namespace Game.DestroyableObjects
{
    class CelMisji:Map.MapObject,Zniszczalny
    {
        int points;
        private string asset_name;

        public CelMisji(ContentManager content, Rectangle rectangle, int x, int y,int game_level,int intelligence_level)
        {
            this.content = content;
            
            this.rectangle = rectangle;
            this.x = x;
            this.y = y;
            this.IsAccesible = true;
            switch (game_level)
            {
                case 1:
                    asset_name = "Textures\\level1_goal";
                    break;
                case 2:
                    asset_name = "Textures\\level2_goal";
                    break;
                case 3:
                    asset_name = "Textures\\level3_goal";
                    break;
                case 4:
                    asset_name = "Textures\\level4_goal";
                    break;
                case 5:
                    asset_name = "Textures\\level5_goal";
                    break;

            }
            texture = content.Load<Texture2D>(asset_name);

            switch (intelligence_level)
            {
                case 1:
                    points = 200;
                    break;
                case 2:
                    points = 100;
                    break;
                case 3:
                    points = 50;
                    break;
                

            }
        }

        void Draw(GameTime gameTime) { }

        public void OnDestroy(Map.Map map)
        {

            map.AddPlayersPoints(points);
            map.UpgradePlayersLevel();
        }
    }
}
