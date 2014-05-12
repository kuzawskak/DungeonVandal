using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Weapon;
using  Game.Characters;

namespace Game
{
    public class Player
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int rackets_count;
        public int Rackets
        {
            get { return rackets_count; }
            set { rackets_count = value; }
        }

        private int dynamites_count;
        public int Dynamite
        {
            get { return dynamites_count; }
            set { dynamites_count = value; }
        }

        private int points;
        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Player(string name) 
        {
            this.name = name;
            this.points = 0;
            this.rackets_count = 0;
            this.dynamites_count = 0;

        }
        private bool is_immortal;
        private int targets_count;        
        private int intelligence_level;

        void UpGrade() { }

        public Player()
        {
            //inicializacja wszytkich pol na 0   
        }

    }
}
