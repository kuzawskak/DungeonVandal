using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Game.Weapon;
using AIHelper;
using System.Windows.Forms;
using XMLManager.XMLObjects;


namespace Game.Map
{
    /// <summary>
    /// Klasa reperezentująca mapę obiektów
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Operator losowego generowania mapy i ruchów z AIHelper.dll
        /// </summary>
        public RandomOperator random_operator;

        /// <summary>
        /// Aktualny poziom gry
        /// </summary>
        public int gameLevel { get; set; }
        /// <summary>
        /// Aktualny gracz
        /// </summary>
        Player player;
        /// <summary>
        /// Klasa gracza, którym sterujemy
        /// </summary>
        public Characters.Vandal vandal;

        /// <summary>
        /// Rozmiar komórki na mapie
        /// </summary>
        private int tile_size;
        /// <summary>
        /// Ilość komórek w pionie
        /// </summary>
        private int height;
        /// <summary>
        /// Ilość komórek w poziomie
        /// </summary>
        private int width;
        /// <summary>
        /// Pobieranie szerokosci mapy 
        /// </summary>
        /// <returns>ilość komórek mapy w poziomie</returns>
        public int getWidth()
        {
            return width;
        }
        /// <summary>
        /// Pobieranie Wysokości mapy
        /// </summary>
        /// <returns>ilość komórek mapy w pionie</returns>
        public int getHeight()
        {
            return height;
        }

        /// <summary>
        /// Poruszanie bohaterem w określoną stronę
        /// </summary>
        /// <param name="dir">kierunek chodzenia</param>
        public void MoveVandal(Game.direction dir)
        {
            vandal.Move(dir);
        }

        /// <summary>
        /// Tablica obiektów mapy
        /// </summary>
        private MapObject[,] objects;

        /// <summary>
        /// Pobieranie obiektu z mapy
        /// </summary>
        /// <param name="x">Wspołrzedna x komórki</param>
        /// <param name="y">Współrzedna y komórki</param>
        /// <returns>Obiekt mapy z wybranej pozycji</returns>
        public MapObject getObject(int x, int y)
        {
            return objects[x, y];
        }


        /// <summary>
        /// XNA Content manager
        /// </summary>
        ContentManager content;

        /// <summary>
        /// Konstruktor wysyoływany w przypadku ładownaia nowej gry
        /// </summary>
        /// <param name="tile_size">rozmiar komórki mapy</param>
        /// <param name="width">szerokosc mapy</param>
        /// <param name="height">wysokosc mapy</param>
        /// <param name="content">XNA Content</param>
        /// <param name="player">instancja gracza</param>
        /// <param name="vandal">instancja Vandala</param>
        /// <param name="gameLevel">poziom gry</param>
        public Map(int tile_size, int width, int height, ContentManager content, Player player,  int gameLevel = 1)
        {
            this.player = player;
            this.gameLevel = gameLevel;
            this.content = content;
            this.width = width;
            this.height = height;
            this.player = player;
            this.tile_size = tile_size;
            objects = new MapObject[width, height];
            random_operator = new RandomOperator(width, height);
            random_operator.GenerateRandomMap(width, height, gameLevel);
            CovertIntToObjects(ref objects, random_operator.Map);


        }

        /// <summary>
        /// Konstruktor wywoływany w pprzypadku ładowania zapisanej gry
        /// </summary>
        /// <param name="tile_size">rozmiar komórki mapy</param>
        /// <param name="width">Szerokośc mapy</param>
        /// <param name="height">Wysokośc mapy</param>
        /// <param name="map">Załadowana mapa</param>
        /// <param name="content">XNA Content</param>
        /// <param name="player">Instancja gracza</param>
        /// <param name="vandala">Instancja Vandala</param>
        /// <param name="gameLevel">poziom gry</param>
        public Map(int tile_size, int width, int height, int[] map, ContentManager content, Player player, int gameLevel = 1)
        {
            this.player = player;
            this.gameLevel = gameLevel;
            this.content = content;
            this.width = width;
            this.height = height;
            this.player = player;
            this.tile_size = tile_size;
            objects = new MapObject[width, height];
            random_operator = new RandomOperator(width, height);
            CovertSquareIntToObjects(ref objects, map);


        }

        /// <summary>
        /// Pobranie stworzonej instancji Vandala
        /// </summary>
        /// <returns></returns>
        public Characters.Vandal GetVandal()
        {
            return this.vandal;
        }

        /// <summary>
        /// Konwersja mapy w postaci tablicy 1-wymairowej (z XML) do tablicy dwywymiarowej obiektów typu MapObject
        /// </summary>
        /// <param name="map_obj">zwracana tablica obiektów</param>
        /// <param name="map">pobierana tablica integerów</param>
        public void CovertSquareIntToObjects(ref MapObject[,] map_obj, int[] map)
        {
            for (int i = 0; i < map.Length; i++)
            {
                int y = i / width;
                int x = i % width;
                switch ((ElementType)map[i])
                {
                    case ElementType.AMEBA:
                        map_obj[x, y] = new DestroyableObjects.Ameba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.BECZKAZGAZEM:
                        break;
                    case ElementType.BLOB:
                        map_obj[x, y] = new Characters.Blob(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.CHODZACABOMBA:
                        map_obj[x, y] = new Characters.ChodzacaBomba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.CIEZKIMUR:
                        map_obj[x, y] = new NonDestroyableObjects.CiezkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.DYNAMIT:
                        map_obj[x, y] = new Weapon.Dynamit(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.GIGANTYCZNYSZCZUR:
                        map_obj[x, y] = new Characters.GigantycznySzczur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.GOBLIN:
                        map_obj[x, y] = new Characters.Goblin(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.KAMIEN:
                        map_obj[x, y] = new DestroyableObjects.Kamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.LEKKIMUR:
                        map_obj[x, y] = new DestroyableObjects.LekkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.MAGICZNYMUR:
                        map_obj[x, y] = new NonDestroyableObjects.MagicznyMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.MARMUROWYKAMIEN:
                        map_obj[x, y] = new NonDestroyableObjects.MarmurowyKamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.NIESTABILNABECZKA:
                        break;
                    case ElementType.PEKDYNAMITOW:
                        map_obj[x, y] = new Weapon.PekDynamitow(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.POLESILOWE:
                        map_obj[x, y] = new Weapon.PoleSilowe(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.PUSTE:
                        map_obj[x, y] = new NonDestroyableObjects.Puste(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size),x,y);
                        break;
                    case ElementType.RACKET:
                        map_obj[x, y] = new Weapon.Racket(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.RADIOAKTYWNYGLAZ:
                        map_obj[x, y] = new NonDestroyableObjects.RadioaktywnyGlaz(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        break;
                    case ElementType.VANDAL:
                        this.vandal = new Characters.Vandal(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                        map_obj[x, y] = vandal;
                        break;
                    case ElementType.ZIEMIA:
                        map_obj[x, y] = new DestroyableObjects.Ziemia(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, player.IntelligenceLevel);
                        break;
                    case ElementType.CELMISJI:
                        map_obj[x, y] = new DestroyableObjects.CelMisji(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, gameLevel, player.IntelligenceLevel);
                        break;
                    default:
                        map_obj[x, y] = new DestroyableObjects.Ziemia(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, player.IntelligenceLevel);
                        break;

                }
            }

        }


        /// <summary>
        /// Ustawienie obiektu na wybranej pozycji
        /// </summary>
        /// <param name="x">Nowa wspolrzedna x na mapie</param>
        /// <param name="y">Nowa wspolrzedna y na mapie</param>
        /// <param name="obj">Obiekt , którego pozycje ustawiamy</param>
        public void setObject(int x, int y, MapObject obj)
        {
            obj.rectangle.X = x * tile_size;
            obj.rectangle.Y = y * tile_size;
            objects[x, y] = obj;

        }


        /// <summary>
        /// Ustawienie stanu Vandala na nieśmiertelny
        /// </summary>
        public void setVandalImmortal()
        {
            vandal.setImmortal();
            vandal.LoadCurrentTexture(this);
        }

        /// <summary>
        /// Konwersja tablicy enum-ów na tablice obiektów MapObject
        /// </summary>
        /// <param name="map_obj">zwracana tablica po konwersji</param>
        /// <param name="objects">pobierana tablica int-ów</param>
        private void CovertIntToObjects(ref MapObject[,] map_obj, ElementType[,] objects)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    switch (objects[x, y])
                    {
                        case ElementType.AMEBA:
                            map_obj[x, y] = new DestroyableObjects.Ameba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.BECZKAZGAZEM:
                            break;
                        case ElementType.BLOB:
                            map_obj[x, y] = new Characters.Blob(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.CHODZACABOMBA:
                            map_obj[x, y] = new Characters.ChodzacaBomba(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.CIEZKIMUR:
                            map_obj[x, y] = new NonDestroyableObjects.CiezkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.DYNAMIT:
                            map_obj[x, y] = new Weapon.Dynamit(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.GIGANTYCZNYSZCZUR:
                            map_obj[x, y] = new Characters.GigantycznySzczur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                    
                        case ElementType.GOBLIN:
                            map_obj[x, y] = new Characters.Goblin(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.KAMIEN:
                            map_obj[x, y] = new DestroyableObjects.Kamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.LEKKIMUR:
                            map_obj[x, y] = new DestroyableObjects.LekkiMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.MAGICZNYMUR:
                            map_obj[x, y] = new NonDestroyableObjects.MagicznyMur(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.MARMUROWYKAMIEN:
                            map_obj[x, y] = new NonDestroyableObjects.MarmurowyKamien(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.NIESTABILNABECZKA:
                            break;
                        case ElementType.PEKDYNAMITOW:
                            map_obj[x, y] = new Weapon.PekDynamitow(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.POLESILOWE:
                            map_obj[x, y] = new Weapon.PoleSilowe(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.PUSTE:
                            map_obj[x, y] = new NonDestroyableObjects.Puste(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size),x,y);
                            break;
                        case ElementType.RACKET:
                            map_obj[x, y] = new Weapon.Racket(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.RADIOAKTYWNYGLAZ:
                            map_obj[x, y] = new NonDestroyableObjects.RadioaktywnyGlaz(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            break;
                        case ElementType.VANDAL:
                            this.vandal  = new Characters.Vandal(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y);
                            map_obj[x, y] = vandal;
                            break;
                        case ElementType.ZIEMIA:
                            map_obj[x, y] = new DestroyableObjects.Ziemia(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, player.IntelligenceLevel);
                            break;
                        case ElementType.CELMISJI:
                            map_obj[x, y] = new DestroyableObjects.CelMisji(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, gameLevel, player.IntelligenceLevel);
                            break;
                        default:
                            map_obj[x, y] = new DestroyableObjects.Ziemia(content, new Rectangle(x * tile_size, y * tile_size, tile_size, tile_size), x, y, player.IntelligenceLevel);
                            break;
                    }
                }
        }

        /// <summary>
        /// Konwersja tablicy obiektów MapObject na jednowymiarową tablicę intów
        /// Funkcja potzrebna na potzreby serializacji XML
        /// </summary>
        /// <param name="int_obj">Zwracana tablica int-ów</param>
        /// <param name="objects">Pobierana tablica obiektów MaoObject</param>
        private void ConvertObjectsToInt(ref int[] int_obj, MapObject[,] objects)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                        int_obj[y * width + x] = (int)objects[x, y].TypeTag;
                   
        }

        /// <summary>
        /// Pobieranie aktualnej mapy w postaci jednowymiarowej tablicy integrów
        /// </summary>
        /// <returns>Tablica integerów reprezentująca stan mapy</returns>
        public int[] getIntMap()
        {
            int[] int_map = new int[width * height];
            ConvertObjectsToInt(ref int_map, objects);
            return int_map;
        }

        /// <summary>
        /// Podwyższenie aktualnego poziomu gry
        /// </summary>
        public void UpgradePlayersLevel()
        {
            if (gameLevel < 5)
            {
                ++gameLevel;
                objects = new MapObject[width, height];
                random_operator.GenerateRandomMap(width, height, gameLevel);
                CovertIntToObjects(ref objects, random_operator.Map);
            }
        }

        /// <summary>
        /// Funkcja rysowania wszytkich obiektów mapy
        /// </summary>
        /// <param name="spritebatch"></param>
        public void Draw(SpriteBatch spritebatch)
        {
           // spritebatch.Draw(vandal.Texture, vandal.rectangle, Color.White);
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    try
                    {
                        spritebatch.Draw(objects[i, j].Texture, objects[i, j].rectangle, Color.White);
                    }
                    catch { }
                }
        }

        /// <summary>
        /// Sprawdzenie czy Vandal znajduje się na wybranej pozycji
        /// </summary>
        /// <param name="x">badana wspolrzedna x na mapie </param>
        /// <param name="y">badana wspolrzedna y na mapie</param>
        /// <returns>wartosc czy Vandal jest na wskazanej pozycji</returns>
        public bool is_vandal_on_rectangle(int x, int y)
        {
            if (x >= 0 && x < this.width && y >= 0 && y < this.height)
                return (vandal.rectangle.X / vandal.rectangle.Width == x || (vandal.rectangle.X + vandal.rectangle.Width - 1) / vandal.rectangle.Width == x) && vandal.rectangle.Y / vandal.rectangle.Height == y;
            else return false;
        }

        /// <summary>
        /// Aktualizacja liczby posiadanych dynamitów gracza
        /// </summary>
        /// <param name="points">liczba dynamitów do dodania</param>
        public void addPlayersDynamites(int points)
        {
            player.Dynamite += points;
        }

        /// <summary>
        /// Aktualizacja liczby posiadanych rakiet przez gracza
        /// </summary>
        /// <param name="points">liczba rakiet do dodania</param>
        public void addPlayersRacket(int points)
        {
            player.Rackets += points;
        }

        /// <summary>
        /// Pobieranie Prostokata z pozycja vandala
        /// </summary>
        /// <returns>Prostokat okreslajacy pozycje vandala</returns>
        public Rectangle getVandalRectangle()
        {
            return vandal.rectangle;
        }

        /// <summary>
        /// Aktualizacja stanu wszystkich obiektów na mapie
        /// </summary>
        /// <param name="vandal_rectangle">Prostokat z aktualna pozycja Vandala</param>
        /// <param name="gametime">czas gry</param>
        public void Update( GameTime gametime)
        {
            for (int i = 0; i < width; i++)
            {

                for (int j = 0; j < height; j++)
                {
                    if (objects[i, j] != null)
                    {
                        objects[i, j].Update(gametime, this);
                    }
                }
            }
        }

        /// <summary>
        /// Pobranie kierunku ruchu Vandala
        /// </summary>
        /// <returns></returns>
        public Game.direction GetVandalDirection()
        {
            return vandal.current_direction;
        }

        /// <summary>
        /// Aktualizacja liczby punktów gracza
        /// </summary>
        /// <param name="points">liczba punktów do dodania</param>
        public void AddPlayersPoints(int points)
        {
            player.Points += points;
        }
    }

}

