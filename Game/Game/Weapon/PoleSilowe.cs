using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Features;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace Game.Weapon
{

    /// <summary>
    /// Klasa pola siłowego - typ broni , który po zebraniu przez Vandala uruchamia jego nieśmiertelność
    /// (100% odporność na ataki wrogów) na określony czas
    /// </summary>
    class PoleSilowe :  Weapon, Zniszczalny
    {
        /// <summary>
        /// Ścieżka do tektury
        /// </summary>
        private string asset_name = "Textures\\pole_silowe";


        /// <summary>
        /// Konstruktor pola siłowego
        /// </summary>
        /// <param name="content">XNA Content</param>
        /// <param name="rectangle">Prostokat reprezentujacy obiekt na mapie</param>
        /// <param name="x">indeks x na mapie obiektów</param>
        /// <param name="y">indeks y na mapie obiektów</param>
        public PoleSilowe(ContentManager content, Rectangle rectangle, int x, int y)
            : base(content, rectangle, x, y)
        {
            this.TypeTag = AIHelper.ElementType.POLESILOWE;
            this.texture = content.Load<Texture2D>(asset_name);
        }

        /// <summary>
        /// Reakcja na znalezienie przez Vandala 
        /// (Vandal staje się nieśmiertelny na określony czas
        /// </summary>
        /// <param name="map">mapa obiektów</param>
        public override void OnFound(Map.Map map)
        {
            found_soundEffect.Play();
            map.setVandalImmortal();
        }

        /// <summary>
        /// Aktualizacja stanu Pola siłowego
        /// Brak zmian stanu - bo obiekt się nie porusza
        /// </summary>
        /// <param name="gametime">Czas gry</param>
        /// <param name="map">mapa obiektów</param>
        public override void Update(GameTime gametime, Map.Map map)
        {

        }


    }

}
