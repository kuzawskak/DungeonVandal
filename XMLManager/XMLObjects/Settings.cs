using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Storage;

namespace XMLManager.XMLObjects
{
    class Settings
    {
        /// <summary>
        /// Device do przechowywania plików XNA
        /// </summary>
        public static StorageDevice device;
        /// <summary>
        /// Nazwa folderu z zapisanymi plikami dla XNA
        /// </summary>
        public static string containerName = "MyGamesStorage\\Settings";
        /// <summary>
        /// Nazwy plików ustawieniami (nazwa taka sama jak nazwa Playera)
        /// </summary>
        public static string filename;

        public static SettingsData settingsToSave;

        /// <summary>
        /// Klasa do zapisu najlepszych wyników
        /// </summary>
        [Serializable]
        public struct SettingsData
        {
            public int AudioVolume;
            public int MusicVolume;
            public bool isMuted;

            public int BrightnessRatio;
            public int ContrastRatio;
            public Keys UpKey;
            public Keys DownKey;
            public Keys RightKey;
            public Keys LeftKey;
            public Keys BlockKey;
            public Keys DynamiteKey;
            public Keys RacketKey;
            public Keys PauseKey;

            public SettingsData(int audio, int music, bool mute, int bright, int contrast,Keys u, Keys d, Keys r, Keys l,Keys blo, Keys dyn, Keys rac, Keys pau )
            {
               AudioVolume = audio;
               MusicVolume = music;
               isMuted = mute;
               BrightnessRatio = bright;
               ContrastRatio = contrast;
               UpKey = u;
               DownKey = d;
               RightKey = r;
               LeftKey = l;
               BlockKey = blo;
               DynamiteKey = dyn;
               RacketKey = rac;
               PauseKey = pau;

            }
            public SettingsData(int def)
            {
                AudioVolume = 5;
                MusicVolume = 5;
                isMuted = false;
                BrightnessRatio = 5;
                ContrastRatio = 5;
                UpKey = Keys.W;
                DownKey = Keys.S;
                RightKey = Keys.R;
                LeftKey = Keys.L;
                BlockKey = Keys.Alt;
                DynamiteKey = Keys.Space;
                RacketKey = Keys.Return;
                PauseKey = Keys.Escape;

            }
        }


        /// <summary>
        /// Ładowanie listy najlepszych wyników dla danego poziomu
        /// </summary>
        /// <param name="result">obiekt typu IAsyncResult dający dostęp do XNA Storage</param>
        /// <param name="gameLevel">poziom gry</param>
        /// <returns></returns>
        public static SettingsData LoadSettings(IAsyncResult result, string playerName)
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
                return new SettingsData(0);
            }

            // Open the file.
            Stream stream = container.OpenFile(filename, FileMode.Open);

            // Read the data from the file.
            XmlSerializer serializer = new XmlSerializer(typeof(SettingsData));
            SettingsData data = (SettingsData)serializer.Deserialize(stream);

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
                XmlSerializer serializer = new XmlSerializer(typeof(SettingsData));
                serializer.Serialize(stream, settingsToSave);
                stream.Close();
                container.Dispose();
                result.AsyncWaitHandle.Close();
            }
        }

 

    }
}
