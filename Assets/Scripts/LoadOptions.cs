using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace Settings
{
    public class LoadOptions : MonoBehaviour
    {
        string filePath;

        public Dictionary<string, int> GetSettings()
        {
            filePath = Path.Combine(Application.persistentDataPath, "options.txt");
            Dictionary<string, int> settings = new Dictionary<string, int>();

            string[] file = File.ReadAllLines(filePath);

            foreach (string line in file)
            {
                string[] pair = line.Split(':');
                settings.Add(pair[0], int.Parse(pair[1]));
            }

            return settings;
        }

        public void UpdateSettings(int volume, int fullscreen)
        {
            string[] newSettings = new string[]
            {
                "volume:" + volume,
                "fullscreen:" + fullscreen
            };

            File.WriteAllLines(filePath, newSettings);
        }

        public void CreateOptionsFile()
        {
            string[] defaultSettings = new string[] {
                "volume:100",
                "fullscreen:0"
            };

            File.WriteAllLines(filePath, defaultSettings);
        }
    }
}
