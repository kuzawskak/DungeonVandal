using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Storage;

namespace XMLManager.XMLObjects
{
    public static class GameState
    {


        /// <summary>
        /// Device do przechowywania plików XNA
        /// </summary>
        public static StorageDevice device;
        /// <summary>
        /// Nazwa folderu z zapisanymi plikami dla XNA
        /// </summary>
        public static string containerName = "MyGamesStorage\\GameStates";
        /// <summary>C:\Users\Kasia\Desktop\DungeonVandal-git\Game\Game\Game.ico
        /// Nazwy plików z zapisanymi stanami gry (nazwa taka sama jak nazwa Playera)
        /// </summary>
        public static string filename;

        public static GameStateData gameStateToSave;

        /// <summary>
        /// Klasa do zapisu najlepszych wyników
        /// </summary>
        [Serializable]
        public struct GameStateData
        {
            public int Count;

            public int[] Levels;
            public int[][,]GameMaps;
            public int[] Points;
            public int[] TotalSeconds;
            public int[] TotalMinutes;
            public int[] Rackets;
            public int[] Dynamites;
            public int[] Intelligence;
          

            public GameStateData(int count,int map_width, int map_height)
            {
                Count = count;
                Levels = new int[count];
                GameMaps = new int[count][,];
                Points = new int[count];
                TotalSeconds = new int[count];
                TotalMinutes = new int[count];
                Rackets = new int[count];
                Dynamites = new int[count];
                Intelligence = new int[count];
            }

            public GameStateData(int count)
            {
                Count = count;
                Levels = null;
                GameMaps = null;
                Points = null;
                TotalSeconds = null;
                TotalMinutes = null;
                Rackets = null;
                Dynamites = null;
                Intelligence = null;
            }
            
        }


        /// <summary>
        /// Ładowanie listy zapisanych stanów gry dla danego playera
        /// </summary>
        /// <param name="result">obiekt typu IAsyncResult dający dostęp do XNA Storage</param>
        /// <param name="gameLevel">poziom gry</param>
        /// <returns></returns>
        public static GameStateData LoadGameState(IAsyncResult result,string playerName)
        {
            filename = playerName;
            device = StorageDevice.EndShowSelector(result);

            // Open a storage container.
            IAsyncResult result2 = device.BeginOpenContainer(containerName, null, null);

            // Wait for the WaitHandle to become signaled.
            result.AsyncWaitHandle.WaitOne();

            StorageContainer container = device.EndOpenContainer(result2);

            // Close the wait handle.
            result.AsyncWaitHandle.Close();

            // Check to see whether the save exists.
            if (!container.FileExists(filename))
            {
                container.Dispose();
                return new GameStateData(0);
            }

            // Open the file.
            Stream stream = container.OpenFile(filename, FileMode.Open);

            // Read the data from the file.
            XmlSerializer serializer = new XmlSerializer(typeof(GameStateData));
            GameStateData data = (GameStateData)serializer.Deserialize(stream);

            // Close the file.
            stream.Close();

            // Dispose the container.
            container.Dispose();

            //Return SettingsData
            return data;
        }

        public static void SaveToDevice(IAsyncResult result, string playerName)
        {
            filename = playerName;
            if (device != null && device.IsConnected)
            {
                IAsyncResult r = device.BeginOpenContainer(containerName, null, null);

                StorageContainer container = device.EndOpenContainer(r);
                if (container.FileExists(filename))
                    container.DeleteFile(filename);
                Stream stream = container.CreateFile(filename);
                XmlSerializer serializer = new XmlSerializer(typeof(GameStateData));
                serializer.Serialize(stream, gameStateToSave);
                stream.Close();
                container.Dispose();
                result.AsyncWaitHandle.Close();
            }
        }


    }
}
