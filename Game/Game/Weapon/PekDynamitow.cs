using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;

namespace Game.Weapon
{
    /// <summary>
    /// Klasa broni, którą można zebrać w postaci pęku dynamitów
    /// Zebranie przez Vandala zwieksza ilość dostępnych dynamitów o 5
    /// </summary>
    class PekDynamitow :  Weapon, Zniszczalny
    {
        /// <summary>
        /// Scieżka do tekstury
        /// </summary>
        private string asset_name = "Textures\\dynamites";

        /// <summary>
        /// Kostruktor
        /// </summary>
        /// <param name="content">XNA Content</param>
        /// <param name="rectangle">Prostokat reprezentujacy obiekt na mapie</param>
        /// <param name="x">indeks x na mapie obiektów</param>
        /// <param name="y">indeks y na mapie obiektów</param>
        public PekDynamitow(ContentManager content, Rectangle rectangle, int x, int y):base(content,rectangle,x,y)
        {
            this.TypeTag = AIHelper.ElementType.PEKDYNAMITOW;
            this.texture = content.Load<Texture2D>(asset_name);
        }

        /// <summary>
        /// Reakcja na znalezienie przez Vandala 
        /// Efekt dźwiękowy i zwiększenie liczby dynamitów o 5
        /// </summary>
        /// <param name="map">Mapa obiektów</param>
         public override void OnFound(Map.Map map)
        {
            found_soundEffect.Play();
            map.addPlayersDynamites(5);

        }

        /// <summary>
        /// Aktualizacja stanu pęku dynamitów na mapie
        /// Nie zmienia stanu - bo obiekt się nie porusza
        /// </summary>
        /// <param name="gametime"></param>
        /// <param name="map"></param>
        public override void Update(GameTime gametime, Map.Map map)
        {

        }

    }
}
