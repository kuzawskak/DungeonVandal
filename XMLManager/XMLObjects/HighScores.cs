using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Windows.Forms;

namespace XMLManager.XMLObjects
{
    public static class HighScores
    {
        /// <summary>
        /// Device do przechowywania plików XNA
        /// </summary>
        public static StorageDevice device;
        /// <summary>
        /// Nazwa folderu z zapisanymi plikami dla XNA
        /// </summary>
        static string containerName = "MyGamesStorage";
        /// <summary>
        /// Nazwy plików z najlepszymi wynikami dla poziomów 1, 2, 3, 4, 5
        /// </summary>
        static string[] filename = { "highscores1.lst", "highscores2.lst", "highscores3.lst", "highscores4.lst", "highscores5.lst" };
        public static HighScoreData highScoreToSave;
        
        /// <summary>
        /// Klasa do zapisu najlepszych wyników
        /// </summary>
        [Serializable]
        public struct HighScoreData
        {
            public string[] PlayerName;
            public int[] Score;
            public string[] Time;
            public int Count;

            public HighScoreData(int count)
            {
                if (count == 0)
                {
                    PlayerName = null;
                    Time = null;
                    Score = null;
                }
                else
                {
                    PlayerName = new string[count];
                    Time = new string[count];
                    Score = new int[count];
                }
                Count = count;
            }
        }

        /// <summary>
        /// Ładowanie listy najlepszych wyników dla danego poziomu
        /// </summary>
        /// <param name="result">obiekt typu IAsyncResult dający dostęp do XNA Storage</param>
        /// <param name="gameLevel">poziom gry</param>
        /// <returns></returns>
        public static HighScoreData LoadHighScores(IAsyncResult result, int gameLevel)
        {
            device = StorageDevice.EndShowSelector(result);

            // Open a storage container.
            IAsyncResult result2 = device.BeginOpenContainer(containerName, null, null);

            // Wait for the WaitHandle to become signaled.
            result.AsyncWaitHandle.WaitOne();

            StorageContainer container = device.EndOpenContainer(result2);

            // Close the wait handle.
            result.AsyncWaitHandle.Close();

            // Check to see whether the save exists.
            if (!container.FileExists(filename[gameLevel - 1]))
            {
                container.Dispose();
                return new HighScoreData(0);
            }

            // Open the file.
            Stream stream = container.OpenFile(filename[gameLevel - 1], FileMode.Open);

            // Read the data from the file.
            XmlSerializer serializer = new XmlSerializer(typeof(HighScoreData));
            HighScoreData data = (HighScoreData)serializer.Deserialize(stream);

            // Close the file.
            stream.Close();

            // Dispose the container.
            container.Dispose();

            //Return HighScoreData
            return data;
        }

        public static void SaveToDevice(IAsyncResult result, int gameLevel)
        {
            if (device != null && device.IsConnected)
            {
                IAsyncResult r = device.BeginOpenContainer(containerName, null, null);

                StorageContainer container = device.EndOpenContainer(r);
                if (container.FileExists(filename[gameLevel - 1]))
                    container.DeleteFile(filename[gameLevel - 1]);
                Stream stream = container.CreateFile(filename[gameLevel - 1]);
                XmlSerializer serializer = new XmlSerializer(typeof(HighScoreData));
                serializer.Serialize(stream, highScoreToSave);
                stream.Close();
                container.Dispose();
                result.AsyncWaitHandle.Close();
            }
        }

 

    }
}
