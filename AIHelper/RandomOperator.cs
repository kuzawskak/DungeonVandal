﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;

namespace AIHelper
{
    public enum ElementType
    {
        CIEZKIMUR, MAGICZNYMUR, MARMUROWYKAMIEN,
        PUSTE, RADIOAKTYWNYGLAZ, DYNAMIT, PEKDYNAMITOW,
        RACKET, POLESILOWE, AMEBA, BECZKAZGAZEM, KAMIEN,
        LEKKIMUR, NIESTABILNABECZKA, ZIEMIA, BLOB, VANDAL, GOBLIN, GIGANTYCZNYSZCZUR, CHODZACABOMBA,CELMISJI
    };

    /// <summary>
    /// Klasa losowego generowania mapy na podstawie poziomu
    /// </summary>
    public class RandomOperator
    {
        /// <summary>
        /// Liczba komrek mapy horyzontalnie
        /// </summary>
        private int map_width;
        /// <summary>
        /// Liczba komorek mapy wertykalnie
        /// </summary>
        private int map_height;

        /// <summary>
        /// mapa reprezentowana jako tablica integerów
        /// </summary>
        public ElementType[,] Map { get; private set; }

        public RandomOperator(int map_width, int map_height)
        {
            this.map_width = map_width;
            this.map_height = map_height;
            Map = new ElementType[map_width, map_height];

        }

        Random rand = new Random();

        public List<int> RandomMove(int x, int y) { return null; }

        public void GenerateRandomMap(int width, int height,int gameLevel)
        {

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    if (i == 0 || i == width - 1 || j == 0 || j == height - 1)
                    {
                        Map[i, j] = ElementType.CIEZKIMUR;
                    }
                    else
                    {
                        Map[i, j] = ElementType.ZIEMIA;
                    }
                }


            //losowanie 10 dynamitow
            int pos_x;
            int pos_y;
            for (int i = 0; i < 10; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);

                Map[pos_x, pos_y] = ElementType.DYNAMIT;
            }
            //losowanie 2 pekow dynamitow

            for (int i = 0; i < 2; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);

                Map[pos_x, pos_y] = ElementType.PEKDYNAMITOW;
            }
            //10 rakiet
            for (int i = 0; i < 10; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);

                Map[pos_x, pos_y] = ElementType.RACKET;
            }
            //magiczny mur
            for (int i = 0; i < 10; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);

                Map[pos_x, pos_y] = ElementType.MAGICZNYMUR;
            }
            //kamien
            for (int i = 0; i < 10; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);

                Map[pos_x, pos_y] = ElementType.KAMIEN;
            }
            //radioaktywny glaz
           /* for (int i = 0; i < 10; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);

                Map[pos_x, pos_y] = ElementType.RADIOAKTYWNYGLAZ;
            }*/
            //ciezki mur
            for (int i = 0; i < gameLevel*5; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);

                Map[pos_x, pos_y] = ElementType.CIEZKIMUR;
            }

            //lekki mur
            for (int i = 0; i < gameLevel*4; i++)
            {
                pos_x = rand.Next(1, width - 2);
                pos_y = rand.Next(1, height - 2);
                Map[pos_x, pos_y] = ElementType.LEKKIMUR;
            }

            //ameba --- cos chyba nie tak
            pos_x = rand.Next(1, width - 2);
            pos_y = rand.Next(1, height - 2);

            Map[pos_x, pos_y] = ElementType.GIGANTYCZNYSZCZUR;


            for (int i = 0; i < gameLevel; i++)
            {
                pos_x = 5;
                pos_y = 5;

                Map[pos_x, pos_y] = ElementType.BLOB;
            }

            pos_x = 8;
            pos_y = 8;

            Map[pos_x, pos_y] = ElementType.GOBLIN;



            pos_x = 7;
            pos_y = 7;

            Map[pos_x, pos_y] = ElementType.POLESILOWE;

            pos_x = 10;
            pos_y = 10;

            Map[pos_x, pos_y] = ElementType.CHODZACABOMBA;

            Map[1, 1] = ElementType.VANDAL;

            Map[width - 2,height - 2 ] = ElementType.CELMISJI;



        }
    }
}
